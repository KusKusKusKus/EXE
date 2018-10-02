using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Media;
using System.Windows;
using System.Runtime.InteropServices;


namespace WindowsFormsApp1
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           

            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.KeyPreview = true;
            


        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
           this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
           this.TopMost = true;
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            SoundPlayer sp = new SoundPlayer(Properties.Resources.song);
            sp.PlayLooping();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F2)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



         private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
          e.Cancel = true;
        }
        
    }
}
