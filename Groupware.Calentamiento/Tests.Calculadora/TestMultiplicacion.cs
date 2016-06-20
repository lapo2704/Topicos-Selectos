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
        public void MultiplicacionSinDecimales()
        {
            Numero elPrimerOperando = new Numero("5", 10);
            Numero elSegundoOperando = new Numero("3", 10);
            Numero elResultadoEsperado = new Numero("2", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Resta();
            elResultadoReal = laReferencia.OperarResta(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }
    }
}
