using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Programa2
{
    public class Programa2
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
                    num = rnd.Next(2, 10000);
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
        public static void Procesos(int nume)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            bool siono = File.Exists("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosBinario.txt");
            bool siono2 = File.Exists("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primos.txt");
            bool siono3 = File.Exists("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosConjunto.txt");
            bool siono4 = File.Exists("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosBinarioConjunto.txt");
            if (siono == true || siono2 == true || siono3 || true)
            {
                File.Delete("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosBinario.txt");
                File.Delete("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primos.txt");
                File.Delete("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosConjunto.txt");
                File.Delete("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosBinarioConjunto.txt");
            }
            File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosBinarioConjunto.txt","Los primos en Binario son: {");
            File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosConjunto.txt", "Los primos son : {");
            int n = 2, total = 1;
            while (total <= nume)
            {
                bool esPrimo = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    string binario = Convert.ToString(n, 2);
                    File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosBinario.txt", binario + "\n");
                    File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primos.txt", n.ToString() + "\n");
                    File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosBinarioConjunto.txt", binario + ", ");
                    File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP2\\primosConjunto.txt",  n.ToString() + ", ");
                    total++;
                }
                n++;
            }
            stopwatch.Stop();
            Console.WriteLine("Se tardo en escribir: {0}", stopwatch.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));
            Console.WriteLine("Exito");
            Console.Beep(200, 5000);
            Menu();
        }
       
    }
}




