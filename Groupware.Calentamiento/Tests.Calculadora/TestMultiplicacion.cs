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
            Numero elPrimerOperando = new Numero("1000000", 10);
            Numero elSegundoOperando = new Numero("1000000", 10);
            Numero elResultadoEsperado = new Numero("1000000000000", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Multiplicacion();
            elResultadoReal = laReferencia.OperarMultiplicacion(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }
    }
}
