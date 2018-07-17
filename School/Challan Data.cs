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
    public partial class Challan_Data : Form
    {
        public string arr;
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd = new SqlCommand();
        string query;
        public Challan_Data()
        {
            InitializeComponent();
        }

        private void Challan_Data_Load(object sender, EventArgs e)
        {
            try
            {
                
                ds = new DataSet();
                da = new SqlDataAdapter("SELECT transaction_id AS [Transaction ID], std_id AS ID, account_no AS [Account Number], bank_name AS [Bank Name], branch_code AS [Branch Code], std_name AS [Student Name], std_class AS Class, std_section AS Section, due_date AS [Due Date], validity_date AS [Validity Date], issue_date AS [Issue Date], registration_fee AS [Registration Fee], admission_fee AS [Admission Fee], security_deposit AS [Security Fee], annual_charge AS [Annual Charges], prospectus AS [Prospectus Fee], tuition_fee AS [Tuition Fee], computer_ict_fee AS [Computer ICT Fee], lab_charges AS [Lab Charges], arrears AS Arrears, safety_fee AS [Safety Fee], admission_process_fee AS [Admission Process Fee], ict_book AS [ICT Book], uniform_fee AS [Uniform Fee], other AS Others, fine AS Fine, before_due_date AS [Net Payable], after_due_date AS [Net Payable After Due Date], status AS [Status] FROM finance", con);
                da.Fill(ds, "finance");
                dataGridView1.DataSource = ds.Tables[0];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Challan_Data_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.challan_data = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                da.Update(ds, "finance");
                MessageBox.Show("Updated Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //con.Open();
            //    //query = "insert into finance values ('"++"')";
            //    //cmd.CommandText = query;
            //    //SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (dataGridView1.IsCurrentRowDirty)
                {
                    //con.Open();
                    //ds = new DataSet();
                    //da = new SqlDataAdapter("SELECT transaction_id AS [Transaction ID], std_id AS ID, account_no AS [Account Number], bank_name AS [Bank Name], branch_code AS [Branch Code], std_name AS [Student Name], std_class AS Class, std_section AS Section, due_date AS [Due Date], validity_date AS [Validity Date], issue_date AS [Issue Date], registration_fee AS [Registration Fee], admission_fee AS [Admission Fee], security_deposit AS [Security Fee], annual_charge AS [Annual Charges], prospectus AS [Prospectus Fee], tuition_fee AS [Tuition Fee], computer_ict_fee AS [Computer ICT Fee], lab_charges AS [Lab Charges], arrears AS Arrears, safety_fee AS [Safety Fee], admission_process_fee AS [Admission Process Fee], ict_book AS [ICT Book], uniform_fee AS [Uniform Fee], other AS Others, fine AS Fine, before_due_date AS [Net Payable], after_due_date AS [Net Payable After Due Date] FROM finance", con);
                    //da.Fill(ds, "finance");
                    //dataGridView1.DataSource = ds.Tables[0];
                    //cmd.Connection = con;
                    string std_id = dataGridView1[1, e.RowIndex].EditedFormattedValue.ToString();
                    string account_no = dataGridView1[2, e.RowIndex].EditedFormattedValue.ToString();
                    string bank_name = dataGridView1[3, e.RowIndex].EditedFormattedValue.ToString();
                    string branch_code = dataGridView1[4, e.RowIndex].EditedFormattedValue.ToString();
                    string std_name = dataGridView1[5, e.RowIndex].EditedFormattedValue.ToString();
                    string std_class = dataGridView1[6, e.RowIndex].EditedFormattedValue.ToString();
                    string std_section = dataGridView1[7, e.RowIndex].EditedFormattedValue.ToString();
                    string due_date = dataGridView1[8, e.RowIndex].EditedFormattedValue.ToString();
                    string validity_date = dataGridView1[9, e.RowIndex].EditedFormattedValue.ToString();
                    string issue_date = dataGridView1[10, e.RowIndex].EditedFormattedValue.ToString();
                    string registration_fee = dataGridView1[11, e.RowIndex].EditedFormattedValue.ToString();
                    string admission_fee = dataGridView1[12, e.RowIndex].EditedFormattedValue.ToString();
                    string security_deposit = dataGridView1[13, e.RowIndex].EditedFormattedValue.ToString();
                    string annual_charge = dataGridView1[14, e.RowIndex].EditedFormattedValue.ToString();
                    string prospectus = dataGridView1[15, e.RowIndex].EditedFormattedValue.ToString();
                    string tuition_fee = dataGridView1[16, e.RowIndex].EditedFormattedValue.ToString();
                    string computer_ict_fee = dataGridView1[17, e.RowIndex].EditedFormattedValue.ToString();
                    string lab_charges = dataGridView1[18, e.RowIndex].EditedFormattedValue.ToString();
                    string arrears = dataGridView1[19, e.RowIndex].EditedFormattedValue.ToString();
                    string safety_fee = dataGridView1[20, e.RowIndex].EditedFormattedValue.ToString();
                    string admission_process_fee = dataGridView1[21, e.RowIndex].EditedFormattedValue.ToString();
                    string ict_book = dataGridView1[22, e.RowIndex].EditedFormattedValue.ToString();
                    string uniform_fee = dataGridView1[23, e.RowIndex].EditedFormattedValue.ToString();
                    string other = dataGridView1[24, e.RowIndex].EditedFormattedValue.ToString();
                    string fine = dataGridView1[25, e.RowIndex].EditedFormattedValue.ToString();
                    string before_due_date = dataGridView1[26, e.RowIndex].EditedFormattedValue.ToString();
                    string after_due_date = dataGridView1[27, e.RowIndex].EditedFormattedValue.ToString();
                    string status = dataGridView1[28, e.RowIndex].EditedFormattedValue.ToString();

                    if (status == "N" || status=="n")
                    {
                        arr = before_due_date;
                        con.Open();
                        cmd.Connection = con;
                        query = "insert into finance values ('" + Convert.ToInt32(std_id) + "','" + account_no + "','" + bank_name + "','" + branch_code + "','" + std_name + "','" + std_class + "','" + std_section + "','" + due_date + "','" + validity_date + "','" + issue_date + "','" + Convert.ToDecimal(registration_fee) + "','" + Convert.ToDecimal(admission_fee) + "','" + Convert.ToDecimal(security_deposit) + "','" + Convert.ToDecimal(annual_charge) + "','" + Convert.ToDecimal(prospectus) + "','" + Convert.ToDecimal(tuition_fee) + "','" + Convert.ToDecimal(computer_ict_fee) + "','" + Convert.ToDecimal(lab_charges) + "','" + Convert.ToDecimal(arr) + "','" + Convert.ToDecimal(safety_fee) + "','" + Convert.ToDecimal(admission_process_fee) + "','" + Convert.ToDecimal(ict_book) + "','" + Convert.ToDecimal(uniform_fee) + "','" + Convert.ToDecimal(other) + "','" + Convert.ToDecimal(fine) + "','" + Convert.ToDecimal(before_due_date) + "','" + Convert.ToDecimal(after_due_date) + "','"+status+"')"; ;
                        cmd.CommandText = query;
                        da.SelectCommand = cmd;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (status == "Y" || status == "y")
                    {
                        con.Open();
                        cmd.Connection = con;
                        query = "insert into finance values ('" + Convert.ToInt32(std_id) + "','" + account_no + "','" + bank_name + "','" + branch_code + "','" + std_name + "','" + std_class + "','" + std_section + "','" + due_date + "','" + validity_date + "','" + issue_date + "','" + Convert.ToDecimal(registration_fee) + "','" + Convert.ToDecimal(admission_fee) + "','" + Convert.ToDecimal(security_deposit) + "','" + Convert.ToDecimal(annual_charge) + "','" + Convert.ToDecimal(prospectus) + "','" + Convert.ToDecimal(tuition_fee) + "','" + Convert.ToDecimal(computer_ict_fee) + "','" + Convert.ToDecimal(lab_charges) + "','" + Convert.ToDecimal(arrears) + "','" + Convert.ToDecimal(safety_fee) + "','" + Convert.ToDecimal(admission_process_fee) + "','" + Convert.ToDecimal(ict_book) + "','" + Convert.ToDecimal(uniform_fee) + "','" + Convert.ToDecimal(other) + "','" + Convert.ToDecimal(fine) + "','" + Convert.ToDecimal(before_due_date) + "','" + Convert.ToDecimal(after_due_date) + "','"+status+"')"; ;
                        cmd.CommandText = query;
                        da.SelectCommand = cmd;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kindly check the status. It is invalid. Make it correct with Yes or No by putting 'Y' or 'N'. Thanks.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            try
            {

                ds = new DataSet();
                da = new SqlDataAdapter("SELECT transaction_id AS [Transaction ID], std_id AS ID, account_no AS [Account Number], bank_name AS [Bank Name], branch_code AS [Branch Code], std_name AS [Student Name], std_class AS Class, std_section AS Section, due_date AS [Due Date], validity_date AS [Validity Date], issue_date AS [Issue Date], registration_fee AS [Registration Fee], admission_fee AS [Admission Fee], security_deposit AS [Security Fee], annual_charge AS [Annual Charges], prospectus AS [Prospectus Fee], tuition_fee AS [Tuition Fee], computer_ict_fee AS [Computer ICT Fee], lab_charges AS [Lab Charges], arrears AS Arrears, safety_fee AS [Safety Fee], admission_process_fee AS [Admission Process Fee], ict_book AS [ICT Book], uniform_fee AS [Uniform Fee], other AS Others, fine AS Fine, before_due_date AS [Net Payable], after_due_date AS [Net Payable After Due Date], status AS [Status] FROM finance WHERE std_class='"+txtClass.Text+"' AND issue_date='"+txtIssueDate.Text+"'", con);
                da.Fill(ds, "finance");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
