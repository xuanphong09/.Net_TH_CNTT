using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giai_PTB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_a.Focus();
            result.Text="Kết quả";
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txt_a.Text);
            float b = float.Parse(txt_b.Text);

            if (a!=0)
            {
                result.Text = "Kết quả : "+ -b/a;

            }
            else
            {
                if (b == 0){
                 
                    result.Text = "Kết quả : " + "Vô số nghiệm";
                }
                else
                    result.Text = "Kết quả : " + "Vô nghiệm";

            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có sự muốn thoát?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (result==DialogResult.Yes)
            {
                Close();

            }
        }
    }
}
