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
    public partial class Shop : Form {
        private Menu _myMenu;

        public Shop(Menu menu) {
            InitializeComponent();
            _myMenu = menu;
            this.Location = menu.Location;
        }

        private void Shop_Load(object sender, EventArgs e) {
            UpdateLabel();
        }

        private void UpdateLabel() {
            labGold.Text = "金币 : "+_myMenu.Gold.ToString();
            labOwnBulletTIme.Text = "数量 : "+_myMenu.OwnBulletTime.ToString();
            labOwnBackToHistory.Text = "数量 : " + _myMenu.OwnBackToHistory.ToString();
            labOwnGetBlockI.Text = "数量 : " + _myMenu.OwnGetBlockI.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            _myMenu.UpdateLabel();
            this.Dispose();
        }

        private void btnBulletTime_Click(object sender, EventArgs e) {
            if (_myMenu.Gold < Tetris.Menu.PRICE_BULLET_TIME) {
                MessageBox.Show("金币不够！");
            }else {
                _myMenu.Gold -= Tetris.Menu.PRICE_BULLET_TIME;
                _myMenu.OwnBulletTime++;
            }
            UpdateLabel();
        }

        private void btnBackToHistory_Click(object sender, EventArgs e) {
            if (_myMenu.Gold < Tetris.Menu.PRICE_BACK_TO_HISTORY) {
                MessageBox.Show("金币不够！");
            } else {
                _myMenu.Gold -= Tetris.Menu.PRICE_BACK_TO_HISTORY;
                _myMenu.OwnBackToHistory++;
            }
            UpdateLabel();
        }

        private void btnGetBlockI_Click(object sender, EventArgs e) {
            if (_myMenu.Gold < Tetris.Menu.PRICE_GET_BLOCK_I) {
                MessageBox.Show("金币不够！");
            } else {
                _myMenu.Gold -= Tetris.Menu.PRICE_GET_BLOCK_I;
                _myMenu.OwnGetBlockI++;
            }
            UpdateLabel();
        }
    }
}
