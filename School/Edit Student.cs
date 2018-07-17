using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School
{
    public partial class Edit_Student : Form
    {
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        public Edit_Student()
        {
            InitializeComponent();
        }
        private void Edit_Student_Load(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
    //              std_id int identity primary key not null,
    //              branch_code varchar(30) null,
    //              std_name varchar(70) not null,
    //              father_name varchar(70)null,
    //              phone varchar(15) null,
    //              std_address nvarchar(150) null,
    //              std_class nvarchar(30) null,
    //              std_section nvarchar(30) null
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update stdBasic set branch_code='" + txtBranchCode.Text.Trim() + "',std_web_portal_id='"+txtWebPortalID.Text.Trim()+"',account_no='"+txtAccountNo.Text.Trim()+"',bank_name='"+txtBankName.Text.Trim()+"',std_name='" + txtStdName.Text.Trim() + "',father_name='" + txtFatherName.Text.Trim() + "',phone='" + txtPhone.Text.Trim() + "',std_address='" + txtAddress.Text.Trim() + "',std_class='" + txtClass.Text.Trim() + "',std_section='" + txtSection.Text.Trim() + "' WHERE std_id='" + Convert.ToInt32(txtStdId.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                con.Close();
                MessageBox.Show("Record edited successfully.");
            }
            catch (Exception ee)
            {

                MessageBox.Show("The student ID is not valid or there is error in selection. Please select a valid method.",ee.ToString());
                con.Close();
            }
            

        }
        private void txtStdId_Leave(object sender, EventArgs e)
        {
        }

        private void txtStdId_Leave_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from stdBasic where std_id='" + Convert.ToInt32(txtStdId.Text) + "'", con);
                da.Fill(dt);
                txtBranchCode.Text = dt.Rows[0][1].ToString();
                txtWebPortalID.Text = dt.Rows[0][2].ToString();
                txtAccountNo.Text = dt.Rows[0][3].ToString();
                txtBankName.Text = dt.Rows[0][4].ToString();
                txtStdName.Text = dt.Rows[0][5].ToString();
                txtFatherName.Text = dt.Rows[0][6].ToString();
                txtPhone.Text = dt.Rows[0][7].ToString();
                txtAddress.Text = dt.Rows[0][8].ToString();
                txtClass.Text = dt.Rows[0][9].ToString();
                txtSection.Text = dt.Rows[0][10].ToString();
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("The student ID is not valid or there is error in selection. Please select a valid method.", ee.ToString());
                con.Close();
            }
        }

        private void Edit_Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.Edit_std = 0;
        }
    }
}
