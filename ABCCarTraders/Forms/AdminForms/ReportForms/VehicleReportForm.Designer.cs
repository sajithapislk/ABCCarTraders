namespace ABCCarTraders.Forms.AdminForms.ReportForms
{
    partial class VehicleReportForm
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
            this.vehicleDataset = new ABCCarTraders.Datasets.VehicleDataset();
            this.VehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VehicleDataset";
            reportDataSource1.Value = this.VehicleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABCCarTraders.Reports.AdminReports.VehicleReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(772, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // vehicleDataset
            // 
            this.vehicleDataset.DataSetName = "VehicleDataset";
            this.vehicleDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VehicleBindingSource
            // 
            this.VehicleBindingSource.DataMember = "Vehicle";
            this.VehicleBindingSource.DataSource = this.vehicleDataset;
            // 
            // VehicleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 437);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VehicleReportForm";
            this.Text = "VehicleReportForm";
            this.Load += new System.EventHandler(this.VehicleReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Datasets.VehicleDataset vehicleDataset;
        private System.Windows.Forms.BindingSource VehicleBindingSource;
    }
}