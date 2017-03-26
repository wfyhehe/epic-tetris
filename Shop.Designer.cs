namespace Tetris {
    partial class Shop {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBuyBulletTime = new System.Windows.Forms.Panel();
            this.btnBulletTime = new System.Windows.Forms.Button();
            this.labBuyBulletTime = new System.Windows.Forms.Label();
            this.pboxBuyBulletTime = new System.Windows.Forms.PictureBox();
            this.pnlGetBlockI = new System.Windows.Forms.Panel();
            this.btnGetBlockI = new System.Windows.Forms.Button();
            this.labGetBlockI = new System.Windows.Forms.Label();
            this.pboxGetBlockI = new System.Windows.Forms.PictureBox();
            this.pnlBackToHistory = new System.Windows.Forms.Panel();
            this.btnBackToHistory = new System.Windows.Forms.Button();
            this.labBackToHistory = new System.Windows.Forms.Label();
            this.pboxBackToHistory = new System.Windows.Forms.PictureBox();
            this.labGold = new System.Windows.Forms.Label();
            this.labOwnBulletTIme = new System.Windows.Forms.Label();
            this.labOwnBackToHistory = new System.Windows.Forms.Label();
            this.labOwnGetBlockI = new System.Windows.Forms.Label();
            this.pnlBuyBulletTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBuyBulletTime)).BeginInit();
            this.pnlGetBlockI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGetBlockI)).BeginInit();
            this.pnlBackToHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackToHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(208, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlBuyBulletTime
            // 
            this.pnlBuyBulletTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBuyBulletTime.Controls.Add(this.labOwnBulletTIme);
            this.pnlBuyBulletTime.Controls.Add(this.btnBulletTime);
            this.pnlBuyBulletTime.Controls.Add(this.labBuyBulletTime);
            this.pnlBuyBulletTime.Controls.Add(this.pboxBuyBulletTime);
            this.pnlBuyBulletTime.Location = new System.Drawing.Point(12, 12);
            this.pnlBuyBulletTime.Name = "pnlBuyBulletTime";
            this.pnlBuyBulletTime.Size = new System.Drawing.Size(481, 82);
            this.pnlBuyBulletTime.TabIndex = 1;
            // 
            // btnBulletTime
            // 
            this.btnBulletTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBulletTime.Location = new System.Drawing.Point(405, 38);
            this.btnBulletTime.Name = "btnBulletTime";
            this.btnBulletTime.Size = new System.Drawing.Size(61, 26);
            this.btnBulletTime.TabIndex = 2;
            this.btnBulletTime.Text = "买！";
            this.btnBulletTime.UseVisualStyleBackColor = true;
            this.btnBulletTime.Click += new System.EventHandler(this.btnBulletTime_Click);
            // 
            // labBuyBulletTime
            // 
            this.labBuyBulletTime.AutoSize = true;
            this.labBuyBulletTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBuyBulletTime.Location = new System.Drawing.Point(70, 4);
            this.labBuyBulletTime.Name = "labBuyBulletTime";
            this.labBuyBulletTime.Size = new System.Drawing.Size(243, 60);
            this.labBuyBulletTime.TabIndex = 1;
            this.labBuyBulletTime.Text = "子弹时间：\n将当前游戏速度降到极慢，持续6秒\n价格 : 20";
            // 
            // pboxBuyBulletTime
            // 
            this.pboxBuyBulletTime.Image = ((System.Drawing.Image)(resources.GetObject("pboxBuyBulletTime.Image")));
            this.pboxBuyBulletTime.Location = new System.Drawing.Point(4, 4);
            this.pboxBuyBulletTime.Name = "pboxBuyBulletTime";
            this.pboxBuyBulletTime.Size = new System.Drawing.Size(60, 60);
            this.pboxBuyBulletTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBuyBulletTime.TabIndex = 0;
            this.pboxBuyBulletTime.TabStop = false;
            // 
            // pnlGetBlockI
            // 
            this.pnlGetBlockI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlGetBlockI.Controls.Add(this.labOwnGetBlockI);
            this.pnlGetBlockI.Controls.Add(this.btnGetBlockI);
            this.pnlGetBlockI.Controls.Add(this.labGetBlockI);
            this.pnlGetBlockI.Controls.Add(this.pboxGetBlockI);
            this.pnlGetBlockI.Location = new System.Drawing.Point(12, 191);
            this.pnlGetBlockI.Name = "pnlGetBlockI";
            this.pnlGetBlockI.Size = new System.Drawing.Size(481, 85);
            this.pnlGetBlockI.TabIndex = 3;
            // 
            // btnGetBlockI
            // 
            this.btnGetBlockI.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetBlockI.Location = new System.Drawing.Point(405, 38);
            this.btnGetBlockI.Name = "btnGetBlockI";
            this.btnGetBlockI.Size = new System.Drawing.Size(61, 26);
            this.btnGetBlockI.TabIndex = 2;
            this.btnGetBlockI.Text = "买！";
            this.btnGetBlockI.UseVisualStyleBackColor = true;
            this.btnGetBlockI.Click += new System.EventHandler(this.btnGetBlockI_Click);
            // 
            // labGetBlockI
            // 
            this.labGetBlockI.AutoSize = true;
            this.labGetBlockI.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGetBlockI.Location = new System.Drawing.Point(70, 4);
            this.labGetBlockI.Name = "labGetBlockI";
            this.labGetBlockI.Size = new System.Drawing.Size(201, 60);
            this.labGetBlockI.TabIndex = 1;
            this.labGetBlockI.Text = "来一个I：\n强制将下一个方块变成方块\'I\'\n价格：30";
            // 
            // pboxGetBlockI
            // 
            this.pboxGetBlockI.Image = ((System.Drawing.Image)(resources.GetObject("pboxGetBlockI.Image")));
            this.pboxGetBlockI.Location = new System.Drawing.Point(4, 4);
            this.pboxGetBlockI.Name = "pboxGetBlockI";
            this.pboxGetBlockI.Size = new System.Drawing.Size(60, 60);
            this.pboxGetBlockI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxGetBlockI.TabIndex = 0;
            this.pboxGetBlockI.TabStop = false;
            // 
            // pnlBackToHistory
            // 
            this.pnlBackToHistory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBackToHistory.Controls.Add(this.labOwnBackToHistory);
            this.pnlBackToHistory.Controls.Add(this.btnBackToHistory);
            this.pnlBackToHistory.Controls.Add(this.labBackToHistory);
            this.pnlBackToHistory.Controls.Add(this.pboxBackToHistory);
            this.pnlBackToHistory.Location = new System.Drawing.Point(12, 100);
            this.pnlBackToHistory.Name = "pnlBackToHistory";
            this.pnlBackToHistory.Size = new System.Drawing.Size(481, 85);
            this.pnlBackToHistory.TabIndex = 3;
            // 
            // btnBackToHistory
            // 
            this.btnBackToHistory.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackToHistory.Location = new System.Drawing.Point(405, 38);
            this.btnBackToHistory.Name = "btnBackToHistory";
            this.btnBackToHistory.Size = new System.Drawing.Size(61, 26);
            this.btnBackToHistory.TabIndex = 2;
            this.btnBackToHistory.Text = "买！";
            this.btnBackToHistory.UseVisualStyleBackColor = true;
            this.btnBackToHistory.Click += new System.EventHandler(this.btnBackToHistory_Click);
            // 
            // labBackToHistory
            // 
            this.labBackToHistory.AutoSize = true;
            this.labBackToHistory.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBackToHistory.Location = new System.Drawing.Point(70, 4);
            this.labBackToHistory.Name = "labBackToHistory";
            this.labBackToHistory.Size = new System.Drawing.Size(328, 60);
            this.labBackToHistory.TabIndex = 1;
            this.labBackToHistory.Text = "回到过去：\n回到6秒前的状态(得分、金币、技能冷却不影响)\n价格 : 50";
            // 
            // pboxBackToHistory
            // 
            this.pboxBackToHistory.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackToHistory.Image")));
            this.pboxBackToHistory.Location = new System.Drawing.Point(4, 4);
            this.pboxBackToHistory.Name = "pboxBackToHistory";
            this.pboxBackToHistory.Size = new System.Drawing.Size(60, 60);
            this.pboxBackToHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBackToHistory.TabIndex = 0;
            this.pboxBackToHistory.TabStop = false;
            // 
            // labGold
            // 
            this.labGold.AutoSize = true;
            this.labGold.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGold.Location = new System.Drawing.Point(381, 322);
            this.labGold.Name = "labGold";
            this.labGold.Size = new System.Drawing.Size(51, 20);
            this.labGold.TabIndex = 4;
            this.labGold.Text = "金币 : ";
            // 
            // labOwnBulletTIme
            // 
            this.labOwnBulletTIme.AutoSize = true;
            this.labOwnBulletTIme.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOwnBulletTIme.Location = new System.Drawing.Point(401, 15);
            this.labOwnBulletTIme.Name = "labOwnBulletTIme";
            this.labOwnBulletTIme.Size = new System.Drawing.Size(51, 20);
            this.labOwnBulletTIme.TabIndex = 3;
            this.labOwnBulletTIme.Text = "数量 : ";
            // 
            // labOwnBackToHistory
            // 
            this.labOwnBackToHistory.AutoSize = true;
            this.labOwnBackToHistory.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOwnBackToHistory.Location = new System.Drawing.Point(401, 15);
            this.labOwnBackToHistory.Name = "labOwnBackToHistory";
            this.labOwnBackToHistory.Size = new System.Drawing.Size(51, 20);
            this.labOwnBackToHistory.TabIndex = 4;
            this.labOwnBackToHistory.Text = "数量 : ";
            // 
            // labOwnGetBlockI
            // 
            this.labOwnGetBlockI.AutoSize = true;
            this.labOwnGetBlockI.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOwnGetBlockI.Location = new System.Drawing.Point(401, 15);
            this.labOwnGetBlockI.Name = "labOwnGetBlockI";
            this.labOwnGetBlockI.Size = new System.Drawing.Size(51, 20);
            this.labOwnGetBlockI.TabIndex = 5;
            this.labOwnGetBlockI.Text = "数量 : ";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 358);
            this.Controls.Add(this.labGold);
            this.Controls.Add(this.pnlBackToHistory);
            this.Controls.Add(this.pnlGetBlockI);
            this.Controls.Add(this.pnlBuyBulletTime);
            this.Controls.Add(this.btnBack);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.pnlBuyBulletTime.ResumeLayout(false);
            this.pnlBuyBulletTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBuyBulletTime)).EndInit();
            this.pnlGetBlockI.ResumeLayout(false);
            this.pnlGetBlockI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGetBlockI)).EndInit();
            this.pnlBackToHistory.ResumeLayout(false);
            this.pnlBackToHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackToHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlBuyBulletTime;
        private System.Windows.Forms.Label labBuyBulletTime;
        private System.Windows.Forms.PictureBox pboxBuyBulletTime;
        private System.Windows.Forms.Button btnBulletTime;
        private System.Windows.Forms.Panel pnlGetBlockI;
        private System.Windows.Forms.Button btnGetBlockI;
        private System.Windows.Forms.Label labGetBlockI;
        private System.Windows.Forms.PictureBox pboxGetBlockI;
        private System.Windows.Forms.Panel pnlBackToHistory;
        private System.Windows.Forms.Button btnBackToHistory;
        private System.Windows.Forms.Label labBackToHistory;
        private System.Windows.Forms.PictureBox pboxBackToHistory;
        private System.Windows.Forms.Label labGold;
        private System.Windows.Forms.Label labOwnBulletTIme;
        private System.Windows.Forms.Label labOwnGetBlockI;
        private System.Windows.Forms.Label labOwnBackToHistory;
    }
}