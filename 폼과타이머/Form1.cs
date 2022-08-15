using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 폼과타이머
{
    public partial class Form1 : Form
    {
        Rectangle[] rectangle;
        public Form1()
        {
            InitializeComponent();
            rectangle = new Rectangle[100];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load event");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.Width = 500;
            control.Height = 500;
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            MessageBox.Show("layout");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 0; i < 100; i++)
            {
                rectangle[i].X = random.Next(200);
                rectangle[i].Y = random.Next(200);
                rectangle[i].Width = 60;
                rectangle[i].Height = 60;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                e.Graphics.DrawRectangle(Pens.Black, rectangle[i]);
            }
        }
    }
}
