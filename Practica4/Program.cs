using System;
using System.Linq;

namespace Programa3
{
    class Programa3
    {
        static void Main(string[] args)
        {
            //GenerarCadenas();
            Console.WriteLine("Iniciando");
            automata();
        }
        static void automata()
        {
            StreamReader lectura = new StreamReader("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP4\\todasCadenas.txt");
            string linea;
            int indiLinea = 1;
            while ((linea = lectura.ReadLine()) != null)
            {
                string[] vs = linea.Split(' ');
                string auto = "A", estado = "A";
                int indice = 1;
                foreach (string v in vs)
                {
                    for (int c = 0; c < v.Length; c++)
                    {
                        if (auto.Equals("A") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AB") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AWC";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AW") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('b') || v[c].Equals('B'))
                            {
                                auto = "AY";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AS") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('a') || v[c].Equals('A'))
                            {
                                auto = "AT";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("A2") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('i') || v[c].Equals('I'))
                            {
                                auto = "A3";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AWC") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('b') || v[c].Equals('B'))
                            {
                                auto = "ADY";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AY") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('a') || v[c].Equals('A'))
                            {
                                auto = "AZ";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AT") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('g') || v[c].Equals('G'))
                            {
                                auto = "AU";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("A3") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('t') || v[c].Equals('T'))
                            {
                                auto = "A4";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("ADY") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('a') || v[c].Equals('A'))
                            {
                                auto = "AZ";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('m') || v[c].Equals('M'))
                            {
                                auto = "AI";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AZ") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('y') || v[c].Equals('Y'))
                            {
                                auto = "A1";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AU") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AWV";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("A4") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW5";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AI") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('a') || v[c].Equals('A'))
                            {
                                auto = "AJ";
                                estado = estado + "->" + auto;
                            }

                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("A1") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AWV") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('b') || v[c].Equals('B'))
                            {
                                auto = "AY";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('a') || v[c].Equals('A'))
                            {
                                auto = "AY";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AW5") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('b') || v[c].Equals('B'))
                            {
                                auto = "AY";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AJ") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2K";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("A2K") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('i') || v[c].Equals('I'))
                            {
                                auto = "A3";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('t') || v[c].Equals('T'))
                            {
                                auto = "AL";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AL") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AWM";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AWM") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('b') || v[c].Equals('B'))
                            {
                                auto = "AY";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('r') || v[c].Equals('R'))
                            {
                                auto = "AN";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                        else if (auto.Equals("AN") == true)
                        {
                            if (v[c].Equals('w') || v[c].Equals('W'))
                            {
                                auto = "AB";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('e') || v[c].Equals('E'))
                            {
                                auto = "AW";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('p') || v[c].Equals('P'))
                            {
                                auto = "AS";
                                estado = estado + "->" + auto;
                            }
                            else if (v[c].Equals('s') || v[c].Equals('S'))
                            {
                                auto = "A2";
                                estado = estado + "->" + auto;
                            }
                            else
                            {
                                auto = "A";
                                estado = estado + "->" + auto;
                            }
                        }
                    }

                    if (auto.Equals("ADY") || auto.Equals("A1") || auto.Equals("AWV") || auto.Equals("AW5") || auto.Equals("AN"))
                    {
                        File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP4\\posiciones.txt", $"En la linea {indiLinea} y la palabra de la linea numero {indice} esta {v}, \n");
                        File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP4\\CadenasAceptadas.txt", v + ", ");
                        File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP4\\estados.txt", estado + ", ");
                    }
                    else
                    {

                        File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP4\\CadenasRechazadas.txt", v + ", ");
                        File.AppendAllText("D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP4\\estados.txt", estado + ", ");

                    }
                    indice++;
                }
                indiLinea++;
            }
            lectura.Close();
            Console.Beep(37, 5000);
            Console.WriteLine("Termino");
        }

    }
}