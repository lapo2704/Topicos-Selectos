using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    class ValidaDivisonPorCero
    {

        public bool DivisionPorCero(string elDivisor)
        {
            bool resultado = true;

            if (elDivisor.Equals("0")) {
                resultado = false;
            }           
            return (resultado);
        }

    }
}
