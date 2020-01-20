namespace UI
{
    partial class AgregarAula
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreAula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoAula = new System.Windows.Forms.ComboBox();
            this.btnAceptarAula = new System.Windows.Forms.Button();
            this.btnCancelarAula = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Aula :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreAula
            // 
            this.txtNombreAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAula.Location = new System.Drawing.Point(140, 88);
            this.txtNombreAula.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreAula.Name = "txtNombreAula";
            this.txtNombreAula.Size = new System.Drawing.Size(191, 26);
            this.txtNombreAula.TabIndex = 1;
            this.txtNombreAula.TextChanged += new System.EventHandler(this.txtNombreAula_TextChanged);
            this.txtNombreAula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbTipoAula
            // 
            this.cmbTipoAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAula.FormattingEnabled = true;
            this.cmbTipoAula.Location = new System.Drawing.Point(140, 159);
            this.cmbTipoAula.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoAula.Name = "cmbTipoAula";
            this.cmbTipoAula.Size = new System.Drawing.Size(191, 28);
            this.cmbTipoAula.TabIndex = 3;
            this.cmbTipoAula.SelectedIndexChanged += new System.EventHandler(this.cmbTipoAula_SelectedIndexChanged);
            // 
            // btnAceptarAula
            // 
            this.btnAceptarAula.BackColor = System.Drawing.Color.Gray;
            this.btnAceptarAula.FlatAppearance.BorderSize = 0;
            this.btnAceptarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarAula.Location = new System.Drawing.Point(11, 247);
            this.btnAceptarAula.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarAula.Name = "btnAceptarAula";
            this.btnAceptarAula.Size = new System.Drawing.Size(320, 29);
            this.btnAceptarAula.TabIndex = 4;
            this.btnAceptarAula.Text = "Aceptar";
            this.btnAceptarAula.UseVisualStyleBackColor = false;
            this.btnAceptarAula.Click += new System.EventHandler(this.btnAceptarAula_Click);
            // 
            // btnCancelarAula
            // 
            this.btnCancelarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarAula.FlatAppearance.BorderSize = 0;
            this.btnCancelarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAula.Location = new System.Drawing.Point(11, 305);
            this.btnCancelarAula.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarAula.Name = "btnCancelarAula";
            this.btnCancelarAula.Size = new System.Drawing.Size(320, 34);
            this.btnCancelarAula.TabIndex = 5;
            this.btnCancelarAula.Text = "Cancelar";
            this.btnCancelarAula.UseVisualStyleBackColor = false;
            this.btnCancelarAula.Click += new System.EventHandler(this.btnCancelarAula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(87, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datos del Aula";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgregarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(342, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelarAula);
            this.Controls.Add(this.btnAceptarAula);
            this.Controls.Add(this.cmbTipoAula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreAula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1300, 200);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Aula";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgregarAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreAula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoAula;
        private System.Windows.Forms.Button btnAceptarAula;
        private System.Windows.Forms.Button btnCancelarAula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}