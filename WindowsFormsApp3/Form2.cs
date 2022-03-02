using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public bool themClicked = false;
        public bool suaClicked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (themClicked == true)
            {
                if (rd_Form2_Nam.Checked == true)
                {
                    mydata(txt_Form2_MSSV.Text, txt_Form2_Hovaten.Text, rd_Form2_Nam.Text, txt_Form2_Email.Text);
                }
                else if (rd_Form2_Nu.Checked == true)
                {
                    mydata(txt_Form2_MSSV.Text, txt_Form2_Hovaten.Text, rd_Form2_Nu.Text, txt_Form2_Email.Text);

                }


            }

            if (suaClicked == true)
            {
                if (rd_Form2_Nam.Checked == true)
                {
                    mydata(txt_Form2_MSSV.Text, txt_Form2_Hovaten.Text, rd_Form2_Nam.Text, txt_Form2_Email.Text);
                }
                else if (rd_Form2_Nu.Checked == true)
                {
                    mydata(txt_Form2_MSSV.Text, txt_Form2_Hovaten.Text, rd_Form2_Nu.Text, txt_Form2_Email.Text);

                }

            }





        }
        // lấy dữ liệu bên form2 hai sau đó đưa về form 1
        public delegate void GETDATA(string MSSV, String hovaten,string gioitinh, string email);
        public GETDATA mydata;
        


        private void btn_Form2_Hovaten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
