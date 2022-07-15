namespace Programa5.Juego
{
    partial class DosJugadores
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Generar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 23);
            this.textBox2.TabIndex = 3;
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(190, 175);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(128, 23);
            this.Generar.TabIndex = 4;
            this.Generar.Text = "Generar Rutas";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(35, 175);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(128, 23);
            this.Guardar.TabIndex = 5;
            this.Guardar.Text = "Guardar Ruta";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // DosJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 229);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "DosJugadores";
            this.Text = "DosJugadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Generar;
        private Button Guardar;
    }
}