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
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                MessageBox.Show("堀 朱莉");
            } else if (timer1.Enabled == false)
            {
                MessageBox.Show("堀 朱莉");
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label3.Left = fpos.X -label3.Width/2;
            label3.Top = fpos.Y - label3.Height / 2;
            label3.Text = $"{fpos.X},{fpos.Y}";


            Score--;
            label2.Text = ("Score ") + Score;

            label1.Left += vx;
            label1.Top += vy ;
            
            if (Score <= 0)
                {
                    //timer1.Enabled = false;
                    label2.Text=("GAMEOVER");
                }

            if (label1.Top < 0 || label1.Top > ClientSize.Height)
            {
                vy = -vy * (int)1.10f;
                //レジのバイトで返金作業するときに×1.08（軽減税率対応物）と×1.10（よく使うからよかったー（返金が良いこととは言っていない）（こちらのミス）（ポンコツ店員）
            }

            if (label1.Left < 0 || label1.Left > ClientSize.Width)
            {
                vx = -vx * (int)1.10f;
                if (label1.Text == ("┗( ・ω・´ )┓三"))
                {
                    label1.Text = ("三┏( ‵ ・ω・ )┛");
                }
                else if (label1.Text == ("三┏( ‵ ・ω・ )┛"))
                {
                    label1.Text = ("┗( ・ω・´ )┓三");
                }
            }
        }
         private void label2_Click(object sender, EventArgs e)
         {

         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } 
}
