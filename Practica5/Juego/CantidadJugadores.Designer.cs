namespace Programa5.Juego
{
    partial class CantidadJugadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.jugador1 = new System.Windows.Forms.RadioButton();
            this.Jugador2 = new System.Windows.Forms.RadioButton();
            this.Siguiete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Cantidad de Jugadores";
            // 
            // jugador1
            // 
            this.jugador1.AutoSize = true;
            this.jugador1.Location = new System.Drawing.Point(99, 55);
            this.jugador1.Name = "jugador1";
            this.jugador1.Size = new System.Drawing.Size(109, 19);
            this.jugador1.TabIndex = 1;
            this.jugador1.TabStop = true;
            this.jugador1.Text = "Un solo jugador";
            this.jugador1.UseVisualStyleBackColor = true;
            // 
            // Jugador2
            // 
            this.Jugador2.AutoSize = true;
            this.Jugador2.Location = new System.Drawing.Point(99, 94);
            this.Jugador2.Name = "Jugador2";
            this.Jugador2.Size = new System.Drawing.Size(100, 19);
            this.Jugador2.TabIndex = 2;
            this.Jugador2.TabStop = true;
            this.Jugador2.Text = "Dos jugadores";
            this.Jugador2.UseVisualStyleBackColor = true;
            // 
            // Siguiete
            // 
            this.Siguiete.Location = new System.Drawing.Point(113, 164);
            this.Siguiete.Name = "Siguiete";
            this.Siguiete.Size = new System.Drawing.Size(75, 23);
            this.Siguiete.TabIndex = 3;
            this.Siguiete.Text = "Siguiente";
            this.Siguiete.UseVisualStyleBackColor = true;
            this.Siguiete.Click += new System.EventHandler(this.Siguiete_Click);
            // 
            // CantidadJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 223);
            this.Controls.Add(this.Siguiete);
            this.Controls.Add(this.Jugador2);
            this.Controls.Add(this.jugador1);
            this.Controls.Add(this.label1);
            this.Name = "CantidadJugadores";
            this.Text = "CantidadJugadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton jugador1;
        private RadioButton Jugador2;
        private Button Siguiete;
    }
}