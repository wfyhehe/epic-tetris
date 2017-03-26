using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Tetris {
    class Blocks {
        public enum BlockType { I, J, L, O, S, T, Z };


        public static bool[,] IType0 = new bool[4, 4] {
            {false,false,true,false },
            {false,false,true,false },
            {false,false,true,false },
            {false,false,true,false }
        };
        public static bool[,] IType1 = new bool[4, 4] {
            {false,false,false,false },
            {false,false,false,false },
            {true,true,true,true },
            {false,false,false,false }
        };
        public static bool[,] IType2 = IType0;
        public static bool[,] IType3 = IType1;

        public static bool[,] JType0 = new bool[4, 4] {
            {false,false,false,false },
            {false,false,false,true },
            {false,true,true,true },
            {false,false,false,false }
        };
        public static bool[,] JType1 = new bool[4, 4] {
            {false,false,true,false },
            {false,false,true,false },
            {false,false,true,true },
            {false,false,false,false }
        };
        public static bool[,] JType2 = new bool[4, 4] {
            {false,false,false,false },
            {false,false,false,false },
            {false,true,true,true },
            {false,true,false,false }
        };
        public static bool[,] JType3 = new bool[4, 4] {
            {false,false,false,false },
            {false,true,true,false },
            {false,false,true,false },
            {false,false,true,false }
        };

        public static bool[,] LType0 = new bool[4, 4] {
            {false,false,false,false },
            {false,true,false,false },
            {false,true,true,true },
            {false,false,false,false }
        };
        public static bool[,] LType1 = new bool[4, 4] {
            {false,false,false,false },
            {false,false,true,true },
            {false,false,true,false },
            {false,false,true,false }
        };
        public static bool[,] LType2 = new bool[4, 4] {
            {false,false,false,false },
            {false,false,false,false },
            {false,true,true,true },
            {false,false,false,true }
        };
        public static bool[,] LType3 = new bool[4, 4] {
            {false,false,false,false },
            {false,false,true,false },
            {false,false,true,false },
            {false,true,true,false }
        };
        public static bool[,] OType0 = new bool[4, 4] {
            {false,true,true,false },
            {false,true,true,false },
            {false,false,false,false },
            {false,false,false,false }
        };
        public static bool[,] OType1 = OType0;
        public static bool[,] OType2 = OType0;
        public static bool[,] OType3 = OType0;

        public static bool[,] SType0 = new bool[4, 4] {
            {false,false,false,false },
            {false,true,true,false },
            {false,false,true,true },
            {false,false,false,false }
        };
        public static bool[,] SType1 = new bool[4, 4] {
            {false,false,true,false },
            {false,true,true,false },
            {false,true,false,false },
            {false,false,false,false }
        };
        public static bool[,] SType2 = SType0;
        public static bool[,] SType3 = SType1;

        public static bool[,] TType0 = new bool[4, 4] {
            {false,false,true,false },
            {false,true,true,true },
            {false,false,false,false },
            {false,false,false,false }
        };
        public static bool[,] TType1 = new bool[4, 4] {
            {false,false,true,false },
            {false,false,true,true },
            {false,false,true,false },
            {false,false,false,false }
        };
        public static bool[,] TType2 = new bool[4, 4] {
            {false,false,false,false },
            {false,true,true,true },
            {false,false,true,false },
            {false,false,false,false }
        };
        public static bool[,] TType3 = new bool[4, 4] {
            {false,false,true,false },
            {false,true,true,false },
            {false,false,true,false },
            {false,false,false,false }
        };

        public static bool[,] ZType0 = new bool[4, 4] {
            {false,true,true,false },
            {true,true,false,false },
            {false,false,false,false },
            {false,false,false,false }
        };
        public static bool[,] ZType1 = new bool[4, 4] {
            {false,true,false,false },
            {false,true,true,false },
            {false,false,true,false },
            {false,false,false,false }
        };
        public static bool[,] ZType2 = ZType0;
        public static bool[,] ZType3 = ZType1;

        public bool[,] Body { get; private set; }
        public BlockType Type { get; private set; }
        public int RotateType { get; private set; }

        //判断坐标是否在方块区域内,避免索引超出数组
        public static bool IsBlockArea(int x, int y) {
            if (x >= 0 && x < 4 && y >= 0 && y < 4) {
                return true;
            } else { return false; }
        }

        public Blocks(BlockType b) {
            Type = b;
            RotateType = 0;
            switch (b) {
                case BlockType.I:
                    Body = IType0;
                    break;
                case BlockType.J:
                    Body = JType0;
                    break;
                case BlockType.L:
                    Body = LType0;
                    break;
                case BlockType.O:
                    Body = OType0;
                    break;
                case BlockType.S:
                    Body = SType0;
                    break;
                case BlockType.T:
                    Body = TType0;
                    break;
                case BlockType.Z:
                    Body = ZType0;
                    break;
            }
        }
        //逆时针旋转
        public void Rotate() {
            if (RotateType == 0) {
                RotateType++;
                switch (Type) {
                    case BlockType.I:
                        Body = IType1;
                        break;
                    case BlockType.J:
                        Body = JType1;
                        break;
                    case BlockType.L:
                        Body = LType1;
                        break;
                    case BlockType.O:
                        Body = OType1;
                        break;
                    case BlockType.S:
                        Body = SType1;
                        break;
                    case BlockType.T:
                        Body = TType1;
                        break;
                    case BlockType.Z:
                        Body = ZType1;
                        break;
                }
            } else if (RotateType == 1) {
                RotateType++;
                switch (Type) {
                    case BlockType.I:
                        Body = IType2;
                        break;
                    case BlockType.J:
                        Body = JType2;
                        break;
                    case BlockType.L:
                        Body = LType2;
                        break;
                    case BlockType.O:
                        Body = OType2;
                        break;
                    case BlockType.S:
                        Body = SType2;
                        break;
                    case BlockType.T:
                        Body = TType2;
                        break;
                    case BlockType.Z:
                        Body = ZType2;
                        break;
                }
            } else if (RotateType == 2) {
                RotateType++;
                switch (Type) {
                    case BlockType.I:
                        Body = IType3;
                        break;
                    case BlockType.J:
                        Body = JType3;
                        break;
                    case BlockType.L:
                        Body = LType3;
                        break;
                    case BlockType.O:
                        Body = OType3;
                        break;
                    case BlockType.S:
                        Body = SType3;
                        break;
                    case BlockType.T:
                        Body = TType3;
                        break;
                    case BlockType.Z:
                        Body = ZType3;
                        break;
                }
            } else if (RotateType == 3) {
                RotateType = 0;
                switch (Type) {
                    case BlockType.I:
                        Body = IType0;
                        break;
                    case BlockType.J:
                        Body = JType0;
                        break;
                    case BlockType.L:
                        Body = LType0;
                        break;
                    case BlockType.O:
                        Body = OType0;
                        break;
                    case BlockType.S:
                        Body = SType0;
                        break;
                    case BlockType.T:
                        Body = TType0;
                        break;
                    case BlockType.Z:
                        Body = ZType0;
                        break;
                }
            }
        }
        //顺时针旋转
        public void RotateR() {
            if (RotateType == 0) {
                RotateType = 3;
                switch (Type) {
                    case BlockType.I:
                        Body = IType3;
                        break;
                    case BlockType.J:
                        Body = JType3;
                        break;
                    case BlockType.L:
                        Body = LType3;
                        break;
                    case BlockType.O:
                        Body = OType3;
                        break;
                    case BlockType.S:
                        Body = SType3;
                        break;
                    case BlockType.T:
                        Body = TType3;
                        break;
                    case BlockType.Z:
                        Body = ZType3;
                        break;
                }
            } else if (RotateType == 1) {
                RotateType--;
                switch (Type) {
                    case BlockType.I:
                        Body = IType0;
                        break;
                    case BlockType.J:
                        Body = JType0;
                        break;
                    case BlockType.L:
                        Body = LType0;
                        break;
                    case BlockType.O:
                        Body = OType0;
                        break;
                    case BlockType.S:
                        Body = SType0;
                        break;
                    case BlockType.T:
                        Body = TType0;
                        break;
                    case BlockType.Z:
                        Body = ZType0;
                        break;
                }
            } else if (RotateType == 2) {
                RotateType--;
                switch (Type) {
                    case BlockType.I:
                        Body = IType1;
                        break;
                    case BlockType.J:
                        Body = JType1;
                        break;
                    case BlockType.L:
                        Body = LType1;
                        break;
                    case BlockType.O:
                        Body = OType1;
                        break;
                    case BlockType.S:
                        Body = SType1;
                        break;
                    case BlockType.T:
                        Body = TType1;
                        break;
                    case BlockType.Z:
                        Body = ZType1;
                        break;
                }
            } else if (RotateType == 3) {
                RotateType--;
                switch (Type) {
                    case BlockType.I:
                        Body = IType2;
                        break;
                    case BlockType.J:
                        Body = JType2;
                        break;
                    case BlockType.L:
                        Body = LType2;
                        break;
                    case BlockType.O:
                        Body = OType2;
                        break;
                    case BlockType.S:
                        Body = SType2;
                        break;
                    case BlockType.T:
                        Body = TType2;
                        break;
                    case BlockType.Z:
                        Body = ZType2;
                        break;
                }
            }
        }
    }
}
