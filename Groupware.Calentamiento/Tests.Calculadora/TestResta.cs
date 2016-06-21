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
    public class TestResta
    {

        [TestMethod]
        public void RestaSinErrores()
        {
            Numero elPrimerOperando = new Numero("11F1FF", 16);
            Numero elSegundoOperando = new Numero("1", 10);
            Numero elResultadoEsperado = new Numero("1176062", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Resta();
            elResultadoReal = laReferencia.OperarResta(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }

        [TestMethod]
        public void RestaConErrores()
        {
            Numero elPrimerOperando = new Numero("11F1FG", 16);
            Numero elSegundoOperando = new Numero("1", 10);
            Numero elResultadoEsperado = new Numero("1176062", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Resta();
            elResultadoReal = laReferencia.OperarResta(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }
    }
}
