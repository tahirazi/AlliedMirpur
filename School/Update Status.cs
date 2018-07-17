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
    public partial class Update_Status : Form
    {
        public string arr;
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd = new SqlCommand();
        string query;
        public Update_Status()
        {
            InitializeComponent();
        }

        private void Update_Status_Load(object sender, EventArgs e)
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

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.IsCurrentRowDirty)
            {
                try
                {
                    SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                    da.Update(ds, "finance");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            try
            {

                ds = new DataSet();
                da = new SqlDataAdapter("SELECT transaction_id AS [Transaction ID], std_id AS ID, account_no AS [Account Number], bank_name AS [Bank Name], branch_code AS [Branch Code], std_name AS [Student Name], std_class AS Class, std_section AS Section, due_date AS [Due Date], validity_date AS [Validity Date], issue_date AS [Issue Date], registration_fee AS [Registration Fee], admission_fee AS [Admission Fee], security_deposit AS [Security Fee], annual_charge AS [Annual Charges], prospectus AS [Prospectus Fee], tuition_fee AS [Tuition Fee], computer_ict_fee AS [Computer ICT Fee], lab_charges AS [Lab Charges], arrears AS Arrears, safety_fee AS [Safety Fee], admission_process_fee AS [Admission Process Fee], ict_book AS [ICT Book], uniform_fee AS [Uniform Fee], other AS Others, fine AS Fine, before_due_date AS [Net Payable], after_due_date AS [Net Payable After Due Date], status AS [Status] FROM finance where std_class='" + txtClass.Text + "' AND issue_date='"+txtIssueDate.Text+"'", con);
                da.Fill(ds, "finance");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Update_Status_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.update_status = 0;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }
    }
}
