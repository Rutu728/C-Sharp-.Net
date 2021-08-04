﻿namespace Employee_Management_System
{
    partial class Frm_View_All_Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_View_All_Employee = new System.Windows.Forms.Label();
            this.dgv_View_All_Employee = new System.Windows.Forms.DataGridView();
            this.employee_Management_System_DBDataSet = new Employee_Management_System.Employee_Management_System_DBDataSet();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new Employee_Management_System.Employee_Management_System_DBDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deparmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.btn_Search_Employee = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Employee
            // 
            this.lbl_View_All_Employee.AutoSize = true;
            this.lbl_View_All_Employee.BackColor = System.Drawing.Color.White;
            this.lbl_View_All_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Employee.Location = new System.Drawing.Point(193, 33);
            this.lbl_View_All_Employee.Name = "lbl_View_All_Employee";
            this.lbl_View_All_Employee.Size = new System.Drawing.Size(321, 39);
            this.lbl_View_All_Employee.TabIndex = 0;
            this.lbl_View_All_Employee.Text = "View All Employee";
            // 
            // dgv_View_All_Employee
            // 
            this.dgv_View_All_Employee.AllowUserToAddRows = false;
            this.dgv_View_All_Employee.AllowUserToDeleteRows = false;
            this.dgv_View_All_Employee.AutoGenerateColumns = false;
            this.dgv_View_All_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.deparmentDataGridViewTextBoxColumn});
            this.dgv_View_All_Employee.DataSource = this.employeeDetailsBindingSource;
            this.dgv_View_All_Employee.Location = new System.Drawing.Point(0, 119);
            this.dgv_View_All_Employee.Name = "dgv_View_All_Employee";
            this.dgv_View_All_Employee.ReadOnly = true;
            this.dgv_View_All_Employee.Size = new System.Drawing.Size(718, 226);
            this.dgv_View_All_Employee.TabIndex = 0;
            // 
            // employee_Management_System_DBDataSet
            // 
            this.employee_Management_System_DBDataSet.DataSetName = "Employee_Management_System_DBDataSet";
            this.employee_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.employee_Management_System_DBDataSet;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deparmentDataGridViewTextBoxColumn
            // 
            this.deparmentDataGridViewTextBoxColumn.DataPropertyName = "Deparment";
            this.deparmentDataGridViewTextBoxColumn.HeaderText = "Deparment";
            this.deparmentDataGridViewTextBoxColumn.Name = "deparmentDataGridViewTextBoxColumn";
            this.deparmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(72, 385);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(229, 41);
            this.btn_Add_New_Employee.TabIndex = 1;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // btn_Search_Employee
            // 
            this.btn_Search_Employee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Search_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Employee.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Search_Employee.Location = new System.Drawing.Point(406, 385);
            this.btn_Search_Employee.Name = "btn_Search_Employee";
            this.btn_Search_Employee.Size = new System.Drawing.Size(199, 41);
            this.btn_Search_Employee.TabIndex = 2;
            this.btn_Search_Employee.Text = "Search Employee";
            this.btn_Search_Employee.UseVisualStyleBackColor = false;
            this.btn_Search_Employee.Click += new System.EventHandler(this.btn_Search_Employee_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Log_Out.Location = new System.Drawing.Point(631, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(75, 31);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // Frm_View_All_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 456);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Search_Employee);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.dgv_View_All_Employee);
            this.Controls.Add(this.lbl_View_All_Employee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_View_All_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Employee";
            this.Load += new System.EventHandler(this.Frm_View_All_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Employee;
        private System.Windows.Forms.DataGridView dgv_View_All_Employee;
        private Employee_Management_System_DBDataSet employee_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_Management_System_DBDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deparmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Button btn_Search_Employee;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}