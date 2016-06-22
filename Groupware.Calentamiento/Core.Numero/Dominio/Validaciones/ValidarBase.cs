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

        public string CambioBase10(Numero elPrimerNumero, int laBase)
        {           
            String Numero = Convert.ToString(elPrimerNumero.elNumero);
            int Base = elPrimerNumero.laBase;
            int ABase = 10;
           // int res = Convert.ToInt32(Numero, Base);
            String ResultadoPrimerNumero = Convert.ToString(Convert.ToInt32(Numero, Base), ABase);

            return (ResultadoPrimerNumero);
        }

        public string CambioBase10aOtras(Numero elPrimerNumero, int laBase)
        {
            String Numero = Convert.ToString(elPrimerNumero.elNumero);
            int Base = 10;
            int ABase = laBase;
            // int res = Convert.ToInt32(Numero, Base);
            String ResultadoPrimerNumero = Convert.ToString(Convert.ToInt32(Numero, Base), ABase);

            return (ResultadoPrimerNumero);
        }

        public String CambioBase10a4(Numero elPrimerNumero)
        {
            int numero = Convert.ToInt32(elPrimerNumero.elNumero);
            int cociente;
            int diferencia = 0;
            string resultados =;
            bool estado = true;
           
            do{
                cociente = (numero / 4);
                diferencia = numero - (cociente * 4);
                numero = cociente;
                cociente = 0;
                if (numero < 4)
                    estado = false;
                resultados = diferencia.ToString() + resultados;
            } while (estado) ;
                resultados = numero.ToString() + resultados;
            return resultados;
        }
    }
}

