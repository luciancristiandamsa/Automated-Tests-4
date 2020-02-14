using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Xunit;

namespace ClassLibrary4
{
   
    public class Class1
    {
        IWebDriver driver = new ChromeDriver(); // First commit
        string validName = "aaa098873";     // Second commit
        string invalidName = "";
        string validEmail = "aaa098873@gmail.com";
        string invalidEmail = "qqqqqqqqqq";
        string validPassword = "ababab.123";
        string invalidPassword = "qqqqqqqqqq";
        string stories = "1";
        string roomsName = "Test Room";

        [Fact]
        [Obsolete]
        public void LoginPage_ValidUsername_ValidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys(validEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(validPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("li-email")));
            driver.FindElement(By.Id("profile-img")).Click();

            string element = driver.FindElement(By.ClassName("li-email")).Text.Substring(0);

            Assert.Equal(validEmail, element);

            driver.Quit();
        }

        [Fact]
        public void LoginPage_InvalidUsername_ValidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys(invalidEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(validPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();

            string element = driver.FindElement(By.ClassName("ng-binding")).Text.Substring(0);

            Assert.Equal("Invalid email address.", element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void LoginPage_ValidUsername_InvalidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys(validEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(invalidPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("ng-binding")));

            bool element = driver.FindElement(By.ClassName("ng-binding")).Displayed;

            Assert.True(element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void LoginPage_InvalidUsername_InvalidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys(invalidEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(invalidPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("ng-binding")));

            bool element = driver.FindElement(By.ClassName("ng-binding")).Displayed;

            Assert.True(element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void SignUpPage_ValidCredentials()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-default")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys(validName);
            driver.FindElement(By.Name("inputEmail")).SendKeys(validEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(validPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("li-email")));
            driver.FindElement(By.Id("profile-img")).Click();

            string element = driver.FindElement(By.ClassName("li-email")).Text.Substring(0);

            Assert.Equal(validEmail, element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void SignUpPage_InvalidName_ValidEmail_ValidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-default")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys(invalidName);
            driver.FindElement(By.Name("inputEmail")).SendKeys(validEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(validPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("close")));

            bool element = driver.FindElement(By.ClassName("close")).Displayed;

            Assert.True(element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void SignUp_ValidName_InvalidEmail_ValidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-default")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys(validName);
            driver.FindElement(By.Name("inputEmail")).SendKeys(invalidEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(validPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("ng-binding")));

            bool element = driver.FindElement(By.ClassName("ng-binding")).Displayed;

            Assert.True(element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void SignUp_ValidName_ValidEmail_InvalidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-default")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys(validName);
            driver.FindElement(By.Name("inputEmail")).SendKeys(validEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(invalidPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("ng-binding")));

            bool element = driver.FindElement(By.ClassName("ng-binding")).Displayed;

            Assert.False(!element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void SignUp_UsingLinkedInIcon()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-default")).Click();
            driver.FindElement(By.CssSelector("body > div.grayed > div > section > form.ng-pristine.ng-valid > ul > li:nth-child(1) > button")).Click();
            var wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait1.Until(ExpectedConditions.TitleContains("LinkedIn Login, Sign in | LinkedIn"));
            driver.FindElement(By.Id("username")).SendKeys(invalidName);
            driver.FindElement(By.Id("password")).SendKeys(invalidPassword);
            driver.FindElement(By.ClassName("btn__primary--large")).Click();
            var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait2.Until(ExpectedConditions.ElementExists(By.Id("error-for-username")));

            bool element = driver.FindElement(By.Id("error-for-username")).Displayed;

            Assert.True(element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void StartQuickPlay_Between_Two_Players_With_PlayerRole()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("a[href*='quickplay']")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys(validName);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait1.Until(ExpectedConditions.ElementToBeClickable(By.Name("createRoomNameInput")));
            driver.FindElement(By.Name("createRoomNameInput")).SendKeys(roomsName);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait2.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));
            driver.FindElement(By.Name("inputName")).SendKeys(stories);
            driver.FindElement(By.XPath("(//*[@class='col-sm-6 margin-bottom'])[2]")).Click();
            var wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait3.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#step-0 > div.popover-navigation > button:nth-child(3)")));
            driver.FindElement(By.CssSelector("#step-0 > div.popover-navigation > button:nth-child(3)")).Click();
            var wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait4.Until(ExpectedConditions.ElementExists(By.Id("btn-start")));
            driver.FindElement(By.Id("btn-start")).Click();
            Thread.Sleep(5);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[4]/button/div[1]")).Click();
            var wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait5.Until(ExpectedConditions.ElementExists(By.ClassName("btn-one")));
            var wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait7.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));

            SelectElement elementSelect = new SelectElement(driver.FindElement(By.Id("finalEstimate")));  
            elementSelect.SelectByValue("7");
            driver.FindElement(By.ClassName("btn-one")).Click();

            string element = driver.FindElement(By.Id("storyEditable")).Text.Substring(0);

            Assert.Equal(stories, element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void FibonacciMode_And_CoundDownMode()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys(validEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(validPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait1.Until(ExpectedConditions.ElementExists(By.ClassName("btn-create-room")));
            driver.FindElement(By.ClassName("btn-create-room")).Click();
            var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait2.Until(ExpectedConditions.ElementExists(By.Id("createRoomNameInput")));
            driver.FindElement(By.Id("createRoomNameInput")).SendKeys(roomsName);
            SelectElement mode = new SelectElement(driver.FindElement(By.ClassName("card-set-type")));
            mode.SelectByValue("2");
            driver.FindElement(By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(8) > div.col-sm-8 > label > span > input")).Click();
            SelectElement time = new SelectElement(driver.FindElement(By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(8) > div.col-sm-4 > div > select")));
            time.SelectByValue("4");
            driver.FindElement(By.ClassName("btn-ok")).Click();
            var wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait3.Until(ExpectedConditions.ElementExists(By.Name("inputName")));
            driver.FindElement(By.Name("inputName")).SendKeys(stories);
            driver.FindElement(By.XPath("(//*[@class='col-sm-6 margin-bottom'])[2]")).Click();
            var wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait4.Until(ExpectedConditions.ElementExists(By.Id("btn-start")));
            driver.FindElement(By.Id("btn-start")).Click();
            Thread.Sleep(5);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[4]/button/div[1]")).Click();
            var wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait5.Until(ExpectedConditions.ElementExists(By.ClassName("btn-one")));
            SelectElement finalEstimate = new SelectElement(driver.FindElement(By.Id("finalEstimate")));
            finalEstimate.SelectByValue("5");
            driver.FindElement(By.ClassName("btn-one")).Click();

            string finalResult = driver.FindElement(By.Id("storyEditable")).Text.Substring(0);

            Assert.Equal(stories, finalResult);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void SignOut_Functionality()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys(validEmail);
            driver.FindElement(By.Name("inputPassword")).SendKeys(validPassword);
            driver.FindElement(By.ClassName("btn-default")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("li-email")));
            driver.FindElement(By.Id("profile-img")).Click();
            driver.FindElement(By.LinkText("Sign Out")).Click();
            var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait2.Until(ExpectedConditions.ElementExists(By.LinkText("Login")));

            bool element = driver.FindElement(By.LinkText("Login")).Displayed;

            Assert.True(element);

            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void PrivacyPolicy_Functionality()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Privacy Policy")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("Privacy Policy"));

            Assert.Equal("PlanITpoker: Privacy Policy", driver.Title);

            driver.Quit();
        }




    }
}
