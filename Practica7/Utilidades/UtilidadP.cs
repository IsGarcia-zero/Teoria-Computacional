using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa7.Utilidades
{
    internal class UtilidadP
    {
        public string GenerarCadenas() {
            var cad = "*";
            var aux = ""; 
            var aux2 = "";
            for (int i = 0; i < Datos.nF; i++) {
                aux += "|";
            }
            for (int i = 0; i < Datos.mF; i++){
                aux2 += "|";
            }
            string cadeF = $"{cad}{aux}{cad}{aux2}{cad}";
            return cadeF;
        }
    }
}
