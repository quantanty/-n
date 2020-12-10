namespace testing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLevelValue = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTimeValue = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbTest = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tuyChonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trungBinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cucKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kinhDiVcloolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhạcChillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamePanel = new testing.BoardGamePanel();
            this.btStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLevelValue
            // 
            this.lbLevelValue.AutoSize = true;
            this.lbLevelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevelValue.Location = new System.Drawing.Point(100, 38);
            this.lbLevelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLevelValue.Name = "lbLevelValue";
            this.lbLevelValue.Size = new System.Drawing.Size(30, 25);
            this.lbLevelValue.TabIndex = 0;
            this.lbLevelValue.Text = "...";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(14, 85);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(54, 13);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Thời gian:";
            // 
            // lbTimeValue
            // 
            this.lbTimeValue.AutoSize = true;
            this.lbTimeValue.Location = new System.Drawing.Point(102, 85);
            this.lbTimeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimeValue.Name = "lbTimeValue";
            this.lbTimeValue.Size = new System.Drawing.Size(16, 13);
            this.lbTimeValue.TabIndex = 0;
            this.lbTimeValue.Text = "...";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(12, 38);
            this.lbLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(80, 25);
            this.lbLevel.TabIndex = 0;
            this.lbLevel.Text = "Độ khó";
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(14, 130);
            this.lbTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(24, 13);
            this.lbTest.TabIndex = 0;
            this.lbTest.Text = "test";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tuyChonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tuyChonToolStripMenuItem
            // 
            this.tuyChonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doKhoToolStripMenuItem,
            this.nhạcChillToolStripMenuItem});
            this.tuyChonToolStripMenuItem.Name = "tuyChonToolStripMenuItem";
            this.tuyChonToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tuyChonToolStripMenuItem.Text = "Tuỳ chọn";
            // 
            // doKhoToolStripMenuItem
            // 
            this.doKhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deToolStripMenuItem,
            this.trungBinhToolStripMenuItem,
            this.khoToolStripMenuItem,
            this.cucKhoToolStripMenuItem,
            this.kinhDiVcloolStripMenuItem});
            this.doKhoToolStripMenuItem.Name = "doKhoToolStripMenuItem";
            this.doKhoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.doKhoToolStripMenuItem.Text = "Độ khó";
            // 
            // deToolStripMenuItem
            // 
            this.deToolStripMenuItem.Name = "deToolStripMenuItem";
            this.deToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deToolStripMenuItem.Text = "Dễ";
            this.deToolStripMenuItem.Click += new System.EventHandler(this.deToolStripMenuItem_Click);
            // 
            // trungBinhToolStripMenuItem
            // 
            this.trungBinhToolStripMenuItem.Name = "trungBinhToolStripMenuItem";
            this.trungBinhToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.trungBinhToolStripMenuItem.Text = "Trung bình";
            this.trungBinhToolStripMenuItem.Click += new System.EventHandler(this.trungBinhToolStripMenuItem_Click);
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.khoToolStripMenuItem.Text = "Khó";
            this.khoToolStripMenuItem.Click += new System.EventHandler(this.khoToolStripMenuItem_Click);
            // 
            // cucKhoToolStripMenuItem
            // 
            this.cucKhoToolStripMenuItem.Name = "cucKhoToolStripMenuItem";
            this.cucKhoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cucKhoToolStripMenuItem.Text = "Cực khó";
            this.cucKhoToolStripMenuItem.Click += new System.EventHandler(this.cucKhoToolStripMenuItem_Click);
            // 
            // kinhDiVcloolStripMenuItem
            // 
            this.kinhDiVcloolStripMenuItem.Name = "kinhDiVcloolStripMenuItem";
            this.kinhDiVcloolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kinhDiVcloolStripMenuItem.Text = "Kinh dị vcl";
            this.kinhDiVcloolStripMenuItem.Click += new System.EventHandler(this.kinhDiVcloolStripMenuItem_Click);
            // 
            // nhạcChillToolStripMenuItem
            // 
            this.nhạcChillToolStripMenuItem.Name = "nhạcChillToolStripMenuItem";
            this.nhạcChillToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.nhạcChillToolStripMenuItem.Text = "Nhạc chill";
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gamePanel.Location = new System.Drawing.Point(243, 26);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(250, 500);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.TabStop = true;
            this.gamePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.boardGamePanel1_MouseMove);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(62, 263);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(98, 78);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Bắt đầu";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 537);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbTimeValue);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbLevelValue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "TETRIS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbLevelValue;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbTimeValue;
        private System.Windows.Forms.Label lbLevel;
        private BoardGamePanel gamePanel;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tuyChonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trungBinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cucKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kinhDiVcloolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhạcChillToolStripMenuItem;
        private System.Windows.Forms.Button btStart;
    }
}

