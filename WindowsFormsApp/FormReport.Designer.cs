
namespace WindowsFormsApp
{
    partial class FormReport
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
            this.uSPGetHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_GetHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPGetHoaDonBindingSource
            // 
            this.uSPGetHoaDonBindingSource.DataMember = "USP_GetHoaDon";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Report_HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(897, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyCuaHangThoiTrangDataSet
            // 
      
            // 
            // USP_GetHoaDonBindingSource
            // 
            this.USP_GetHoaDonBindingSource.DataMember = "USP_GetHoaDon";
    
            // 
            // USP_GetHoaDonTableAdapter
            // 

            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 495);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Report";
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPGetHoaDonBindingSource;
        private System.Windows.Forms.BindingSource USP_GetHoaDonBindingSource;
    }
}