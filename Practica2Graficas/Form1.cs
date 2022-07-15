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

namespace Graph2
{
    public partial class Form1 : Form
    {
        static List<UInt64> cuentas;
        static List<UInt64> cuentasp;
        static List<UInt64> cusas;
        static List<Double> cuentasLog;
        static List<Double> cusasLog;
        public Form1()
        {
            InitializeComponent();
        }
        public static void leer()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            StreamReader lectura = new StreamReader("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosBinario.txt");
            StreamReader lectura2 = new StreamReader("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primos.txt");
            string linea, linea2;
            int cuenta = 0, usass = 0;
            Double cuentaLog = 0, usassLog = 0;
            cuentas = new List<UInt64>();
            cuentasp = new List<UInt64>();
            cusas = new List<UInt64>();
            cuentasLog = new List<Double>();
            cusasLog = new List<Double>();
            while ((linea = lectura.ReadLine()) != null)
            {
                cuenta = linea.Count(caracter => caracter.Equals('1'));
                usass = linea.Count();
                cuentas.Add(Convert.ToUInt64(cuenta));
                cusas.Add(Convert.ToUInt64(usass));
            }
            while ((linea2 = lectura2.ReadLine()) != null)
            {
                cuentasp.Add(Convert.ToUInt64(linea2));
            }
            for (int i = 0; i < cuentas.Count(); i++)
            {
                cuentaLog = Math.Log(Convert.ToDouble(cuentas[i]), 10);
                cuentasLog.Add(cuentaLog);
                usassLog = Math.Log(Convert.ToDouble(cusas[i]), 10);
                cusasLog.Add(Convert.ToDouble(usassLog));
                Console.WriteLine(cuentaLog);
            }
            stopwatch.Stop();
            Console.WriteLine("Se tardo en leer: {0}", stopwatch.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));
            Console.Beep(200, 1000);
            lectura.Close();
            lectura2.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            leer();
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
                chart1.Series["Series1"].Points.AddXY(Convert.ToInt64(cuentasp[i]), cuentas[i]);
                chart2.Series["Series1"].Points.AddXY(Convert.ToInt64(cuentasp[i]), cusas[i]);
                chart3.Series["Series1"].Points.AddXY(Convert.ToInt64(cuentasp[i]), cuentasLog[i]);
                chart4.Series["Series1"].Points.AddXY(Convert.ToInt64(cuentasp[i]), cusasLog[i]);
            }
        }
    }
}
