using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Frm_View_All_Employee : Form
    {
        public Frm_View_All_Employee()
        {
            InitializeComponent();
        }

        private void Frm_View_All_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Management_System_DBDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.employee_Management_System_DBDataSet.Employee_Details);

        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee obj = new frm_Add_New_Employee();

            obj.Show();
            this.Hide();
        }

        private void btn_Search_Employee_Click(object sender, EventArgs e)
        {
            frm_Search_Employee obj = new frm_Search_Employee();

            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Frm_login obj = new Frm_login();

            obj.Show();
            this.Hide();

        }

       

        

       

       
    }
}
