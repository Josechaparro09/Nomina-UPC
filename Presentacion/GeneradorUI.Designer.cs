namespace Presentacion
{
    partial class GeneradorUI
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.txtNCate = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHMin = new System.Windows.Forms.TextBox();
            this.txthMax = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOca = new System.Windows.Forms.Label();
            this.txtNOca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(254, 69);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(281, 16);
            this.lblTittle.TabIndex = 4;
            this.lblTittle.Text = "Seleccione el numero de profesores a simular";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txthMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHMin);
            this.groupBox1.Controls.Add(this.nudMax);
            this.groupBox1.Controls.Add(this.nudMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCate);
            this.groupBox1.Controls.Add(this.txtNCate);
            this.groupBox1.Location = new System.Drawing.Point(138, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 249);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(76, 30);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(100, 16);
            this.lblCate.TabIndex = 5;
            this.lblCate.Text = "N° Catedraticos";
            // 
            // txtNCate
            // 
            this.txtNCate.Location = new System.Drawing.Point(59, 49);
            this.txtNCate.Name = "txtNCate";
            this.txtNCate.Size = new System.Drawing.Size(134, 22);
            this.txtNCate.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(365, 418);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rango de horas (mes)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "-";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(30, 110);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(62, 22);
            this.nudMin.TabIndex = 12;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(148, 111);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(62, 22);
            this.nudMax.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio por hora";
            // 
            // txtHMin
            // 
            this.txtHMin.Location = new System.Drawing.Point(30, 179);
            this.txtHMin.Name = "txtHMin";
            this.txtHMin.Size = new System.Drawing.Size(79, 22);
            this.txtHMin.TabIndex = 14;
            // 
            // txthMax
            // 
            this.txthMax.Location = new System.Drawing.Point(131, 179);
            this.txthMax.Name = "txthMax";
            this.txthMax.Size = new System.Drawing.Size(79, 22);
            this.txthMax.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOca);
            this.groupBox2.Controls.Add(this.txtNOca);
            this.groupBox2.Location = new System.Drawing.Point(423, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 249);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lblOca
            // 
            this.lblOca.AutoSize = true;
            this.lblOca.Location = new System.Drawing.Point(33, 110);
            this.lblOca.Name = "lblOca";
            this.lblOca.Size = new System.Drawing.Size(100, 16);
            this.lblOca.TabIndex = 11;
            this.lblOca.Text = "N° Ocasionales";
            // 
            // txtNOca
            // 
            this.txtNOca.Location = new System.Drawing.Point(36, 129);
            this.txtNOca.Name = "txtNOca";
            this.txtNOca.Size = new System.Drawing.Size(134, 22);
            this.txtNOca.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "-";
            // 
            // GeneradorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTittle);
            this.Name = "GeneradorUI";
            this.Text = "Generador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.TextBox txtNCate;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOca;
        private System.Windows.Forms.TextBox txtNOca;
    }
}