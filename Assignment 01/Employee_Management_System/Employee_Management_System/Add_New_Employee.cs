using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Employee_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();

            obj.Show();

            this.Hide();

        }

        private void lbl_View_All_Details_Click(object sender, EventArgs e)
        {
            frm_View_All_Employee obj = new frm_View_All_Employee();

            obj.Show();

            this.Hide();

        }

        void Clear_Control()
        {
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Salary.Clear();
            dtp_DOB.Text = "";
            cmb_Department.Text = "";

            tb_ID.Focus();
          }


        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Salary.Text != "" && cmb_Department.Text != "" && dtp_DOB.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Employee_Details(ID,Name,DOB,Salary,Deparment) VALUES (@id,@name,@dob,@salary,@dept)";

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("dob", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("salary", SqlDbType.Money).Value = tb_Salary.Text;
                Cmd.Parameters.Add("dept", SqlDbType.NVarChar).Value = cmb_Department.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Con_Close();


            }
            else
            {
                MessageBox.Show("Fill The Information","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Warning);
    
            }

            Clear_Control();
            
        }


    }
}
