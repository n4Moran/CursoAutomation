namespace SeleniumCarrito.src.utils
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;
    public class WaitHelpers
    {
        private WebDriverWait Wait { get; }

        public WaitHelpers(IWebDriver driver, int waitTimeInMiliseconds)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(waitTimeInMiliseconds));
        }

        public void WaitForElement(By by)
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }
    }
}
