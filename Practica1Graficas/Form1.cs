using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraficoP1
{
    public partial class Form1 : Form
    {
        static List<UInt64> cuentas;
        static List<UInt64> cusas;
        static List<Double> cuentasLog;
        static List<Double> cusasLog;
        public Form1()
        {
            InitializeComponent();
        }
        public static void leer()
        {
            Stopwatch s2 = new Stopwatch();
            s2.Start();
            StreamReader lectura = new StreamReader("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP1\\universo.txt");
            string linea;
            int conjuto = 1, cuenta = 0;
            Int64 usass = 0;
            double cuentaLog = 0, usassLog = 0;
            cuentas = new List<UInt64>();
            cusas = new List<UInt64>();
            cuentasLog = new List<Double>();
            cusasLog = new List<Double>();
            while ((linea = lectura.ReadLine()) != null)
            {
                if (linea.Length > conjuto)
                {
                    cusas.Add(Convert.ToUInt64(usass));
                    cuentas.Add(Convert.ToUInt64(cuenta));
                    cuenta = 0;
                    usass = 0;
                    conjuto++;
                }
                usass += linea.Count();
                cuenta += linea.Count(caracter => caracter.Equals('1'));
                //Console.WriteLine(linea);
                //Console.WriteLine(usass);
            }
            cusas.Add(Convert.ToUInt64(usass));
            cuentas.Add(Convert.ToUInt64(cuenta));
            for (int i = 0; i < cuentas.Count(); i++)
            {
                cuentaLog = Math.Log(Convert.ToDouble(cuentas[i]), 10);
                cuentasLog.Add(cuentaLog);
                usassLog = Math.Log(Convert.ToDouble(cusas[i]), 10);
                cusasLog.Add(Convert.ToDouble(usassLog));
                Console.WriteLine(cuentaLog);
            }
            s2.Stop();
            Console.WriteLine("Se tardo en leer: {0}", s2.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));
            Console.Beep(300, 1000);
            lectura.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //leo el archivo
            leer();
            //saco el eje X
            List<string> series = new List<string>();
            //cambiar la composicion de colores
            chart1.Palette = ChartColorPalette.BrightPastel;
            chart2.Palette = ChartColorPalette.BrightPastel;
            chart3.Palette = ChartColorPalette.BrightPastel;
            chart4.Palette = ChartColorPalette.BrightPastel;
            chart1.Titles.Add("Unos");
            chart2.Titles.Add("Todos");
            chart3.Titles.Add("Unos Log");
            chart4.Titles.Add("Todos Log");
            for (int i = 0; i < cuentas.Count(); i++)
            {
                series.Add(Convert.ToString(i + 1));
                chart1.Series["Series1"].Points.AddXY(Convert.ToInt64(series[i]) , cuentas[i]);
                chart2.Series["Series1"].Points.AddXY(Convert.ToInt64(series[i]), cusas[i]);
                chart3.Series["Series1"].Points.AddXY(Convert.ToInt64(series[i]), cuentasLog[i]);
                chart4.Series["Series1"].Points.AddXY(Convert.ToInt64(series[i]), cusasLog[i]);
            }
            Console.WriteLine(cuentas.Count());
        }
    }
}
