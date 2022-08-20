using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 대화상자
{
    public partial class Form1 : Form
    {
        //  세트 2
        /*int Sum;*/

        //  세트 3
        /*public string Message;*/

        //  세트 4
        Form2 Dlg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form2 Dlg = new Form2();
            if(Dlg.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("정상 종료");
            }

            Dlg.Dispose();*/

            //  세트 2
            /*Form2 Dlg = new Form2();
            Dlg.ShowDialog();

            Sum = Dlg.x + Dlg.y;
            Dlg.Dispose();
            Invalidate();*/

            //  세트 4
            if(Dlg == null)
            {
                Dlg = new Form2();
                Dlg.Show();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.DrawString("계산된 결과는 " + Sum.ToString() + " 입니다", Font, Brushes.Black, 10, 30);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  세트 3
            /*Form2 Dlg = new Form2();
            Dlg.Owner = this;
            Message = textBox1.Text;
            Dlg.ShowDialog();
            Dlg.Dispose();*/
        }
    }
}
