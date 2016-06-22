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
        public void Multiplicacion()
        {
            Numero elPrimerOperando = new Numero("1", 10);
            Numero elSegundoOperando = new Numero("7", 8);
            Numero elResultadoEsperado = new Numero("7", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Multiplicacion();
            elResultadoReal = laReferencia.OperarMultiplicacion(elPrimerOperando, elSegundoOperando,elResultadoEsperado);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }

         [TestMethod]
         [ExpectedException(typeof(OverflowException))]
         public void MultiplicacionConDesbordamiento()
         {
            try
            {
                Numero elPrimerOperando = new Numero("2200000000", 10);
                Numero elSegundoOperando = new Numero("2", 10);
                Numero elResultadoEsperado = new Numero("4", 10);
                Numero elResultadoReal;

                //Invoque el metodo que se prueba
                var laReferencia = new Core.Numero.Dominio.Acciones.Multiplicacion();
                elResultadoReal = laReferencia.OperarMultiplicacion(elPrimerOperando, elSegundoOperando,elResultadoEsperado);

                //Verificar si el resultado obtenido es el mismo que es el espereado
                Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
            }
            catch (System.OverflowException e) {
               StringAssert.Contains(e.Message,e.ToString());
            }
        }
    }
}
