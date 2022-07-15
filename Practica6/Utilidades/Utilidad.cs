using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa6.Utilidades
{
    internal class Utilidad
    {
        public string GenerarCadenas()
        {
            var tam = new Random();
            var chars = "01";
            var arr = new char[tam.Next(1, 100000)];
            var rnd = new Random();
            for (int i = 0; i < arr.Length; i ++)
            {
                arr[i] = chars[rnd.Next(chars.Length)];
            }
            var v = new String(arr);
            return v;
        }
    }
}
