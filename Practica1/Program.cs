
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace Programa1
{
    public class Programa1
    {
        public static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            int num = 0;
            const string Menus = "1. Escoger Numero:\n2. Al azar:\n3.Salir.";
            Console.WriteLine(">>Menu<<");
            Console.WriteLine("Eliga una opcion");
            Console.WriteLine(Menus);
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingresa k: ");
                    num = Convert.ToInt32(Console.ReadLine() ?? "0");
                    Procesos(num);
                    break;
                case 2:
                    Random rnd = new Random();
                    num = rnd.Next(2, 30);
                    Console.WriteLine($"Se escogio un numero al azar: {num}");
                    Procesos(num);
                    break;
                case 3:
                    Console.WriteLine("Adios");
                    break;
                default:
                    Menu();
                    break;
            }
        }
        public static void Procesos(int num)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string alfabeto = "01";
            List<string> cadenas = new();
            foreach (char c in alfabeto)
                cadenas.Add(c.ToString());
            string header = $"Escogio \u03A3^{num} \n siendo esto: \u03A3^* = ( ";
            bool siono = File.Exists("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP1\\universo.txt");
            if (siono == true)
            {
                File.Delete("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP1\\universo.txt");
            }
            File.AppendAllLines("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP1\\universo.txt", cadenas);
            for (int i = 1; i < num; i++)
            {
                List<string>[] auxiliar = new List<string>[alfabeto.Length];
                for (int j = 0; j < auxiliar.Length; j++)
                {
                    auxiliar[j] = new();
                    auxiliar[j].AddRange(cadenas);
                    for (int k = 0; k < auxiliar[j].Count; k++)
                        auxiliar[j][k] = string.Concat(alfabeto[j], auxiliar[j][k]);
                }
                cadenas = new();
                foreach (List<string> lista in auxiliar)
                    cadenas.AddRange(lista);
                File.AppendAllLines("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP1\\universo.txt", cadenas);
            }
            Console.WriteLine("Exito, se ha guardado en universo.txt");
            cadenas.Clear();
            cadenas = new();
            GC.Collect(GC.MaxGeneration);
            GC.Collect(GC.GetGeneration(cadenas));
            GC.Collect();
            stopwatch.Stop();
            Console.WriteLine("Se tardo en escribir: {0}", stopwatch.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));
            Console.Beep(200, 5000);
            Menu();
        }
    }
}