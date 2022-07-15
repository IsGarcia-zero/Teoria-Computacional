namespace Programa5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (manual.Checked){
                Juego.CantidadJugadores cantidad = new();
                cantidad.ShowDialog();
            }
            else {
                MessageBox.Show("Aleatorio");
                UtilidadesC.Utilidades utilidades = new();
                string o = utilidades.GenerarCadenas();
                string p = utilidades.GenerarCadenas();
                bool c = utilidades.CantidadJugadores();
                UtilidadesC.DatoCad.Cadena1 = o;
                UtilidadesC.DatoCad.Cadena2 = p;
                UtilidadesC.DatoCad.Jugadores = c;
                if (c)
                {
                    MessageBox.Show($"Es un jugador y la cadena es {o}");
                }
                else {
                    MessageBox.Show($"Son dos jugadores y la cadena 1 es {o} y la cadena 2 es {p}");
                }
                Juego.Tablero tablero = new();
                tablero.ShowDialog();
            }
        }
    }
}