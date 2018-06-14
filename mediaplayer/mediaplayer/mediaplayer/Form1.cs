using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mediaplayer
{
    public partial class mediaplayer : Form
    {
        public mediaplayer()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                

        }
    
        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Choose a file";
            
            if (opf.ShowDialog() == DialogResult.OK)
                filepath = opf.FileName;
            axWindowsMediaPlayer1.URL = filepath;


            /**string a, b;
            a = System.IO.Path.GetFileName(fdlg.FileName);
            b = System.IO.Path.GetDirectoryName(fdlg.FileName);
            MessageBox.Show("你选择了文件：" + a);
            axWindowsMediaPlayer1.URL = System.IO.Path.GetDirectoryName(fdlg.FileName);

            /**
             fdlg.InitialDirectory = @"c:\";  
            fdlg.RestoreDirectory = true;
            string url = System.IO.Path.GetFileNameWithoutExtension(fdlg.FileName);
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                
                //MessageBox.Show("你选择了文件：" + fdlg.FileName);
                MessageBox.Show("url:"+System.IO.Path.GetFileNameWithoutExtension(fdlg.FileName));
                //axWindowsMediaPlayer1.URL = "url";
            }  
            **/




        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void 播放暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)axWindowsMediaPlayer1.playState == 2)
                axWindowsMediaPlayer1.Ctlcontrols.play();
            else if ((int)axWindowsMediaPlayer1.playState == 3)
                axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void 快进ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void 快退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void 音量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.settings.volume <= 90)
            {
                axWindowsMediaPlayer1.settings.volume += 10;
            }
            else
            {
                axWindowsMediaPlayer1.settings.volume = 100;
            }
        }

        private void 音量ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.settings.volume >= 10)
            {
                axWindowsMediaPlayer1.settings.volume -= 10;
            }
            else
            {
                axWindowsMediaPlayer1.settings.volume = 0;
            }
        }

        private void 静音ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = 0;
        }

        public string playpath { get; set; }
    }
}