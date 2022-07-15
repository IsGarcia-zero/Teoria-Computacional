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
    public partial class Tablero : Form
    {
        public Tablero()
        {
            InitializeComponent();
        }

        private void Tablero_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Dibujo el tablero
            SolidBrush r = new(Color.Red);
            SolidBrush n = new(Color.Black);
            TableroColor(r, n, g);
            SolidBrush brush = new(Color.Black);
            Pen pen = new(brush);
            Font drf = new("Arial", 16);
            StringFormat fmt = new();
            if (UtilidadesC.DatoCad.Jugadores)
            {
                List<char> ax = new();
                String cadena = UtilidadesC.DatoCad.Cadena1;
                ax = dfa(cadena);
                crearRutas(ax, cadena, false);
            }
            else {
                List<char> ax = new();
                List<char> ax2 = new();
                String cadena = UtilidadesC.DatoCad.Cadena1;
                String cadena2 = UtilidadesC.DatoCad.Cadena2;
                ax = dfa(cadena);
                ax2 = dfa2(cadena2);
                crearRutas(ax, cadena, false);
                crearRutas(ax2, cadena2, true);
            }
            dibujarRutas(g, n, r);
            g.DrawString(UtilidadesC.DatoCad.Cadena1, drf, brush, 15, 15);
        }
        private void TableroColor(SolidBrush r, SolidBrush n, Graphics g)
        {
            for (int k = 50; k <= 200; k += 50)
            {
                if (k == 50 || k == 150)
                {
                    for (int i = 50; i < 200; i += 100)
                    {
                        g.FillRectangle(n, i, k, 50, 50);
                    }
                    for (int i = 100; i <= 200; i += 100)
                    {
                        g.FillRectangle(r, i, k, 50, 50);
                    }
                }
                if (k == 100 || k == 200)
                {
                    for (int i = 50; i < 200; i += 100)
                    {
                        g.FillRectangle(r, i, k, 50, 50);
                    }
                    for (int i = 100; i <= 200; i += 100)
                    {
                        g.FillRectangle(n, i, k, 50, 50);
                    }
                }
            }

        }
        private List<char> dfa(String cadena)
        {
            int i = 0;
            char stado = 'A';
            List<char> axp = new();
            axp.Add(stado);
            while (i < cadena.Length)
            {
                switch (stado)
                {
                    case 'A':
                        if (cadena[i] == 'r')
                        {
                            stado = 'B';
                        }
                        else
                        {
                            stado = 'C';
                        }
                        break;
                    case 'B':
                    case 'C':
                        if (cadena[i] == 'r')
                        {
                            stado = 'D';
                        }
                        else
                        {
                            if (stado == 'B')
                            {
                                stado = 'E';
                            }
                            if (stado == 'B')
                            {
                                stado = 'F';
                            }
                        }

                        break;
                    case 'D':
                    case 'F':
                    case 'G':
                    case 'H':
                    case 'I':
                    case 'J':
                    case 'K':
                        if (cadena[i] == 'r')
                        {
                            stado = 'G';
                        }
                        else
                        {
                            if (stado == 'D' || stado == 'I')
                                stado = 'H';
                            if (stado == 'J')
                                stado = 'F';
                            if (stado == 'G' || stado == 'H' || stado == 'K')
                                stado = 'K';
                            if (stado == 'F')
                                stado = 'J';
                        }
                        break;
                    case 'E':
                        if (cadena[i] == 'r')
                        {
                            stado = 'G';
                        }
                        else
                        {
                            stado = 'H';
                        }
                        break;
                    default:
                        break;
                }
                axp.Add(stado);
                i++;
            }
            return axp;
        }
        private List<char> dfa2(String cadena)
        {
            int i = 0;
            char stado = 'A';
            List<char> axp = new();
            axp.Add(stado);
            while (i < cadena.Length)
            {
                switch (stado)
                {
                    case 'A':
                        if (cadena[i] == 'r')
                        {
                            stado = 'B';
                        }
                        else
                        {
                            stado = 'C';
                        }
                        break;
                    case 'B':
                    case 'C':
                        if (cadena[i] == 'n')
                        {
                            stado = 'E';
                        }
                        else
                        {
                            if (stado == 'B')
                            {
                                stado = 'D';
                            }
                            if (stado == 'B')
                            {
                                stado = 'F';
                            }
                        }

                        break;
                    case 'D':
                    case 'E':
                    case 'G':
                    case 'H':
                    case 'I':
                    case 'J':
                    case 'K':
                        if (cadena[i] == 'n')
                        {
                            stado = 'H';
                        }
                        else
                        {
                            if (stado == 'E' || stado == 'J')
                                stado = 'I';
                            if (stado == 'D')
                                stado = 'G';
                            if (stado == 'H' || stado == 'I' || stado == 'K')
                                stado = 'K';
                            if (stado == 'G')
                                stado = 'D';
                        }
                        break;
                    case 'F':
                        if (cadena[i] == 'n')
                        {
                            stado = 'J';
                        }
                        else
                        {
                            stado = 'I';
                        }
                        break;
                    default:
                        break;
                }
                axp.Add(stado);
                i++;
            }
            return axp;
        }
        private void crearRutas(List<char> ax, string cadena, bool s)
        {
            int n = ax.Count;
            int m = cadena.Length;
            List<List<string>> conjunto = new();
            if (!s)
            {
                for (int i = 0; i < n; i++)
                {
                    conjunto.Add(estados(ax[i]));
                }
                List<string> cadena1 = new();
                foreach (var c in "final")
                {
                    cadena1.Add(c.ToString());
                }
                conjunto.Add(cadena1);
                ruta("1", cadena, conjunto, 0, 0, m, "1", false);
                //MessageBox.Show(cadena1);
            }

            else {
                for (int i = 0; i < n; i++)
                {
                    conjunto.Add(estados2(ax[i]));
                }
                List<string> cadena2 = new();
                foreach (var c in "final")
                {
                    cadena2.Add(c.ToString());
                }
                conjunto.Add(cadena2);
                ruta("4", cadena, conjunto, 0, 0, m, "4", true);
            }
        }
        private List<string> estados(char e)
        {
            List<string> conjuntos = new();
            switch (e)
            {
                case 'A':
                    conjuntos.Add("1");
                    break;
                case 'B':
                    conjuntos.Add("2");
                    conjuntos.Add("5");
                    break;
                case 'C':
                    conjuntos.Add("6");
                    break;
                case 'D':
                    conjuntos.Add("2");
                    conjuntos.Add("5");
                    conjuntos.Add("7");
                    conjuntos.Add("10");
                    break;
                case 'E':
                    conjuntos.Add("1");
                    conjuntos.Add("3");
                    conjuntos.Add("6");
                    conjuntos.Add("9");
                    break;
                case 'F':
                    conjuntos.Add("1");
                    conjuntos.Add("3");
                    conjuntos.Add("9");
                    conjuntos.Add("11");
                    break;
                case 'G':
                    conjuntos.Add("2");
                    conjuntos.Add("4");
                    conjuntos.Add("5");
                    conjuntos.Add("7");
                    conjuntos.Add("10");
                    conjuntos.Add("12");
                    conjuntos.Add("13");
                    conjuntos.Add("15");
                    break;
                case 'H':
                    conjuntos.Add("1");
                    conjuntos.Add("3");
                    conjuntos.Add("6");
                    conjuntos.Add("8");
                    conjuntos.Add("9");
                    conjuntos.Add("11");
                    conjuntos.Add("14");
                    break;
                case 'I':
                    conjuntos.Add("2");
                    conjuntos.Add("4");
                    conjuntos.Add("5");
                    conjuntos.Add("7");
                    conjuntos.Add("10");
                    conjuntos.Add("13");
                    break;
                case 'J':
                    conjuntos.Add("6");
                    conjuntos.Add("8");
                    conjuntos.Add("14");
                    conjuntos.Add("16");
                    break;
                case 'K':
                    conjuntos.Add("1");
                    conjuntos.Add("3");
                    conjuntos.Add("6");
                    conjuntos.Add("8");
                    conjuntos.Add("9");
                    conjuntos.Add("11");
                    conjuntos.Add("14");
                    conjuntos.Add("16");
                    break;
                default:
                    break;
            }
            return conjuntos;
        }
        private List<string> estados2(char e)
        {
            List<string> conjuntos = new();
            switch (e)
            {
                case 'A':
                    conjuntos.Add("4");
                    break;
                case 'B':
                    conjuntos.Add("7");
                    break;
                case 'C':
                    conjuntos.Add("3");
                    conjuntos.Add("8");
                    break;
                case 'D':
                    conjuntos.Add("2");
                    conjuntos.Add("4");
                    conjuntos.Add("10");
                    conjuntos.Add("12");
                    break;
                case 'E':
                    conjuntos.Add("3");
                    conjuntos.Add("6");
                    conjuntos.Add("8");
                    conjuntos.Add("11");
                    break;
                case 'F':
                    conjuntos.Add("2");
                    conjuntos.Add("4");
                    conjuntos.Add("7");
                    conjuntos.Add("12");
                    break;
                case 'G':
                    conjuntos.Add("5");
                    conjuntos.Add("7");
                    conjuntos.Add("13");
                    conjuntos.Add("15");
                    break;
                case 'H':
                    conjuntos.Add("1");
                    conjuntos.Add("3");
                    conjuntos.Add("6");
                    conjuntos.Add("8");
                    conjuntos.Add("9");
                    conjuntos.Add("11");
                    conjuntos.Add("14");
                    conjuntos.Add("16");
                    break;
                case 'I':
                    conjuntos.Add("2");
                    conjuntos.Add("4");
                    conjuntos.Add("5");
                    conjuntos.Add("7");
                    conjuntos.Add("10");
                    conjuntos.Add("12");
                    conjuntos.Add("15");
                    break;
                case 'J':
                    conjuntos.Add("1");
                    conjuntos.Add("3");
                    conjuntos.Add("6");
                    conjuntos.Add("8");
                    conjuntos.Add("11");
                    conjuntos.Add("16");
                    break;
                case 'K':
                    conjuntos.Add("2");
                    conjuntos.Add("4");
                    conjuntos.Add("5");
                    conjuntos.Add("7");
                    conjuntos.Add("10");
                    conjuntos.Add("12");
                    conjuntos.Add("13");
                    conjuntos.Add("15");
                    break;
                default:
                    break;
            }
            return conjuntos;
        }
        private void ruta(string cadenaI, string cadena, List<List<string>> datos, int i, int j, int n, string k, bool s)
        {
            String rutas = "D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP5";
            List<string> cadenapro = new();
            foreach (var c in "final")
            {
                cadenapro.Add(c.ToString());
            }
            for (; j < datos[i].Count; j++)
            {
                if (!datos[i + 1].OrderBy(m => m).SequenceEqual(cadenapro.OrderBy(m => m)) && datos[i][j].Equals(k))
                {
                    for (int p = 0; p < datos[i + 1].Count; p++)
                    {
                        bool si = nfa(cadena[i], datos[i][j].ToString(), datos[i + 1][p].ToString());
                        if (si)
                        {
                            string aux = cadenaI;
                            string dato = datos[i + 1][p].ToString();
                            aux += ",";
                            aux += dato;
                            if (i == n - 1)
                            {
                                File.AppendAllText($"{rutas}\\Rutas.txt", $"{aux}\n");
                                if (s)
                                {
                                    if (dato == "13")
                                        File.AppendAllText($"{rutas}\\RutasA2.txt", $"{aux}\n");
                                }
                                else
                                {
                                    if (dato == "16")
                                        File.AppendAllText($"{rutas}\\RutasA1.txt", $"{aux}\n");
                                }
                            }
                            ruta(aux, cadena, datos, i + 1, 0, n, datos[i + 1][p], s);
                        }
                    }
                    
                }
                
            }
        }
        private bool nfa(char color, string act, string sig)
        {
            bool cumple = true;
            switch (act)
            {
                case "1":
                    if (color == 'r')
                    {
                        if (sig == "2" || sig == "5")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "6")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }

                    break;
                case "2":
                    if (color == 'r')
                    {
                        if (sig == "5" || sig == "7")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "1" || sig == "3" || sig == "6")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "3":
                    if (color == 'r')
                    {
                        if (sig == "2" || sig == "4" || sig == "7")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "6" || sig == "8")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "4":
                    if (color == 'r')
                    {
                        if (sig == "7")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "3" || sig == "8")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "5":
                    if (color == 'r')
                    {
                        if (sig == "2" || sig == "10")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "1" || sig == "6" || sig == "9")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "6":
                    if (color == 'r')
                    {
                        if (sig == "2" || sig == "5" || sig == "7" || sig == "10")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "1" || sig == "3" || sig == "9" || sig == "11")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "7":
                    if (color == 'r')
                    {
                        if (sig == "2" || sig == "4" || sig == "10" || sig == "12")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "3" || sig == "6" || sig == "8" || sig == "11")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "8":
                    if (color == 'r')
                    {
                        if (sig == "4" || sig == "7" || sig == "12")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "3" || sig == "11")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "9":
                    if (color == 'r')
                    {
                        if (sig == "5" || sig == "10" || sig == "13")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "6" || sig == "14")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "10":
                    if (color == 'r')
                    {
                        if (sig == "5" || sig == "7" || sig == "13" || sig == "15")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "6" || sig == "9" || sig == "11" || sig == "14")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "11":
                    if (color == 'r')
                    {
                        if (sig == "7" || sig == "10" || sig == "12" || sig == "15")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "6" || sig == "8" || sig == "14" || sig == "16")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "12":
                    if (color == 'r')
                    {
                        if (sig == "7" || sig == "15")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "8" || sig == "11" || sig == "16")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "13":
                    if (color == 'r')
                    {
                        if (sig == "10")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "9" || sig == "14")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "14":
                    if (color == 'r')
                    {
                        if (sig == "10" || sig == "13" || sig == "15")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "9" || sig == "11")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "15":
                    if (color == 'r')
                    {
                        if (sig == "10" || sig == "12")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "11" || sig == "14" || sig == "16")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
                case "16":
                    if (color == 'r')
                    {
                        if (sig == "12" || sig == "15")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    else
                    {
                        if (sig == "11")
                        {
                            cumple = true;
                        }
                        else
                            cumple = false;
                    }
                    break;
            }
            return cumple;
        }
        private void dibujarRutas(Graphics g, SolidBrush n, SolidBrush r) {
            if (UtilidadesC.DatoCad.Jugadores) {
                StreamReader lectura = new StreamReader("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP5\\RutasA1.txt");
                string linea;
                List<List<string>> rutas = new();
                List<string> ruta = new();
                SolidBrush green = new(Color.Green);
                while ((linea = lectura.ReadLine()) != null) {
                    ruta = new();
                    string[] vs = linea.Split(',');
                    foreach (string v in vs) {
                        ruta.Add(v);
                    }
                    rutas.Add(ruta);
                }
                lectura.Close();
                int max = rutas[0].Count;
                int min = rutas[0].Count;
                List<string> minRut = new();
                foreach (List<string> pro in rutas)
                {
                    pro.Count();
                    if (pro.Count > max)
                    {
                        max = pro.Count;
                    }
                    else if (pro.Count < min)
                    {
                        min = pro.Count;
                        minRut = pro;
                    }
                    else {
                        minRut = pro;
                    }
                }
                foreach (string v in minRut)
                {
                    switch (v)
                    {
                        case "1":
                            g.FillEllipse(green, 60, 60, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "2":
                            g.FillEllipse(green, 110, 60, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "3":
                            g.FillEllipse(green, 160, 60, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "4":
                            g.FillEllipse(green, 210, 60, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "5":
                            g.FillEllipse(green, 60, 110, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "6":
                            g.FillEllipse(green, 110, 110, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "7":
                            g.FillEllipse(green, 160, 110, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "8":
                            g.FillEllipse(green, 210, 110, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "9":
                            g.FillEllipse(green, 60, 160, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "10":
                            g.FillEllipse(green, 110, 160, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "11":
                            g.FillEllipse(green, 160, 160, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "12":
                            g.FillEllipse(green, 210, 160, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "13":
                            g.FillEllipse(green, 60, 210, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "14":
                            g.FillEllipse(green, 110, 210, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "15":
                            g.FillEllipse(green, 160, 210, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                        case "16":
                            g.FillEllipse(green, 210, 210, 25, 25);
                            Thread.Sleep(1500);
                            TableroColor(r, n, g);
                            break;
                    }
                }
                //MessageBox.Show(max.ToString() + " " + min.ToString());
            }
            else {
                try {
                    StreamReader lectura = new StreamReader("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP5\\RutasA1.txt");
                    StreamReader lectura2 = new StreamReader("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP5\\RutasA2.txt");
                    string linea;
                    string linea2;
                    List<string> ruta2 = new List<string>();
                    List<List<string>> rutas2 = new();
                    List<List<string>> rutas1 = new();
                    List<string> ruta1 = new();
                    SolidBrush green = new(Color.Green);
                    SolidBrush blue = new(Color.Cyan);
                    while (((linea = lectura.ReadLine()) != null))
                    {
                        ruta1 = new();
                        string[] vs = linea.Split(',');
                        foreach (string v in vs)
                        {
                            ruta1.Add(v);
                        }
                        rutas1.Add(ruta1);
                    }
                    while ((linea2 = lectura2.ReadLine()) != null)
                    {
                        ruta2 = new();
                        string[] vs = linea2.Split(',');
                        foreach (string v in vs)
                        {
                            ruta2.Add(v);
                        }
                        rutas2.Add(ruta2);
                    }
                    lectura.Close();
                    lectura2.Close();
                    int max1 = rutas1[0].Count;
                    int min1 = rutas1[0].Count;
                    List<string> minRut1 = new();
                    foreach (List<string> pro1 in rutas1)
                    {
                        pro1.Count();
                        if (pro1.Count > max1)
                        {
                            max1 = pro1.Count;
                        }
                        else if (pro1.Count < min1)
                        {
                            min1 = pro1.Count;
                            minRut1 = pro1;
                        }
                        else
                        {
                            minRut1 = pro1;
                        }
                    }
                    int max2 = rutas2[0].Count;
                    int min2 = rutas2[0].Count;
                    List<string> minRut2 = new();
                    foreach (List<string> pro2 in rutas2)
                    {
                        pro2.Count();
                        if (pro2.Count > max2)
                        {
                            max2 = pro2.Count;
                        }
                        else if (pro2.Count < min2)
                        {
                            min2 = pro2.Count;
                            minRut2 = pro2;
                        }
                        else
                        {
                            minRut2 = pro2;
                        }
                    }

                    foreach (string v in minRut1)
                    {
                        switch (v)
                        {
                            case "1":
                                g.FillEllipse(green, 60, 60, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "2":
                                g.FillEllipse(green, 110, 60, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "3":
                                g.FillEllipse(green, 160, 60, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "4":
                                g.FillEllipse(green, 210, 60, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "5":
                                g.FillEllipse(green, 60, 110, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "6":
                                g.FillEllipse(green, 110, 110, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "7":
                                g.FillEllipse(green, 160, 110, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "8":
                                g.FillEllipse(green, 210, 110, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "9":
                                g.FillEllipse(green, 60, 160, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "10":
                                g.FillEllipse(green, 110, 160, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "11":
                                g.FillEllipse(green, 160, 160, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "12":
                                g.FillEllipse(green, 210, 160, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "13":
                                g.FillEllipse(green, 60, 210, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "14":
                                g.FillEllipse(green, 110, 210, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "15":
                                g.FillEllipse(green, 160, 210, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                            case "16":
                                g.FillEllipse(green, 210, 210, 25, 25);
                                Thread.Sleep(1500);
                                TableroColor(r, n, g);
                                break;
                        }
                    }
                    foreach (string v in minRut2) {
                        switch (v)
                        {
                            case "1":
                                g.FillEllipse(blue, 60, 60, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "2":
                                g.FillEllipse(blue, 110, 60, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "3":
                                g.FillEllipse(blue, 160, 60, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "4":
                                g.FillEllipse(blue, 210, 60, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "5":
                                g.FillEllipse(blue, 60, 110, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "6":
                                g.FillEllipse(blue, 110, 110, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "7":
                                g.FillEllipse(blue, 160, 110, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "8":
                                g.FillEllipse(blue, 210, 110, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "9":
                                g.FillEllipse(blue, 60, 160, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "10":
                                g.FillEllipse(blue, 110, 160, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "11":
                                g.FillEllipse(blue, 160, 160, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "12":
                                g.FillEllipse(blue, 210, 160, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "13":
                                g.FillEllipse(blue, 60, 210, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "14":
                                g.FillEllipse(blue, 110, 210, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "15":
                                g.FillEllipse(blue, 160, 210, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                            case "16":
                                g.FillEllipse(blue, 210, 210, 25, 25);
                                Thread.Sleep(500);
                                TableroColor(r, n, g);
                                break;
                        }

                    }
                    if (minRut1.Count > minRut2.Count)
                    {
                        MessageBox.Show("Ganó el jugador 2");
                    }
                    else {
                        MessageBox.Show("Ganó el jugador 1");
                    }
                }
                catch (Exception er) {
                    MessageBox.Show("No existe el archivo, no hay rutas ganadoras");
                }
                
            }
        }
    }
}
    

