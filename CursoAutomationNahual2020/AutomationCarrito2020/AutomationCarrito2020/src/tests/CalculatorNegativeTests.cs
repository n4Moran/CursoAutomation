namespace AutomationCarrito2020.src.tests
{
    using AutomationCarrito2020.src.hooks;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class CalculatorNegativeTests : CalculatorHook
    {
        [TestCase(2, 2, 5)]
        [TestCase(3, -2, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(-2, -2, -3)]
        public void TestSumNegativeCase(double a, double b, double expected)
        {
            var result = Calc.Add(a, b);

            Assert.AreNotEqual(expected, result, $"El valor que se esperaba era {expected} pero se obtuvo{result}.");
        }
    }
}
