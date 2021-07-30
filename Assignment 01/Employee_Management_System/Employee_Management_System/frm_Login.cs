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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }


        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Admin" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Sucessfull", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Employee obj = new frm_Add_New_Employee();

                obj.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Incorrect Username OR Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

       
    }
}
