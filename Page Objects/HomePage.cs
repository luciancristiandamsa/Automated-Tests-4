using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelTry.Page_Objects
{
    public class HomePage
    {
        IWebDriver driver;
        By Login = By.CssSelector("a[href *= '/authentication/']");
        By SignUp = By.CssSelector("a[href *= '/signup/']");
        By SignUpNow = By.CssSelector("a[href *= '/signup/']");
        By StartQuickPlay = By.CssSelector("a[href *= '/quickplay/']");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginFromHomePage()
        {
            driver.FindElement(Login).Click();
        }

        public void SignUpFromHomePage()
        {
            driver.FindElement(SignUp).Click();
        }

        public void SignUpNowFromHomePage()
        {
            driver.FindElement(SignUpNow).Click();
        }

        public void StartQuickPlayFromHomePage()
        {
            driver.FindElement(StartQuickPlay).Click();
        }
    }
}
