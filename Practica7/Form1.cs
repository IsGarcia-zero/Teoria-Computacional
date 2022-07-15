namespace Programa7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int mP, nP;
        private void Alet_Click(object sender, EventArgs e)
        {
            var ra = new Random();
            n.Text = ra.Next(1,25).ToString();
            m.Text = ra.Next(1, 25).ToString();
            mP = Convert.ToInt32(m.Text);
            nP = Convert.ToInt32(n.Text);
            Utilidades.Datos.mF = mP;
            Utilidades.Datos.nF = nP;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            bool siono = File.Exists("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP7\\ID.txt");
            if (siono == true)
            {
                File.Delete("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP7\\ID.txt");
            }
            else {
                MessageBox.Show("No existe el archivo");
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            mP = Convert.ToInt32(m.Text);
            nP = Convert.ToInt32(n.Text);
            Utilidades.Datos.mF = mP;
            Utilidades.Datos.nF = nP;
            App.Turing turing = new();
            turing.ShowDialog();
        }
    }
}