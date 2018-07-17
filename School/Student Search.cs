using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School
{
    public partial class Student_Search : Form
    {
        public Student_Search()
        {
            InitializeComponent();
        }

        private void Student_Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.stdBasic' table. You can move, or remove it, as needed.
            this.stdBasicTableAdapter.Fill(this.DataSet1.stdBasic);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Name")
            {
                try
                {
                    this.stdBasicTableAdapter.FillBy2(this.DataSet1.stdBasic, txtSearch.Text);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Please provide valid Data",ee.ToString());
                }
            }
            if (comboBox1.SelectedItem == "Class")
            {
                try
                {
                    this.stdBasicTableAdapter.FillBy1(this.DataSet1.stdBasic, txtSearch.Text);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Please provide valid Data",ee.ToString());
                    
                }
            }
            if (comboBox1.SelectedItem == "Student ID")
            {
                try
                {
                    this.stdBasicTableAdapter.FillBy(this.DataSet1.stdBasic, Convert.ToInt32(txtSearch.Text));
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Please provide valid Data", ee.ToString());
                }
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Student_Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.std_search = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.stdBasicTableAdapter.FillBy3(this.DataSet1.stdBasic, txtSearch.Text+'%');
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Please provide valid Data", ee.ToString());
            }
        }
    }
}
