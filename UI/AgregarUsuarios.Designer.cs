namespace UI
{
    partial class AgregarUsuarios
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnCancelarAgregarUsuario = new System.Windows.Forms.Button();
            this.btnAceptarAgregarUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmarcontrasena = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.IdUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(196, 74);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(152, 20);
            this.txtCorreo.TabIndex = 65;
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Correo :";
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Location = new System.Drawing.Point(196, 45);
            this.txtApellidoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(152, 20);
            this.txtApellidoUsuario.TabIndex = 61;
            this.txtApellidoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Apellido de Usuario :";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(196, 14);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(152, 20);
            this.txtNombreUsuario.TabIndex = 59;
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            this.txtNombreUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreUsuario_Validating);
            // 
            // btnCancelarAgregarUsuario
            // 
            this.btnCancelarAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAgregarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCancelarAgregarUsuario.Location = new System.Drawing.Point(4, 350);
            this.btnCancelarAgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarAgregarUsuario.Name = "btnCancelarAgregarUsuario";
            this.btnCancelarAgregarUsuario.Size = new System.Drawing.Size(374, 38);
            this.btnCancelarAgregarUsuario.TabIndex = 58;
            this.btnCancelarAgregarUsuario.Text = "CANCELAR";
            this.btnCancelarAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnCancelarAgregarUsuario.Click += new System.EventHandler(this.btnCancelarAgregarUsuario_Click);
            // 
            // btnAceptarAgregarUsuario
            // 
            this.btnAceptarAgregarUsuario.BackColor = System.Drawing.Color.Gray;
            this.btnAceptarAgregarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAceptarAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAceptarAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarAgregarUsuario.Location = new System.Drawing.Point(4, 276);
            this.btnAceptarAgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarAgregarUsuario.Name = "btnAceptarAgregarUsuario";
            this.btnAceptarAgregarUsuario.Size = new System.Drawing.Size(374, 40);
            this.btnAceptarAgregarUsuario.TabIndex = 57;
            this.btnAceptarAgregarUsuario.Text = "ACEPTAR";
            this.btnAceptarAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAceptarAgregarUsuario.Click += new System.EventHandler(this.btnAceptarAgregarUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nombre de Usuario :";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(196, 104);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(152, 20);
            this.txtContraseña.TabIndex = 67;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Contraseña :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Confirmar contraseña :";
            // 
            // txtConfirmarcontrasena
            // 
            this.txtConfirmarcontrasena.Location = new System.Drawing.Point(196, 140);
            this.txtConfirmarcontrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarcontrasena.Name = "txtConfirmarcontrasena";
            this.txtConfirmarcontrasena.Size = new System.Drawing.Size(152, 20);
            this.txtConfirmarcontrasena.TabIndex = 69;
            this.txtConfirmarcontrasena.UseSystemPasswordChar = true;
            this.txtConfirmarcontrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarcontrasena_KeyPress);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(196, 173);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(152, 21);
            this.cmbRol.TabIndex = 70;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Rol :";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.Location = new System.Drawing.Point(277, 232);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(71, 23);
            this.btnModificar.TabIndex = 72;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // IdUsuario
            // 
            this.IdUsuario.Location = new System.Drawing.Point(196, 208);
            this.IdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Size = new System.Drawing.Size(152, 20);
            this.IdUsuario.TabIndex = 73;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.IdUsuario_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "IdUsuario :";
            this.label7.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AgregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(381, 422);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IdUsuario);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtConfirmarcontrasena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnCancelarAgregarUsuario);
            this.Controls.Add(this.btnAceptarAgregarUsuario);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1400, 150);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnCancelarAgregarUsuario;
        private System.Windows.Forms.Button btnAceptarAgregarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmarcontrasena;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox IdUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}