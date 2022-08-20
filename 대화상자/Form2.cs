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
    public partial class Form2 : Form
    {
        //  세트 2
        /*public int x, y;*/

        //  세트 3
        /*string Message;*/
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*DialogResult = DialogResult.Yes;*/

            //  세트 3
            /*Form1 MainForm = (Form1)Owner;
            Message = MainForm.Message;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  세트 2
            /*x = int.Parse(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            Close();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //  세트 3
            /*e.Graphics.DrawString(Message, Font, Brushes.Black, 10, 30);*/

            //  세트 4
            /*e.Graphics.DrawString("Hello World! Form2", Font, Brushes.Black, 10, 30);*/
        }
    }
}
