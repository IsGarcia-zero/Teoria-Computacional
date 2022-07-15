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
    public partial class Unjugador : Form
    {
        public Unjugador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            UtilidadesC.Utilidades utilidades = new ();
            string o =  utilidades.GenerarCadenas();
            textBox1.Text = o;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string? a; 
            a = textBox1.Text;
            if (a == ""){
                MessageBox.Show("Ingrese una cadena");
            }else {
                UtilidadesC.DatoCad.Cadena1 = a;
                UtilidadesC.DatoCad.Jugadores = true;
                Tablero tablero = new();
                tablero.ShowDialog();
            }
        }
    }
}
