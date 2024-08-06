namespace AutomationCarrito2020.src.tests
{
    using AutomationCarrito2020.src.hooks;
    using AutomationCarrito2020.src.utils;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CalculatorPositiveTests : CalculatorHook
    {

        [TestCase(2,3,5)]
        [TestCase(3,-3,0)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -1, -3)]
        public void TestSumPositiveCase(double a, double b, double expected)
        {
            var result = Calc.Add(a, b);

            Assert.AreEqual(expected, result, $"El valor que se esperaba era {expected} pero se obtuvo{result}.");
        }

        
    }
}
