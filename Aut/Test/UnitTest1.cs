using System;
using Aut;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
        public void TestAdd()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15);
        }
    }
}
