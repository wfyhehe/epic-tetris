using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Tetris {

    public class Map {
        private static Map _instance = null;

        public bool[,] BackGround { get; set; }//用二维bool数组表示版面
        public int MapHeight { get; private set; }//地图高度，默认20
        public int MapInvisableHeight { get; private set; }//地图隐藏高度(用于存放4*4新方块)，默认4
        public int MapWidth { get; set; }//地图宽度，默认10
        public int[] MapRowsStatus { get; private set; }//行状态数组 0:非空非满 1:满 -1:空

        public delegate void ClearRowsHandler(int rows);
        public event ClearRowsHandler ClearRowsEvent;//清除行事件

        private Map() {
            MapHeight = 20;
            MapInvisableHeight = 4;
            MapWidth = 10;
            BackGround = new bool[MapHeight + MapInvisableHeight, MapWidth];
            MapRowsStatus = new int[MapHeight];
        }

        private Map(int width, int height) {
            if (height > 10 && width > 6) {
                MapHeight = height;
                MapWidth = width;
            } else {
                MapHeight = 20;
                MapHeight = 10;
            }
            MapInvisableHeight = 4;
            MapRowsStatus = new int[MapHeight];
            BackGround = new bool[MapHeight + MapInvisableHeight, MapWidth];
        }

        public static Map CreateInstance(int width, int height) {
            if (_instance == null) {
                return new Map(width, height);
            } else { return _instance; }
        }

        public static Map CreateInstance() {
            if (_instance == null) {
                return new Map();
            } else { return _instance; }
        }

        public void SetSize(int height,int width) {//重置地图大小
            MapHeight = height;
            MapWidth = width;
            BackGround = new bool[MapHeight + MapInvisableHeight, MapWidth];
            MapRowsStatus = new int[MapHeight];
        }

        //判断坐标是否在地图内,避免索引超出数组
        public bool IsInMap(int x, int y) {
            if (x >= 0 && x < MapHeight && y >= 0 && y < MapWidth) {
                return true;
            } else {
                return false;
            }
        }

        //更新行状态数组,若更新前后状态不变,返回false,否则返回true
        public bool UpdateMapRowsStatus() {
            bool updated = false;
            for (int i = 0; i < MapHeight; i++) {
                bool isFull = true;
                bool isEmpty = true;
                for (int j = 0; j < MapWidth; j++) {
                    if (BackGround[i, j]) {
                        isEmpty = false;
                    } else {
                        isFull = false;
                    }
                }
                if (isFull) {
                    if (!updated || MapRowsStatus[i] != 1) { updated = true; }
                    MapRowsStatus[i] = 1;
                } else if (isEmpty) {
                    if (!updated || MapRowsStatus[i] != -1) { updated = true; }
                    MapRowsStatus[i] = -1;
                } else {
                    if (!updated || MapRowsStatus[i] != 0) { updated = true; }
                    MapRowsStatus[i] = 0;
                }
            }
            return updated;
        }

        //清除面板上所有方块
        public void Clear() {
            for (int i = 0; i < MapHeight + MapInvisableHeight; i++) {
                for (int j = 0; j < MapWidth; j++) {
                    BackGround[i, j] = false;
                }
            }
            UpdateMapRowsStatus();
        }

        //清除行,改变面板状态,并产生事件
        public void OnClearRows() {
            int fullRows = 0;//一次性清除行数
            UpdateMapRowsStatus();
            for (int i = 0; i < MapHeight && MapRowsStatus[i] != -1; i++) {
                if (MapRowsStatus[i] == 1) { fullRows++; }
            }
            ClearRowsEvent(fullRows); //产生清除行事件
            int cleared = 0;
            for (int i = 0; i < MapHeight; i++) {
                //扫描i行，将值赋给i-cleared行
                for (int j = 0; j < MapWidth; j++) {
                    BackGround[i - cleared, j] = BackGround[i, j];

                }
                if (MapRowsStatus[i] == 1) { cleared++; }
            }
            UpdateMapRowsStatus();
            //for (int i = 0; MapRowsStatus[i] != -1; i++) {
            //    if (MapRowsStatus[i + fullRows] == -1) {//清行后应为空的行
            //        for (int j = 0; j < MapWidth; j++) { BackGround[i, j] = false; }
            //    }
            //}
        }


    }
}
