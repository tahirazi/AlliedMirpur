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
    public partial class Delete_Student : Form
    {
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        public Delete_Student()
        {
            InitializeComponent();
        }

        private void Delete_Student_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Yellow;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from stdBasic WHERE std_id='" + Convert.ToInt32(txtStdId.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                con.Close();
                MessageBox.Show("Record deleted successfully.");
            }
            catch (Exception ee)
            {

                MessageBox.Show("You selected an invalid student ID. Please provide valid data.", ee.ToString());
                con.Close();
            }
            
        }

        private void txtStdId_Leave(object sender, EventArgs e)
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

                MessageBox.Show("You selected an invalid student ID. Please provide valid data.",ee.ToString());
                con.Close();
            }
            
        }

        private void Delete_Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.delete_std = 0;
        }
    }
}
