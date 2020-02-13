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
        
        [Fact]
        public void LoginPage_ValidUsername_ValidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(1) > a")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys("aaa098873@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("ababab.123");
            driver.FindElement(By.CssSelector("body > div.grayed > div > section > form.ng-dirty.ng-valid.ng-valid-required > div:nth-child(7) > div > button")).Click();
            Thread.Sleep(3000);

            Assert.Equal("PlanITpoker: Your Poker Rooms", driver.Title);

            driver.Close();
        }

        [Fact]
        public void LoginPage_InvalidUsername_ValidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(1) > a")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys("qqqqqqqqqq");
            driver.FindElement(By.Name("inputPassword")).SendKeys("ababab.123");
            driver.FindElement(By.XPath("/html/body/div[1]/div/section/form[1]/div[7]/div/button")).Click();
            Thread.Sleep(2000);

            string element = driver.FindElement(By.XPath("/html/body/div[1]/div/section/form[1]/div[3]/div/div/div/span")).Text.Substring(0);

            Assert.Equal("Invalid email address.", element);

            driver.Close();
        }

        [Fact]
        public void LoginPage_ValidUsername_InvalidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(1) > a")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys("aaa098873@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("qqqqqqqqqq");
            driver.FindElement(By.XPath("/html/body/div[1]/div/section/form[1]/div[7]/div/button")).Click();
            Thread.Sleep(2000);

            string element = driver.FindElement(By.ClassName("ng-binding")).Text.Substring(0);

            Assert.Equal("You have provided invalid credentials.", element);

            driver.Close();
        }

        [Fact]
        public void LoginPage_InvalidUsername_InvalidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(1) > a")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys("qqqqqqqqqq");
            driver.FindElement(By.Name("inputPassword")).SendKeys("qqqqqqqqqq");
            driver.FindElement(By.XPath("/html/body/div[1]/div/section/form[1]/div[7]/div/button")).Click();
            Thread.Sleep(2000);

            string element = driver.FindElement(By.ClassName("ng-binding")).Text.Substring(0);

            Assert.Equal("Invalid email address.", element);

            driver.Close();
        }

        [Fact]
        public void SignUpPage_ValidCredentials()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(2) > a")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys("aaa098873");
            driver.FindElement(By.Name("inputEmail")).SendKeys("aaa098873@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("ababab.123");
            driver.FindElement(By.XPath("/html/body/div[1]/div/section/form[1]/div[5]/div/button")).Click();
            Thread.Sleep(2000);

            Assert.Equal("PlanITpoker: Your Poker Rooms", driver.Title);

            driver.Close();
        }

        [Fact]
        public void SignUpPage_InvalidName_ValidEmail_ValidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(2) > a")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys("");
            driver.FindElement(By.Name("inputEmail")).SendKeys("aaa098873@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("ababab.123");
            driver.FindElement(By.XPath("/html/body/div[1]/div/section/form[1]/div[5]/div/button")).Click();
            Thread.Sleep(3000);

            string element = driver.FindElement(By.XPath("/html/body/div[1]/div/section/form[1]/div[4]/div/div/div/span")).Text.Substring(0);

            Assert.Equal("Please fill all the required fields.", element);

            driver.Close();
        }

        [Fact]
        public void SignUp_ValidName_InvalidEmail_ValidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(2) > a")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys("aaa098873");
            driver.FindElement(By.Name("inputEmail")).SendKeys("…@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("ababab.123");
            driver.FindElement(By.XPath("/html/body/div[1]/div/section/form[1]/div[5]/div/button")).Click();
            Thread.Sleep(3000);

            string element = driver.FindElement(By.ClassName("ng-binding")).Text.Substring(0);

            Assert.Equal("Invalid email address.", element);

            driver.Close();
        }

        [Fact]
        public void SignUp_ValidName_ValidEmail_InvalidPassword()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(2) > a")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys("aaa098873");
            driver.FindElement(By.Name("inputEmail")).SendKeys("aaa098873@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("...");
            driver.FindElement(By.XPath("/html/body/div[1]/div/section/form[1]/div[5]/div/button")).Click();
            Thread.Sleep(3000);

            string element = driver.FindElement(By.ClassName("ng-binding")).Text.Substring(0);

            Assert.Equal("You have provided invalid credentials.", element);

            driver.Close();
        }

        [Fact]
        public void SignUp_UsingLinkedInIcon()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(2) > a")).Click();
            driver.FindElement(By.CssSelector("body > div.grayed > div > section > form.ng-pristine.ng-valid > ul > li:nth-child(1) > button > img")).Click();
            driver.FindElement(By.Id("username")).SendKeys("aaa098873@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("ababab.123");
            driver.FindElement(By.CssSelector("#app__container > main > div > form > div.login__form_action_container.login__form_action_container--multiple-actions > button")).Click();
            Thread.Sleep(2500);

            string element = driver.FindElement(By.Id("error-for-username")).Text.Substring(0);

            Assert.Equal("Hmm, we don't recognize that email. Please try again.", element);

            driver.Quit();
        }

        [Fact]
        public void StartQuickPlay_Between_Two_Players_With_PlayerRole()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("body > div.pages-home > div.welcome > div > div > div:nth-child(1) > ul > li:nth-child(2) > a")).Click();
            driver.FindElement(By.Name("inputName")).SendKeys("qqq");
            driver.FindElement(By.CssSelector("body > div.grayed > div > section > form > div:nth-child(3) > div > button")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("createRoomNameInput")).SendKeys("First Room");
            driver.FindElement(By.CssSelector("#createRoomModal > div > div > div.modal-body > div > div:nth-child(1) > button")).Submit();
            Thread.Sleep(4000);
            driver.FindElement(By.Name("inputName")).SendKeys("1\n2");
            driver.FindElement(By.CssSelector("#createStoryModal > div > div > form > div.modal-body > div:nth-child(4) > div:nth-child(2) > button")).Submit();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#step-0 > div.popover-navigation > button:nth-child(3)")).Click();
            driver.FindElement(By.Id("btn-start")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[8]/button/div[2]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SelectElement elementSelect = new SelectElement(driver.FindElement(By.Id("finalEstimate")));
            elementSelect.SelectByValue("7");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[1]/div[2]/button")).Click();

            string element = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[1]/div[2]/div/div/div[1]/div/div/div[2]")).Text.Substring(0);

            Assert.Equal("voted", element);

            driver.Quit();
        }

        [Fact]
        public void FibonacciMode_And_CoundDownMode()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(1) > a")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys("aaa098873@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("ababab.123");
            driver.FindElement(By.CssSelector("body > div.grayed > div > section > form.ng-dirty.ng-valid.ng-valid-required > div:nth-child(7) > div > button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div[3]/div[2]/div[2]/button")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("createRoomNameInput")).SendKeys("First Rooms - Fibonacci");
            SelectElement mode = new SelectElement(driver.FindElement(By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div.row.form-controls > div.col-sm-4 > div > select")));
            mode.SelectByValue("2");
            driver.FindElement(By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(8) > div.col-sm-8 > label > span > input")).Click();
            SelectElement time = new SelectElement(driver.FindElement(By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(8) > div.col-sm-4 > div > select")));
            time.SelectByValue("4");
            driver.FindElement(By.CssSelector("#createRoomModal > div > div > div.modal-body > div > div:nth-child(1) > button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.Name("inputName")).SendKeys("1\n2");
            driver.FindElement(By.CssSelector("#createStoryModal > div > div > form > div.modal-body > div:nth-child(4) > div:nth-child(2) > button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.Id("btn-start")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[4]/button/div[2]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            SelectElement finalEstimate = new SelectElement(driver.FindElement(By.Id("finalEstimate")));
            finalEstimate.SelectByValue("5");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[1]/div[2]/button")).Click();

            string finalResult = driver.FindElement(By.CssSelector("body > div.grayed > div > div.row > div > div > section > div > div:nth-child(2) > div:nth-child(2) > div.col-md-8 > div > section > div.vote-results > div.chart-block1 > div > div > div.col-sm-6.col-sm-offset-1.col-md-6.col-md-offset-0.col-lg-6.col-lg-offset-1.text-center > div > div > div.center-subtitle")).Text.Substring(0);

            Assert.Equal("voted", finalResult);

            driver.Quit();
        }

        [Fact]
        public void SignOut_Functionality()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(1) > a")).Click();
            driver.FindElement(By.Name("inputEmail")).SendKeys("aaa098873@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("ababab.123");
            driver.FindElement(By.CssSelector("body > div.grayed > div > section > form.ng-dirty.ng-valid.ng-valid-required > div:nth-child(7) > div > button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("profile-img")).Click();
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li.dropdown.open > ul > li:nth-child(5) > a")).Click();
            Thread.Sleep(4000);

            Assert.Equal("PlanITpoker: Online Scrum planning poker for Agile project teams", driver.Title);

            driver.Quit();
        }

        [Fact]
        public void PrivacyPolicy_Functionality()
        {
            driver.Navigate().GoToUrl("https://www.planitpoker.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("body > div.footer-home > footer > div > div.row.footer2 > div:nth-child(2) > div > a.link.first-link")).Click();

            Assert.Equal("PlanITpoker: Privacy Policy", driver.Title);

            driver.Quit();
        }




    }
}
