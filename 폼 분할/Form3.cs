using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 폼_분할
{
    public partial class Form3 : Form
    {
        Image myImage;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            myImage = Image.FromFile("test.png");
            this.AutoScrollMinSize = myImage.Size;  // 스크롤바 출현
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(myImage, AutoScrollPosition.X, AutoScrollPosition.Y);
        }

        private void 윈도우ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 윈도우2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 폼1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  아래와 같은 형태로 자식 폼 생성 및 지정
            //  주석처리한 이유는 실제로 만들어 놓지 않은 폼이 있기때문
            /*Form2 MdiChildForm1 = new Form2();
            MdiChildForm1.MdiParent = this;
            MdiChildForm1.Show();*/
        }

        private void 폼2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form3 MdiChildForm1 = new Form2();
            MdiChildForm1.MdiParent = this;
            MdiChildForm1.Show();*/
        }

        private void 폼3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form4 MdiChildForm1 = new Form2();
            MdiChildForm1.MdiParent = this;
            MdiChildForm1.Show();*/
        }

        private void 폼4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form5 MdiChildForm1 = new Form2();
            MdiChildForm1.MdiParent = this;
            MdiChildForm1.Show();*/
        }
    }
}
