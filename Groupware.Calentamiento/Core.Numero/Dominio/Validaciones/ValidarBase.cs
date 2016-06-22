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
            string ResultadoPrimerNumero = "";

            if (elPrimerNumero.laBase == 4)
            {
                ResultadoPrimerNumero = CambioBase4a10(elPrimerNumero,laBase);
            }
            else if (elPrimerNumero.laBase == 32)
            {
                ResultadoPrimerNumero = CambioBase32a10(elPrimerNumero, laBase);
            }
            else
            {
                String Numero = Convert.ToString(elPrimerNumero.elNumero);
                int Base = elPrimerNumero.laBase;
                int ABase = 10;
                ResultadoPrimerNumero = Convert.ToString(Convert.ToInt32(Numero, Base), ABase);
            }
            return (ResultadoPrimerNumero);
        }

        public string CambioBase10aOtras(Numero elPrimerNumero, int laBase)
        {
            string ResultadoPrimerNumero = "";
            if (elPrimerNumero.laBase == 4)
            {
                ResultadoPrimerNumero = CambioBase10a4(elPrimerNumero, laBase);
            }
            else if (elPrimerNumero.laBase == 32)
            {
                ResultadoPrimerNumero = CambioBase10a32(elPrimerNumero, laBase);
            }
            else
            {
                String Numero = Convert.ToString(elPrimerNumero.elNumero);
                int Base = 10;
                int ABase = laBase;               
                ResultadoPrimerNumero = Convert.ToString(Convert.ToInt32(Numero, Base), ABase);                
            }
            return (ResultadoPrimerNumero);
        }

        public string CambioBase10a4(Numero elPrimerNumero, int laBase)
        {
            int numero = Convert.ToInt32(elPrimerNumero.elNumero);
            int cociente;
            int diferencia = 0;
            string resultados = " ";
            bool estado = true;

            do
            {
                cociente = (numero / 4);
                diferencia = numero - (cociente * 4);
                numero = cociente;
                cociente = 0;
                if (numero < 4)
                    estado = false;
                resultados = diferencia.ToString() + resultados;
            } while (estado);
            resultados = numero.ToString() + resultados;
            return resultados;
        }

        public string CambioBase4a10(Numero elPrimerNumero, int laBase)
        {
            string elResultado = "";
            int contador = 0;
            double acumulador = 0 ;
            int numeroConvertido = 0;

            for (int i=elPrimerNumero.elNumero.Length-1; i>=0; i--)
            {
                string numero = Convert.ToString(elPrimerNumero.elNumero[i]);
                numeroConvertido = Convert.ToInt32(numero);
                acumulador += (numeroConvertido * (Math.Pow(4,contador)));
                //acumulador += (int(char[i]) * 4 ^ contador);
               // elResultado = acumulador.ToString();
                contador++;              
            }
            elResultado = acumulador.ToString();
            return elResultado;
        }

        public string CambioBase10a32(Numero elPrimerNumero, int laBase)
        {
            var validar = new Validaciones.ValidarNumero();
            int numero = Convert.ToInt32(elPrimerNumero.elNumero);
            int cociente;
            int diferencia = 0;
            string resultados = "";
            bool estado = true;

            do           
            {
                cociente = (numero / 32);
                diferencia = numero - (cociente * 32);
                numero = cociente;
                cociente = 0;
                if (numero < 32)
                    estado = false;
                resultados = validar.CaracterValor(diferencia).ToString() + resultados;
            } while (estado) ;
            if (numero != 0)
            {
                resultados = validar.CaracterValor(numero).ToString() + resultados;
            }           
            return resultados;
        }

        public string CambioBase32a10(Numero elPrimerNumero, int laBase)
        {
            var validar= new Validaciones.ValidarNumero();

            string elResultado = "";
            int contador = 0;
            double acumulador = 0;
            int numeroConvertido = 0;

            for (int i = elPrimerNumero.elNumero.Length - 1; i >= 0; i--)
            {
               char numero = elPrimerNumero.elNumero[i];
                numeroConvertido = validar.ValorCaracter(numero); 
                acumulador += (numeroConvertido * (Math.Pow(32, contador)));
                contador++;
            }
            elResultado = acumulador.ToString();
            return elResultado;
        }
    }
}

