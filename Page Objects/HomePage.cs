using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectModelTry.Page_Objects;
using System;

namespace PageObjectModelTry
{
    public class HomePage 
    {
        private readonly ChromeDriver driver;
        private readonly WebDriverWait wait;

        public HomePage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public string Title()
        {
            string title = this.driver.Title;
            return title;
        }

        public LoginPage ClickLogin()
        {
            IWebElement element = driver.FindElement(By.XPath("//a[text()='Login']"));
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