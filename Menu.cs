using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris {
    public partial class Menu : Form {
        public const string VERSION = "v2.1";
        private const string SECRET_KEY = "asshole";
        public const int PRICE_BULLET_TIME = 20;
        public const int PRICE_BACK_TO_HISTORY = 50;
        public const int PRICE_GET_BLOCK_I = 30;

        private string _directory;
        public Map MyMap {
            get; set;
        }
        public int HighestScore {
            get; set;
        }
        public int Gold {
            get; set;
        }
        public int OwnBulletTime {
            get; set;
        }
        public int OwnBackToHistory {
            get; set;
        }
        public int OwnGetBlockI {
            get; set;
        }

        public Menu() {
            InitializeComponent();
            _directory = System.Environment.CurrentDirectory;
        }

        //加密\解密函数
        private static string TextEncrypt(string content, string secretKey) {
            char[] data = content.ToCharArray();
            char[] key = secretKey.ToCharArray();
            for (int i = 0; i < data.Length; i++) {
                data[i] ^= key[i % key.Length];
            }
            return new string(data);
        }

        private void Menu_Load(object sender, EventArgs e) {

            FileLoad();
            MyMap = Map.CreateInstance();

            UpdateLabel();

        }

        //重载Show函数绑定到Disposed事件上
        private void Show(object sender, EventArgs e) {
            UpdateLabel();
            Show();
        }

        public void UpdateLabel() {
            labHighestScore.Text = "最高分 : " + HighestScore.ToString();
            labGold.Text = "金币 : " + Gold.ToString();
        }

        private void btnEnter_Click(object sender, EventArgs e) {//进入游戏界面
            TetrisForm tetris = new TetrisForm(MyMap, this);
            tetris.Disposed += Show;//子窗口关闭时，显示菜单
            tetris.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e) {//退出
            Application.Exit();
        }

        public void FileSave() {

            try {
                System.IO.File.WriteAllLines(_directory + @"\documents",
                    new string[] { TextEncrypt(Gold.ToString(),SECRET_KEY),
                        TextEncrypt(HighestScore.ToString(),SECRET_KEY),
                        TextEncrypt(OwnBulletTime.ToString(),SECRET_KEY),
                        TextEncrypt(OwnBackToHistory.ToString(),SECRET_KEY),
                        TextEncrypt(OwnGetBlockI.ToString(),SECRET_KEY)
                    }, Encoding.UTF8);
            } catch { }
        }

        public void FileLoad() {
            string[] lines = new string[5];
            try {
                lines = System.IO.File.ReadAllLines(_directory + @"\documents");
                for (int i = 0; i < lines.Length; i++) {
                    lines[i] = TextEncrypt(lines[i], SECRET_KEY);
                }
                Gold = int.Parse(lines[0]);
                HighestScore = int.Parse(lines[1]);
                OwnBulletTime = int.Parse(lines[2]);
                OwnBackToHistory = int.Parse(lines[3]);
                OwnGetBlockI = int.Parse(lines[4]);

            } catch {
                Gold = 200;
                HighestScore = 0;
                OwnBulletTime = 3;
                OwnBackToHistory = 3;
                OwnGetBlockI = 3;
            }
        }
        private void Menu_Dispose(object sender, EventArgs e) {
            FileSave();
        }

        private void btnAbout_Click(object sender, EventArgs e) {
            MessageBox.Show("By WHU-王fy\n版本" + VERSION + "\n2017.3.25");
        }

        private void btnSetting_Click(object sender, EventArgs e) {
            Setting setting = new Setting(this);
            setting.Show();
        }

        private void btnShop_Click(object sender, EventArgs e) {
            Shop shop = new Shop(this);
            shop.Show();
        }
    }
}
