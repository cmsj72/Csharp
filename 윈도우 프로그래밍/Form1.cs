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
        string strMessage;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.DrawString("Hello World", Font, Brushes.Black, 10, 10);
            e.Graphics.DrawLine(Pens.Red, 10, 10, 200, 10);
            e.Graphics.DrawEllipse(Pens.Black, 10, 20, 100, 100);
            e.Graphics.DrawRectangle(Pens.Black, 130, 20, 100, 100);*/

            //KeyPress 예제 코드 세트
            e.Graphics.DrawString(strMessage, Font, Brushes.Black, 10, 10);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*MessageBox.Show("KeyDown");*/

            /*if(e.KeyCode == Keys.A && e.Shift && e.Control)
            {
                MessageBox.Show("KeyCode + Shift + Control");
            }*/

            /*switch (e.KeyCode)
            {
                case Keys.A:
                    MessageBox.Show("A키");
                    break;
                case Keys.B:
                    MessageBox.Show("B키");
                    break;
                case Keys.C:
                    MessageBox.Show("C키");
                    break;
            }*/

            /*if(e.Modifiers == (Keys.Shift | Keys.Control))
            {
                MessageBox.Show("Modifiers + Shift + Control");
            }
            if(e.KeyCode == Keys.A && e.Modifiers == (Keys.Shift | Keys.Alt))
            {
                MessageBox.Show("A + Shift + Alt");
            }*/

            if(e.KeyData == (Keys.A | Keys.Shift | Keys.Control))
            {
                MessageBox.Show("A + Shift + Control");
            }
        }

        //KeyPress 예제 코드 세트
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*MessageBox.Show("KeyPress");*/

            strMessage += e.KeyChar;
            Invalidate();
        }
    }
}
