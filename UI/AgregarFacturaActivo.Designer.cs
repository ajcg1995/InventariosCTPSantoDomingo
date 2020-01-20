namespace UI
{
    partial class AgregarFacturaActivo
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
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.btnCancelarFacturaActivo = new System.Windows.Forms.Button();
            this.btnAceptarFacturaActivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Identificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPoliza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaFactura = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(163, 48);
            this.txtNumeroFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(152, 20);
            this.txtNumeroFactura.TabIndex = 19;
            // 
            // btnCancelarFacturaActivo
            // 
            this.btnCancelarFacturaActivo.BackColor = System.Drawing.Color.Red;
            this.btnCancelarFacturaActivo.FlatAppearance.BorderSize = 0;
            this.btnCancelarFacturaActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFacturaActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFacturaActivo.Location = new System.Drawing.Point(11, 261);
            this.btnCancelarFacturaActivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarFacturaActivo.Name = "btnCancelarFacturaActivo";
            this.btnCancelarFacturaActivo.Size = new System.Drawing.Size(354, 22);
            this.btnCancelarFacturaActivo.TabIndex = 17;
            this.btnCancelarFacturaActivo.Text = "Cancelar";
            this.btnCancelarFacturaActivo.UseVisualStyleBackColor = false;
            this.btnCancelarFacturaActivo.Click += new System.EventHandler(this.btnCancelarFacturaActivo_Click);
            // 
            // btnAceptarFacturaActivo
            // 
            this.btnAceptarFacturaActivo.BackColor = System.Drawing.Color.SlateGray;
            this.btnAceptarFacturaActivo.FlatAppearance.BorderSize = 0;
            this.btnAceptarFacturaActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarFacturaActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarFacturaActivo.Location = new System.Drawing.Point(11, 217);
            this.btnAceptarFacturaActivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarFacturaActivo.Name = "btnAceptarFacturaActivo";
            this.btnAceptarFacturaActivo.Size = new System.Drawing.Size(354, 23);
            this.btnAceptarFacturaActivo.TabIndex = 16;
            this.btnAceptarFacturaActivo.Text = "Aceptar";
            this.btnAceptarFacturaActivo.UseVisualStyleBackColor = false;
            this.btnAceptarFacturaActivo.Click += new System.EventHandler(this.btnAceptarFacturaActivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Número de Factura";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identificacion.Location = new System.Drawing.Point(17, 14);
            this.Identificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(100, 16);
            this.Identificacion.TabIndex = 14;
            this.Identificacion.Text = "Identificación";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(163, 14);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(152, 20);
            this.txtIdentificacion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Monto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Moneda";
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.Location = new System.Drawing.Point(163, 146);
            this.txtNumeroPoliza.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Size = new System.Drawing.Size(152, 20);
            this.txtNumeroPoliza.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Número Póliza";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(163, 114);
            this.cmbMoneda.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(152, 21);
            this.cmbMoneda.TabIndex = 27;
            this.cmbMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbMoneda_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fecha Factura";
            // 
            // fechaFactura
            // 
            this.fechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFactura.Location = new System.Drawing.Point(163, 182);
            this.fechaFactura.Margin = new System.Windows.Forms.Padding(2);
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Size = new System.Drawing.Size(152, 20);
            this.fechaFactura.TabIndex = 29;
            this.fechaFactura.Value = new System.DateTime(2019, 10, 12, 21, 18, 25, 0);
            // 
            // AgregarFacturaActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(376, 294);
            this.Controls.Add(this.fechaFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.txtNumeroPoliza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.btnCancelarFacturaActivo);
            this.Controls.Add(this.btnAceptarFacturaActivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Identificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarFacturaActivo";
            this.Text = "Agregar Factura de Activo";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Button btnCancelarFacturaActivo;
        private System.Windows.Forms.Button btnAceptarFacturaActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Identificacion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroPoliza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaFactura;
    }
}