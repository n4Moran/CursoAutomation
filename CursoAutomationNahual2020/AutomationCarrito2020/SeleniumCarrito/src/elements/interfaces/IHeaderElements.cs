namespace SeleniumCarrito.src.elements.interfaces
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IHeaderElements
    {
        IWebElement LoginButton { get; }
        IWebElement RegisterButton { get; }
        IWebElement WelcomeMessage { get; }
        IWebElement LogOutButton { get; }

    }
}
