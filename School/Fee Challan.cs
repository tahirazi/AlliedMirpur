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
    public partial class Fee_Challan : Form
    {
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        
        public Fee_Challan()
        {
            InitializeComponent();
        }

        private void Fee_Challan_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string status="";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText ="insert into finance values ('"+Convert.ToInt32(txtStdID.Text.Trim())+"','"+txtAccountNo.Text.Trim()+"','"+txtBankName.Text.Trim()+"','"+txtBranchCode.Text.Trim()+"','"+txtStdName.Text.Trim()+"','"+txtStdClass.Text.Trim()+"','"+txtSection.Text.Trim()+"','"+txtDueDate.Text.Trim()+"','"+txtValidityDate.Text.Trim()+"','"+txtIssueDate.Text.Trim()+"','"+Convert.ToDecimal(txtRegFee.Text.Trim())+"','"+Convert.ToDecimal(txtAdmFee.Text.Trim())+"','"+Convert.ToDecimal(txtSecurityFee.Text.Trim())+"','"+Convert.ToDecimal(txtAnnualCharge.Text.Trim())+"','"+Convert.ToDecimal(txtProspectus.Text.Trim())+"','"+Convert.ToDecimal(txtTuitionFee.Text.Trim())+"','"+Convert.ToDecimal(txtComputerICT.Text.Trim())+"','"+Convert.ToDecimal(txtLabCharges.Text.Trim())+"','"+Convert.ToDecimal(txtArrears.Text.Trim())+"','"+Convert.ToDecimal(txtSafetyFee.Text.Trim())+"','"+Convert.ToDecimal(txtAdmiProcessFee.Text.Trim())+"','"+Convert.ToDecimal(txtICTBook.Text.Trim())+"','"+Convert.ToDecimal(txtUniformFee.Text.Trim())+"','"+Convert.ToDecimal(txtOther.Text.Trim())+"','"+Convert.ToDecimal(txtFine.Text.Trim())+"','"+Convert.ToDecimal(txtNetPayable.Text.Trim())+"','"+Convert.ToDecimal(txtNetPayableAfter.Text.Trim())+"','"+status+"')";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                con.Close();
                MessageBox.Show("Record Added successfully.");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Some fields are empty or invalid. Please fill all fields or provide valid information. Fee fields require numeric data. Student ID field require a valid student ID. Please check provided information carefully. Try Again with valid data.",ee.ToString());
                con.Close();
            }
        }

        private void txtStdID_Leave(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from stdBasic where std_id='" + Convert.ToInt32(txtStdID.Text) + "'", con);
                da.Fill(dt);
                txtBranchCode.Text = dt.Rows[0][1].ToString();
                txtStdName.Text = dt.Rows[0][5].ToString();
                txtStdClass.Text = dt.Rows[0][9].ToString();
                txtSection.Text = dt.Rows[0][10].ToString();
                txtBankName.Text=dt.Rows[0][4].ToString();
                txtAccountNo.Text=dt.Rows[0][3].ToString();
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Please provide valid student ID.",ee.ToString());
                con.Close();
            }
            
        }

        private void txtNetPayable_Enter(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, d, ee, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t;
                a = Convert.ToDouble(txtRegFee.Text);
                b = Convert.ToDouble(txtAdmFee.Text);
                c = Convert.ToDouble(txtSecurityFee.Text);
                d = Convert.ToDouble(txtAnnualCharge.Text);
                ee = Convert.ToDouble(txtProspectus.Text);
                f = Convert.ToDouble(txtAdmiProcessFee.Text);
                g = Convert.ToDouble(txtUniformFee.Text);
                h = 0;
                i = Convert.ToDouble(txtTuitionFee.Text);
                j = Convert.ToDouble(txtComputerICT.Text);
                k = Convert.ToDouble(txtLabCharges.Text);
                l = Convert.ToDouble(txtArrears.Text);
                m = Convert.ToDouble(txtSafetyFee.Text);
                n = 0;
                o = 0;
                p = 0;
                q = Convert.ToDouble(txtICTBook.Text);
                r = Convert.ToDouble(txtOther.Text);
                s = Convert.ToDouble(txtFine.Text);
                t = a + b + c + d + ee + f + g + h + i + j + k + l + m + n + o + p + q + r + s;
                txtNetPayable.Text = Convert.ToString(t);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Please provide valid data into all fee fields. Do not let any field empty. Provide at least a 0 in field if it is not data to enter. The empty field make confliction in calculations.",ee.ToString());
                con.Close();
            }
            
        }

        private void label29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fee_Challan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.Fee_Challan = 0;
        }
    }
}
