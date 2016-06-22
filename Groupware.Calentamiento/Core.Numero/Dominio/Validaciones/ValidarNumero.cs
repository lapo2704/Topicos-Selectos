using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarNumero
    {
         Char[] arreglovalida = new Char[32] { '0','1','2','3','4','5','6','7','8','9',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R',
            'S','T','U','V'};
        
        public bool ElNumeroEsValidoEnLaBase(string elNumero, int laBase) {
            bool elResultado = true;
            Char[] arreglo = elNumero.ToCharArray();
            int i = 0;
            while (i < arreglo.Length && (elResultado= true)) {

                elResultado = compara(arreglo[i], laBase);
                i++;
            }                     
            return elResultado;
        }

        public bool compara (char elNumero, int laBase){
            bool elResultado = false;
            for (int i = 0; i < 32; i++) {

                if (arreglovalida[i].Equals(elNumero) && i < laBase ) {
                    elResultado = true;
                    i = 32;
                }
            }
            return (elResultado);
        }                               
    }
}

