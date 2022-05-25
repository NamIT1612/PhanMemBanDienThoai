
namespace DoAn_PTPM_UDTM
{
    partial class frmInHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QL_BanDienThoaiDataSet = new DoAn_PTPM_UDTM.QL_BanDienThoaiDataSet();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOADONTableAdapter = new DoAn_PTPM_UDTM.QL_BanDienThoaiDataSetTableAdapters.HOADONTableAdapter();
            this.SANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SANPHAMTableAdapter = new DoAn_PTPM_UDTM.QL_BanDienThoaiDataSetTableAdapters.SANPHAMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QL_BanDienThoaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SANPHAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOADONBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SANPHAMBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_PTPM_UDTM.rpHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(810, 599);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // QL_BanDienThoaiDataSet
            // 
            this.QL_BanDienThoaiDataSet.DataSetName = "QL_BanDienThoaiDataSet";
            this.QL_BanDienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.QL_BanDienThoaiDataSet;
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // SANPHAMBindingSource
            // 
            this.SANPHAMBindingSource.DataMember = "SANPHAM";
            this.SANPHAMBindingSource.DataSource = this.QL_BanDienThoaiDataSet;
            // 
            // SANPHAMTableAdapter
            // 
            this.SANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 599);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInHoaDon";
            this.Text = "IN HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QL_BanDienThoaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SANPHAMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private QL_BanDienThoaiDataSet QL_BanDienThoaiDataSet;
        private System.Windows.Forms.BindingSource SANPHAMBindingSource;
        private QL_BanDienThoaiDataSetTableAdapters.HOADONTableAdapter HOADONTableAdapter;
        private QL_BanDienThoaiDataSetTableAdapters.SANPHAMTableAdapter SANPHAMTableAdapter;
    }
}