using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelTry.Page_Objects
{
    public class SignUpPage
    {
        private readonly ChromeDriver driver;
        private readonly WebDriverWait wait;

        public SignUpPage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public YourPokerRoomsPage_VotingProcess FillUpAllFields(string name, string email, string password)
        {
            driver.FindElementByName("inputName").SendKeys(name);
            driver.FindElementByName("inputEmail").SendKeys(email);
            driver.FindElementByName("inputPassword").SendKeys(password);
            IWebElement clickSignUp = driver.FindElementByXPath("//*[text()='Sign up']");
            clickSignUp.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("profile-img")));
            IWebElement clickOnProfileImage = driver.FindElementById("profile-img");
            clickOnProfileImage.Click();
            IWebElement clickOnSignOut = driver.FindElementByCssSelector("a[href*='/authentication/logout/']");
            clickOnSignOut.Click();

            return new YourPokerRoomsPage_VotingProcess(driver);
        }
    }
}
