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
    public partial class Setting : Form {
        private Menu _myMenu;
        public Setting(Menu menu) {
            InitializeComponent();
            _myMenu = menu;
            this.Location = menu.Location;
            txtHeight.Text = _myMenu.MyMap.MapHeight.ToString();
            txtWidth.Text = _myMenu.MyMap.MapWidth.ToString();

        }

        private void btnOK_Click(object sender, EventArgs e) {
            try {
                int height = int.Parse(txtHeight.Text);
                int width = int.Parse(txtWidth.Text);
                if (height >= 10 && height <= 45 && width >= 8 && width <= 60) {
                    _myMenu.MyMap.SetSize(height, width);
                } else {
                    throw new Exception("高度范围10~45，宽度范围8~60");
                }
                this.Dispose();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "错误");

            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
