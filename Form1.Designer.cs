namespace Tetris
{
    partial class TetrisForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TetrisForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.btnBreak = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labScore = new System.Windows.Forms.Label();
            this.labClearedRows = new System.Windows.Forms.Label();
            this.pnlShowNext = new System.Windows.Forms.Panel();
            this.labNext = new System.Windows.Forms.Label();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.labHighest = new System.Windows.Forms.Label();
            this.tmrKeyS_Down = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.labGold = new System.Windows.Forms.Label();
            this.tmrHistoryCd = new System.Windows.Forms.Timer(this.components);
            this.pboxBullet = new System.Windows.Forms.PictureBox();
            this.pnlSkill = new System.Windows.Forms.Panel();
            this.pnlBlockI = new System.Windows.Forms.Panel();
            this.labBlockIRemain = new System.Windows.Forms.Label();
            this.labBlockICd = new System.Windows.Forms.Label();
            this.labBlockI = new System.Windows.Forms.Label();
            this.pboxBlockI = new System.Windows.Forms.PictureBox();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.labBackRemain = new System.Windows.Forms.Label();
            this.labBackCd = new System.Windows.Forms.Label();
            this.labBack = new System.Windows.Forms.Label();
            this.pboxBack = new System.Windows.Forms.PictureBox();
            this.pnlBullet = new System.Windows.Forms.Panel();
            this.labBulletRemain = new System.Windows.Forms.Label();
            this.labBulletCd = new System.Windows.Forms.Label();
            this.labBullet = new System.Windows.Forms.Label();
            this.tmrSecond = new System.Windows.Forms.Timer(this.components);
            this.pnlScore.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBullet)).BeginInit();
            this.pnlSkill.SuspendLayout();
            this.pnlBlockI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBlockI)).BeginInit();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack)).BeginInit();
            this.pnlBullet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(0, 198);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "返回主菜单";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(0, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 37);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.BackColor = System.Drawing.Color.Black;
            this.pnlMap.ForeColor = System.Drawing.Color.Black;
            this.pnlMap.Location = new System.Drawing.Point(242, 47);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(300, 600);
            this.pnlMap.TabIndex = 3;
            this.pnlMap.Click += new System.EventHandler(this.pnlMap_Click);
            this.pnlMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnBreak
            // 
            this.btnBreak.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBreak.Location = new System.Drawing.Point(0, 74);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(100, 37);
            this.btnBreak.TabIndex = 4;
            this.btnBreak.Text = "暂停";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labScore.Location = new System.Drawing.Point(3, 38);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(60, 20);
            this.labScore.TabIndex = 5;
            this.labScore.Text = "得分 : 0";
            // 
            // labClearedRows
            // 
            this.labClearedRows.AutoSize = true;
            this.labClearedRows.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClearedRows.Location = new System.Drawing.Point(3, 67);
            this.labClearedRows.Name = "labClearedRows";
            this.labClearedRows.Size = new System.Drawing.Size(60, 20);
            this.labClearedRows.TabIndex = 6;
            this.labClearedRows.Text = "行数 : 0";
            // 
            // pnlShowNext
            // 
            this.pnlShowNext.BackColor = System.Drawing.Color.Black;
            this.pnlShowNext.ForeColor = System.Drawing.Color.Black;
            this.pnlShowNext.Location = new System.Drawing.Point(592, 47);
            this.pnlShowNext.Name = "pnlShowNext";
            this.pnlShowNext.Size = new System.Drawing.Size(180, 180);
            this.pnlShowNext.TabIndex = 7;
            this.pnlShowNext.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShowNext_Paint);
            // 
            // labNext
            // 
            this.labNext.AutoSize = true;
            this.labNext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNext.Location = new System.Drawing.Point(632, 237);
            this.labNext.Name = "labNext";
            this.labNext.Size = new System.Drawing.Size(84, 19);
            this.labNext.TabIndex = 8;
            this.labNext.Text = "下一个方块";
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlScore.Controls.Add(this.labHighest);
            this.pnlScore.Controls.Add(this.labClearedRows);
            this.pnlScore.Controls.Add(this.labScore);
            this.pnlScore.Location = new System.Drawing.Point(632, 277);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(100, 100);
            this.pnlScore.TabIndex = 9;
            // 
            // labHighest
            // 
            this.labHighest.AutoSize = true;
            this.labHighest.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labHighest.Location = new System.Drawing.Point(3, 9);
            this.labHighest.Name = "labHighest";
            this.labHighest.Size = new System.Drawing.Size(75, 20);
            this.labHighest.TabIndex = 7;
            this.labHighest.Text = "最高分 : 0";
            // 
            // tmrKeyS_Down
            // 
            this.tmrKeyS_Down.Tick += new System.EventHandler(this.tmrKeyS_Down_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelp.Location = new System.Drawing.Point(0, 117);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 35);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnStart);
            this.pnlButtons.Controls.Add(this.btnBack);
            this.pnlButtons.Controls.Add(this.btnHelp);
            this.pnlButtons.Controls.Add(this.btnBreak);
            this.pnlButtons.Location = new System.Drawing.Point(632, 397);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(100, 256);
            this.pnlButtons.TabIndex = 12;
            // 
            // labGold
            // 
            this.labGold.AutoSize = true;
            this.labGold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labGold.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGold.Location = new System.Drawing.Point(461, 670);
            this.labGold.Name = "labGold";
            this.labGold.Size = new System.Drawing.Size(83, 29);
            this.labGold.TabIndex = 13;
            this.labGold.Text = "金币 : 0";
            // 
            // tmrHistoryCd
            // 
            this.tmrHistoryCd.Interval = 6000;
            // 
            // pboxBullet
            // 
            this.pboxBullet.BackColor = System.Drawing.SystemColors.Info;
            this.pboxBullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxBullet.Image = ((System.Drawing.Image)(resources.GetObject("pboxBullet.Image")));
            this.pboxBullet.Location = new System.Drawing.Point(94, 33);
            this.pboxBullet.Name = "pboxBullet";
            this.pboxBullet.Size = new System.Drawing.Size(100, 100);
            this.pboxBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBullet.TabIndex = 14;
            this.pboxBullet.TabStop = false;
            // 
            // pnlSkill
            // 
            this.pnlSkill.Controls.Add(this.pnlBlockI);
            this.pnlSkill.Controls.Add(this.pnlBack);
            this.pnlSkill.Controls.Add(this.pnlBullet);
            this.pnlSkill.Location = new System.Drawing.Point(23, 47);
            this.pnlSkill.Name = "pnlSkill";
            this.pnlSkill.Size = new System.Drawing.Size(200, 600);
            this.pnlSkill.TabIndex = 15;
            // 
            // pnlBlockI
            // 
            this.pnlBlockI.Controls.Add(this.labBlockIRemain);
            this.pnlBlockI.Controls.Add(this.labBlockICd);
            this.pnlBlockI.Controls.Add(this.labBlockI);
            this.pnlBlockI.Controls.Add(this.pboxBlockI);
            this.pnlBlockI.Location = new System.Drawing.Point(3, 403);
            this.pnlBlockI.Name = "pnlBlockI";
            this.pnlBlockI.Size = new System.Drawing.Size(197, 163);
            this.pnlBlockI.TabIndex = 18;
            // 
            // labBlockIRemain
            // 
            this.labBlockIRemain.AutoSize = true;
            this.labBlockIRemain.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBlockIRemain.Location = new System.Drawing.Point(3, 113);
            this.labBlockIRemain.Name = "labBlockIRemain";
            this.labBlockIRemain.Size = new System.Drawing.Size(55, 20);
            this.labBlockIRemain.TabIndex = 17;
            this.labBlockIRemain.Text = "剩余  : ";
            // 
            // labBlockICd
            // 
            this.labBlockICd.AutoSize = true;
            this.labBlockICd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBlockICd.Location = new System.Drawing.Point(3, 79);
            this.labBlockICd.Name = "labBlockICd";
            this.labBlockICd.Size = new System.Drawing.Size(51, 20);
            this.labBlockICd.TabIndex = 16;
            this.labBlockICd.Text = "冷却 : ";
            // 
            // labBlockI
            // 
            this.labBlockI.AutoSize = true;
            this.labBlockI.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBlockI.Location = new System.Drawing.Point(103, 136);
            this.labBlockI.Name = "labBlockI";
            this.labBlockI.Size = new System.Drawing.Size(77, 20);
            this.labBlockI.TabIndex = 15;
            this.labBlockI.Text = "来一个I(3)";
            // 
            // pboxBlockI
            // 
            this.pboxBlockI.BackColor = System.Drawing.SystemColors.Info;
            this.pboxBlockI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxBlockI.Image = ((System.Drawing.Image)(resources.GetObject("pboxBlockI.Image")));
            this.pboxBlockI.Location = new System.Drawing.Point(94, 33);
            this.pboxBlockI.Name = "pboxBlockI";
            this.pboxBlockI.Size = new System.Drawing.Size(100, 100);
            this.pboxBlockI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBlockI.TabIndex = 14;
            this.pboxBlockI.TabStop = false;
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.labBackRemain);
            this.pnlBack.Controls.Add(this.labBackCd);
            this.pnlBack.Controls.Add(this.labBack);
            this.pnlBack.Controls.Add(this.pboxBack);
            this.pnlBack.Location = new System.Drawing.Point(3, 190);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(197, 163);
            this.pnlBack.TabIndex = 18;
            // 
            // labBackRemain
            // 
            this.labBackRemain.AutoSize = true;
            this.labBackRemain.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBackRemain.Location = new System.Drawing.Point(3, 113);
            this.labBackRemain.Name = "labBackRemain";
            this.labBackRemain.Size = new System.Drawing.Size(55, 20);
            this.labBackRemain.TabIndex = 17;
            this.labBackRemain.Text = "剩余  : ";
            // 
            // labBackCd
            // 
            this.labBackCd.AutoSize = true;
            this.labBackCd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBackCd.Location = new System.Drawing.Point(3, 79);
            this.labBackCd.Name = "labBackCd";
            this.labBackCd.Size = new System.Drawing.Size(51, 20);
            this.labBackCd.TabIndex = 16;
            this.labBackCd.Text = "冷却 : ";
            // 
            // labBack
            // 
            this.labBack.AutoSize = true;
            this.labBack.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBack.Location = new System.Drawing.Point(103, 136);
            this.labBack.Name = "labBack";
            this.labBack.Size = new System.Drawing.Size(88, 20);
            this.labBack.TabIndex = 15;
            this.labBack.Text = "回到过去(2)";
            // 
            // pboxBack
            // 
            this.pboxBack.BackColor = System.Drawing.SystemColors.Info;
            this.pboxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxBack.Image = ((System.Drawing.Image)(resources.GetObject("pboxBack.Image")));
            this.pboxBack.Location = new System.Drawing.Point(94, 33);
            this.pboxBack.Name = "pboxBack";
            this.pboxBack.Size = new System.Drawing.Size(100, 100);
            this.pboxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBack.TabIndex = 14;
            this.pboxBack.TabStop = false;
            // 
            // pnlBullet
            // 
            this.pnlBullet.Controls.Add(this.labBulletRemain);
            this.pnlBullet.Controls.Add(this.labBulletCd);
            this.pnlBullet.Controls.Add(this.labBullet);
            this.pnlBullet.Controls.Add(this.pboxBullet);
            this.pnlBullet.Location = new System.Drawing.Point(0, 3);
            this.pnlBullet.Name = "pnlBullet";
            this.pnlBullet.Size = new System.Drawing.Size(197, 163);
            this.pnlBullet.TabIndex = 17;
            // 
            // labBulletRemain
            // 
            this.labBulletRemain.AutoSize = true;
            this.labBulletRemain.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBulletRemain.Location = new System.Drawing.Point(3, 113);
            this.labBulletRemain.Name = "labBulletRemain";
            this.labBulletRemain.Size = new System.Drawing.Size(55, 20);
            this.labBulletRemain.TabIndex = 17;
            this.labBulletRemain.Text = "剩余  : ";
            // 
            // labBulletCd
            // 
            this.labBulletCd.AutoSize = true;
            this.labBulletCd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBulletCd.Location = new System.Drawing.Point(3, 79);
            this.labBulletCd.Name = "labBulletCd";
            this.labBulletCd.Size = new System.Drawing.Size(51, 20);
            this.labBulletCd.TabIndex = 16;
            this.labBulletCd.Text = "冷却 : ";
            // 
            // labBullet
            // 
            this.labBullet.AutoSize = true;
            this.labBullet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBullet.Location = new System.Drawing.Point(106, 136);
            this.labBullet.Name = "labBullet";
            this.labBullet.Size = new System.Drawing.Size(88, 20);
            this.labBullet.TabIndex = 15;
            this.labBullet.Text = "子弹时间(1)";
            // 
            // tmrSecond
            // 
            this.tmrSecond.Interval = 1000;
            this.tmrSecond.Tick += new System.EventHandler(this.tmrSecond_Tick);
            // 
            // TetrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(823, 710);
            this.Controls.Add(this.pnlSkill);
            this.Controls.Add(this.labGold);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.labNext);
            this.Controls.Add(this.pnlShowNext);
            this.Controls.Add(this.pnlMap);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TetrisForm";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxBullet)).EndInit();
            this.pnlSkill.ResumeLayout(false);
            this.pnlBlockI.ResumeLayout(false);
            this.pnlBlockI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBlockI)).EndInit();
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack)).EndInit();
            this.pnlBullet.ResumeLayout(false);
            this.pnlBullet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labClearedRows;
        private System.Windows.Forms.Panel pnlShowNext;
        private System.Windows.Forms.Label labNext;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Timer tmrKeyS_Down;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label labHighest;
        private System.Windows.Forms.Label labGold;
        private System.Windows.Forms.Timer tmrHistoryCd;
        private System.Windows.Forms.PictureBox pboxBullet;
        private System.Windows.Forms.Panel pnlSkill;
        private System.Windows.Forms.Panel pnlBlockI;
        private System.Windows.Forms.Label labBlockIRemain;
        private System.Windows.Forms.Label labBlockICd;
        private System.Windows.Forms.Label labBlockI;
        private System.Windows.Forms.PictureBox pboxBlockI;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Label labBackRemain;
        private System.Windows.Forms.Label labBackCd;
        private System.Windows.Forms.Label labBack;
        private System.Windows.Forms.PictureBox pboxBack;
        private System.Windows.Forms.Panel pnlBullet;
        private System.Windows.Forms.Label labBulletRemain;
        private System.Windows.Forms.Label labBulletCd;
        private System.Windows.Forms.Label labBullet;
        private System.Windows.Forms.Timer tmrSecond;
    }
}

