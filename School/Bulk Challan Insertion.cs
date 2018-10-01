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
    public partial class Bulk_Challan_Insertion : Form
    {
        public string arr;
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd = new SqlCommand();
        string query;
        public Bulk_Challan_Insertion()
        {
            InitializeComponent();
        }

        private void Bulk_Challan_Insertion_Load(object sender, EventArgs e)
        {
            try
            {

                ds = new DataSet();
                da = new SqlDataAdapter("SELECT std_id AS ID, account_no AS [Account Number], bank_name AS [Bank Name], branch_code AS [Branch Code], std_name AS [Student Name], std_class AS Class, std_section AS Section, registration_fee AS [Registration Fee], admission_fee AS [Admission Fee], security_deposit AS [Security Fee], annual_charge AS [Annual Charges], prospectus AS [Prospectus Fee], tuition_fee AS [Tuition Fee], computer_ict_fee AS [Computer ICT Fee], lab_charges AS [Lab Charges], arrears AS Arrears, safety_fee AS [Safety Fee], admission_process_fee AS [Admission Process Fee], ict_book AS [ICT Book], uniform_fee AS [Uniform Fee], other AS Others, fine AS Fine, before_due_date AS [Net Payable], after_due_date AS [Net Payable After Due Date], status AS [Status] FROM finance", con);
                da.Fill(ds, "finance");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                ds = new DataSet();
                da = new SqlDataAdapter("SELECT std_id AS ID, account_no AS [Account Number], bank_name AS [Bank Name], branch_code AS [Branch Code], std_name AS [Student Name], std_class AS Class, std_section AS Section, registration_fee AS [Registration Fee], admission_fee AS [Admission Fee], security_deposit AS [Security Fee], annual_charge AS [Annual Charges], prospectus AS [Prospectus Fee], tuition_fee AS [Tuition Fee], computer_ict_fee AS [Computer ICT Fee], lab_charges AS [Lab Charges], arrears AS Arrears, safety_fee AS [Safety Fee], admission_process_fee AS [Admission Process Fee], ict_book AS [ICT Book], uniform_fee AS [Uniform Fee], other AS Others, fine AS Fine, before_due_date AS [Net Payable], after_due_date AS [Net Payable After Due Date], status AS [Status] FROM finance WHERE std_class='" + txtClass.Text + "' AND issue_date='" + txtIssueDate.Text + "'", con);
                da.Fill(ds, "finance");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string StrQuery = @"INSERT INTO finance VALUES ('" + Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value) + "', '" + dataGridView1.Rows[i].Cells["Account Number"].Value + "', '" + dataGridView1.Rows[i].Cells["Bank Name"].Value + "','" + dataGridView1.Rows[i].Cells["Branch Code"].Value + "', '" + dataGridView1.Rows[i].Cells["Student Name"].Value + "', '" + dataGridView1.Rows[i].Cells["Class"].Value + "', '" + dataGridView1.Rows[i].Cells["Section"].Value + "','" + txtDueDate.Text.Trim() + "','" + txtValidityDate.Text.Trim() + "','" + txtNewIssueDate.Text.Trim() + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Registration Fee"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Admission Fee"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Security Fee"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Annual Charges"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Prospectus Fee"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Tuition Fee"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Computer ICT Fee"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Lab Charges"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Arrears"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Safety Fee"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Admission Process Fee"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["ICT Book"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Uniform Fee"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Others"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Fine"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Net Payable"].Value) + "', '" + Convert.ToDecimal(dataGridView1.Rows[i].Cells["Net Payable After Due Date"].Value) + "', '" + dataGridView1.Rows[i].Cells["Status"].Value + "');";

                try
                {
                    using (SqlConnection conn = new SqlConnection(Connection_Properties.GetConnectionString()))
                    {
                        using (SqlCommand comm = new SqlCommand(StrQuery, conn))
                        {
                            conn.Open();
                            comm.ExecuteNonQuery();
                            comm.Clone();
                            conn.Close();
                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("All Records Added Successfully.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void Bulk_Challan_Insertion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.bulk_challan_insertion = 0;
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
