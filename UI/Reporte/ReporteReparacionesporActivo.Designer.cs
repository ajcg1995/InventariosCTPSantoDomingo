namespace UI.Reporte
{
    partial class ReporteReparacionesporActivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteReparacionesporActivo));
            this.SPReporteReparacionesporActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new UI.Reporte.DataSetPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SPReporteReparacionesporActivoTableAdapter = new UI.Reporte.DataSetPrincipalTableAdapters.SPReporteReparacionesporActivoTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.númeroDeActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtActivo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SPReporteReparacionesporActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPReporteReparacionesporActivoBindingSource
            // 
            this.SPReporteReparacionesporActivoBindingSource.DataMember = "SPReporteReparacionesporActivo";
            this.SPReporteReparacionesporActivoBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SPReporteReparacionesporActivoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Reporte.ReporteReparacionesporActivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1581, 784);
            this.reportViewer1.TabIndex = 0;
            // 
            // SPReporteReparacionesporActivoTableAdapter
            // 
            this.SPReporteReparacionesporActivoTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.númeroDeActivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1581, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // númeroDeActivoToolStripMenuItem
            // 
            this.númeroDeActivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtActivo,
            this.toolStripSeparator1});
            this.númeroDeActivoToolStripMenuItem.Name = "númeroDeActivoToolStripMenuItem";
            this.númeroDeActivoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.númeroDeActivoToolStripMenuItem.Text = "Número de Activo";
            this.númeroDeActivoToolStripMenuItem.Click += new System.EventHandler(this.númeroDeActivoToolStripMenuItem_Click);
            // 
            // tstxtActivo
            // 
            this.tstxtActivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtActivo.Name = "tstxtActivo";
            this.tstxtActivo.Size = new System.Drawing.Size(100, 23);
            this.tstxtActivo.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarReporte.Image")));
            this.btnGenerarReporte.Location = new System.Drawing.Point(372, 0);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(196, 26);
            this.btnGenerarReporte.TabIndex = 8;
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReporteReparacionesporActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 808);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReporteReparacionesporActivo";
            this.Text = "Reporte de Reparaciones por Activo";
            this.Load += new System.EventHandler(this.ReporteReparacionesporActivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SPReporteReparacionesporActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SPReporteReparacionesporActivoBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.SPReporteReparacionesporActivoTableAdapter SPReporteReparacionesporActivoTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem númeroDeActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tstxtActivo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}