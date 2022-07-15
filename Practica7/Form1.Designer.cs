namespace Programa7
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
            this.Alet = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.labeln = new System.Windows.Forms.Label();
            this.labelm = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.TextBox();
            this.Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alet
            // 
            this.Alet.Location = new System.Drawing.Point(245, 246);
            this.Alet.Name = "Alet";
            this.Alet.Size = new System.Drawing.Size(146, 23);
            this.Alet.TabIndex = 0;
            this.Alet.Text = "Generar Aleatoriamente";
            this.Alet.UseVisualStyleBackColor = true;
            this.Alet.Click += new System.EventHandler(this.Alet_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(71, 246);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(109, 23);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar Datos";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // labeln
            // 
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(37, 53);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(55, 15);
            this.labeln.TabIndex = 2;
            this.labeln.Text = "Ingrese n";
            // 
            // labelm
            // 
            this.labelm.AutoSize = true;
            this.labelm.Location = new System.Drawing.Point(37, 119);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(59, 15);
            this.labelm.TabIndex = 3;
            this.labelm.Text = "Ingrese m";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(150, 53);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 23);
            this.n.TabIndex = 4;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(150, 119);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(100, 23);
            this.m.TabIndex = 5;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(141, 293);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(138, 23);
            this.Borrar.TabIndex = 6;
            this.Borrar.Text = "Borrar historial(ID\'s)";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 346);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.m);
            this.Controls.Add(this.n);
            this.Controls.Add(this.labelm);
            this.Controls.Add(this.labeln);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Alet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Alet;
        private Button Guardar;
        private Label labeln;
        private Label labelm;
        private TextBox n;
        private TextBox m;
        private Button Borrar;
    }
}