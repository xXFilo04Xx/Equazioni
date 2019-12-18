using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void IsDeterminedTest()
        {
            double a = 4;
            double b = 6;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void IsNotDeterminedTest()
        {
            double a = 0;
            double b = 6;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void IsInconsisted()
        {
            double a = 0;
            bool risposta = Equazioni.IsInconsisted(a);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void IsNotInconsisted()
        {
            double a = 4;
            bool risposta = Equazioni.IsInconsisted(a);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void IsNotDegree2Test()
        {
            double a = 0;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void DeltaTest()
        {
            double a = 4;
            double b = 6;
            double c = 5;
            double delta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(-44, delta);
        }
        [TestMethod]
        public void DeltaTest1()
        {
            double a = 0;
            double b = 3;
            double c = 2;
            double delta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(double.NaN, delta);
        }
        [TestMethod]
        public void DeltaTest2()
        {
            double a = 4;
            double b = 0;
            double c = 5;
            double delta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(-80, delta);
        }
        [TestMethod]
        public void DeltaTest3()
        {
            double a = 4;
            double b = 6;
            double c = 0;
            double delta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(36, delta);
        }
        [TestMethod]
        public void EquationDegree1()
        {
            double a = 3;
            double b = 6;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual("-2", risposta);
        }
        [TestMethod]
        public void EquationDegree1_1()
        {
            double a = 0;
            double b = 3;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual("Impossible", risposta);
        }
        [TestMethod]
        public void EquationDegree1_2()
        {
            double a = 6;
            double b = 0;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual("0", risposta);
        }
        [TestMethod]
        public void EquationDegree1_3()
        {
            double a = 0;
            double b = 0;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual("Indeterminated", risposta);
        }
        
    }
}
