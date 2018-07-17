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
    public partial class All_Fee_Report : Form
    {
        public All_Fee_Report()
        {
            InitializeComponent();
        }

        private void All_Fee_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.finance' table. You can move, or remove it, as needed.
            this.financeTableAdapter.Fill(this.DataSet1.finance);

            this.reportViewer1.RefreshReport();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if ( cmbSearch.SelectedItem == "All Data")
            {
                try
                {
                    this.financeTableAdapter.Fill(this.DataSet1.finance);

                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Please provide valid Data", ee.ToString());
                }
            }
            if (cmbSearch.SelectedItem == "Specific Date")
            {
                try
                {
                    this.financeTableAdapter.FillBy1(this.DataSet1.finance, txtDate.Text);

                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Please provide valid Data", ee.ToString());
                }
            }
            if (cmbSearch.SelectedItem == "Paid")
            {
                try
                {
                    this.financeTableAdapter.FillBy2(this.DataSet1.finance, "Y", txtDate.Text);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please provide valid Data", ex.ToString());
                }
                
            }
            if (cmbSearch.SelectedItem == "Un-Paid")
            {
                try
                {
                    this.financeTableAdapter.FillBy2(this.DataSet1.finance, "N", txtDate.Text);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please provide valid Data", ex.ToString());
                }
            }
            if (cmbSearch.SelectedItem == "Specific Class")
            {
                try
                {
                    this.financeTableAdapter.FillBy3(this.DataSet1.finance,txtClass.Text, txtDate.Text);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please provide valid Data", ex.ToString());
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void All_Fee_Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.all_fee_report = 0;
        }
    }
}
