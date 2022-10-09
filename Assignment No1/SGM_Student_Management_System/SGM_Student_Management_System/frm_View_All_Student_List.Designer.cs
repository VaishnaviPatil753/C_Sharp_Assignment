namespace SGM_Student_Management_System
{
    partial class frm_View_All_Student_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_All_Student_List));
            this.lbl_View_Students_List = new System.Windows.Forms.Label();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetails1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Student_Management_System_DBDataSet1 = new SGM_Student_Management_System.SGM_Student_Management_System_DBDataSet1();
            this.studentDetails1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Student_Management_System_DBDataSet = new SGM_Student_Management_System.SGM_Student_Management_System_DBDataSet();
            this.student_Details1TableAdapter = new SGM_Student_Management_System.SGM_Student_Management_System_DBDataSetTableAdapters.Student_Details1TableAdapter();
            this.student_Details1TableAdapter1 = new SGM_Student_Management_System.SGM_Student_Management_System_DBDataSet1TableAdapters.Student_Details1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetails1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Management_System_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetails1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Management_System_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Students_List
            // 
            this.lbl_View_Students_List.AutoSize = true;
            this.lbl_View_Students_List.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_View_Students_List.Font = new System.Drawing.Font("Cambria", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Students_List.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_View_Students_List.Location = new System.Drawing.Point(252, 9);
            this.lbl_View_Students_List.Name = "lbl_View_Students_List";
            this.lbl_View_Students_List.Size = new System.Drawing.Size(573, 80);
            this.lbl_View_Students_List.TabIndex = 0;
            this.lbl_View_Students_List.Text = "View Students List";
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(962, -1);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(178, 70);
            this.btn_Log_Out.TabIndex = 2;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(338, 651);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(435, 72);
            this.btn_Add_New_Student.TabIndex = 1;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_List.DataSource = this.studentDetails1BindingSource1;
            this.dgv_Student_List.Location = new System.Drawing.Point(12, 110);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            this.dgv_Student_List.RowTemplate.Height = 24;
            this.dgv_Student_List.Size = new System.Drawing.Size(1116, 535);
            this.dgv_Student_List.TabIndex = 3;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetails1BindingSource1
            // 
            this.studentDetails1BindingSource1.DataMember = "Student_Details1";
            this.studentDetails1BindingSource1.DataSource = this.sGM_Student_Management_System_DBDataSet1;
            // 
            // sGM_Student_Management_System_DBDataSet1
            // 
            this.sGM_Student_Management_System_DBDataSet1.DataSetName = "SGM_Student_Management_System_DBDataSet1";
            this.sGM_Student_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetails1BindingSource
            // 
            this.studentDetails1BindingSource.DataMember = "Student_Details1";
            this.studentDetails1BindingSource.DataSource = this.sGM_Student_Management_System_DBDataSet;
            // 
            // sGM_Student_Management_System_DBDataSet
            // 
            this.sGM_Student_Management_System_DBDataSet.DataSetName = "SGM_Student_Management_System_DBDataSet";
            this.sGM_Student_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_Details1TableAdapter
            // 
            this.student_Details1TableAdapter.ClearBeforeFill = true;
            // 
            // student_Details1TableAdapter1
            // 
            this.student_Details1TableAdapter1.ClearBeforeFill = true;
            // 
            // frm_View_All_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1140, 751);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.lbl_View_Students_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_View_All_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Student List";
            this.Load += new System.EventHandler(this.frm_View_All_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetails1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Management_System_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetails1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Management_System_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Students_List;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private SGM_Student_Management_System_DBDataSet sGM_Student_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetails1BindingSource;
        private SGM_Student_Management_System_DBDataSetTableAdapters.Student_Details1TableAdapter student_Details1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private SGM_Student_Management_System_DBDataSet1 sGM_Student_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetails1BindingSource1;
        private SGM_Student_Management_System_DBDataSet1TableAdapters.Student_Details1TableAdapter student_Details1TableAdapter1;
    }
}