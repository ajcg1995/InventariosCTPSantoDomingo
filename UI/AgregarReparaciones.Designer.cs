namespace UI
{
    partial class AgregarReparaciones
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtpReparacion = new System.Windows.Forms.DateTimePicker();
            this.txtReparacion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.RichTextBox();
            this.dtpReporte = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdRep = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(31, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reparación";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpReparacion
            // 
            this.dtpReparacion.Location = new System.Drawing.Point(204, 280);
            this.dtpReparacion.Name = "dtpReparacion";
            this.dtpReparacion.Size = new System.Drawing.Size(203, 20);
            this.dtpReparacion.TabIndex = 1;
            // 
            // txtReparacion
            // 
            this.txtReparacion.Location = new System.Drawing.Point(204, 326);
            this.txtReparacion.Name = "txtReparacion";
            this.txtReparacion.Size = new System.Drawing.Size(203, 61);
            this.txtReparacion.TabIndex = 2;
            this.txtReparacion.Text = "";
            this.txtReparacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReparacion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Reparacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalle Reparacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(166, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Reporte Reparación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Identificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Detalle Reporte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha del Reporte";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(204, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(203, 20);
            this.txtId.TabIndex = 18;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtReporte
            // 
            this.txtReporte.Enabled = false;
            this.txtReporte.Location = new System.Drawing.Point(204, 123);
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(203, 61);
            this.txtReporte.TabIndex = 20;
            this.txtReporte.Text = "";
            this.txtReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReporte_KeyPress);
            // 
            // dtpReporte
            // 
            this.dtpReporte.Location = new System.Drawing.Point(204, 213);
            this.dtpReporte.Name = "dtpReporte";
            this.dtpReporte.Size = new System.Drawing.Size(203, 20);
            this.dtpReporte.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(28, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Id Reparacion";
            // 
            // txtIdRep
            // 
            this.txtIdRep.Enabled = false;
            this.txtIdRep.Location = new System.Drawing.Point(204, 45);
            this.txtIdRep.Name = "txtIdRep";
            this.txtIdRep.Size = new System.Drawing.Size(203, 20);
            this.txtIdRep.TabIndex = 23;
            this.txtIdRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdRep_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(431, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgregarReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(498, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIdRep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpReporte);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReparacion);
            this.Controls.Add(this.dtpReparacion);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(750, 500);
            this.Name = "AgregarReparaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AgregarReparaciones";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AgregarReparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpReparacion;
        private System.Windows.Forms.RichTextBox txtReparacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RichTextBox txtReporte;
        private System.Windows.Forms.DateTimePicker dtpReporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdRep;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}