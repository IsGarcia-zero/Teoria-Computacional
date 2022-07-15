using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa6.App
{
    public partial class Pila : Form
    {
        public Pila()
        {
            InitializeComponent();
        }

        private void Pila_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush escr = new(Color.Black);
            Pen pen = new(escr);
            Font f = new("Arial", 16);
            StringFormat fmt = new();
            SolidBrush verde = new(Color.Green);
            //g.DrawString(Utilidades.Datos.cadena, f, escr, 15, 15);
            Rectangulo(g, verde);
            var cP = Utilidades.Datos.cadena;
            Stack pila = new();
            Stack p2 = new();
            String ruta = "D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP6";
            for (int i = cP.Length; i > 0; i--)
            {
                p2.Push(cP[i - 1]);
            }
            AutomataPila(p2, f, escr, g);
            string estado = "q";
            string cadep = "", cadep2 = "";
            foreach (var c in p2)
            {
                cadep += c;
            }
            foreach (var c in pila)
            {
                cadep2 += c;
            }
            File.AppendAllText($"{ruta}\\ID.txt", $"({estado}, {cadep}, {cadep2}Z)+");
            List<String> historia = new();
            if (cP[0] == '0')
            {
                for (int i = 0; i < cP.Length; i++)
                {
                    try
                    {
                        if (cP[i] == '0')
                        {
                            estado = "q";
                            g.DrawString(estado, f, escr, 550, 424);
                            pila.Push("X");
                            p2.Pop();
                            string cade1 = "", cade2 = "";
                            foreach (var c in p2) {
                                cade1 += c;
                            }
                            foreach (var c in pila)
                            {
                                cade2 += c;
                            }
                            File.AppendAllText($"{ruta}\\ID.txt", $"({estado}, {cade1}, {cade2}Z)+");
                            BorrarX(g);
                            EscribirX(pila, f, escr, g);
                            Borrar(g);
                            AutomataPila(p2, f, escr, g);
                            historia.Add(estado);
                        }
                        else if (cP[i] == '1')
                        {
                            Rectangulo(g, verde);
                            pila.Pop();
                            BorrarX(g);
                            EscribirX(pila, f, escr, g);
                            estado = "p";
                            g.DrawString(estado, f, escr, 550, 424);
                            p2.Pop();
                            string cade1 = "", cade2="";
                            foreach (var c in p2)
                            {
                                cade1 += c;
                            }
                            foreach (var c in pila)
                            {
                                cade2 += c;
                            }
                            File.AppendAllText($"{ruta}\\ID.txt", $"({estado}, {cade1}, {cade2}Z)+");
                            Borrar(g);
                            AutomataPila(p2, f, escr, g);
                            historia.Add(estado);
                        }
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show("Rechazada");
                        break;
                    }

                }
            }
            

            else
            {
                MessageBox.Show("Rechazado");
            }
            estado = "f";
            string cadef1 = "", cadef2 = "";
            foreach (var c in p2)
            {
                cadef1 += c;
            }
            foreach (var c in pila)
            {
                cadef2 += c;
            }
            File.AppendAllText($"{ruta}\\ID.txt", $"({estado}, {cadef1}, {cadef2}Z)+");
            Rectangulo(g, verde);
            g.DrawString(estado, f, escr, 550, 424);
        }
        public void AutomataPila(Stack p2, Font f, SolidBrush escr, Graphics g ) {
            int j = 318;
            foreach (var c in p2)
            {
                g.DrawString(c.ToString(), f, escr, 550, j);
                if (Utilidades.Datos.cadena.Length <= 10)
                {
                    Thread.Sleep(1000);
                }
                j -= 16;
            }
        }
        public void Borrar(Graphics g) {
            SolidBrush borra = new(Color.White);
            g.FillRectangle(borra, 550, 0, 16, 340);
        }
        public void Rectangulo(Graphics g, SolidBrush verde) {
            g.FillRectangle(verde, 502, 374, 100, 100);
            g.DrawLine(new Pen(Color.Black), 550, 374, 550, 315);
            g.DrawLine(new Pen(Color.Black), 550, 474, 550, 490);
        }
        public void EscribirX(Stack pila, Font f, SolidBrush escr, Graphics g) {
            int j = 494;
            foreach (var c in pila)
            {
                g.DrawString("Z", f, escr, 550, j+16);
                g.DrawString(c.ToString(), f, escr, 550, j);
                if (Utilidades.Datos.cadena.Length <=10) { 
                    Thread.Sleep(1000);
                }
                j += 16;
            }
        }
        public void BorrarX(Graphics g)
        {
            SolidBrush borra = new(Color.White);
            g.FillRectangle(borra, 550, 490, 16, 768);
        }
    }
}
