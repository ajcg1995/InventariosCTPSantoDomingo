namespace UI
{
    partial class AgregarPrestadorServicio
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
            this.fechaVisita = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreTecnico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.btnCancelarPrestadorServicio = new System.Windows.Forms.Button();
            this.btnAceptarPrestadorServicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedulaTecnico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fechaVisita
            // 
            this.fechaVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVisita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVisita.Location = new System.Drawing.Point(213, 353);
            this.fechaVisita.Margin = new System.Windows.Forms.Padding(2);
            this.fechaVisita.Name = "fechaVisita";
            this.fechaVisita.Size = new System.Drawing.Size(288, 26);
            this.fechaVisita.TabIndex = 53;
            this.fechaVisita.Value = new System.DateTime(2019, 10, 12, 21, 18, 25, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Fecha de Visita";
            // 
            // txtNombreTecnico
            // 
            this.txtNombreTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTecnico.Location = new System.Drawing.Point(213, 183);
            this.txtNombreTecnico.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreTecnico.Name = "txtNombreTecnico";
            this.txtNombreTecnico.Size = new System.Drawing.Size(288, 26);
            this.txtNombreTecnico.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre del Técnico";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(213, 102);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(288, 26);
            this.txtNombreEmpresa.TabIndex = 47;
            // 
            // btnCancelarPrestadorServicio
            // 
            this.btnCancelarPrestadorServicio.BackColor = System.Drawing.Color.Red;
            this.btnCancelarPrestadorServicio.FlatAppearance.BorderSize = 0;
            this.btnCancelarPrestadorServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPrestadorServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPrestadorServicio.Location = new System.Drawing.Point(11, 545);
            this.btnCancelarPrestadorServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarPrestadorServicio.Name = "btnCancelarPrestadorServicio";
            this.btnCancelarPrestadorServicio.Size = new System.Drawing.Size(510, 34);
            this.btnCancelarPrestadorServicio.TabIndex = 46;
            this.btnCancelarPrestadorServicio.TabStop = false;
            this.btnCancelarPrestadorServicio.Text = "Cancelar";
            this.btnCancelarPrestadorServicio.UseVisualStyleBackColor = false;
            this.btnCancelarPrestadorServicio.Click += new System.EventHandler(this.btnCancelarPrestadorServicio_Click);
            // 
            // btnAceptarPrestadorServicio
            // 
            this.btnAceptarPrestadorServicio.BackColor = System.Drawing.Color.Gray;
            this.btnAceptarPrestadorServicio.FlatAppearance.BorderSize = 0;
            this.btnAceptarPrestadorServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.btnAceptarPrestadorServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(222)))));
            this.btnAceptarPrestadorServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPrestadorServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarPrestadorServicio.Location = new System.Drawing.Point(11, 484);
            this.btnAceptarPrestadorServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarPrestadorServicio.Name = "btnAceptarPrestadorServicio";
            this.btnAceptarPrestadorServicio.Size = new System.Drawing.Size(510, 33);
            this.btnAceptarPrestadorServicio.TabIndex = 45;
            this.btnAceptarPrestadorServicio.Text = "Aceptar";
            this.btnAceptarPrestadorServicio.UseVisualStyleBackColor = false;
            this.btnAceptarPrestadorServicio.Click += new System.EventHandler(this.btnAceptarPrestadorServicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre de la Empresa";
            // 
            // txtCedulaTecnico
            // 
            this.txtCedulaTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaTecnico.Location = new System.Drawing.Point(213, 266);
            this.txtCedulaTecnico.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedulaTecnico.Name = "txtCedulaTecnico";
            this.txtCedulaTecnico.Size = new System.Drawing.Size(288, 26);
            this.txtCedulaTecnico.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Cédula del Técnico";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 28);
            this.label3.TabIndex = 56;
            this.label3.Text = "Módulo de Provedores";
            // 
            // AgregarPrestadorServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(532, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedulaTecnico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaVisita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreTecnico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.btnCancelarPrestadorServicio);
            this.Controls.Add(this.btnAceptarPrestadorServicio);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 200);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarPrestadorServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Agregar Prestador de Servicio";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgregarPrestadorServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaVisita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Button btnCancelarPrestadorServicio;
        private System.Windows.Forms.Button btnAceptarPrestadorServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedulaTecnico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}