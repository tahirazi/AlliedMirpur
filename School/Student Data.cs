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
    public partial class Student_Data : Form
    {
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        SqlDataAdapter da;
        DataSet ds;
        public Student_Data()
        {
            InitializeComponent();
        }

        private void Student_Data_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                ds = new DataSet();
                da = new SqlDataAdapter("SELECT std_id AS ID, branch_code AS [Branch Code], std_web_portal_id AS [Web Portal ID], account_no AS [Account Number], bank_name AS [Bank Name],std_name AS Name, father_name AS [Father Name], phone AS [Phone Number], std_address AS Address, std_class AS Class, std_section AS Section FROM stdBasic", con);
                da.Fill(ds, "stdBasic");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Student_Data_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.stdData = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);
                da.Update(ds, "stdBasic");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }
    }
}
