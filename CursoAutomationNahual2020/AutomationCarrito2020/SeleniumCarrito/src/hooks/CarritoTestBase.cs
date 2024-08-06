namespace SeleniumCarrito.src.hooks
{
    using NUnit.Framework;
    using SeleniumCarrito.src.utils;

    public class CarritoTestBase : TestBase
    {
        const string URL = "https://nahual-app-carrito.herokuapp.com/";

        protected WaitHelpers Wait { get; }

        public CarritoTestBase() : base()
        {
            Wait = new WaitHelpers(Driver, 10000);
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Driver.Navigate().GoToUrl(URL);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}