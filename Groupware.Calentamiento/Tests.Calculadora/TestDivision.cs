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
    public class TestDivision
    {
       [TestMethod]
        public void Division()
        {
            Numero elPrimerOperando = new Numero("78G", 16);
            Numero elSegundoOperando = new Numero("1", 10);
            Numero elResultadoEsperado = new Numero("1931", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Division();
            elResultadoReal = laReferencia.OperarDivision(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }

       [TestMethod]
        public void DivisionConCero()
        {
             Numero elPrimerOperando = new Numero("5", 10);
                Numero elSegundoOperando = new Numero("0", 10);
                Numero elResultadoEsperado = new Numero("∞", 10);
                Numero elResultadoReal;

                //Invoque el metodo que se prueba
                var laReferencia = new Core.Numero.Dominio.Acciones.Division();
                elResultadoReal = laReferencia.OperarDivision(elPrimerOperando, elSegundoOperando);

                //Verificar si el resultado obtenido es el mismo que es el espereado
                Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
            }           
        }
    }

