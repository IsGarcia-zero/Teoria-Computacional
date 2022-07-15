namespace Programa6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GuardarCad = new System.Windows.Forms.Button();
            this.Generar = new System.Windows.Forms.Button();
            this.Cant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 159);
            this.textBox1.MaxLength = 100001;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 23);
            this.textBox1.TabIndex = 0;
            // 
            // GuardarCad
            // 
            this.GuardarCad.Location = new System.Drawing.Point(133, 327);
            this.GuardarCad.Name = "GuardarCad";
            this.GuardarCad.Size = new System.Drawing.Size(123, 23);
            this.GuardarCad.TabIndex = 1;
            this.GuardarCad.Text = "Guardar Cadena";
            this.GuardarCad.UseVisualStyleBackColor = true;
            this.GuardarCad.Click += new System.EventHandler(this.GuardarCad_Click);
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(506, 327);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(123, 23);
            this.Generar.TabIndex = 2;
            this.Generar.Text = "Generar Cadena";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Cant
            // 
            this.Cant.AutoSize = true;
            this.Cant.Location = new System.Drawing.Point(622, 232);
            this.Cant.Name = "Cant";
            this.Cant.Size = new System.Drawing.Size(38, 15);
            this.Cant.TabIndex = 3;
            this.Cant.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cant);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.GuardarCad);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button GuardarCad;
        private Button Generar;
        private Label Cant;
    }
}