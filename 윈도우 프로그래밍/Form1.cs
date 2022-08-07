using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈도우_프로그래밍
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Hello World", Font, Brushes.Black, 10, 10);
            e.Graphics.DrawLine(Pens.Red, 10, 10, 200, 10);
            e.Graphics.DrawEllipse(Pens.Black, 10, 20, 100, 100);
            e.Graphics.DrawRectangle(Pens.Black, 130, 20, 100, 100);
        }
    }
}
