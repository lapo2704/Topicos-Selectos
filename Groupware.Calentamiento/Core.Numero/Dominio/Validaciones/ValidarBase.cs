using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarBase
    {
        public bool LaBaseEstaEnElIntervaloCorrecto(int laBase)
        {
            bool resultado;
            resultado = (2 <= laBase) & (laBase <= 32);
            return (resultado);
        }

        public bool LasDosBasesSonIguiales(Numero elPrimerNumero, Numero elSengundoNumero)
        {
            bool resultado;

            resultado = (elPrimerNumero.laBase == elSengundoNumero.laBase);
            return (resultado);
        }

        public string CambioBase(Numero elPrimerNumero, int laBase)
        {
           
            String Numero = Convert.ToString(elPrimerNumero.elNumero);
            int Base = elPrimerNumero.laBase;
            int ABase = 10;
           // int res = Convert.ToInt32(Numero, Base);
            String ResultadoPrimerNumero = Convert.ToString(Convert.ToInt32(Numero, Base), ABase);

            return (ResultadoPrimerNumero);
        }
    }
}

