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
        [Fact]
        public void VerifyLoginPageWithValidCredentials()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.planitpoker.com");
            HomePage home = new HomePage(driver);
            home.LoginFromHomePage();
            LoginPage login = new LoginPage(driver);
            login.ValidTypeUserEmail();
            login.ValidTypePassword();
            login.ClickLoginButton();
            Thread.Sleep(7000);
            YourPokerRooms room = new YourPokerRooms(driver);
            room.ClickOnTheProfileImage();
            string element = driver.FindElement(By.ClassName("li-email")).Text.Substring(0);
            Assert.Equal(LoginPage.validEmail , element);
            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void VerifyForgottenPassword()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/authentication/");
            LoginPage login = new LoginPage(driver);
            login.ClickForgottenPassword();
            RestorePasswordPage restore = new RestorePasswordPage(driver);
            restore.InsertTheEmail();
            restore.ClickOnTheRestorePasswordButton();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[1]/div/section/form/div[2]/div/div/div/span")));
            Thread.Sleep(5000);
            bool finalResult = driver.FindElement(By.XPath("/html/body/div[1]/div/section/form/div[2]/div/div/div/span")).Displayed;
            Assert.True(finalResult);
            driver.Quit();
        }

        [Fact]
        public void VerifySignUpWithLinkedInAccount()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.planitpoker.com/authentication/");
            LoginPage login = new LoginPage(driver);
            login.LoginWIthLinkedInAccount();
            Thread.Sleep(3000);
            Assert.Equal("LinkedIn Login, Sign in | LinkedIn", driver.Title);
            driver.Quit();
        }

        [Fact]
        public void VerifyFibonacciModeWithCounddown()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.planitpoker.com");
            HomePage home = new HomePage(driver);
            home.LoginFromHomePage();
            LoginPage login = new LoginPage(driver);
            login.ValidTypeUserEmail();
            login.ValidTypePassword();
            login.ClickLoginButton();
            Thread.Sleep(7000);
            YourPokerRooms rooms = new YourPokerRooms(driver);
            rooms.ClickOnCreateRoom();
            Thread.Sleep(5000);
            rooms.EnterTheNewRoomName();
            rooms.CardSetTypeMode();
            rooms.ClickOnTheMarkSignCountdown();
            rooms.InsertCountdown();
            rooms.ClickOnTheCreateButton();
            Thread.Sleep(5000);
            CreatedRoomAndVoting voting = new CreatedRoomAndVoting(driver);
            voting.TypeTheStoryName();
            voting.ClickOnTheSaveAndCloseButton();
            Thread.Sleep(3000);
            voting.ClickOnTheStartButton();
            Thread.Sleep(3000);
            voting.ClickOnTheCard_13();
            Thread.Sleep(3000);
            voting.ClickOnFinalEstimate();
            voting.SelectFinalEstimate();
            voting.ClickOnFinishButton();
            string finalAssert = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[1]/div/div[1]/div[1]/div[4]")).GetAttribute("ng-show");
            Assert.Equal("!!statusMessage.closed", finalAssert);
            driver.Quit();

        }
        
    }
}
