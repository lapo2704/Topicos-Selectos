using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
   public class Resta
    {
        public Numero OperarResta(Numero elPrimerNumero, Numero elSegundoNumero)
        {
            Numero resultado = null;
            Numero numeroUno = null;
            Numero numeroDos = null;

            var validarBases = new Validaciones.ValidarBase();

            string PrimerNumero = validarBases.CambioBase(elPrimerNumero, elPrimerNumero.laBase);
           // string SegundoNumero = validarBases.CambioBaseSegundo(elSegundoNumero, elSegundoNumero.laBase);

            numeroUno = new Numero(PrimerNumero.ToString(), 10);
           // numeroDos = new Numero(SegundoNumero.ToString(), 10);


            if (validarBases.LasDosBasesSonIguiales(numeroUno, numeroDos))
            {
                double elResultadoNumerico = Convert.ToDouble(numeroUno.elNumero) - Convert.ToDouble(numeroDos.elNumero);

                resultado = new Numero(elResultadoNumerico.ToString(), 10);

            }
            return (resultado);
        }
    }
}
