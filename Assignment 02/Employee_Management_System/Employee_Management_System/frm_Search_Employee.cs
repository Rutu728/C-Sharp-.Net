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
    public partial class frm_Search_Employee : Form
    {
        public frm_Search_Employee()
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
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Salary.Clear();
            dtp_DOB.Text = "";
            cmb_Depertment.Text = "";

            tb_ID.Focus();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee obj = new frm_Add_New_Employee();

            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Details_Click(object sender, EventArgs e)
        {
            Frm_View_All_Employee obj = new Frm_View_All_Employee();

            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Frm_login obj = new Frm_login();

            obj.Show();
            this.Hide();
        
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

               Cmd.CommandText = "select * From Employee_Details where ID = " + tb_ID.Text + "";

               var obj = Cmd.ExecuteReader();

               if (obj.Read())
               {
                   tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                   dtp_DOB.Text = (obj["DOB"].ToString());
                   tb_Salary.Text =(obj["Salary"].ToString());
                   cmb_Depertment.Text = obj.GetString(obj.GetOrdinal("Deparment"));
               }
               else
               {
                   MessageBox.Show("No Such Record Found","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                   Clear_Controls();

               }

              
               Con_Close();

            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

       
       

       
      
      
      
        
       
    }
}
