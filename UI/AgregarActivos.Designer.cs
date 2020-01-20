namespace UI
{
    partial class AgregarActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarActivos));
            this.fechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdentificacionActivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelarActivos = new System.Windows.Forms.Button();
            this.btnAceptarActivos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbLeyAdquirida = new System.Windows.Forms.ComboBox();
            this.cmbCategoría = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCreacion.Location = new System.Drawing.Point(196, 191);
            this.fechaCreacion.Margin = new System.Windows.Forms.Padding(2);
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.Size = new System.Drawing.Size(235, 20);
            this.fechaCreacion.TabIndex = 91;
            this.fechaCreacion.Value = new System.DateTime(2019, 10, 14, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 90;
            this.label7.Text = "Fecha de Creación";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(196, 122);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(235, 20);
            this.txtUbicacion.TabIndex = 89;
            this.txtUbicacion.TextChanged += new System.EventHandler(this.txtUbicacion_TextChanged);
            this.txtUbicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUbicacion_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 88;
            this.label8.Text = "Ubicación";
            // 
            // txtIdentificacionActivo
            // 
            this.txtIdentificacionActivo.Location = new System.Drawing.Point(196, 21);
            this.txtIdentificacionActivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacionActivo.Name = "txtIdentificacionActivo";
            this.txtIdentificacionActivo.Size = new System.Drawing.Size(235, 20);
            this.txtIdentificacionActivo.TabIndex = 87;
            this.txtIdentificacionActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionActivo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Identificacion de Activo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "Marca";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(196, 53);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(235, 20);
            this.txtDescripcion.TabIndex = 79;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // btnCancelarActivos
            // 
            this.btnCancelarActivos.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarActivos.FlatAppearance.BorderSize = 0;
            this.btnCancelarActivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarActivos.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarActivos.Image")));
            this.btnCancelarActivos.Location = new System.Drawing.Point(248, 392);
            this.btnCancelarActivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarActivos.Name = "btnCancelarActivos";
            this.btnCancelarActivos.Size = new System.Drawing.Size(171, 45);
            this.btnCancelarActivos.TabIndex = 78;
            this.btnCancelarActivos.UseVisualStyleBackColor = false;
            this.btnCancelarActivos.Click += new System.EventHandler(this.btnCancelarActivos_Click);
            // 
            // btnAceptarActivos
            // 
            this.btnAceptarActivos.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarActivos.FlatAppearance.BorderSize = 0;
            this.btnAceptarActivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptarActivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptarActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarActivos.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarActivos.Image")));
            this.btnAceptarActivos.Location = new System.Drawing.Point(50, 399);
            this.btnAceptarActivos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarActivos.Name = "btnAceptarActivos";
            this.btnAceptarActivos.Size = new System.Drawing.Size(96, 33);
            this.btnAceptarActivos.TabIndex = 77;
            this.btnAceptarActivos.UseVisualStyleBackColor = false;
            this.btnAceptarActivos.Click += new System.EventHandler(this.btnAceptarActivos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Descripción";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(196, 87);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(235, 20);
            this.txtMarca.TabIndex = 99;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(196, 157);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(235, 20);
            this.txtProveedor.TabIndex = 103;
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedor_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 102;
            this.label12.Text = "Proveedor";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(196, 299);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(235, 21);
            this.cmbEstado.TabIndex = 120;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(27, 304);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 16);
            this.label18.TabIndex = 119;
            this.label18.Text = "Estado";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(27, 231);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 123;
            this.label19.Text = "Ley Adquirida";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(27, 264);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 16);
            this.label20.TabIndex = 125;
            this.label20.Text = "Categoría";
            // 
            // cmbLeyAdquirida
            // 
            this.cmbLeyAdquirida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeyAdquirida.FormattingEnabled = true;
            this.cmbLeyAdquirida.Location = new System.Drawing.Point(196, 226);
            this.cmbLeyAdquirida.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLeyAdquirida.Name = "cmbLeyAdquirida";
            this.cmbLeyAdquirida.Size = new System.Drawing.Size(235, 21);
            this.cmbLeyAdquirida.TabIndex = 127;
            this.cmbLeyAdquirida.SelectedIndexChanged += new System.EventHandler(this.cmbLeyAdquirida_SelectedIndexChanged);
            // 
            // cmbCategoría
            // 
            this.cmbCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoría.FormattingEnabled = true;
            this.cmbCategoría.Location = new System.Drawing.Point(196, 263);
            this.cmbCategoría.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoría.Name = "cmbCategoría";
            this.cmbCategoría.Size = new System.Drawing.Size(235, 21);
            this.cmbCategoría.TabIndex = 128;
            this.cmbCategoría.SelectedIndexChanged += new System.EventHandler(this.cmbCategoría_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(41, 393);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 44);
            this.btnModificar.TabIndex = 134;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgregarActivos
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(482, 504);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbCategoría);
            this.Controls.Add(this.cmbLeyAdquirida);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.fechaCreacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdentificacionActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnCancelarActivos);
            this.Controls.Add(this.btnAceptarActivos);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1200, 450);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Activos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgregarActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fechaCreacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdentificacionActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancelarActivos;
        private System.Windows.Forms.Button btnAceptarActivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbLeyAdquirida;
        private System.Windows.Forms.ComboBox cmbCategoría;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}