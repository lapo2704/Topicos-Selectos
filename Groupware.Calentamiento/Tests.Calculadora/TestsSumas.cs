using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{
    [TestClass]
    public class TestsSumas
    {
        [TestMethod]
        public void SumaBase()
        {
            //definicion del escenario

            Numero elPrimerOperando = new Numero("10330", 4);
            Numero elSegundoOperando = new Numero("12", 10);
            Numero elResultadoEsperado = new Numero("328", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferencia.Operar(elPrimerOperando, elSegundoOperando, elResultadoEsperado);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }

     /*   [TestMethod]
        public void SumaBase4()
        {
            //definicion del escenario

            Numero elPrimerOperando = new Numero("32112", 4);
            Numero elSegundoOperando = new Numero("12", 8);
            Numero elResultadoEsperado = new Numero("918", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferencia.Operar(elPrimerOperando,elSegundoOperando,elResultadoEsperado);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }*/

    }

}
