namespace SeleniumCarrito.src.tests
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using SeleniumCarrito.src.hooks;

    public class LoginTests : CarritoTestBase
    {

        const string LoginButton = "a[href*='login']";
        const string EmailInputID = "login-email";
        const string PassInputID = "login-password";
        const string SubmitButton = "button[type='submit']";
        const string WelcomeMessage = "h1 div[class='top-button ng-binding']";
        

        [TestCase("progressivechanges@hotmail.com", "test1234", "Bienvenido facundo alarcon!")]
        public void ValidLoginTest(string user, string pass, string expectedMessage)
        {
            Wait.WaitForElement(By.CssSelector(LoginButton));
            IWebElement loginButton = Driver.FindElement(By.CssSelector(LoginButton));
            loginButton.Click();

            Wait.WaitForElement(By.Id(EmailInputID));
            IWebElement emailInput = Driver.FindElement(By.Id(EmailInputID));
            emailInput.Click();
            emailInput.SendKeys(user);

            Wait.WaitForElement(By.Id(PassInputID));
            IWebElement passInput = Driver.FindElement(By.Id(PassInputID));
            passInput.Click();
            passInput.SendKeys(pass);

            Wait.WaitForElement(By.CssSelector(SubmitButton));
            IWebElement submitButton = Driver.FindElement(By.CssSelector(SubmitButton));
            submitButton.Click();

            Wait.WaitForElement(By.CssSelector(WelcomeMessage));
            IWebElement welcomeMessage = Driver.FindElement(By.CssSelector(WelcomeMessage));

            Assert.IsTrue(welcomeMessage.Text.Contains(expectedMessage), $"Se esperaba el titulo h1: {expectedMessage} pero se obtuvo: {welcomeMessage.Text}");
        }
    }
}
