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
        private readonly ChromeDriver driver;  
        private readonly WebDriverWait wait; 
         
        public Tests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.planitpoker.com");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Fact]
        public void LoginAndPlayOnScrumMode()
        {
            var home = new HomePage(driver);
            var login = home.ClickLogin();
            var room = login.LoginProcessTypeCredentials("aaa098873@gmail.com", "ababab.123");
            var createNewRoom = room.SetUpAndCreateNewRoom("First Room");
            var createNewStory = createNewRoom.VotingProcess("First Story");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='toast-message']")));
            bool assertionResult = driver.FindElementByXPath("//*[@class='toast-message']").Displayed;

            Assert.True(assertionResult); 
            driver.Quit();
        }

        [Fact]
        public void StartQuickPlay()
        {
            var home = new HomePage(driver);
            var login = home.ClickOnStartQuickPlay();
            var room = login.EnterTheName("Test");
            var createNewRoom = room.SetUpAndCreateNewRoom("First Room QuickPlay");
            var createNewStory = createNewRoom.VotingProcessQuickPlay("First QuickPlay Story");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='toast-message']")));
            bool assertionResult = driver.FindElementByXPath("//*[@class='toast-message']").Displayed;

            Assert.True(assertionResult);
            driver.Quit();
        }

        [Fact]
        public void SignUpWithValidCredentials()
        {
            var home = new HomePage(driver);
            var signup = home.ClickOnSignUp();
            var room = signup.FillUpAllFields("aaa098873", "aaa098873@gmail.com", "ababab.123");
            bool assertionResult = driver.FindElement(By.LinkText("Login")).Displayed;

            Assert.True(assertionResult);
            driver.Quit();
        }

        [Fact]
        public void SignUpUsingLinkedInAccount()
        {
            var home = new HomePage(driver);
            var login = home.ClickLogin();
            var linkedIn = login.ClickOnTheLinkedInIcon("test", "test");
            bool assertionResult = driver.FindElementByXPath("//*[@id='error-for-username']").Displayed;

            Assert.True(assertionResult);
            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void RestorePassword()
        {
            var home = new HomePage(driver);
            var login = home.ClickLogin();
            var restorePassword = login.ClickOnForgottenPassword("aaa098873@gmail.com");
            bool assertionResult = driver.FindElementByXPath("//*[@class='ng-binding']").Displayed;

            Assert.True(assertionResult);
            driver.Quit();
        }


        [Fact]
        [Obsolete]
        public void LoginAndPlayOnPlayingCardsMode()
        {
            var home = new HomePage(driver);
            var login = home.ClickLogin();
            var room = login.LoginProcessTypeCredentials("aaa098873@gmail.com", "ababab.123");
            var createNewRoom = room.SetUpAndCreateNewRoomWithDifferentModes("First Room");
            var createNewStory = createNewRoom.VotingProcess("First Story");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='toast-message']")));
            bool assertionResult = driver.FindElementByXPath("//*[@class='toast-message']").Displayed;

            Assert.True(assertionResult);
            driver.Quit();
        }

    }
}
