namespace Tetris {
    partial class Menu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labHighestScore = new System.Windows.Forms.Label();
            this.labGold = new System.Windows.Forms.Label();
            this.labVersion = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnter.Location = new System.Drawing.Point(3, 3);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(104, 35);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "进入游戏";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(3, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labHighestScore
            // 
            this.labHighestScore.AutoSize = true;
            this.labHighestScore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labHighestScore.Location = new System.Drawing.Point(-1, 267);
            this.labHighestScore.Name = "labHighestScore";
            this.labHighestScore.Size = new System.Drawing.Size(62, 20);
            this.labHighestScore.TabIndex = 2;
            this.labHighestScore.Text = "最高分 :";
            // 
            // labGold
            // 
            this.labGold.AutoSize = true;
            this.labGold.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGold.Location = new System.Drawing.Point(-1, 229);
            this.labGold.Name = "labGold";
            this.labGold.Size = new System.Drawing.Size(47, 20);
            this.labGold.TabIndex = 3;
            this.labGold.Text = "金币 :";
            // 
            // labVersion
            // 
            this.labVersion.AutoSize = true;
            this.labVersion.BackColor = System.Drawing.Color.Transparent;
            this.labVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labVersion.Location = new System.Drawing.Point(367, 453);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(81, 20);
            this.labVersion.TabIndex = 4;
            this.labVersion.Text = "版本 : v2.0";
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbout.Location = new System.Drawing.Point(3, 126);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(104, 35);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.Location = new System.Drawing.Point(3, 85);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(104, 35);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShop.Location = new System.Drawing.Point(3, 44);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(104, 35);
            this.btnShop.TabIndex = 7;
            this.btnShop.Text = "商店";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Wheat;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnEnter);
            this.pnlButtons.Controls.Add(this.btnShop);
            this.pnlButtons.Controls.Add(this.labGold);
            this.pnlButtons.Controls.Add(this.labHighestScore);
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnSetting);
            this.pnlButtons.Controls.Add(this.btnAbout);
            this.pnlButtons.Location = new System.Drawing.Point(12, 168);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(116, 305);
            this.pnlButtons.TabIndex = 8;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(460, 482);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.labVersion);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "俄罗斯方块";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Disposed += new System.EventHandler(this.Menu_Dispose);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labHighestScore;
        private System.Windows.Forms.Label labGold;
        private System.Windows.Forms.Label labVersion;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Panel pnlButtons;
    }
}