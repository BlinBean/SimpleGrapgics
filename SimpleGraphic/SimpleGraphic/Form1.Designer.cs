namespace SimpleGraphic
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cbX = new System.Windows.Forms.CheckBox();
            this.cbY = new System.Windows.Forms.CheckBox();
            this.cbZ = new System.Windows.Forms.CheckBox();
            this.cbLine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(35, 13);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 250;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(213, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 250;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cbX
            // 
            this.cbX.AutoSize = true;
            this.cbX.BackColor = System.Drawing.Color.Black;
            this.cbX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbX.Location = new System.Drawing.Point(459, 41);
            this.cbX.Name = "cbX";
            this.cbX.Size = new System.Drawing.Size(30, 16);
            this.cbX.TabIndex = 1;
            this.cbX.Text = "X";
            this.cbX.UseVisualStyleBackColor = false;
            this.cbX.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbY
            // 
            this.cbY.AutoSize = true;
            this.cbY.BackColor = System.Drawing.Color.Black;
            this.cbY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbY.Location = new System.Drawing.Point(459, 64);
            this.cbY.Name = "cbY";
            this.cbY.Size = new System.Drawing.Size(30, 16);
            this.cbY.TabIndex = 2;
            this.cbY.Text = "Y";
            this.cbY.UseVisualStyleBackColor = false;
            // 
            // cbZ
            // 
            this.cbZ.AutoSize = true;
            this.cbZ.BackColor = System.Drawing.Color.Black;
            this.cbZ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbZ.Location = new System.Drawing.Point(459, 87);
            this.cbZ.Name = "cbZ";
            this.cbZ.Size = new System.Drawing.Size(30, 16);
            this.cbZ.TabIndex = 3;
            this.cbZ.Text = "Z";
            this.cbZ.UseVisualStyleBackColor = false;
            // 
            // cbLine
            // 
            this.cbLine.AutoSize = true;
            this.cbLine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbLine.Location = new System.Drawing.Point(459, 109);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(48, 16);
            this.cbLine.TabIndex = 4;
            this.cbLine.Text = "Line";
            this.cbLine.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.cbLine);
            this.Controls.Add(this.cbZ);
            this.Controls.Add(this.cbY);
            this.Controls.Add(this.cbX);
            this.Controls.Add(this.trackBar1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "        ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox cbX;
        private System.Windows.Forms.CheckBox cbY;
        private System.Windows.Forms.CheckBox cbZ;
        private System.Windows.Forms.CheckBox cbLine;
    }
}

