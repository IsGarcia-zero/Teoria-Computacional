using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa5.UtilidadesC
{
    internal class Utilidades
    {
        public string GenerarCadenas()
        {
            var tam = new Random();
            var chars = "rn";
            var arr = new char[tam.Next(2, 10)];
            var rnd = new Random();
            for (int i = 0; i < arr.Length; i ++)
            {
                arr[i] = chars[rnd.Next(chars.Length)];
            }
            var v = new String(arr);
            return v;
        }
        public bool CantidadJugadores() {
            bool res;
            var p = new Random();
            if (p.Next(2) == 1){
                Console.WriteLine("Un jugador");
                res = true;
            }
            else {
                Console.WriteLine("Dos Jugadores");
                res = false;
            }
            return res;
        }
    }
}
