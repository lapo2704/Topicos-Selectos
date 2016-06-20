using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{
    [TestClass]
    public class TestsSumas
    {
        [TestMethod]
        public void SumaSinDecimales()
        {
            //definicion del escenario
        
            Numero elPrimerOperando = new Numero("11F1FF", 16);
            Numero elSegundoOperando = new Numero("7", 8);
            Numero elResultadoEsperado = new Numero("1176070", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferencia.Operar(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado,elResultadoReal);
        }

        [TestMethod]
        public void SumaConDecimales()
        {
            //definicion del escenario
            Numero elPrimerOperando = new Numero("1.3", 10);
            Numero elSegundoOperando = new Numero("-9.5", 10);
            Numero elResultadoEsperado = new Numero("-8.2", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferencia.Operar(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }

    }

}
