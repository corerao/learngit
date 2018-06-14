namespace mediaplayer
{
    partial class mediaplayer
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mediaplayer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快进ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快退ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音量ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.静音ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.播放ToolStripMenuItem,
            this.选项ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 播放ToolStripMenuItem
            // 
            this.播放ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.播放暂停ToolStripMenuItem,
            this.停止ToolStripMenuItem,
            this.快进ToolStripMenuItem,
            this.快退ToolStripMenuItem});
            this.播放ToolStripMenuItem.Name = "播放ToolStripMenuItem";
            this.播放ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.播放ToolStripMenuItem.Text = "播放";
            // 
            // 播放暂停ToolStripMenuItem
            // 
            this.播放暂停ToolStripMenuItem.Name = "播放暂停ToolStripMenuItem";
            this.播放暂停ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.播放暂停ToolStripMenuItem.Text = "播放/暂停";
            this.播放暂停ToolStripMenuItem.Click += new System.EventHandler(this.播放暂停ToolStripMenuItem_Click);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.停止ToolStripMenuItem.Text = "停止";
            this.停止ToolStripMenuItem.Click += new System.EventHandler(this.停止ToolStripMenuItem_Click);
            // 
            // 快进ToolStripMenuItem
            // 
            this.快进ToolStripMenuItem.Name = "快进ToolStripMenuItem";
            this.快进ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.快进ToolStripMenuItem.Text = "快进";
            this.快进ToolStripMenuItem.Click += new System.EventHandler(this.快进ToolStripMenuItem_Click);
            // 
            // 快退ToolStripMenuItem
            // 
            this.快退ToolStripMenuItem.Name = "快退ToolStripMenuItem";
            this.快退ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.快退ToolStripMenuItem.Text = "快退";
            this.快退ToolStripMenuItem.Click += new System.EventHandler(this.快退ToolStripMenuItem_Click);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.音量ToolStripMenuItem,
            this.音量ToolStripMenuItem1,
            this.静音ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 音量ToolStripMenuItem
            // 
            this.音量ToolStripMenuItem.Name = "音量ToolStripMenuItem";
            this.音量ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.音量ToolStripMenuItem.Text = "音量加";
            this.音量ToolStripMenuItem.Click += new System.EventHandler(this.音量ToolStripMenuItem_Click);
            // 
            // 音量ToolStripMenuItem1
            // 
            this.音量ToolStripMenuItem1.Name = "音量ToolStripMenuItem1";
            this.音量ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.音量ToolStripMenuItem1.Text = "音量减";
            this.音量ToolStripMenuItem1.Click += new System.EventHandler(this.音量ToolStripMenuItem1_Click);
            // 
            // 静音ToolStripMenuItem
            // 
            this.静音ToolStripMenuItem.Name = "静音ToolStripMenuItem";
            this.静音ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.静音ToolStripMenuItem.Text = "静音";
            this.静音ToolStripMenuItem.Click += new System.EventHandler(this.静音ToolStripMenuItem_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 27);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(386, 343);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // mediaplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 365);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mediaplayer";
            this.Text = "视频播放器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快进ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快退ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音量ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 静音ToolStripMenuItem;
    }
}

