using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
   public class Multiplicacion
    {
        static int max = 2147483647;

        public Numero OperarMultiplicacion(Numero elPrimerNumero, Numero elSegundoNumero)
        {
            Numero resultado = null;
            Numero numeroUno = null;
            Numero numeroDos = null;

            try
            {
                /*if ((Convert.ToInt32(elPrimerNumero.elNumero) > max) || (Convert.ToInt32(elSegundoNumero.elNumero) > max))
                {
                    resultado = null;
                }
                else
                {*/
                    var validarBases = new Validaciones.ValidarBase();
                    var validarNumero = new Validaciones.ValidarNumero();

                    string PrimerNumero = validarBases.CambioBase(elPrimerNumero, elPrimerNumero.laBase);
                    string SegundoNumero = validarBases.CambioBase(elSegundoNumero, elSegundoNumero.laBase);

                    numeroUno = new Numero(PrimerNumero.ToString(), 10);
                    numeroDos = new Numero(SegundoNumero.ToString(), 10);
                    
                    if (validarBases.LasDosBasesSonIguiales(numeroUno, numeroDos))
                    {
                        double elResultadoNumerico = Convert.ToDouble(numeroUno.elNumero) * Convert.ToDouble(numeroDos.elNumero);

                        resultado = new Numero(elResultadoNumerico.ToString(), 10);
                    }
                //}
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Overflow" + e.ToString());

            }
            return (resultado);
        }        
    }
}
