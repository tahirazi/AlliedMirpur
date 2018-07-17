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
    public partial class Practice : Form
    {
        public Practice()
        {
            InitializeComponent();
        }

        private void Practice_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
           
        }

        private void btnMakeChallan_Click(object sender, EventArgs e)
        {
            ds_all_challan.EnforceConstraints = false;
            this.FeeDetailsTableAdapter.FillBy(this.ds_all_challan.FeeDetails, txtIssueDate.Text, txtStdClass.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
