﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_Student_Management_System
{
    public partial class frm_View_All_Student_List : Form
    {
        public frm_View_All_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void frm_View_All_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGM_Student_Management_System_DBDataSet1.Student_Details1' table. You can move, or remove it, as needed.
            this.student_Details1TableAdapter1.Fill(this.sGM_Student_Management_System_DBDataSet1.Student_Details1);
            // TODO: This line of code loads data into the 'sGM_Student_Management_System_DBDataSet.Student_Details1' table. You can move, or remove it, as needed.
            this.student_Details1TableAdapter.Fill(this.sGM_Student_Management_System_DBDataSet.Student_Details1);

        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }
    }
}
