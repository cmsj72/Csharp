using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 대화상자2
{
    public partial class Form1 : Form
    {
        //  세트 3
        /*int Number;
        string Message;*/

        //  세트 4
        int Red, Green, Blue;
        public Form1()
        {
            InitializeComponent();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  세트 1
            /*saveFileDialog1.Filter = "데이터(*.dat)|*.dat";
            //  데이터(*.dat)는 *.dat에 대한 설명
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //  파일 처리
            }*/

            //  세트 2
            /*int Number = 12;
            string Message = "Hello World!";
            Stream myStream;
            saveFileDialog1.DefaultExt = "dat";
            saveFileDialog1.Filter = "데이터(*.dat)|*.dat";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (BinaryWriter bw = new BinaryWriter(myStream))
                    {
                        bw.Write(Number);
                        bw.Write(Message);
                    }
                }
            }*/

            //  세트 3
            /*Stream myStream;
            openFileDialog1.Filter = "데이터(*.dat)|*.dat";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((myStream = openFileDialog1.OpenFile()) != null)
                {
                    using(BinaryReader br = new BinaryReader(myStream))
                    {
                        Number = br.ReadInt32();
                        Message = br.ReadString();
                        Invalidate();
                    }
                }
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  세트 4
            Red = Green = Blue = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //  세트 3
            /*e.Graphics.DrawString(Number.ToString(), Font, Brushes.Black, 10, 30);
            e.Graphics.DrawString(Message, Font, Brushes.Black, 10, 50);*/

            //  세트 4
            string str = "Red: " + Red + "Green: " + Green + "Blue: " + Blue;
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color Color1 = colorDialog1.Color;
                Red = Color1.R;
                Green = Color1.G;
                Blue = Color1.B;
                Invalidate();
            }
        }
    }
}
