using java.sql;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectModelTry.Page_Objects;
using System;
using System.Threading;
using Xunit;

namespace PageObjectModelTry
{
    public class Tests 
    {
        private readonly ChromeDriver driver;//
        private readonly WebDriverWait wait;
         
        public Tests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.planitpoker.com");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Fact]
        [Obsolete]
        public void LoginWithValidCredentials()
        {
            var home = new Home(driver);
            var login = home.ClickLoginPage();
            var rooms = login.LoginProcessTypeCredentials("aaa098873@gmail.com", "ababab.123");
            var createNewRoom = rooms.SetUpAndCreateNewRoom("First Room");
            var createNewStory = createNewRoom.VotingProcess("First Story");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[1]/div/div[1]/div[1]/div[4]")));
            bool alert = driver.FindElementByXPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[1]/div/div[1]/div[1]/div[4]").Displayed;
            Assert.True(alert);
            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void StartQuickPlay()
        {
            var home = new Home(driver);
            var login = home.ClickOnStartQuickPlay();
            var room = login.EnterTheName("Test");
            var createNewRoom = room.SetUpAndCreateNewRoom("First Room QuickPlay");
            var createNewStory = createNewRoom.VotingProcessQuickPlay("First QuickPlay Story");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[1]/div/div[1]/div[1]/div[4]")));
            bool alert = driver.FindElementByXPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[1]/div/div[1]/div[1]/div[4]").Displayed;
            Assert.True(alert);
            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void SignUpWithValidCredentials()
        {
            var home = new Home(driver);
            var signup = home.ClickOnSignUp();
            var room = signup.FillUpAllFields("aaa098873", "aaa098873@gmail.com", "ababab.123");
            bool element = driver.FindElement(By.LinkText("Login")).Displayed;

            Assert.True(element);
            driver.Quit();
        }
    }
}
