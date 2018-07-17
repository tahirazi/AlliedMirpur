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
    public partial class Sums : Form
    {
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        public Sums()
        {
            InitializeComponent();
        }

        private void Sums_Load(object sender, EventArgs e)
        {
            lblSum.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(before_due_date) AS AutoSum FROM finance",con);
            da.Fill(dt);
            lblSum.Text=dt.Rows[0][0].ToString();
            lblSum.Visible = true;
            con.Close();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sums_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.sums = 0;
        }
    }
}
