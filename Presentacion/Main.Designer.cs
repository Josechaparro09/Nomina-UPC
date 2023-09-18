namespace Presentacion
{
    partial class Main
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
            this.btnGAle = new System.Windows.Forms.Button();
            this.btnGMan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGAle
            // 
            this.btnGAle.Location = new System.Drawing.Point(201, 219);
            this.btnGAle.Name = "btnGAle";
            this.btnGAle.Size = new System.Drawing.Size(177, 32);
            this.btnGAle.TabIndex = 0;
            this.btnGAle.Text = "Generar aleatoriamente";
            this.btnGAle.UseVisualStyleBackColor = true;
            this.btnGAle.Click += new System.EventHandler(this.btnGAle_Click);
            // 
            // btnGMan
            // 
            this.btnGMan.Location = new System.Drawing.Point(413, 219);
            this.btnGMan.Name = "btnGMan";
            this.btnGMan.Size = new System.Drawing.Size(172, 32);
            this.btnGMan.TabIndex = 1;
            this.btnGMan.Text = "Registrar manualmente";
            this.btnGMan.UseVisualStyleBackColor = true;
            this.btnGMan.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGMan);
            this.Controls.Add(this.btnGAle);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGAle;
        private System.Windows.Forms.Button btnGMan;
    }
}