using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
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

        public YourPokerRoomsPage_VotingProcess LoginProcessTypeCredentials(string email, string password)
        {
            driver.FindElement(By.Name("inputEmail")).SendKeys(email);
            driver.FindElement(By.Name("inputPassword")).SendKeys(password);
            driver.FindElement(By.ClassName("btn-login")).Click();

            return new YourPokerRoomsPage_VotingProcess(driver);
        }

        [Obsolete]
        public YourPokerRoomsPage_VotingProcess EnterTheName(string name)
        {
            driver.FindElementByName("inputName").SendKeys(name);
            IWebElement element = driver.FindElementByXPath("//*[@class='btn btn-default btn-lg btn-enter btn-block']");
            element.Click();

            return new YourPokerRoomsPage_VotingProcess(driver);
        }
    }

}

