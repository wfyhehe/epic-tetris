namespace Tetris {
    partial class Setting {
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
            this.labHeight = new System.Windows.Forms.Label();
            this.labWidth = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.labRecommandHeight = new System.Windows.Forms.Label();
            this.labRecommandWidth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labHeight
            // 
            this.labHeight.AutoSize = true;
            this.labHeight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labHeight.Location = new System.Drawing.Point(30, 36);
            this.labHeight.Name = "labHeight";
            this.labHeight.Size = new System.Drawing.Size(81, 20);
            this.labHeight.TabIndex = 0;
            this.labHeight.Text = "地图高度 : ";
            // 
            // labWidth
            // 
            this.labWidth.AutoSize = true;
            this.labWidth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWidth.Location = new System.Drawing.Point(30, 70);
            this.labWidth.Name = "labWidth";
            this.labWidth.Size = new System.Drawing.Size(81, 20);
            this.labWidth.TabIndex = 1;
            this.labWidth.Text = "地图宽度 : ";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(53, 215);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(153, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(118, 36);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(32, 25);
            this.txtHeight.TabIndex = 4;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(117, 70);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(33, 25);
            this.txtWidth.TabIndex = 5;
            // 
            // labRecommandHeight
            // 
            this.labRecommandHeight.AutoSize = true;
            this.labRecommandHeight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRecommandHeight.Location = new System.Drawing.Point(166, 36);
            this.labRecommandHeight.Name = "labRecommandHeight";
            this.labRecommandHeight.Size = new System.Drawing.Size(82, 20);
            this.labRecommandHeight.TabIndex = 6;
            this.labRecommandHeight.Text = "(建议设20)";
            // 
            // labRecommandWidth
            // 
            this.labRecommandWidth.AutoSize = true;
            this.labRecommandWidth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRecommandWidth.Location = new System.Drawing.Point(166, 70);
            this.labRecommandWidth.Name = "labRecommandWidth";
            this.labRecommandWidth.Size = new System.Drawing.Size(82, 20);
            this.labRecommandWidth.TabIndex = 7;
            this.labRecommandWidth.Text = "(建议设10)";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.labRecommandWidth);
            this.Controls.Add(this.labRecommandHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labWidth);
            this.Controls.Add(this.labHeight);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHeight;
        private System.Windows.Forms.Label labWidth;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label labRecommandHeight;
        private System.Windows.Forms.Label labRecommandWidth;
    }
}