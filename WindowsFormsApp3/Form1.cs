using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Phải import thêm mới sư dụng sql được

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {   //Tạo kết nối với database
        //---
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=MSI;Initial Catalog=QuanLyLopHoc;Integrated Security=True"; //CHỗ này phải sữa lại đường dẫn tùy mỗi mấy nha
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //---
        //Hàm post dữ liệu lên DataGridView
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from Sinhvien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtg_Sinhvien.DataSource = table;

        }
        //Hàm insert clds sau đso post lên DataGridView
        void InsertData(string MSSV , string Hovaten , string gioitinh , string email)
        {
            command = connection.CreateCommand();
            string query = string.Format("Insert into Sinhvien Values(N'{0}',N'{1}',N'{2}',N'{3}')",MSSV , Hovaten , gioitinh , email);
            command.CommandText= query;
            command.ExecuteNonQuery();
            loaddata();

        }
        //Hàm delete clds sau đso post lên DataGridView
        void DeleteData(string mssv)
        {
            command = connection.CreateCommand();
            string query = string.Format("Delete Sinhvien where masv = '{0}'", mssv);
            command.CommandText = query;
            command.ExecuteNonQuery();
            loaddata();
        }
        //Hàm update lên DataGridView trong csdl{2}
        void UpdateData(string MSSV ,string Hovaten, string gioitinh, string email)
        {
            command = connection.CreateCommand();
            string query = string.Format("Update Sinhvien set hoten=N'{1}',gioitinh=N'{2}',email=N'{3}' where masv='{0}'", MSSV, Hovaten, gioitinh, email);
            command.CommandText = query;
            command.ExecuteNonQuery();
            loaddata();

        }

        //Đưa dữ liệu sau khi lấy được vào {1} để tính toán
        public void GETVALUE_Insert(string MSSV,string HOVATEN,string GIOITINH , string Email)
        {
            InsertData(MSSV , HOVATEN , GIOITINH , Email);
        }
        //Đưa dữ liệu sau khi lấy được vào {2} để tính toán
        public void GETVALUE_Update(string MSSV , string HOVATEN, string GIOITINH, string Email)
        {
            UpdateData(MSSV,HOVATEN, GIOITINH, Email);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //Kết nói và tải database lên
        private void Form1_Load(object sender, EventArgs e)
        {
        
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }
        
        //Nhận dữ liệu form2 sau đó thực hiện insert trong sql 
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.themClicked = true;
            form2.mydata = new Form2.GETDATA(GETVALUE_Insert);
            form2.ShowDialog();
        }

        //Nhận dữ liệu form2 sau đó thực hiện update trong sql 
        private void btn_Form1_Suathongtin_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.suaClicked = true;
            form2.mydata = new Form2.GETDATA(GETVALUE_Update);
            form2.ShowDialog();

        }

        private void btn_Form_Xoadulieu_Click(object sender, EventArgs e)
        {
            if (masv != null)
            {
                DeleteData(masv);
            }
        }

        private void dtg_Sinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        private string masv;

        private void dtg_Sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtg_Sinhvien.CurrentCell.RowIndex;
            masv = dtg_Sinhvien.Rows[i].Cells[0].Value.ToString();
        }
    }
}
