using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PageObjectModelTry.Page_Objects
{
    public class LoginPage
    {
        private readonly ChromeDriver driver;
        private readonly WebDriverWait wait;

        public LoginPage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public YourPokerRoomsPage_VotingProcess LoginProcessWithValidCredentials(string email, string password)
        {
            driver.FindElement(By.Name("inputEmail")).SendKeys(email);
            driver.FindElement(By.Name("inputPassword")).SendKeys(password);
            driver.FindElement(By.ClassName("btn-login")).Click();

            return new YourPokerRoomsPage_VotingProcess(driver);
        }

        public YourPokerRoomsPage_VotingProcess EnterTheName(string name)
        {
            driver.FindElementByName("inputName").SendKeys(name);
            IWebElement element = driver.FindElementByXPath("//button[text()='Enter']");
            element.Click();

            return new YourPokerRoomsPage_VotingProcess(driver);
        }

        public LoginPage ClickOnTheLinkedInIcon(string email, string password)
        {
            IWebElement clickOnIcon = driver.FindElementByXPath("//*[@title='LinkedIn']");
            clickOnIcon.Click();
            driver.FindElementById("username").SendKeys(email);
            driver.FindElementById("password").SendKeys(password);
            IWebElement clickOnLogin = driver.FindElementByXPath("//button[text()='Sign in']");
            clickOnLogin.Click();

            return new LoginPage(driver);
        }

        public LoginPage ClickOnForgottenPassword(string email)
        {
            IWebElement clickFogottenPassword = driver.FindElementByCssSelector("a[href='/authentication/restorepassword/']");
            clickFogottenPassword.Click();
            driver.FindElementByName("inputEmail").SendKeys(email);
            IWebElement clickRestore = driver.FindElementByXPath("//button[text()='Restore password']");
            clickRestore.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(text(), 'Password has been')]")));

            return new LoginPage(driver);
        }
    }
}

