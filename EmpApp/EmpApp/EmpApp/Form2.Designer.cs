using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Lab5;

namespace EmpApp
{
    partial class Form2
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
            List<Employee> temp = Employee.getAllEmp();



            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namesTable = new System.Data.DataTable();
            this.idColumn = new System.Data.DataColumn();
            this.NameColumn = new System.Data.DataColumn();
            this.sColumn = new System.Data.DataColumn();
            this.dColumn = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(647, 503);
            this.dataGridView1.TabIndex = 2;
            // 
            // namesTable
            // 
            this.namesTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.idColumn,
            this.NameColumn,
            this.sColumn,
            this.dColumn});
            this.namesTable.Namespace = "";
            this.namesTable.PrimaryKey = new System.Data.DataColumn[0];
            // 
            // idColumn
            // 
            this.idColumn.AutoIncrement = true;
            this.idColumn.Caption = "id";
            this.idColumn.ColumnName = "id";
            this.idColumn.DataType = typeof(int);
            //this.idColumn.DefaultValue = ((object)(resources.GetObject("idColumn.DefaultValue")));
            this.idColumn.Namespace = "";
            // 
            // NameColumn
            // 
            this.NameColumn.Caption = "name";
            this.NameColumn.ColumnName = "name";
            this.NameColumn.DefaultValue = "name";
            this.NameColumn.Namespace = "";
            // 
            // sColumn
            // 
            this.sColumn.Caption = "salary";
            this.sColumn.ColumnName = "salary";
            this.sColumn.DataType = typeof(int);
            this.sColumn.DefaultValue = ((object)(resources.GetObject("sColumn.DefaultValue")));
            this.sColumn.Namespace = "";
            // 
            // dColumn
            // 
            this.dColumn.Caption = "dept";
            this.dColumn.ColumnName = "dept";
            this.dColumn.DefaultValue = "dept";
            this.dColumn.Namespace = "";

            this.dataGridView1.Columns.Add("id", "id");
            this.dataGridView1.Columns.Add("name", "name");
            this.dataGridView1.Columns.Add("salary", "salary");
            this.dataGridView1.Columns.Add("dept", "dept");


            
            for (int i = 0; i < temp.Count; i++)
            {
                this.dataGridView1.Rows.Add(i, temp[i].name, temp[i].salary, temp[i].dept);
            }

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "GridView List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.namesTable)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();

        } //get all form

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DataTable namesTable;
        private DataColumn idColumn;
        private DataColumn NameColumn;
        private DataColumn sColumn;
        private DataColumn dColumn;
    }
}

