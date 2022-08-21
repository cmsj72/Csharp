
namespace 폼_분할
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.윈도우ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.윈도우2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.윈도우ToolStripMenuItem,
            this.윈도우2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.윈도우ToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 윈도우ToolStripMenuItem
            // 
            this.윈도우ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼1ToolStripMenuItem,
            this.폼2ToolStripMenuItem});
            this.윈도우ToolStripMenuItem.Name = "윈도우ToolStripMenuItem";
            this.윈도우ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.윈도우ToolStripMenuItem.Text = "윈도우";
            this.윈도우ToolStripMenuItem.Click += new System.EventHandler(this.윈도우ToolStripMenuItem_Click);
            // 
            // 윈도우2ToolStripMenuItem
            // 
            this.윈도우2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼3ToolStripMenuItem,
            this.폼4ToolStripMenuItem});
            this.윈도우2ToolStripMenuItem.Name = "윈도우2ToolStripMenuItem";
            this.윈도우2ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.윈도우2ToolStripMenuItem.Text = "윈도우2";
            this.윈도우2ToolStripMenuItem.Click += new System.EventHandler(this.윈도우2ToolStripMenuItem_Click);
            // 
            // 폼1ToolStripMenuItem
            // 
            this.폼1ToolStripMenuItem.Name = "폼1ToolStripMenuItem";
            this.폼1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.폼1ToolStripMenuItem.Text = "폼1";
            this.폼1ToolStripMenuItem.Click += new System.EventHandler(this.폼1ToolStripMenuItem_Click);
            // 
            // 폼2ToolStripMenuItem
            // 
            this.폼2ToolStripMenuItem.Name = "폼2ToolStripMenuItem";
            this.폼2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.폼2ToolStripMenuItem.Text = "폼2";
            this.폼2ToolStripMenuItem.Click += new System.EventHandler(this.폼2ToolStripMenuItem_Click);
            // 
            // 폼3ToolStripMenuItem
            // 
            this.폼3ToolStripMenuItem.Name = "폼3ToolStripMenuItem";
            this.폼3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.폼3ToolStripMenuItem.Text = "폼3";
            this.폼3ToolStripMenuItem.Click += new System.EventHandler(this.폼3ToolStripMenuItem_Click);
            // 
            // 폼4ToolStripMenuItem
            // 
            this.폼4ToolStripMenuItem.Name = "폼4ToolStripMenuItem";
            this.폼4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.폼4ToolStripMenuItem.Text = "폼4";
            this.폼4ToolStripMenuItem.Click += new System.EventHandler(this.폼4ToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 윈도우ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 윈도우2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼4ToolStripMenuItem;
    }
}