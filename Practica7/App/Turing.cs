using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa7.App
{
    public partial class Turing : Form
    {
        public Turing()
        {
            InitializeComponent();
        }

        private void Turing_Paint(object sender, PaintEventArgs e)
        {
            Utilidades.UtilidadP utilidad = new();
            Graphics g = e.Graphics;
            SolidBrush escr = new(Color.Black);
            Pen pen = new(escr);
            Font f = new("Arial", 16);
            StringFormat fmt = new();
            SolidBrush verde = new(Color.Green);
            string cadenaEvaluar;
            cadenaEvaluar = utilidad.GenerarCadenas();
            //g.DrawString(cadenaEvaluar, f, escr, 15, 15);
            DibujarRectangulosTuring(g, verde, cadenaEvaluar, pen, f, fmt);
            Borrar(g);
            Thread.Sleep(2000);
            string a = Turinga(g, verde, cadenaEvaluar, pen, f, fmt);
            DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
        }
        private void DibujarRectangulosTuring(Graphics g, SolidBrush verde, string cadenaEvaluar, Pen pen, Font f, StringFormat fmt) {
            int j = 100;
            foreach (var c in cadenaEvaluar) {
                g.FillRectangle(verde, j, 200, 50, 50);
                g.DrawString(c.ToString(), f, (SolidBrush)new(Color.Black), j+25, 200);
                j +=50;
            }
        }
        private void Borrar(Graphics g) {
            SolidBrush borra = new(Color.White);
            g.FillRectangle(borra, 0, 0, 3000, 200);
        }
        private void Marcador(Graphics g,  int i, Pen pen, Font f, StringFormat fmt) {
            SolidBrush rojo = new(Color.Red);
            int k = 100;
            switch (i) {
                case 0:
                    g.FillRectangle(rojo, k, 100, 50, 50);
                    g.DrawString("0", f, (SolidBrush)new(Color.Black), k + 25, 100);
                    g.DrawLine(pen, k + 25, 150, k + 25, 200);
                    break;
                case 1:
                    g.FillRectangle(rojo, k+50, 100, 50, 50);
                    g.DrawString("1", f, (SolidBrush)new(Color.Black), k + 75, 100);
                    g.DrawLine(pen, k + 75, 150, k + 75, 200);
                    break;
                case 2:
                    g.FillRectangle(rojo, k + 100, 100, 50, 50);
                    g.DrawString("2", f, (SolidBrush)new(Color.Black), k + 125, 100);
                    g.DrawLine(pen, k + 125, 150, k + 125, 200);
                    break;
                case 3:
                    g.FillRectangle(rojo, k + 150, 100, 50, 50);
                    g.DrawString("3", f, (SolidBrush)new(Color.Black), k + 175, 100);
                    g.DrawLine(pen, k + 175, 150, k + 175, 200);
                    break;
                case 4:
                    g.FillRectangle(rojo, k + 200, 100, 50, 50);
                    g.DrawString("4", f, (SolidBrush)new(Color.Black), k + 225, 100);
                    g.DrawLine(pen, k + 225, 150, k + 225, 200);
                    break;
                case 5:
                    g.FillRectangle(rojo, k + 250, 100, 50, 50);
                    g.DrawString("5", f, (SolidBrush)new(Color.Black), k + 275, 100);
                    g.DrawLine(pen, k + 275, 150, k + 275, 200);
                    break;
                case 6:
                    g.FillRectangle(rojo, k + 300, 100, 50, 50);
                    g.DrawString("6", f, (SolidBrush)new(Color.Black), k + 325, 100);
                    g.DrawLine(pen, k + 325, 150, k + 325, 200);
                    break;
                case 7:
                    g.FillRectangle(rojo, k + 350, 100, 50, 50);
                    g.DrawString("7", f, (SolidBrush)new(Color.Black), k + 375, 100);
                    g.DrawLine(pen, k + 375, 150, k + 375, 200);
                    break;
                case 8:
                    g.FillRectangle(rojo, k + 400, 100, 50, 50);
                    g.DrawString("8", f, (SolidBrush)new(Color.Black), k + 425, 100);
                    g.DrawLine(pen, k + 425, 150, k + 425, 200);
                    break;
                case 9:
                    g.FillRectangle(rojo, k + 450, 100, 50, 50);
                    g.DrawString("9", f, (SolidBrush)new(Color.Black), k + 475, 100);
                    g.DrawLine(pen, k + 475, 150, k + 475, 200);
                    break;
                case 10:
                    g.FillRectangle(rojo, k + 500, 100, 50, 50);
                    g.DrawString("10", f, (SolidBrush)new(Color.Black), k + 525, 100);
                    g.DrawLine(pen, k + 525, 150, k + 525, 200);
                    break;
                case 11:
                    g.FillRectangle(rojo, k + 550, 100, 50, 50);
                    g.DrawString("11", f, (SolidBrush)new(Color.Black), k + 575, 100);
                    g.DrawLine(pen, k + 575, 150, k + 575, 200);
                    break;
                case 12:
                    g.FillRectangle(rojo, k + 600, 100, 50, 50);
                    g.DrawString("12", f, (SolidBrush)new(Color.Black), k + 625, 100);
                    g.DrawLine(pen, k + 625, 150, k + 625, 200);
                    break;
                case 13:
                    g.FillRectangle(rojo, k + 650, 100, 50, 50);
                    g.DrawString("13", f, (SolidBrush)new(Color.Black), k + 675, 100);
                    g.DrawLine(pen, k + 675, 150, k + 675, 200);
                    break;
                case 14:
                    g.FillRectangle(rojo, k + 700, 100, 50, 50);
                    g.DrawString("14", f, (SolidBrush)new(Color.Black), k + 725, 100);
                    g.DrawLine(pen, k + 725, 150, k + 725, 200);
                    break;
                case 15:
                    g.FillRectangle(rojo, k + 750, 100, 50, 50);
                    g.DrawString("15", f, (SolidBrush)new(Color.Black), k + 775, 100);
                    g.DrawLine(pen, k + 775, 150, k + 775, 200);
                    break;
                case 16:
                    g.FillRectangle(rojo, k + 800, 100, 50, 50);
                    g.DrawString("16", f, (SolidBrush)new(Color.Black), k + 825, 100);
                    g.DrawLine(pen, k + 825, 150, k + 825, 200);
                    break;
                case 17:
                    g.FillRectangle(rojo, k + 850, 100, 50, 50);
                    g.DrawString("17", f, (SolidBrush)new(Color.Black), k + 875, 100);
                    g.DrawLine(pen, k + 875, 150, k + 875, 200);
                    break;
                case 18:
                    g.FillRectangle(rojo, k + 900, 100, 50, 50);
                    g.DrawString("18", f, (SolidBrush)new(Color.Black), k + 925, 100);
                    g.DrawLine(pen, k + 925, 150, k + 925, 200);
                    break;
                case 19:
                    g.FillRectangle(rojo, k + 950, 100, 50, 50);
                    g.DrawString("19", f, (SolidBrush)new(Color.Black), k + 975, 100);
                    g.DrawLine(pen, k + 975, 150, k + 975, 200);
                    break;
                case 20:
                    g.FillRectangle(rojo, k + 1000, 100, 50, 50);
                    g.DrawString("20", f, (SolidBrush)new(Color.Black), k + 1025, 100);
                    g.DrawLine(pen, k + 1025, 150, k + 1025, 200);
                    break;
                case 21:
                    g.FillRectangle(rojo, k + 1050, 100, 50, 50);
                    g.DrawString("21", f, (SolidBrush)new(Color.Black), k + 1075, 100);
                    g.DrawLine(pen, k + 1075, 150, k + 1075, 200);
                    break;
                case 22:
                    g.FillRectangle(rojo, k + 1100, 100, 50, 50);
                    g.DrawString("22", f, (SolidBrush)new(Color.Black), k + 1125, 100);
                    g.DrawLine(pen, k + 1125, 150, k + 1125, 200);
                    break;
                case 23:
                    g.FillRectangle(rojo, k + 1150, 100, 50, 50);
                    g.DrawString("23", f, (SolidBrush)new(Color.Black), k + 1175, 100);
                    g.DrawLine(pen, k + 1175, 150, k + 1175, 200);
                    break;
                case 24:
                    g.FillRectangle(rojo, k + 1200, 100, 50, 50);
                    g.DrawString("24", f, (SolidBrush)new(Color.Black), k + 1225, 100);
                    g.DrawLine(pen, k + 1225, 150, k + 1225, 200);
                    break;
                case 25:
                    g.FillRectangle(rojo, k + 1250, 100, 50, 50);
                    g.DrawString("25", f, (SolidBrush)new(Color.Black), k + 1275, 100);
                    g.DrawLine(pen, k + 1275, 150, k + 1275, 200);
                    break;
            }
        }
        private string CadenaResponsiva(List<char> k) {
            string fe = "";
            foreach (var c in k)
            {
                fe += c;
            }
            return fe;
        }
        private void ID(List<char> r, String ruta, String cadenaEvaluar, List<char> valor)
        {
            valor = new();
            string a = "";
            foreach (var q in r)
            {
                a += q;
            }
            File.AppendAllText($"{ruta}\\ID.txt", $"({a})+");
            
        }
        private string Turinga(Graphics g, SolidBrush verde, string cadenaEvaluar, Pen pen, Font f, StringFormat fmt)
        {
            String ruta = "D:\\Documentos\\ESCOM\\Teoria Computacional\\DatosP7";
            char estado = '1';
            String cadenaReal, cadMod;
            List<char> k = new();
            List<char> r = new();
            List<char> valor = new();
            bool bandera = true;
            int i = 1;
            cadenaReal = $"-{cadenaEvaluar}-";
            foreach (char c in cadenaReal){
                k.Add(c);
            }
            foreach (char c in cadenaReal)
            {
                valor.Add(c);
            }
            foreach (char c in cadenaReal)
            {
                r.Add(c);
            }
            while (bandera == true)
            {
                switch (estado)
                {
                    case '1':
                        switch (k[i]) {
                            case '*':
                                k[i] = 'X';
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                estado = '2';
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string a = CadenaResponsiva(k);
                                r = new();
                                foreach (char c in a)
                                {
                                    r.Add(c);
                                }
                                DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
                                break;        
                        }
                        break;
                    case '2':
                        switch (k[i])
                        {
                            case '*':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                estado = '3';
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string a = CadenaResponsiva(k);
                                r = new();
                                foreach (char c in a)
                                {
                                    r.Add(c);
                                }
                                DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
                                break;
                            case '|':
                                
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string b = CadenaResponsiva(k);
                                r = new();
                                foreach (char c in b)
                                {
                                    r.Add(c);
                                }
                                DibujarRectangulosTuring(g, verde, b, pen, f, fmt);
                                break;
                        }
                        break;
                    case '3':
                        switch (k[i])
                        {
                            case '*':
                                k[i] = 'X';
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                r = new();
                                i--;
                                estado = '4';
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string a = CadenaResponsiva(k);
                                foreach (char c in a)
                                {
                                    r.Add(c);
                                }
                                DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
                                break;
                            case '|':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string b = CadenaResponsiva(k);
                                r = new();
                                foreach (char c in b)
                                {
                                    r.Add(c);
                                }
                                DibujarRectangulosTuring(g, verde, b, pen, f, fmt);
                                break;
                        }
                        break;
                    case '4':
                        switch (k[i]) {
                            case '*':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i--;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string c = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in c)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, c, pen, f, fmt);
                                break;
                            case '|':
                                //cadenaReal.Replace(cadenaReal[i], 'a');
                                k[i] = 'a';
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                estado = '5';
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string a = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in a)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
                                break;
                            case 'X':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                estado = '7';
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string b = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in b)
                                {
                                    r.Add(ce);
                                }                                
                                DibujarRectangulosTuring(g, verde, b, pen, f, fmt);
                                break;
                        }
                        break;
                    case '5':
                        switch (k[i])
                        {
                            case '-':
                                //cadenaReal.Replace(cadenaReal[i], '|');
                                k[i] = '|';
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                k.Add('-');
                                r.Add('-');
                                i--;
                                estado = '6';
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string a = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in a)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
                                break;
                            case '*':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string b = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in b)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, b, pen, f, fmt);
                                break;
                            case '|':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string c = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in c)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, c, pen, f, fmt);
                                break;
                            case 'X':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string d = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in d)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, d, pen, f, fmt);
                                break;
                        }
                        break;
                    case '6':
                        switch (k[i])
                        {
                            case '*':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i--;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string a = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in a)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
                                break;
                            case '|':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i--;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string b = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in b)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, b, pen, f, fmt);
                                break;
                            case 'a':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                k[i] = '|';
                                i--;
                                estado = '4';
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string c = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in c)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, c, pen, f, fmt);
                                break;
                            case 'X':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                r = new();
                                i--;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string d = CadenaResponsiva(k);
                                foreach (char ce in d)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, d, pen, f, fmt);
                                break;
                        }
                        break;
                    case '7':
                        switch (k[i])
                        {
                            case '*':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                estado = '8';
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string a = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in a)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
                                break;
                            case '|':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string b = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in b)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, b, pen, f, fmt);
                                break;
                        }
                        break;
                    case '8':
                        switch (k[i])
                        {
                            case '-':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                k[i] = '*';
                                i--;
                                estado = '9';
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string a = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in a)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
                                break;
                            case '|':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i++;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string b = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in b)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, b, pen, f, fmt);
                                break;
                            case 'X':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                k[i] = '*';
                                i++;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string c = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in c)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, c, pen, f, fmt);
                                break;
                        }
                        break;
                    case '9':
                        switch (k[i])
                        {
                            case '*':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i--;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string a = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in a)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, a, pen, f, fmt);
                                break;
                            case '|':
                                r[i] = 'q';
                                ID(r, ruta, cadenaEvaluar, valor);
                                i--;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string b = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in b)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, b, pen, f, fmt);
                                break;
                            case 'X':
                                //cadenaReal.Replace(cadenaReal[i], '*');.
                                k[i] = '*';
                                r[i] = 'f';
                                ID(r, ruta, cadenaEvaluar, valor);
                                k.Add('-');
                                r.Add('-');
                                bandera = false;
                                if (Utilidades.Datos.nF + Utilidades.Datos.mF < 10)
                                {
                                    Thread.Sleep(1000);
                                }
                                Borrar(g);
                                Marcador(g, i, pen, f, fmt);
                                string c = CadenaResponsiva(k);
                                r = new();
                                foreach (char ce in c)
                                {
                                    r.Add(ce);
                                }
                                DibujarRectangulosTuring(g, verde, c, pen, f, fmt);
                                break;
                        }
                        break;
                }
                
            }
            string fe = "";
            foreach (var c in k)
            {
                fe += c;
            }
            Console.Beep(100, 5000);
            return fe;
        }
    }
}
