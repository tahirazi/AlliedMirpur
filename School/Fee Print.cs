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
    public partial class Fee_Print : Form
    {
        public Fee_Print()
        {
            InitializeComponent();
        }

        private void Fee_Print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.finance' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportParameter parameters = new ReportParameter("Month", txtMonth.Text);
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.financeTableAdapter.FillBy(this.DataSet1.finance, Int32.Parse(textBox1.Text),txtIssueDate.Text);
            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fee_Print_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.Fee_Report = 0;
        }
    }
}
