using System;
using System.Diagnostics;
using System.Threading;
using Aut;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test2
{
    [TestClass]
    public class UnitTest2
    {
        [ClassInitialize]
        public static void ClassSetup(TestContext context)
        {
            webUrl = (string)context.Properties["webAppUrl"];
            webAppUserName = (string)context.Properties["-webAppUserName"];
        }

        [TestMethod]
        [TestCategory("Odd"), TestCategory("EvenOdd")]
        public void TestAdd21()
        {
            double number1 = 10.1;
            double number2 = 5.2;
            AdvancedCalc calc = new AdvancedCalc();
            double sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15.3);
        }

        [TestMethod]
        [TestCategory("Even"), TestCategory("EvenOdd")]
        public void TestAdd22()
        {
            double number1 = 10.1;
            double number2 = 5.2;
            AdvancedCalc calc = new AdvancedCalc();
            double sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15.3);
        }


        [TestMethod]
        [TestCategory("Odd"), TestCategory("EvenOdd")]
        public void TestAdd23()
        {
            double number1 = 10.1;
            double number2 = 5.2;
            AdvancedCalc calc = new AdvancedCalc();
            double sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15.3);
        }


        [TestMethod]
        [TestCategory("Even"), TestCategory("EvenOdd")]
        public void TestAdd24()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15);
        }


        [TestMethod]
        [TestCategory("Odd"), TestCategory("EvenOdd")]
        public void TestAdd25()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        [TestCategory("Even"), TestCategory("EvenOdd")]
        public void TestAdd26()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        [TestCategory("RunSettingsTest")]
        public void TestMethodRunSettings()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Assert.AreEqual(webUrl, "http://localhost");
            Assert.AreEqual(webAppUserName, "Admin");
            Assert.AreEqual(sum, 15);
        }


        [TestMethod]
        [TestCategory("RunSettingsTestOverride")]
        public void TestMethodRunSettingsOverride()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Assert.AreEqual(webUrl, "http://override");
            Assert.AreEqual(webAppUserName, "--override-Admin--;blah");
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        [TestCategory("RunInParallel")]
        public void TestMethodRunInParallel2()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Thread.Sleep(5 * 60 * 1000);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        [TestCategory("RunInIsolation")]
        public void TestMethodRunInIsolation()
        {
            int number1 = 10;
            int number2 = 5;
            Calc calc = new Calc();
            int sum = calc.Add(number1, number2);
            Process currentProcess = Process.GetCurrentProcess();
            Console.WriteLine("The process Id is :" + currentProcess.Id);
            Console.WriteLine("The process name is :" + currentProcess.ProcessName);
            Console.WriteLine("The process running in the box :" + currentProcess.MachineName);
            Assert.AreEqual(sum, 15);
        }
        private static string webUrl = string.Empty;
        private static string webAppUserName = string.Empty;

    }
}
