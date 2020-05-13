namespace EstadoCuentaByID
{
    partial class frmEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstado));
            this.DS_VALORES = new EstadoCuentaByID.DS_VALORES();
            this.PA_ESTADOCUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_ESTADOCUENTATableAdapter = new EstadoCuentaByID.DS_VALORESTableAdapters.PA_ESTADOCUENTATableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ESTADOCUENTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_VALORES
            // 
            this.DS_VALORES.DataSetName = "DS_VALORES";
            this.DS_VALORES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ESTADOCUENTABindingSource
            // 
            this.PA_ESTADOCUENTABindingSource.DataMember = "PA_ESTADOCUENTA";
            this.PA_ESTADOCUENTABindingSource.DataSource = this.DS_VALORES;
            // 
            // PA_ESTADOCUENTATableAdapter
            // 
            this.PA_ESTADOCUENTATableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DS_VALORES";
            reportDataSource2.Value = this.PA_ESTADOCUENTABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EstadoCuentaByID.Reportes.EstadoCuentabyID.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstado";
            this.Text = "RESUMEN DE ESTADO DE CUENTA";
            this.Load += new System.EventHandler(this.FrmEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_VALORES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ESTADOCUENTABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PA_ESTADOCUENTABindingSource;
        private DS_VALORES DS_VALORES;
        private DS_VALORESTableAdapters.PA_ESTADOCUENTATableAdapter PA_ESTADOCUENTATableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}