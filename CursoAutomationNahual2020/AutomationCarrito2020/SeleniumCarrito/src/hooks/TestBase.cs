namespace SeleniumCarrito.src.hooks
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public class TestBase
    {
        protected IWebDriver Driver { get; }

        public TestBase()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }
    }
}