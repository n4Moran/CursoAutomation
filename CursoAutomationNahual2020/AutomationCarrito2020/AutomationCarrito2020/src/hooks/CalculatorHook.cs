namespace AutomationCarrito2020.src.hooks
{
    using AutomationCarrito2020.src.utils;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public abstract class CalculatorHook
    {
        protected Calculator Calc { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            System.Console.WriteLine("Estamos ejecutando el one time setup");
            Calc = new Calculator();
        }
        [SetUp]
        public void SetUp()
        {
            System.Console.WriteLine("Estamos ejecutando el SetUp");
        }
        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Estamos ejecutando el TearDown ");
        }
        [OneTimeSetUp]
        public void OneTimeTearDown()
        {
            System.Console.WriteLine("Estamos ejecutando el one time teardown ");
        }
    }

}
