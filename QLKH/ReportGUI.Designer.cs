namespace QLKhoHang
{
    partial class ReportGUI
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlkhDataSet12 = new QLKhoHang.qlkhDataSet12();
            this.qlkhDataSet12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HangHoaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaViewTableAdapter = new QLKhoHang.qlkhDataSet12TableAdapters.HangHoaViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qlkhDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlkhDataSet12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.hangHoaViewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKhoHang.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(783, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // qlkhDataSet12
            // 
            this.qlkhDataSet12.DataSetName = "qlkhDataSet12";
            this.qlkhDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlkhDataSet12BindingSource
            // 
            this.qlkhDataSet12BindingSource.DataSource = this.qlkhDataSet12;
            this.qlkhDataSet12BindingSource.Position = 0;
            // 
            // HangHoaViewBindingSource
            // 
            this.HangHoaViewBindingSource.DataMember = "HangHoaView";
            this.HangHoaViewBindingSource.DataSource = this.qlkhDataSet12;
            // 
            // hangHoaViewBindingSource1
            // 
            this.hangHoaViewBindingSource1.DataMember = "HangHoaView";
            this.hangHoaViewBindingSource1.DataSource = this.qlkhDataSet12;
            // 
            // hangHoaViewTableAdapter
            // 
            this.hangHoaViewTableAdapter.ClearBeforeFill = true;
            // 
            // ReportGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportGUI";
            this.Text = "ReportGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportGUI__FormClosing);
            this.Load += new System.EventHandler(this.ReportGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlkhDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlkhDataSet12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qlkhDataSet12BindingSource;
        private qlkhDataSet12 qlkhDataSet12;
        private System.Windows.Forms.BindingSource HangHoaViewBindingSource;
        private System.Windows.Forms.BindingSource hangHoaViewBindingSource1;
        private qlkhDataSet12TableAdapters.HangHoaViewTableAdapter hangHoaViewTableAdapter;
    }
}