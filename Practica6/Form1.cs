namespace Programa6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            Utilidades.Utilidad utilidad = new();
            string aleatorio;
            aleatorio = utilidad.GenerarCadenas();
            Cant.Text = aleatorio.Length.ToString();
            textBox1.Text = aleatorio;
            Utilidades.Datos.cadena = aleatorio;
            App.Pila pila = new();
            Thread.Sleep(1000);
            pila.ShowDialog();
        }

        private void GuardarCad_Click(object sender, EventArgs e)
        {
            Utilidades.Datos.cadena = textBox1.Text;
            App.Pila pila = new();
            pila.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}