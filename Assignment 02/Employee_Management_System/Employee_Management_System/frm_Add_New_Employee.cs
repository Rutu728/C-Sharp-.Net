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

        void Clear_Controls()
        {
            tb_Id.Clear();
            tb_Name.Clear();
            dtp_DOb.Text = "";
            tb_Salary.Clear();
            cmb_Depertment.Text = "";


            tb_Id.Focus();

        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Frm_login obj = new Frm_login();

            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Employee_Click(object sender, EventArgs e)
        {
            Frm_View_All_Employee obj = new Frm_View_All_Employee();

            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text != "" && tb_Name.Text != "" && dtp_DOb.Text != "" && tb_Salary.Text != "" && cmb_Depertment.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "insert into Employee_Details (ID,Name,Salary,DOB,Deparment)values(@id,@name,@salary,@dob,@deparment)";

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_Id.Text;
                Cmd.Parameters.Add("name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("salary", SqlDbType.Money).Value = tb_Salary.Text;
                Cmd.Parameters.Add("dob", SqlDbType.Date).Value = dtp_DOb.Text;
                Cmd.Parameters.Add("deparment", SqlDbType.NVarChar).Value = cmb_Depertment.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Con_Close();


            }
            else
            {
                MessageBox.Show("Incomplete Information","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


            Clear_Controls();
        }

    

       
        
        

    }
}