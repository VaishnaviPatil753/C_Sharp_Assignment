using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB;Integrated Security=True");

        void Con_open()
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Con;
            cmd.CommandText = "Select Count(*) From Student_Details";

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                cmd.CommandText = "Select Max(Roll_No)From Student_Details";

                Cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());

            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "1/1/2005";
        }

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Roll_No.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Mobile_No.TextLength == 10 && cmb_Course.Text != "")
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Student_Details (Roll_No, Name, DOB, Mobile_No, Course) Values (@RNo, @Nm, @DOB, @MNo, @Course)";


                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;


                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfuly","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Cumpulsary Fields","Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_List obj = new frm_View_All_Student_List();
            obj.Show();
            this.Hide();
        }
        
        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
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
    }
}
 