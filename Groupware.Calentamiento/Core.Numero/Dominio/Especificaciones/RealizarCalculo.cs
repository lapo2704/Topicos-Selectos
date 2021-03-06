﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Especificaciones
{
    public class RealizarCalculo
    {
        public Numero OperadorBinario(char elOperador, Numero elPrimerNumero, Numero elSegundoNumero, Numero Resultado)
        {
            Numero elResultado = null;
            switch (elOperador)
            {
                case '+': var accionSuma = new Acciones.Suma();
                    elResultado = accionSuma.Operar(elPrimerNumero, elSegundoNumero,Resultado);  
                    break;
                case '-': var accionResta = new Acciones.Resta();
                    elResultado = accionResta.OperarResta(elPrimerNumero,elSegundoNumero,Resultado) ;
                    break;
                case '*': var accionMultiplicacion = new Acciones.Multiplicacion();
                    elResultado = accionMultiplicacion.OperarMultiplicacion(elPrimerNumero,elSegundoNumero,Resultado) ;
                    break;
                case '/': var accionDivision = new Acciones.Division();
                    elResultado = accionDivision.OperarDivision(elPrimerNumero,elSegundoNumero,Resultado) ;
                    break;
            }
            return (elResultado);
        }
    }
}
