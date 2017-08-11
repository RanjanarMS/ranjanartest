using System;
using System.Threading;
using Aut;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Odd"), TestCategory("EvenOdd")]
        public void TestAdd11()
        {
            double number1 = 10.1;
            double number2 = 5.2;
            AdvancedCalc calc = new AdvancedCalc();
            double sum = calc.Add(number1, number2);
            Thread.Sleep(30 * 1000);
            Assert.AreEqual(sum, 15.3);
        }

        [TestMethod]
        [TestCategory("Even"), TestCategory("EvenOdd")]
        public void TestAdd12()
        {
            double number1 = 10.1;
            double number2 = 5.2;
            AdvancedCalc calc = new AdvancedCalc();
            double sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15.3);
        }


        [TestMethod]
        [TestCategory("Odd"), TestCategory("EvenOdd")]
        public void TestAdd13()
        {
            double number1 = 10.1;
            double number2 = 5.2;
            AdvancedCalc calc = new AdvancedCalc();
            double sum = calc.Add(number1, number2);
            Thread.Sleep(30 * 1000);
            Assert.AreEqual(sum, 15.3);
        }


        [TestMethod]
        [TestCategory("Even"), TestCategory("EvenOdd")]
        public void TestAdd14()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15);
        }


        [TestMethod]
        [TestCategory("Odd"), TestCategory("EvenOdd")]
        public void TestAdd15()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Thread.Sleep(30 * 1000);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        [TestCategory("Even"), TestCategory("EvenOdd")]
        public void TestAdd16()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        [TestCategory("RunInParallel")]
        public void TestMethodRunInParallel1()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Thread.Sleep(5 * 60 * 1000);
            Assert.AreEqual(sum, 15);
        }

    }
}
