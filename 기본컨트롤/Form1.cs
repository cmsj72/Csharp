using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 기본컨트롤
{
    public partial class Form1 : Form
    {
        RadioButton SelectedRadio;
        public Form1()
        {
            InitializeComponent();
            textBox11.Text = hScrollBar1.Value.ToString();
            textBox13.Text = "0";

            domainUpDown1.SelectedIndex = 0;
            textBox14.Text = domainUpDown1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strResult = "체크 1:" + checkBox1.CheckState +
                "체크 2:" + checkBox2.CheckState +
                "체크 3:" + checkBox3.CheckState;
            MessageBox.Show(strResult);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("radio 1 선택");
            else if(radioButton2.Checked)
                MessageBox.Show("radio 2 선택");
            if(radioButton3.Checked)
                MessageBox.Show("radio 3 선택");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SelectedRadio == radioButton4)
                MessageBox.Show("radio 4 선택");
            else if (SelectedRadio == radioButton5)
                MessageBox.Show("radio 5 선택");
            if (SelectedRadio == radioButton6)
                MessageBox.Show("radio 6 선택");
        }

        //  라디오 버튼은 그룹화된 라디오 버튼 중에서 하나만 선택되기 때문에 아래와 같은 형태로도 가능하다.
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int CLang = Convert.ToInt32(textBox3.Text);
            int CPlus = Convert.ToInt32(textBox4.Text);
            int CShap = Convert.ToInt32(textBox5.Text);

            float Average = (CLang + CPlus + CShap) / 3.0f;
            string Result = Average.ToString("f1");
            MessageBox.Show(Result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Clear();// 같은 결과
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = comboBox1.SelectedIndex;
            string FruitName = comboBox1.Text;
            textBox6.Text = Index.ToString();
            textBox7.Text = FruitName;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox8.Text = listBox1.SelectedIndex.ToString();
            textBox9.Text = listBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox10.Text);
            textBox10.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox11.Text = hScrollBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox12.Text = trackBar1.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox13.Text = numericUpDown1.Value.ToString();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            textBox14.Text = domainUpDown1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            //  이미지 파일 이름 입력
            pictureBox2.Image = Image.FromFile("test.bmp");*/
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*//  버튼을 클릭시 이미지를 로드 하게 하는 코드
            pictureBox2.Image = Image.FromFile("test.bmp");*/
        }
    }
}
