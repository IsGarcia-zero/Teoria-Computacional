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
    public partial class CantidadJugadores : Form
    {
        public CantidadJugadores()
        {
            InitializeComponent();
        }

        private void Siguiete_Click(object sender, EventArgs e)
        {
            if (jugador1.Checked){
                Unjugador uno = new();
                uno.ShowDialog();
            }
            else {
                DosJugadores dos = new();
                dos.ShowDialog();
            }
        }
    }
}
