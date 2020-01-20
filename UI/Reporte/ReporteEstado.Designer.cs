namespace UI.Reporte
{
    partial class ReporteEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEstado));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SPReportesActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new UI.Reporte.DataSetPrincipal();
            this.SPReporteEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.SPReportesActivosTableAdapter = new UI.Reporte.DataSetPrincipalTableAdapters.SPReportesActivosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SPReporteEstadoTableAdapter = new UI.Reporte.DataSetPrincipalTableAdapters.SPReporteEstadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SPReportesActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPReporteEstadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SPReportesActivosBindingSource
            // 
            this.SPReportesActivosBindingSource.DataMember = "SPReportesActivos";
            this.SPReportesActivosBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SPReporteEstadoBindingSource
            // 
            this.SPReporteEstadoBindingSource.DataMember = "SPReporteEstado";
            this.SPReporteEstadoBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado del Activo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(812, 11);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(119, 21);
            this.cmbEstado.TabIndex = 1;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarReporte.Image")));
            this.btnGenerarReporte.Location = new System.Drawing.Point(950, 0);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(196, 39);
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // SPReportesActivosTableAdapter
            // 
            this.SPReportesActivosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SPReportesActivosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SPReporteEstadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Reporte.ReportedeEstado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1293, 487);
            this.reportViewer1.TabIndex = 7;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_2);
            // 
            // SPReporteEstadoTableAdapter
            // 
            this.SPReporteEstadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 487);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReporteEstado";
            this.Text = "Reporte de Estado";
            this.Load += new System.EventHandler(this.ReporteEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SPReportesActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPReporteEstadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.BindingSource SPReportesActivosBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.SPReportesActivosTableAdapter SPReportesActivosTableAdapter;
        private System.Windows.Forms.Button btnGenerarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SPReporteEstadoBindingSource;
        private DataSetPrincipalTableAdapters.SPReporteEstadoTableAdapter SPReporteEstadoTableAdapter;
    }
}