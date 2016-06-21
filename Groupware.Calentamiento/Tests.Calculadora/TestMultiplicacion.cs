using Core.Numero;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Calculadora
{
    [TestClass]
    public class TestMultiplicacion
    {
        [TestMethod]
        public void MultiplicacionSinErrores()
        {
            Numero elPrimerOperando = new Numero("R1R", 32);
            Numero elSegundoOperando = new Numero("7", 8);
            Numero elResultadoEsperado = new Numero("1", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Multiplicacion();
            elResultadoReal = laReferencia.OperarMultiplicacion(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }

        [TestMethod]
        public void MultiplicacionConDesbordamiento()
        {
            Numero elPrimerOperando = new Numero("2200000000", 10);
            Numero elSegundoOperando = new Numero("2", 10);
            Numero elResultadoEsperado = new Numero("4", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Multiplicacion();
            elResultadoReal = laReferencia.OperarMultiplicacion(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }
    }
}
