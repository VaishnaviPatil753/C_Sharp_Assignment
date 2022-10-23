﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_View_All_Student_List : Form
    {
        public frm_View_All_Student_List()
        {
            InitializeComponent();
        }


        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }
        
        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
             DialogResult Res= MessageBox.Show("Are You Shoure Want To Log Out???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

             if (Res == DialogResult.Yes)
             {
                 Frm_Login obj = new Frm_Login();
                 obj.Show();
                 this.Hide();
             }
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet3.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Management_System_DBDataSet3.Student_Details);

        }

    }
}
