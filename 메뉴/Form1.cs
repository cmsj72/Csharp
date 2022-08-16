using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 메뉴
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("열기");
        }

        //  ContextStrip/열기
        private void 열기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("컨텍스트 메뉴 열기");
        }
    }
}
