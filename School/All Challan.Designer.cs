namespace School
{
    partial class All_Challan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.btnMakeChallan = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStdClass = new System.Windows.Forms.TextBox();
            this.FeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_all_challan = new School.ds_all_challan();
            this.FeeDetailsTableAdapter = new School.ds_all_challanTableAdapters.FeeDetailsTableAdapter();
            this.cmbIDs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_all_challan)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsFeeChallan";
            reportDataSource1.Value = this.FeeDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "School.rpt_fee_challan_all.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(900, 613);
            this.reportViewer1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select An Issue Date to Print all the challan of that Issue Date";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Location = new System.Drawing.Point(316, 9);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(100, 20);
            this.txtIssueDate.TabIndex = 0;
            // 
            // btnMakeChallan
            // 
            this.btnMakeChallan.Location = new System.Drawing.Point(786, 9);
            this.btnMakeChallan.Name = "btnMakeChallan";
            this.btnMakeChallan.Size = new System.Drawing.Size(94, 23);
            this.btnMakeChallan.TabIndex = 3;
            this.btnMakeChallan.Text = "Make Challan";
            this.btnMakeChallan.UseVisualStyleBackColor = true;
            this.btnMakeChallan.Click += new System.EventHandler(this.btnMakeChallan_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(492, 9);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Class";
            // 
            // txtStdClass
            // 
            this.txtStdClass.Location = new System.Drawing.Point(664, 11);
            this.txtStdClass.Name = "txtStdClass";
            this.txtStdClass.Size = new System.Drawing.Size(100, 20);
            this.txtStdClass.TabIndex = 2;
            // 
            // FeeDetailsBindingSource
            // 
            this.FeeDetailsBindingSource.DataMember = "FeeDetails";
            this.FeeDetailsBindingSource.DataSource = this.ds_all_challan;
            // 
            // ds_all_challan
            // 
            this.ds_all_challan.DataSetName = "ds_all_challan";
            this.ds_all_challan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FeeDetailsTableAdapter
            // 
            this.FeeDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // cmbIDs
            // 
            this.cmbIDs.FormattingEnabled = true;
            this.cmbIDs.Location = new System.Drawing.Point(15, 9);
            this.cmbIDs.Name = "cmbIDs";
            this.cmbIDs.Size = new System.Drawing.Size(121, 21);
            this.cmbIDs.TabIndex = 8;
            this.cmbIDs.Visible = false;
            // 
            // All_Challan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 651);
            this.Controls.Add(this.cmbIDs);
            this.Controls.Add(this.txtStdClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.btnMakeChallan);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "All_Challan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allied School || All Challan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.All_Challan_FormClosed);
            this.Load += new System.EventHandler(this.All_Challan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_all_challan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FeeDetailsBindingSource;
        private ds_all_challan ds_all_challan;
        private ds_all_challanTableAdapters.FeeDetailsTableAdapter FeeDetailsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.Button btnMakeChallan;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStdClass;
        private System.Windows.Forms.ComboBox cmbIDs;
    }
}