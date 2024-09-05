using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username=txt_password.Text;
            string password=txt_password.Text;

            if(username=="admin" && password=="admin")
            {
                MessageBox.Show(
                    "Dang nhap thanh cong",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Dang nhap khong thanh cong",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txt_user_name.Clear();
                txt_password.Clear();
                txt_user_name.Focus();
            }
        }
    }
}
