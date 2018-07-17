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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        #region Navigation
        private void btnAddStd_Click(object sender, EventArgs e)
        {
            Global.add_std++;
            if(Global.add_std==1)
            {
            Add_Student addstd = new Add_Student();
            addstd.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditStd_Click(object sender, EventArgs e)
        {
            Global.Edit_std++;
            if(Global.Edit_std==1)
            {
            Edit_Student es = new Edit_Student();
            es.Show();
            }
        }

        private void btnDeleteStd_Click(object sender, EventArgs e)
        {
            Global.delete_std++;
            if (Global.delete_std==1)
            {
                Delete_Student ds = new Delete_Student();
                ds.Show();
            }
        }

        private void btnFeeChallan_Click(object sender, EventArgs e)
        {
            Global.Fee_Challan++;
            if (Global.Fee_Challan==1)
            {
                Fee_Challan fc = new Fee_Challan();
                fc.Show();
            }
        }

        private void btnStdSearch_Click(object sender, EventArgs e)
        {
            Global.std_search++;
            if (Global.std_search==1)
            {
                Student_Search ssr = new Student_Search();
                ssr.Show();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Global.Fee_Report++;
            if (Global.Fee_Report==1)
            {
                Fee_Print fp = new Fee_Print();
                fp.Show();
            }
        }

        private void lblBackup_Click(object sender, EventArgs e)
        {
            Global.bachup++;
            if (Global.bachup==1)
            {
                Backup bu = new Backup();
                bu.Show();
            }
        }

        private void btnEditFeeChallan_Click(object sender, EventArgs e)
        {
            Global.Edit_Challan++;
            if (Global.Edit_Challan==1)
            {
                Edit_Challan ec = new Edit_Challan();
                ec.Show();
            }
        }

        private void btnDeleteFeeChallan_Click(object sender, EventArgs e)
        {
            Global.delete_challan++;
            if (Global.delete_challan==1)
            {
                Delete_Challan dc = new Delete_Challan();
                dc.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.sums++;
            if (Global.sums==1)
            {
                Sums sms = new Sums();
                sms.Show();
            }
        }

        private void btnAllFeeReport_Click(object sender, EventArgs e)
        {
            Global.all_fee_report++;
            if (Global.all_fee_report==1)
            {
                All_Fee_Report afrpt = new All_Fee_Report();
                afrpt.Show();
            }
        }

        private void btnAllChallanPrint_Click(object sender, EventArgs e)
        {
            Global.all_challan++;
            if(Global.all_challan==1)
            {
                ACP frm = new ACP();
                frm.Show();
            }
        }

        private void btnStudentData_Click(object sender, EventArgs e)
        {
            Global.stdData++;
            if(Global.stdData==1)
            {
            Student_Data stdData = new Student_Data();
            stdData.Show();
            }
        }

        private void btnChallanData_Click(object sender, EventArgs e)
        {
            Global.challan_data++;
            if (Global.challan_data == 1)
            {
                Challan_Data chdata = new Challan_Data();
                chdata.Show();
            }
        }
        #endregion

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            Global.update_status++;
            if (Global.update_status == 1)
            {
                Update_Status_2 upStatus = new Update_Status_2();
                upStatus.Show();
            }
        }

        private void btnBulkInsert_Click(object sender, EventArgs e)
        {
            Global.bulk_challan_insertion++;
            if (Global.bulk_challan_insertion == 1)
            {
                Bulk_Challan_Insertion frm = new Bulk_Challan_Insertion();
                frm.Show();
            }
        }
    }
}
