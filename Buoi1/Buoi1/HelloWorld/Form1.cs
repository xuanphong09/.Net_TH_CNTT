using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void btn_1_click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World","Hop thoai",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            MessageBox.Show("Xin chao","Hop thoai",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }


    }
}
