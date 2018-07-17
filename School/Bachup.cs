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
    public partial class Backup : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader reader;
        string sql = "";
        string ConnectionString="";
        public Backup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            btnBackUp.Enabled = false;
            btnRestore.Enabled = false;
            cmbDatabase.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionString = "Data Source="+txtDataSource.Text+"; User Id="+txtUserId.Text+"; Password="+txtPassword.Text+"";
                con = new SqlConnection(ConnectionString);
                con.Open();
                //sql = "EXEC sp_databases";
                sql = "SELECT * FROM sys.databases d WHERE d.database_id>4";
                cmd = new SqlCommand(sql,con);
                reader = cmd.ExecuteReader();
                cmbDatabase.Items.Clear();
                while(reader.Read())
                {
                    cmbDatabase.Items.Add(reader[0].ToString());
                }
                reader.Dispose();
                con.Close();
                con.Dispose();
                txtDataSource.Enabled = false;
                txtUserId.Enabled = false;
                txtPassword.Enabled = false;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnBackUp.Enabled = true;
                btnRestore.Enabled = true;
                cmbDatabase.Enabled = true;
                btnDisconnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            txtDataSource.Enabled = true;
            txtUserId.Enabled = true;
            txtPassword.Enabled = true;
            cmbDatabase.Enabled = false;
            btnBackUp.Enabled = false;
            btnRestore.Enabled = false;
            btnConnect.Enabled = true;

        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbDatabase.Text.CompareTo("")==0)
                {
                    MessageBox.Show("Please Select a Database.");
                    return;
                }
                con = new SqlConnection(ConnectionString);
                con.Open();
                sql = "BACKUP DATABASE "+cmbDatabase.Text+" TO DISK='"+txtLocation.Text+"\\"+cmbDatabase.Text+"-"+DateTime.Now.Ticks.ToString()+".bak'";
                cmd = new SqlCommand(sql,con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                MessageBox.Show("Database Backup created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                con.Dispose();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                txtLocation.Text = dlg.SelectedPath;
            }
        }

        private void btnDBFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files (*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                txtDBBackupPath.Text = dlg.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbDatabase.Text.CompareTo("")==0)
                {
                    MessageBox.Show("Please select a database.");
                    return;
                }
                con = new SqlConnection(ConnectionString);
                con.Open();
                sql = "ALTER DATABASE "+cmbDatabase.Text+" SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "RESTORE DATABASE "+cmbDatabase.Text+" FROM DISK ='"+txtDBBackupPath.Text+"' WITH REPLACE;";
                cmd = new SqlCommand(sql,con);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                MessageBox.Show("Database successfully restore.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                con.Dispose();
            }
        }

        private void Backup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.bachup = 0;
        }
    }
}
