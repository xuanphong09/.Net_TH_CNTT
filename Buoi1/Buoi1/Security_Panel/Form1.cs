using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pass;
        private void Form1_Load(object sender, EventArgs e)
        {
            pass = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pass = "";
            txtPass.Clear();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            pass += 1;
            txtPass.Text = pass;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            pass += 2;
            txtPass.Text = pass;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            pass += 3;
            txtPass.Text = pass;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            pass += 4;
            txtPass.Text = pass;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            pass += 5;
            txtPass.Text = pass;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            pass += 6;
            txtPass.Text = pass;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            pass += 7;
            txtPass.Text = pass;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            pass += 8;
            txtPass.Text = pass;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            pass += 9;
            txtPass.Text = pass;
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi yêu cầu báo động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        DateTime now = DateTime.Now;
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (pass == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(pass=="1496" || pass == "2673")
            {
                ListViewItem lvi = new ListViewItem(now.ToString());
                lvi.SubItems.Add("Công nghệ phần mềm");
                lvi.SubItems.Add("Chấp nhận");

                //thêm liv vào lsv
                lsv.Items.Add(lvi);
                pass = "";
                txtPass.Text = pass;

            }
            else if (pass == "7462")
            {
                ListViewItem lvi = new ListViewItem(now.ToString());
                lvi.SubItems.Add("Nghiên cứu viên");
                lvi.SubItems.Add("Chấp nhận");

                //thêm liv vào lsv
                lsv.Items.Add(lvi);
                pass = "";
                txtPass.Text = pass;

            }
            else if (pass == "8884" || pass== "3842" || pass== "3383")
            {
                ListViewItem lvi = new ListViewItem(now.ToString());
                lvi.SubItems.Add("Thiết kế mô hình");
                lvi.SubItems.Add("Chấp nhận");

                //thêm liv vào lsv
                lsv.Items.Add(lvi);
                pass = "";
                txtPass.Text = pass;

            }
            else
            {
                ListViewItem lvi = new ListViewItem(now.ToString());
                lvi.SubItems.Add("Không có");
                lvi.SubItems.Add("Từ chối");

                //thêm liv vào lsv
                lsv.Items.Add(lvi);
                pass = "";
                txtPass.Text = pass;

            }

        }
    }
}
