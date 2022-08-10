using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDI
{
    public partial class Form1 : Form
    {
        Point[] ptCircle;
        int nCount;
        public Form1()
        {
            InitializeComponent();
            ptCircle = new Point[100];
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < nCount; i++)
            {
                e.Graphics.DrawEllipse(Pens.Black, ptCircle[i].X - 10, ptCircle[i].Y - 10, 20, 20);
            }

            /*string str = "Alpha:" + Color.Blue.A + " Red:" + Color.Blue.R + " Greem:" + Color.Blue.G + " Blue:" + Color.Blue.B;*/

            /* Color myColor = Color.FromArgb(255, 0, 0);
             Pen newPen = new Pen(myColor);
             newPen.Width = 5.0f;
             e.Graphics.DrawLine(newPen, 10, 10, 100, 10);
             e.Graphics.DrawLine(Pens.Blue, 10, 20, 100, 20);
             newPen.Dispose();*/

            /*Pen myPen = new Pen(Color.Black, 3.0f);
            myPen.DashStyle = DashStyle.DashDot;
            e.Graphics.DrawLine(myPen, 10, 10, 200, 10);
            myPen.DashStyle = DashStyle.Dot;
            e.Graphics.DrawLine(myPen, 10, 20, 200, 20);*/

            /*SolidBrush myBrush = new SolidBrush(Color.Blue);
            e.Graphics.FillEllipse(myBrush, 10, 10, 100, 100);
            myBrush.Dispose();*/

            HatchBrush Hash = new HatchBrush(HatchStyle.Plaid, Color.Red, Color.Blue);
            e.Graphics.FillRectangle(Hash, 10, 10, 200, 200);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //1번코드
            /*ptCircle[nCount].X = e.X;
            ptCircle[nCount].Y = e.Y;
            nCount++;
            //화면을 다시 그림
            Invalidate();*/

            //2번코드
            ptCircle[nCount].X = e.X;
            ptCircle[nCount].Y = e.Y;
            Graphics g = CreateGraphics();
            g.DrawEllipse(Pens.Black, ptCircle[nCount].X - 10, ptCircle[nCount].Y - 10, 20, 20);
            nCount++;
            //사용한 후에는 Dispose
            g.Dispose();
        }
    }
}
