using System;
using System.Linq;

namespace Programa3
{
    class Programa3
    {
        static void Main(string[] args)
        {
            GenerarCadenas();
        }
        static void Iniciar(){
            var rand = new Random();
            if (rand.Next(2) == 1){
                Console.WriteLine("Apagado");
                
            }
            else { 
                Console.WriteLine("Encendido");
                GenerarCadenas();
            }

        }
        static void GenerarCadenas() {
            var characters = "01";
            var Charsarr = new char[10];
            var random = new Random();
            Console.WriteLine("Generando cadenas");
            for (int j = 0; j < 10; j++){
                for (int i = 0; i < Charsarr.Length; i++){
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }
                var resultString = new String(Charsarr);
                File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP3\\todasCadenas.txt", resultString + "\n");
            }
            Console.WriteLine("Cadenas Generadas");
            Thread.Sleep(1000);
            automata();
        }
        static void automata()
        {
            StreamReader lectura = new StreamReader("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP3\\todasCadenas.txt");
            string linea;
            while ((linea = lectura.ReadLine()) != null)
            {
                string auto = "q0", estado = "";
                for (int c = 0; c < linea.Length; c++)
                {
                    if (auto.Equals("q0") == true)
                    {
                        if (linea[c].Equals('0') == true)
                        {
                            auto = "q2";
                            estado = estado + "->" + auto;
                        }
                        else if (linea[c].Equals('1') == true)
                        {
                            auto = "q1";
                            estado = estado + "->" + auto;
                        }
                    }
                    else if (auto.Equals("q1") == true)
                    {
                        if (linea[c].Equals('0') == true)
                        {
                            auto = "q3";
                            estado = estado + "->" + auto;
                        }
                        else if (linea[c].Equals('1') == true)
                        {
                            auto = "q0";
                            estado = estado + "->" + auto;
                        }
                    }
                    else if (auto.Equals("q2") == true)
                    {
                        if (linea[c].Equals('0') == true)
                        {
                            auto = "q0";
                            estado = estado + "->" + auto;
                        }
                        else if (linea[c].Equals('1') == true)
                        {
                            auto = "q3";
                            estado = estado + "->" + auto;
                        }
                    }
                    else if (auto.Equals("q3") == true)
                    {
                        if (linea[c].Equals('0') == true)
                        {
                            auto = "q1";
                            estado = estado + "->" + auto;
                        }
                        else if (linea[c].Equals('1') == true)
                        {
                            auto = "q2";
                            estado = estado + "->" + auto;
                        }
                    }

                }
                if (auto.Equals("q0") == true)
                {
                    File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP3\\CadenasAceptadas.txt", linea + ", ");
                    File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP3\\estados.txt", estado + ", ");
                }
                else
                {
                    File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP3\\CadenasRechazadas.txt", linea + ", ");
                    File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP3\\estados.txt", estado + ", ");

                }

            }
            lectura.Close(); 
            Iniciar();
        }
    
    }
}