using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 고급컨트롤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            //progressBar1.PerformStep();
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
            }

            textBox1.Text = progressBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            textBox2.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //  이미지 리스트의 이미지를 그리는 코드
            /*imageList1.Draw(e.Graphics, 0, 0, 0);
            imageList1.Draw(e.Graphics, 70, 0, 1);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tab1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tab2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tab3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int CLanguage = int.Parse(textBox3.Text);
            int CPlus = int.Parse(textBox4.Text);
            int Cshap = int.Parse(textBox5.Text);
            int Total = CLanguage + CPlus + Cshap;
            float Average = Total / 3.0f;
            listView1.Items.Add(new ListViewItem(new string[] {CLanguage.ToString(), CPlus.ToString(), Cshap.ToString(),
                Total.ToString(), Average.ToString("f1")}));
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int CLanguage = int.Parse(textBox3.Text);
            int CPlus = int.Parse(textBox4.Text);
            int Cshap = int.Parse(textBox5.Text);
            int Total = CLanguage + CPlus + Cshap;
            float Average = Total / 3.0f;

            listView1.SelectedItems[0].SubItems[0].Text = textBox3.Text;
            listView1.SelectedItems[0].SubItems[1].Text = textBox4.Text;
            listView1.SelectedItems[0].SubItems[2].Text = textBox5.Text;
            listView1.SelectedItems[0].SubItems[3].Text = Total.ToString();
            listView1.SelectedItems[0].SubItems[4].Text = textBox3.Text;Average.ToString("f1");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int CLanguage = int.Parse(textBox3.Text);
            int CPlus = int.Parse(textBox4.Text);
            int Cshap = int.Parse(textBox5.Text);
            int Total = CLanguage + CPlus + Cshap;
            float Average = Total / 3.0f;

            int index = listView1.SelectedIndices[0];
            listView1.Items.Insert(index, new ListViewItem(new string[] {CLanguage.ToString(), CPlus.ToString(), Cshap.ToString(),
                Total.ToString(), Average.ToString("f1")}));
        }
    }
}
