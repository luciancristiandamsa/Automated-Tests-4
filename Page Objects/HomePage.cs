using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectModelTry.Page_Objects;

namespace PageObjectModelTry
{
    public class Home 
    {
        private readonly ChromeDriver driver;

        public Home(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage ClickLoginPage()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[1]/a"));
            element.Click();
            return new LoginPage(driver);
        }

        public LoginPage ClickOnStartQuickPlay()
        {
            IWebElement element = driver.FindElementByCssSelector("a[href*='quickplay']");
            element.Click();

            return new LoginPage(driver);
        }

        public SignUpPage ClickOnSignUp()
        {
            IWebElement clickSignUp = driver.FindElementByCssSelector("a[href*='signup']");
            clickSignUp.Click();

            return new SignUpPage(driver);
        }
    }
}