namespace BookMS
{
    partial class User_Success
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书查看与借阅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前借阅的图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(202, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书查看与借阅ToolStripMenuItem,
            this.当前借阅的图书ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书查看与借阅ToolStripMenuItem
            // 
            this.图书查看与借阅ToolStripMenuItem.Name = "图书查看与借阅ToolStripMenuItem";
            this.图书查看与借阅ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.图书查看与借阅ToolStripMenuItem.Text = "图书查看与借阅";
            this.图书查看与借阅ToolStripMenuItem.Click += new System.EventHandler(this.图书查看与借阅ToolStripMenuItem_Click);
            // 
            // 当前借阅的图书ToolStripMenuItem
            // 
            this.当前借阅的图书ToolStripMenuItem.Name = "当前借阅的图书ToolStripMenuItem";
            this.当前借阅的图书ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.当前借阅的图书ToolStripMenuItem.Text = "当前借阅的图书";
            this.当前借阅的图书ToolStripMenuItem.Click += new System.EventHandler(this.当前借阅的图书ToolStripMenuItem_Click);
            // 
            // User_Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User_Success";
            this.Text = "用户中心";
            this.Load += new System.EventHandler(this.User_Success_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书查看与借阅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前借阅的图书ToolStripMenuItem;
    }
}