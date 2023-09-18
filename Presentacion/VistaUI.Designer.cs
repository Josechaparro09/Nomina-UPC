namespace Presentacion
{
    partial class VistaUI
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
            this.tbPOca = new System.Windows.Forms.DataGridView();
            this.tbPCate = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postgrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semillero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbPOca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPCate)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPOca
            // 
            this.tbPOca.AllowUserToAddRows = false;
            this.tbPOca.AllowUserToDeleteRows = false;
            this.tbPOca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbPOca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.asd,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Tiempo,
            this.Column6});
            this.tbPOca.Location = new System.Drawing.Point(88, 41);
            this.tbPOca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPOca.Name = "tbPOca";
            this.tbPOca.ReadOnly = true;
            this.tbPOca.RowHeadersWidth = 51;
            this.tbPOca.RowTemplate.Height = 24;
            this.tbPOca.Size = new System.Drawing.Size(933, 238);
            this.tbPOca.TabIndex = 0;
            // 
            // tbPCate
            // 
            this.tbPCate.AccessibleName = "tbPCate";
            this.tbPCate.AllowUserToAddRows = false;
            this.tbPCate.AllowUserToDeleteRows = false;
            this.tbPCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbPCate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Profesor,
            this.Correo,
            this.Telefono,
            this.Postgrado,
            this.Semillero,
            this.Horas,
            this.ValorHoras,
            this.Nomina});
            this.tbPCate.Location = new System.Drawing.Point(88, 313);
            this.tbPCate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPCate.Name = "tbPCate";
            this.tbPCate.ReadOnly = true;
            this.tbPCate.RowHeadersWidth = 51;
            this.tbPCate.RowTemplate.Height = 24;
            this.tbPCate.Size = new System.Drawing.Size(933, 238);
            this.tbPCate.TabIndex = 1;
            this.tbPCate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbPCate_CellContentClick);
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 125;
            // 
            // Profesor
            // 
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.MinimumWidth = 6;
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            this.Profesor.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Postgrado
            // 
            this.Postgrado.HeaderText = "Postgrado";
            this.Postgrado.MinimumWidth = 6;
            this.Postgrado.Name = "Postgrado";
            this.Postgrado.ReadOnly = true;
            this.Postgrado.Width = 125;
            // 
            // Semillero
            // 
            this.Semillero.HeaderText = "Semillero";
            this.Semillero.MinimumWidth = 6;
            this.Semillero.Name = "Semillero";
            this.Semillero.ReadOnly = true;
            this.Semillero.Width = 125;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.MinimumWidth = 6;
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            this.Horas.Width = 125;
            // 
            // ValorHoras
            // 
            this.ValorHoras.HeaderText = "Valor hora";
            this.ValorHoras.MinimumWidth = 6;
            this.ValorHoras.Name = "ValorHoras";
            this.ValorHoras.ReadOnly = true;
            this.ValorHoras.Width = 125;
            // 
            // Nomina
            // 
            this.Nomina.HeaderText = "Nomina";
            this.Nomina.MinimumWidth = 6;
            this.Nomina.Name = "Nomina";
            this.Nomina.ReadOnly = true;
            this.Nomina.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profesores ocasionales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profesores catedraticos";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cedula";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Profesor";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // asd
            // 
            this.asd.HeaderText = "Correo";
            this.asd.MinimumWidth = 6;
            this.asd.Name = "asd";
            this.asd.ReadOnly = true;
            this.asd.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Postgrao";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Semillero";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.MinimumWidth = 6;
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            this.Tiempo.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nomina";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // lblNomina
            // 
            this.lblNomina.AutoSize = true;
            this.lblNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomina.Location = new System.Drawing.Point(488, 663);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(44, 32);
            this.lblNomina.TabIndex = 4;
            this.lblNomina.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 663);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // VistaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 713);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPCate);
            this.Controls.Add(this.tbPOca);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VistaUI";
            this.Text = "VistaUI";
            this.Load += new System.EventHandler(this.VistaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPOca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPCate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.DataGridView tbPOca;
        private System.Windows.Forms.DataGridView tbPCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postgrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semillero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn asd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label label3;
    }
}