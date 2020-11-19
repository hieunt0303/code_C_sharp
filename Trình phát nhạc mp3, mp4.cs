using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using VisioForge.Types.OutputFormat;

namespace Bai2
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string a;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    a = ofd.FileName;
                    axWindowsMediaPlayer1.URL= ofd.FileName;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            
        }

        

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime a = DateTime.Today;
            textBox1.Text = a.ToString("D") + " " + DateTime.Now.ToString("h:mm:ss tt");

            timer1.Start();

        }
        

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }


        private static readonly TimeSpan timeout = TimeSpan.FromSeconds(1);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime a = DateTime.Today;
            textBox1.Text = a.ToString("D") + " " + DateTime.Now.ToString("h:mm:ss tt");

        }
    }
}

