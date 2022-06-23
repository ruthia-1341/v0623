using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0623
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int Score = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("堀 朱莉");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Score--;
            label2.Text = ("Score ") + Score;

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0 || label1.Left >= ClientSize.Width)
            {
                vx = -vx;
            }

            if (label1.Top < 0 || label1.Top >= ClientSize.Height)
            {
                vy = -vy;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
