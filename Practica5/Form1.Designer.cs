namespace Programa5
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
            this.label1 = new System.Windows.Forms.Label();
            this.manual = new System.Windows.Forms.RadioButton();
            this.random = new System.Windows.Forms.RadioButton();
            this.jugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoja modo automatico o modo manual";
            // 
            // manual
            // 
            this.manual.AutoSize = true;
            this.manual.Location = new System.Drawing.Point(80, 45);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(65, 19);
            this.manual.TabIndex = 1;
            this.manual.TabStop = true;
            this.manual.Text = "manual";
            this.manual.UseVisualStyleBackColor = true;
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Location = new System.Drawing.Point(80, 82);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(67, 19);
            this.random.TabIndex = 2;
            this.random.TabStop = true;
            this.random.Text = "random";
            this.random.UseVisualStyleBackColor = true;
            // 
            // jugar
            // 
            this.jugar.Location = new System.Drawing.Point(80, 124);
            this.jugar.Name = "jugar";
            this.jugar.Size = new System.Drawing.Size(75, 23);
            this.jugar.TabIndex = 3;
            this.jugar.Text = "¡Jugar!";
            this.jugar.UseVisualStyleBackColor = true;
            this.jugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 183);
            this.Controls.Add(this.jugar);
            this.Controls.Add(this.random);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton manual;
        private RadioButton random;
        private Button jugar;
    }
}