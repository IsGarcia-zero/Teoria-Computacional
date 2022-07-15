using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa5.Juego
{
    public partial class DosJugadores : Form
    {
        public DosJugadores()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            UtilidadesC.Utilidades u = new();
            textBox1.Text = u.GenerarCadenas();
            textBox2.Text = u.GenerarCadenas();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string? a, b;
            a = textBox1.Text;
            b = textBox2.Text;
            if (a == "" || b == "")
            {
                MessageBox.Show("No se puede guardar una cadena vacia");
            }
            else
            {
                UtilidadesC.DatoCad.Cadena1 = a;
                UtilidadesC.DatoCad.Cadena2 = b;
                UtilidadesC.DatoCad.Jugadores = false;
                Tablero tablero = new();
                tablero.ShowDialog();
            }
        }
    }
}
