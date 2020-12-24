namespace HopitalApp.Vistas
{
    partial class ImprimirFactura
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
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ImprimirFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImprimirFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewer
            // 
            this.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DetalleFactura";
            reportDataSource1.Value = this.ImprimirFacturaBindingSource;
            reportDataSource2.Name = "Factura";
            reportDataSource2.Value = this.FacturaEntityBindingSource;
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "HopitalApp.Vistas.ReportFactura.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ReportViewer.TabIndex = 0;
            // 
            // ImprimirFacturaBindingSource
            // 
            this.ImprimirFacturaBindingSource.DataMember = "DetalleFactura";
            this.ImprimirFacturaBindingSource.DataSource = typeof(HopitalApp.Negocio.ImprimirFacturas);
            // 
            // FacturaEntityBindingSource
            // 
            this.FacturaEntityBindingSource.DataSource = typeof(HopitalApp.FacturaEntity);
            // 
            // ImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportViewer);
            this.Name = "ImprimirFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImprimirFactura";
            this.Load += new System.EventHandler(this.ImprimirFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImprimirFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private System.Windows.Forms.BindingSource ImprimirFacturaBindingSource;
        private System.Windows.Forms.BindingSource FacturaEntityBindingSource;
    }
}