using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestConnect
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //tao chuoi ket noi
        string strCon = @"Data Source=M10;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        //tao doi tuong ket noi
        SqlConnection sqlCon = null;

        //hàm kết nối
        private void MoKetNoi()
        {
            //rong thi thi tao moi
            if(sqlCon == null) {
                sqlCon= new SqlConnection(strCon);
            }

            //dong thi mo ket noi

            if(sqlCon.State==ConnectionState.Closed) {
                sqlCon.Open();
                MessageBox.Show("thanh cong");
            }
        }

        //ham dong ket noi
        private void DongKetNoi()
        {
            if(sqlCon!=null && sqlCon.State== ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MoKetNoi();
        }
    }
}
