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
    public partial class Add_Student : Form
    {
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        
        public Add_Student()
        {
            InitializeComponent();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Insetion
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into stdBasic values ('" + txtBranchCode.Text.Trim() + "','"+txtWebPortalID.Text.Trim()+"','"+txtAccountNo.Text.Trim()+"','"+txtBankName.Text.Trim()+"','" + txtStdName.Text.Trim() + "','"+txtFatherName.Text.Trim()+"','"+txtPhone.Text.Trim()+"','"+txtAddress.Text.Trim()+"','"+txtClass.Text.Trim()+"','"+txtSection.Text.Trim()+"')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            con.Close();
            MessageBox.Show("Record Added.");
            }
            catch (Exception ee)
            {

                MessageBox.Show("Some Fields are empty or invalid. Please fill all fields or provide valid data.",ee.ToString());
                con.Close();
            }
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "insert into stdBasic values ('" + txtBranchCode.Text.Trim() + "','" + txtStdName.Text.Trim() + "','"+txtFatherName.Text.Trim()+"','"+txtPhone.Text.Trim()+"','"+txtAddress.Text.Trim()+"','"+txtClass.Text.Trim()+"','"+txtSection.Text.Trim()+"')";
            //cmd.ExecuteNonQuery();
            //cmd.Clone();
            //con.Close();
            //MessageBox.Show("Record Added.");
        }
        #endregion

        private void Add_Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.add_std = 0;
        }
    }
}
