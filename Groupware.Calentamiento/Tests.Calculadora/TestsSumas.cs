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

            Numero elPrimerOperando = new Numero("F", 16);
            Numero elSegundoOperando = new Numero("12", 8);
            Numero elResultadoEsperado = new Numero("00011001", 2);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Suma();
            elResultadoReal = laReferencia.Operar(elPrimerOperando, elSegundoOperando, elResultadoEsperado);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }

    }

}
