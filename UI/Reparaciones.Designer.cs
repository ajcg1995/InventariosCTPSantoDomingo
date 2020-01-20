namespace UI
{
    partial class Reparaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablaEquipo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IdReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reparado = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaEquipo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablaEquipo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaEquipo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.TablaEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaEquipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TablaEquipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReparacion,
            this.Identificacion,
            this.Descripcion,
            this.DetalleReparacion,
            this.Reparado});
            this.TablaEquipo.EnableHeadersVisualStyles = false;
            this.TablaEquipo.GridColor = System.Drawing.Color.SteelBlue;
            this.TablaEquipo.Location = new System.Drawing.Point(36, 110);
            this.TablaEquipo.Name = "TablaEquipo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaEquipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaEquipo.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.TablaEquipo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaEquipo.Size = new System.Drawing.Size(1437, 573);
            this.TablaEquipo.TabIndex = 1;
            this.TablaEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaEquipo_CellContentClick);
            // 
            // label1
            // 
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo de Reparaciones";
            // 
            // IdReparacion
            // 
            this.IdReparacion.HeaderText = "IdReparacion";
            this.IdReparacion.MinimumWidth = 10;
            this.IdReparacion.Name = "IdReparacion";
            this.IdReparacion.Width = 150;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.MinimumWidth = 6;
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Width = 300;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 300;
            // 
            // DetalleReparacion
            // 
            this.DetalleReparacion.HeaderText = "DetalleReparacion";
            this.DetalleReparacion.MinimumWidth = 6;
            this.DetalleReparacion.Name = "DetalleReparacion";
            this.DetalleReparacion.Width = 300;
            // 
            // Reparado
            // 
            this.Reparado.HeaderText = "";
            this.Reparado.MinimumWidth = 6;
            this.Reparado.Name = "Reparado";
            this.Reparado.Text = "Reporte";
            this.Reparado.UseColumnTextForButtonValue = true;
            this.Reparado.Width = 250;
            // 
            // Reparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1508, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaEquipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reparaciones";
            this.Text = "Reparaciones";
            this.Load += new System.EventHandler(this.Reparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaEquipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView TablaEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleReparacion;
        private System.Windows.Forms.DataGridViewButtonColumn Reparado;
    }
}