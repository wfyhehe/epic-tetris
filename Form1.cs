using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using static Tetris.Blocks;

namespace Tetris {
    public partial class TetrisForm : Form {
        private const int PADDING = 50;
        private const int HISTORY_INTERVAL = 6;
        private int BLOCK_SIZE = 30;
        private Map _map1;
        private Blocks _currentBlock;//当前方块
        private Blocks _nextBlock;//下一个方块
        private int _currentPositionX;
        private int _currentPositionY;
        private int _clearedRows;
        private int _score;
        private bool _isUp;
        private int _bulletTimeCd;
        private int _backToHistoryCd;
        private int _getBlockICd;
        private int _bulletTimeSpan;
        private bool _bulletTimeEnable;
        private bool _backToHistorytEnable;
        private bool _getBlockIEnable;
        private bool _bulletTimeRunning;
        private Random ran;
        private Menu _myMenu;//用于访问菜单窗体
        public delegate void SpeedChangeHandler(int speed);
        public event SpeedChangeHandler SpeedChangeEvent;//改变速度事件
        internal class Snap {//快照:记录当前状态的类
            public bool[,] markBackGround;
            public Blocks markCurrentBlock;
            public Blocks markNextBlock;
            public int markCurrentPositionX;
            public int markCurrentPositionY;

            public Snap(bool[,] backGround, Blocks curBlock, Blocks nextBlock, int curPosX, int curPosY) {
                //markBackGround = backGround;
                markBackGround = new bool[backGround.GetLength(0), backGround.GetLength(1)];
                Array.Copy(backGround, markBackGround, backGround.Length);
                markCurrentBlock = curBlock;
                markNextBlock = nextBlock;
                markCurrentPositionX = curPosX;
                markCurrentPositionY = curPosY;
            }
        }
        private Snap[] _snaps;

        private int Speed { get; set; }//游戏速度

        public TetrisForm() {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            _map1 = Map.CreateInstance();
        }

        public TetrisForm(Map map, Menu menu) {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            _map1 = map;
            _myMenu = menu;

        }

        //防止窗体闪烁的代码(不知原理)
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            if (_myMenu.MyMap.MapHeight > 30 || _myMenu.MyMap.MapWidth > 40) {
                BLOCK_SIZE = 20;
            }
            pnlSkill.Location = new Point(PADDING, PADDING);
            pnlSkill.Size = new Size(PADDING * 4, PADDING * 12);
            pnlMap.Location = new Point(pnlSkill.Right + PADDING, PADDING);
            pnlMap.Size = new Size(_map1.MapWidth * BLOCK_SIZE, _map1.MapHeight * BLOCK_SIZE);
            pnlShowNext.Location = new Point(PADDING * 2 + pnlMap.Right, PADDING);
            pnlShowNext.Size = new Size(6 * BLOCK_SIZE, 6 * BLOCK_SIZE);
            labNext.Location = new Point(pnlShowNext.Left + 40, pnlShowNext.Bottom + 10);
            pnlScore.Location = new Point(labNext.Left, pnlShowNext.Bottom + PADDING);
            pnlButtons.Location = new Point(labNext.Left, pnlScore.Bottom + 20);
            labGold.Location = new Point(pnlMap.Left, pnlMap.Bottom + 10);
            Height = pnlMap.Bottom + PADDING * 4;
            Width = pnlShowNext.Right + PADDING;
            UpdateLabel();

            _map1.ClearRowsEvent += GameOver;
            _map1.ClearRowsEvent += ScoreCalculate;
            SpeedChangeEvent += SpeedChange;

            _isUp = true;
            Speed = 500;
            timer1.Interval = Speed;


        }

        private void GameInit() {
            ran = new Random();
            _currentBlock = new Blocks(GetRandomBlock());
            _nextBlock = new Blocks(GetRandomBlock());
            _currentPositionX = _map1.MapHeight;
            _currentPositionY = _map1.MapWidth / 2 - 2;
            _clearedRows = 0;
            _score = 0;
            _snaps = new Snap[HISTORY_INTERVAL];
            _map1.Clear();
            tmrHistoryCd.Start();
            tmrSecond.Start();
            timer1.Start();
            _bulletTimeCd = 0;
            _backToHistoryCd = 6;
            _getBlockICd = 0;
            _bulletTimeSpan = 0;
            _bulletTimeEnable = true;
            _backToHistorytEnable = false;
            _getBlockIEnable = true;
            this.KeyPreview = true;
        }

        private void UpdateLabel() {
            labClearedRows.Text = "行数 : " + _clearedRows.ToString();
            labScore.Text = "得分 : " + _score.ToString();
            labHighest.Text = "最高分 : " + _myMenu.HighestScore.ToString();

            labGold.Text = "金币 : " + _myMenu.Gold.ToString();

            labBulletCd.Text = "冷却 : " + _bulletTimeCd.ToString();
            labBackCd.Text = "冷却 : " + _backToHistoryCd.ToString();
            labBlockICd.Text = "冷却 : " + _getBlockICd.ToString();
            labBulletRemain.Text = "剩余 : " + _myMenu.OwnBulletTime.ToString();
            labBackRemain.Text = "剩余 : " + _myMenu.OwnBackToHistory.ToString();
            labBlockIRemain.Text = "剩余 : " + _myMenu.OwnGetBlockI.ToString();
        }

        private void ScoreCalculate(int rows) {
            switch (rows) {
                case 0:
                    break;
                case 1:
                    _score += 40;
                    _myMenu.Gold += 2;
                    _clearedRows++;
                    break;
                case 2:
                    _score += 100;
                    _myMenu.Gold += 5;
                    _clearedRows += 2;
                    break;
                case 3:
                    _score += 300;
                    _myMenu.Gold += 15;
                    _clearedRows += 3;
                    break;
                case 4:
                    _score += 1200;
                    _myMenu.Gold += 60;
                    _clearedRows += 4;
                    break;
            }
            _myMenu.FileSave();

            if (_clearedRows >= 5 && _clearedRows < 10) {//根据消行数调节速度
                Speed = 450;
            } else if (_clearedRows >= 10 && _clearedRows < 15) {
                Speed = 400;
            } else if (_clearedRows >= 15 && _clearedRows < 20) {
                Speed = 350;
            } else if (_clearedRows >= 20 && _clearedRows < 30) {
                Speed = 300;
            } else if (_clearedRows >= 30 && _clearedRows < 50) {
                Speed = 250;
            } else if (_clearedRows >= 50 && _clearedRows < 80) {
                Speed = 200;
            } else if (_clearedRows >= 80 && _clearedRows < 100) {
                Speed = 150;
            } else if (_clearedRows >= 100) {
                Speed = 100;
            }
            if (SpeedChangeEvent != null) {
                SpeedChangeEvent(Speed);
            }//触发变速事件
        }

        private void SpeedChange(int speed) {
            timer1.Interval = Speed;
        }

        //返回一个随机BlockType枚举
        private BlockType GetRandomBlock() {
            BlockType[] types = Enum.GetValues(typeof(BlockType)) as BlockType[];
            return types[ran.Next(0, types.Length)];
        }

        //重置当前坐标,下一个方块
        private void ResetNext() {
            _currentPositionX = _map1.MapHeight;
            _currentPositionY = _map1.MapWidth / 2 - 2;
            _currentBlock = _nextBlock;
            _nextBlock = new Blocks(GetRandomBlock());
        }

        private void GameOver(int a) {
            for (int j = 0; j < _map1.MapWidth; j++) {
                if (IsBlockHere(_map1.MapHeight, j)) {//如果顶上有方块
                    timer1.Stop();
                    if (_score > _myMenu.HighestScore) {
                        _myMenu.HighestScore = _score;
                        MessageBox.Show("你打破了记录！最高分 :" + _score.ToString(), "新纪录！");
                    } else {
                        MessageBox.Show("运气不好，再来一盘吧", "游戏结束！");
                    }
                    _myMenu.FileSave();
                    btnStart.Enabled = true;
                    break;
                }
            }
        }

        //W,A,D键需弹起后才能再次按下,S键根据定时器tmrKeyS_Down的间隔连续读取
        protected override void OnKeyDown(KeyEventArgs e) {
            base.OnKeyDown(e);
            switch (e.KeyData) {
                case Keys.W:
                    if (_isUp) {
                        BlockRotate();
                        Refresh();
                        _isUp = false;
                    }
                    break;
                case Keys.S:
                    if (!tmrKeyS_Down.Enabled) {
                        BlockDown();
                        Refresh();
                        _isUp = false;
                        tmrKeyS_Down.Start();
                    }
                    break;
                case Keys.A:
                    if (_isUp) {
                        BlockLeft();
                        Refresh();
                        _isUp = false;
                    }
                    break;
                case Keys.D:
                    if (_isUp) {
                        BlockRight();
                        Refresh();
                        _isUp = false;
                    }
                    break;
                case Keys.D1://子弹时间
                    BulletTime();
                    Refresh();
                    break;
                case Keys.D2://回到过去
                    BackToHistory();
                    Refresh();
                    break;
                case Keys.D3://方块I
                    GetBlockI();
                    Refresh();
                    break;
            }

        }

        //判断键是否已经弹起
        protected override void OnKeyUp(KeyEventArgs e) {
            base.OnKeyUp(e);
            _isUp = true;
        }

        #region 判断方块位置 及方块移动代码
        //private void pnlMap_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
        //    if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) {
        //        BlockRotate();
        //    } else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) {
        //        BlockDown();
        //    } else if (e.KeyCode == Keys.Left) {
        //        BlockLeft();
        //    } else if (e.KeyCode == Keys.Right) {
        //        BlockRight();
        //    }
        //    Refresh();
        //    pnlMap.Focus();
        //}

        //判断坐标(x,y)处是否有方块
        private bool IsBlockHere(int x, int y) {
            if (Blocks.IsBlockArea(x - _currentPositionX, y - _currentPositionY) &&
                _currentBlock.Body[x - _currentPositionX, y - _currentPositionY]) {
                return true;
            } else { return false; }
        }

        //判断当前方块是否在地图内
        private bool IsBlockInMap() {
            for (int i = 0; i < _map1.MapHeight + _map1.MapInvisableHeight; i++) {
                if (IsBlockHere(i, _map1.MapWidth) || IsBlockHere(i, -1)) { return false; }
            }
            for (int j = 0; j < _map1.MapWidth; j++) {
                if (IsBlockHere(_map1.MapHeight + _map1.MapInvisableHeight, j) || IsBlockHere(-1, j)) { return false; }

            }
            return true;
        }

        //判断当前方块是否与其他方块重叠
        private bool IsReach() {
            for (int i = _currentPositionX; i < _currentPositionX + 4; i++) {
                for (int j = _currentPositionY; j < _currentPositionY + 4; j++) {
                    if (_map1.IsInMap(i, j)) {
                        if (IsBlockHere(i, j) && _map1.BackGround[i, j]) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //将方块固定到地图
        private void CopyBlockToMap() {
            for (int i = _currentPositionX; i < _currentPositionX + 4; i++) {
                for (int j = _currentPositionY; j < _currentPositionY + 4; j++) {
                    if (_map1.IsInMap(i, j) && _currentBlock.Body[i - _currentPositionX, j - _currentPositionY]) {
                        _map1.BackGround[i, j] = true;
                    }
                }
            }
        }

        private bool BlockRotate() {
            _currentBlock.Rotate();
            if (!IsBlockInMap() || IsReach()) {
                _currentBlock.RotateR();
                return false;
            } else {
                return true;
            }
        }

        private bool BlockDown() {
            _currentPositionX--;
            if (!IsBlockInMap() || IsReach()) {
                _currentPositionX++;
                CopyBlockToMap();
                _map1.OnClearRows();
                ResetNext();
                return false;
            } else {
                return true;
            }
        }

        private bool BlockLeft() {
            _currentPositionY--;
            if (!IsBlockInMap() || IsReach()) {
                _currentPositionY++;
                return false;
            } else {
                return true;
            }
        }

        private bool BlockRight() {
            _currentPositionY++;
            if (!IsBlockInMap() || IsReach()) {
                _currentPositionY--;
                return false;
            } else {
                return true;
            }
        }
        #endregion

        #region 特殊效果代码
        private bool BulletTime() {
            if (_bulletTimeEnable && _myMenu.OwnBulletTime > 0) {//不在Cd
                _bulletTimeEnable = false;
                _bulletTimeRunning = true;
                SpeedChangeEvent -= SpeedChange;//暂时注销变速
                pboxBullet.BorderStyle = BorderStyle.Fixed3D;
                _bulletTimeSpan = 1;
                timer1.Interval = 1000;
                tmrSecond.Interval = 3000;
                _myMenu.OwnBulletTime--;
                return true;
            } else { return false; }
        }

        private bool GetBlockI() {//获得一个I方块
            if (_getBlockIEnable && _myMenu.OwnGetBlockI > 0) {
                _getBlockIEnable = false;
                _nextBlock = new Blocks(BlockType.I);
                _myMenu.OwnGetBlockI--;
                _getBlockICd = 30;
                return true;
            } else { return false; }
        }

        private bool BackToHistory() {//回到6秒前
            if (_backToHistorytEnable && _myMenu.OwnBackToHistory > 0) {
                _backToHistorytEnable = false;
                _backToHistoryCd = 30;
                _map1.BackGround = _snaps[HISTORY_INTERVAL - 1].markBackGround;
                _currentBlock = _snaps[HISTORY_INTERVAL - 1].markCurrentBlock;
                _nextBlock = _snaps[HISTORY_INTERVAL - 1].markNextBlock;
                _currentPositionX = _snaps[HISTORY_INTERVAL - 1].markCurrentPositionX;
                _currentPositionY = _snaps[HISTORY_INTERVAL - 1].markCurrentPositionY;
                _myMenu.OwnBackToHistory--;
                return true;
            } else { return false; }
        }

        #endregion

        #region 绘图代码
        //在pnl_Map坐标x,y处画一个颜色为color,大小为BLOCK_SIZE的方块
        private void pnlMap_Paint(int x, int y, Color color, PaintEventArgs e) {
            Rectangle rect = new Rectangle(
                y * BLOCK_SIZE, pnlMap.Height - (x + 1) * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE);
            e.Graphics.FillRectangle(new SolidBrush(color), rect);
            e.Graphics.DrawRectangle(Pens.Silver, rect);
        }

        //绘图函数
        private void panel1_Paint_1(object sender, PaintEventArgs e) {
            if (timer1.Enabled) {
                Color color = new Color();
                color = Color.Aqua;
                for (int i = 0; i < _map1.MapHeight; i++) {
                    for (int j = 0; j < _map1.MapWidth; j++) {
                        if (_map1.BackGround[i, j]) {
                            color = Color.DarkCyan;
                            pnlMap_Paint(i, j, color, e);
                        } else if (IsBlockHere(i, j)) {
                            switch (_currentBlock.Type) {
                                case BlockType.I:
                                    color = Color.LightSalmon;
                                    break;
                                case BlockType.J:
                                    color = Color.LimeGreen;
                                    break;
                                case BlockType.L:
                                    color = Color.Orchid;
                                    break;
                                case BlockType.O:
                                    color = Color.Firebrick;
                                    break;
                                case BlockType.S:
                                    color = Color.SteelBlue;
                                    break;
                                case BlockType.T:
                                    color = Color.Khaki;
                                    break;
                                case BlockType.Z:
                                    color = Color.LightCoral;
                                    break;
                            }
                            pnlMap_Paint(i, j, color, e);
                        }
                    }
                }
            }
        }

        private void pnlShowNext_Paint(object sender, PaintEventArgs e) {
            if (timer1.Enabled) {
                Color color = new Color();
                for (int i = 0; i < 4; i++) {
                    for (int j = 0; j < 4; j++) {
                        if (_nextBlock.Body[i, j]) {
                            switch (_nextBlock.Type) {
                                case BlockType.I:
                                    color = Color.LightSalmon;
                                    break;
                                case BlockType.J:
                                    color = Color.LimeGreen;
                                    break;
                                case BlockType.L:
                                    color = Color.Orchid;
                                    break;
                                case BlockType.O:
                                    color = Color.Firebrick;
                                    break;
                                case BlockType.S:
                                    color = Color.SteelBlue;
                                    break;
                                case BlockType.T:
                                    color = Color.Khaki;
                                    break;
                                case BlockType.Z:
                                    color = Color.LightCoral;
                                    break;
                            }
                            Rectangle rect = new Rectangle(
                    (j + 1) * BLOCK_SIZE, pnlShowNext.Height - (i + 2) * BLOCK_SIZE, BLOCK_SIZE, BLOCK_SIZE);
                            e.Graphics.FillRectangle(new SolidBrush(color), rect);
                            e.Graphics.DrawRectangle(Pens.Silver, rect);
                        }
                    }
                }
            }
        }



        #endregion

        #region 控件代码
        private void button1_Click(object sender, EventArgs e) {//开始游戏
            GameInit();
            pnlMap.Focus();
            btnStart.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e) {//返回主菜单
            this.Dispose();
        }

        private void btnBreak_Click(object sender, EventArgs e) {//暂停
            if (timer1.Enabled) {
                timer1.Stop();
                tmrSecond.Stop();
                tmrHistoryCd.Stop();
                this.KeyPreview = false;
                btnBreak.Text = "继续";
            } else {
                timer1.Start();
                tmrHistoryCd.Start();
                tmrSecond.Start();
                this.KeyPreview = true;
                btnBreak.Text = "暂停";
            }

        }

        private void btnHelp_Click(object sender, EventArgs e) {
            MessageBox.Show("W-旋转,S-下降,A-左移,D-右移\n数字1-子弹时间,数字2-回到过去,数字3-来一个I", "帮助");
        }

        private void timer1_Tick(object sender, EventArgs e) {//Tick
            BlockDown();
            Refresh();
        }

        private void pnlMap_Click(object sender, EventArgs e) {
            pnlMap.Focus();
        }

        private void tmrKeyS_Down_Tick(object sender, EventArgs e) {
            tmrKeyS_Down.Stop();//只执行一次
        }

        private void tmrSecond_Tick(object sender, EventArgs e) {
            for (int i = HISTORY_INTERVAL - 1; i > 0; i--) {//每秒更新一次Snap
                _snaps[i] = _snaps[i - 1];
            }
            _snaps[0] = new Snap(_map1.BackGround, _currentBlock, _nextBlock, _currentPositionX, _currentPositionY);

            if (_bulletTimeCd > 0) {
                _bulletTimeCd--;
            } else { _bulletTimeEnable = true; }
            if (_backToHistoryCd > 0) {
                _backToHistoryCd--;
            } else { _backToHistorytEnable = true; }
            if (_getBlockICd > 0) {
                _getBlockICd--;
            } else { _getBlockIEnable = true; }
            if (_bulletTimeSpan > 0) {
                _bulletTimeSpan--;
            } else if (_bulletTimeRunning) {
                _bulletTimeRunning = false;
                pboxBullet.BorderStyle = BorderStyle.None;
                SpeedChange(Speed);
                if (SpeedChangeEvent == null) {
                    SpeedChangeEvent += SpeedChange;
                }
                tmrSecond.Interval = 1000;
                _bulletTimeCd = 30;
            }
            UpdateLabel();
        }

        #endregion


    }
}
