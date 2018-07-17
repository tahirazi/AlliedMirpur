namespace School
{
    partial class Practice
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
            this.ds_all_challan = new School.ds_all_challan();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new School.ds_all_challanTableAdapters.DataTable1TableAdapter();
            this.FeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FeeDetailsTableAdapter = new School.ds_all_challanTableAdapters.FeeDetailsTableAdapter();
            this.txtStdClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnMakeChallan = new System.Windows.Forms.Button();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds_all_challan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeeDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FeeDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "School.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(887, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // ds_all_challan
            // 
            this.ds_all_challan.DataSetName = "ds_all_challan";
            this.ds_all_challan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ds_all_challan;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FeeDetailsBindingSource
            // 
            this.FeeDetailsBindingSource.DataMember = "FeeDetails";
            this.FeeDetailsBindingSource.DataSource = this.ds_all_challan;
            // 
            // FeeDetailsTableAdapter
            // 
            this.FeeDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // txtStdClass
            // 
            this.txtStdClass.Location = new System.Drawing.Point(664, 11);
            this.txtStdClass.Name = "txtStdClass";
            this.txtStdClass.Size = new System.Drawing.Size(100, 20);
            this.txtStdClass.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Month";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(492, 9);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 9;
            // 
            // btnMakeChallan
            // 
            this.btnMakeChallan.Location = new System.Drawing.Point(795, 9);
            this.btnMakeChallan.Name = "btnMakeChallan";
            this.btnMakeChallan.Size = new System.Drawing.Size(94, 23);
            this.btnMakeChallan.TabIndex = 11;
            this.btnMakeChallan.Text = "Make Challan";
            this.btnMakeChallan.UseVisualStyleBackColor = true;
            this.btnMakeChallan.Click += new System.EventHandler(this.btnMakeChallan_Click);
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Location = new System.Drawing.Point(316, 9);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(100, 20);
            this.txtIssueDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select An Issue Date to Print all the challan of that Issue Date";
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 506);
            this.Controls.Add(this.txtStdClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.btnMakeChallan);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Practice";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.Practice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_all_challan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeeDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ds_all_challan ds_all_challan;
        private ds_all_challanTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource FeeDetailsBindingSource;
        private ds_all_challanTableAdapters.FeeDetailsTableAdapter FeeDetailsTableAdapter;
        private System.Windows.Forms.TextBox txtStdClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnMakeChallan;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.Label label1;
    }
}