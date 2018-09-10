using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Clase1;

namespace UnitTestClase1
{
    [TestClass]
    public class UnitTest1
    {
        //<summary>
        // Dado que el usuario digita 2 numeros 
        // cuando digite 6 y 5
        // entonces la suma debe retornar 11
        //</summary>
           
        [TestMethod]
        public void TestSumar()
        {

            // Preparacion
            var aritmetica = new Aritmetica();

            //Accion
            var total = aritmetica.Sumar(5, 6);

            // Assert
            Assert.AreEqual(11, total);
        }

        /// <summary>
        ///  Dado que el usuario digita 2 numeros 
        /// cuando digite 6 y 5 
        /// entonces la resta debe retornar 1
        /// </summary>
        [TestMethod]
        public void TestRestar()
        {

            // Preparacion
            var aritmetica = new Aritmetica();

            //Accion
            var total = aritmetica.Restar(6, 5);

            // Assert
            Assert.AreEqual(1, total);
        }

        /// <summary>
        /// Dado que el usuario digita 2 numeros 
        /// cuando digite 6 y 5 
        /// entonces la multiplicacion debe retornar 30
        /// </summary>
        [TestMethod]
        public void TestMultiplcar()
        {

            // Preparacion
            var aritmetica = new Aritmetica();

            //Accion
            var total = aritmetica.Multiplicar(6, 5);

            // Assert
            Assert.AreEqual(1, total);
        }
        /// <summary>
        /// Dado que el usuario digita 2 numeros 
        /// Cuando digite 2 como dividendo y 0 como divisor
        /// Entonces el sistema debe retornar "Error division con 0 no valida"
        /// </summary>
        [TestMethod]
        public void TestDividirCaso1()
        {

            // Preparacion
            var aritmetica = new Aritmetica();

            //Accion
            var response = aritmetica.Dividir(2,10);

            // Assert
            Assert.AreEqual(0.2f, response.Resultado);
        }
        /// <summary>
        /// Dado que el usuario digita 2 numeros 
        /// Cuando digite 2 como dividendo y 0 como divisor
        /// Entonces el sistema debe retornar "Error division con 0 no valida"
        /// </summary>
        [TestMethod]
        public void TestDividirCaso2()
        {

            // Preparacion
            var aritmetica = new Aritmetica();

            //Accion
            var response = aritmetica.Dividir(2, 0);

            // Assert
            Assert.AreEqual("Error division con 0 no valida", response.Message);
        }
    }
}
