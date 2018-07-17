using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace School
{
    public partial class Edit_Challan : Form
    {
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        public Edit_Challan()
        {
            InitializeComponent();
        }

        private void Edit_Challan_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White;
            groupBox3.ForeColor = Color.White;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText ="UPDATE finance SET  account_no='" + txtAccountNo.Text.Trim() + "',bank_name='" + txtBankName.Text.Trim() + "',branch_code='" + txtBranchCode.Text.Trim() + "',std_name='" + txtStdName.Text.Trim() + "',std_class='" + txtStdClass.Text.Trim() + "',std_section='" + txtSection.Text.Trim() + "',due_date='" + txtDueDate.Text.Trim() + "',validity_date='" + txtValidityDate.Text.Trim() + "',issue_date='" + txtIssueDate.Text.Trim() + "',registration_fee='" + Convert.ToDecimal(txtRegFee.Text.Trim()) + "',admission_fee='" + Convert.ToDecimal(txtAdmFee.Text.Trim()) + "',security_deposit='" + Convert.ToDecimal(txtSecurityFee.Text.Trim()) + "',annual_charge='" + Convert.ToDecimal(txtAnnualCharge.Text.Trim()) + "',prospectus='" + Convert.ToDecimal(txtProspectus.Text.Trim()) + "',tuition_fee='" + Convert.ToDecimal(txtTuitionFee.Text.Trim()) + "',computer_ict_fee='" + Convert.ToDecimal(txtComputerICT.Text.Trim()) + "',lab_charges='" + Convert.ToDecimal(txtLabCharges.Text.Trim()) + "',arrears='" + Convert.ToDecimal(txtArrears.Text.Trim()) + "',safety_fee='" + Convert.ToDecimal(txtSafetyFee.Text.Trim()) + "',admission_process_fee='" + Convert.ToDecimal(txtAdmiProcessFee.Text.Trim()) + "',ict_book='" + Convert.ToDecimal(txtICTBook.Text.Trim()) + "',uniform_fee='" + Convert.ToDecimal(txtUniformFee.Text.Trim()) + "',other='" + Convert.ToDecimal(txtOther.Text.Trim()) + "',fine='" + Convert.ToDecimal(txtFine.Text.Trim()) + "',before_due_date='" + Convert.ToDecimal(txtNetPayable.Text.Trim()) + "',after_due_date='" + Convert.ToDecimal(txtNetPayableAfter.Text.Trim()) + "' WHERE std_id='"+Convert.ToInt32(txtStdID.Text)+"'";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                con.Close();
                MessageBox.Show("Record Edited successfully.");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Some fields are empty or invalid. Please fill all fields or provide valid information. Fee fields require numeric data. Student ID field require a valid student ID. Please check provided information carefully. Try Again with valid data.", ee.ToString());
                con.Close();
            }
        }

        private void txtStdID_Leave(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from finance where std_id='" + Convert.ToInt32(txtStdID.Text) + "'", con);
                da.Fill(dt);
                txtBranchCode.Text = dt.Rows[0][3].ToString();
                txtStdName.Text = dt.Rows[0][4].ToString();
                txtStdClass.Text = dt.Rows[0][5].ToString();
                txtSection.Text = dt.Rows[0][6].ToString();
                txtAccountNo.Text = dt.Rows[0][1].ToString();
                txtBankName.Text = dt.Rows[0][2].ToString();
                txtDueDate.Text=dt.Rows[0][7].ToString();
                txtValidityDate.Text=dt.Rows[0][8].ToString();
                txtIssueDate.Text=dt.Rows[0][9].ToString();
                txtRegFee.Text=dt.Rows[0][10].ToString();
                txtAdmFee.Text=dt.Rows[0][11].ToString();
                txtSecurityFee.Text=dt.Rows[0][12].ToString();
                txtAnnualCharge.Text=dt.Rows[0][13].ToString();
                txtProspectus.Text=dt.Rows[0][14].ToString();
                txtTuitionFee.Text=dt.Rows[0][15].ToString();
                txtComputerICT.Text=dt.Rows[0][16].ToString();
                txtLabCharges.Text=dt.Rows[0][17].ToString();
                txtArrears.Text=dt.Rows[0][18].ToString();
                txtSafetyFee.Text=dt.Rows[0][19].ToString();
                txtAdmiProcessFee.Text=dt.Rows[0][20].ToString();
                txtICTBook.Text=dt.Rows[0][21].ToString();
                txtUniformFee.Text=dt.Rows[0][22].ToString();
                txtOther.Text=dt.Rows[0][23].ToString();
                txtFine.Text=dt.Rows[0][24].ToString();
                txtNetPayable.Text=dt.Rows[0][25].ToString();
                txtNetPayableAfter.Text=dt.Rows[0][26].ToString();
                
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Please provide valid student ID.", ee.ToString());
                con.Close();
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("Please provide valid data into all fee fields. Do not let any field empty. Provide at least a 0 in field if it is not data to enter. The empty field make confliction in calculations.", ee.ToString());
                con.Close();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Edit_Challan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.Edit_Challan = 0;
        }
    }
}
