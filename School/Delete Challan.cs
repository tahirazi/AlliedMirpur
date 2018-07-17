using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School
{
    public partial class Delete_Challan : Form
    {
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        public Delete_Challan()
        {
            InitializeComponent();
        }
        private void Delete_Challan_Load(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from finance WHERE std_id='" + Convert.ToInt32(txtStdId.Text) + "' AND issue_date='"+txtIssueDate.Text+"'";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                con.Close();
                MessageBox.Show("Record deleted successfully.");
            }
            catch (Exception ee)
            {

                MessageBox.Show("You selected an invalid student ID or Invalid Issue Date. Please provide valid data.", ee.ToString());
                con.Close();
            }
        }

        private void txtStdId_Leave(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from finance where std_id='" + Convert.ToInt32(txtStdId.Text) + "'", con);
                da.Fill(dt);
                txtBranchCode.Text = dt.Rows[0][3].ToString();
                txtAccountNo.Text = dt.Rows[0][1].ToString();
                txtBankName.Text = dt.Rows[0][2].ToString();
                txtStdName.Text = dt.Rows[0][4].ToString();
                txtClass.Text = dt.Rows[0][5].ToString();
                txtSection.Text = dt.Rows[0][6].ToString();
                con.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show("You selected an invalid student ID. Please provide valid data.", ee.ToString());
                con.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Challan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.delete_challan = 0;
        }
    }
}
