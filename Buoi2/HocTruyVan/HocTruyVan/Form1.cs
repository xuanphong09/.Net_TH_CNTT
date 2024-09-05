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

namespace HocTruyVan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strCon = @"Data Source=M10;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        SqlConnection sqlCon = null;

        //mo ket noi
        private void MoKetNoi()
        {
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if(sqlCon.State==ConnectionState.Closed) {
                sqlCon.Open();
            }

        }

        private void DongKetNoi() {
            if(sqlCon!=null && sqlCon.State==ConnectionState.Open) {
                sqlCon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoKetNoi();

            //Doi tuong thuc thi truy van
            SqlCommand sqlCmd =  new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select count(*) from Sinhvien";

            //gan truy van vao ket noi
            sqlCmd.Connection= sqlCon;

            //nhan ket qua
            int kq= (int)sqlCmd.ExecuteScalar();
            MessageBox.Show("Số lượng sinh viên là: "+ kq);
        }
    }
}
