using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using CalculatorApp.Controllers;
using CalculatorApp.Models;
using CalculatorApp.Repository;

namespace CalculatorApp.Tests.Controllers
{
    [TestClass]
    public class CalculatorControllerTest
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            CalulatorRepository calcRepo = new CalulatorRepository();
            Calculate calc = new Calculate()
            {
                Num1 = 12,
                Num2 = 12
            };
            int answer = calc.Num1 + calc.Num2;
            Assert.AreEqual(answer,calcRepo.Add(calc.Num1,calc.Num2));
        }

        [TestMethod]
        public void TestSubtractNumbers()
        {
            CalulatorRepository calcRepo = new CalulatorRepository();
            Calculate calc = new Calculate()
            {
                Num1 = 12,
                Num2 = 2
            };
            int answer = calc.Num1 - calc.Num2;
            Assert.AreEqual(answer, calcRepo.Subtract(calc.Num1, calc.Num2));
        }

        [TestMethod]
        public void TestMultiplyTwoNumbers()
        {
            CalulatorRepository calcRepo = new CalulatorRepository();
            Calculate calc = new Calculate()
            {
                Num1 = 12,
                Num2 = 2
            };
            int answer = calc.Num1 * calc.Num2;
            Assert.AreEqual(answer, calcRepo.Multiply(calc.Num1, calc.Num2));
        }

        [TestMethod]
        public void TestDivideTwoNumbers()
        {
            CalulatorRepository calcRepo = new CalulatorRepository();
            Calculate calc = new Calculate()
            {
                Num1 = 12,
                Num2 = 2
            };
            int answer = calc.Num1 / calc.Num2;
            Assert.AreEqual(answer, calcRepo.Divide(calc.Num1, calc.Num2));
        }


    }
}
