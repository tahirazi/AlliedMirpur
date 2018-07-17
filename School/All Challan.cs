using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace School
{
    public partial class All_Challan : Form
    {
        
        public All_Challan()
        {
            InitializeComponent();
        }

        private void All_Challan_Load(object sender, EventArgs e)
        {
            //this.FeeDetailsTableAdapter.Fill(this.ds_all_challan.FeeDetails);
            //this.reportViewer1.RefreshReport();
            
        }

        private void All_Challan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.all_challan = 0;
        }

        private void btnMakeChallan_Click(object sender, EventArgs e)
        {
            ReportParameter parameters = new ReportParameter("Month",txtMonth.Text);
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.FeeDetailsTableAdapter.FillBy(this.ds_all_challan.FeeDetails, txtIssueDate.Text,txtStdClass.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
