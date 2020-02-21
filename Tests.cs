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
        IWebDriver driver = new ChromeDriver();

        [Fact]
        public void VerifyLoginPageWithValidCredentials()
        {
            AccessURL url = new AccessURL(driver);
            url.AccessAndJoinTheURL();
            Thread.Sleep(3000);
            HomePage home = new HomePage(driver);
            home.ClickLogin();
            LoginPage login = new LoginPage(driver);
            login.LoginProcessTypeCredentials("aaa098873@gmail.com", "ababab.123");
            Thread.Sleep(7000);
            YourPokerRooms_VotingProcess room = new YourPokerRooms_VotingProcess(driver);
            room.ClickOnTheProfileImage();
            string element = driver.FindElement(By.ClassName("li-email")).Text.Substring(0);
            Assert.Equal("aaa098873@gmail.com", element);
            driver.Quit();
        }

        [Fact]
        [Obsolete]
        public void VerifyForgottenPassword()
        {
            AccessURL url = new AccessURL(driver);
            url.AccessAndJoinTheURL();
            Thread.Sleep(2000);
            HomePage home = new HomePage(driver);
            home.ClickLogin();
            LoginPage login = new LoginPage(driver);
            login.ClickForgottenPassword();
            RestorePasswordPage restore = new RestorePasswordPage(driver);
            restore.EntireProcessForRestore("aaa098873@gmail.com");
            Thread.Sleep(5000);
            bool finalResult = driver.FindElement(By.XPath("/html/body/div[1]/div/section/form/div[2]/div/div/div/span")).Displayed;
            Assert.True(finalResult);
            driver.Quit();
        }

        [Fact]
        public void VerifySignUpWithLinkedInAccount()
        {
            AccessURL url = new AccessURL(driver);
            url.AccessAndJoinTheURL();
            HomePage home = new HomePage(driver);
            home.ClickLogin();
            LoginPage login = new LoginPage(driver);
            login.ClickOnTheLinkedInIcon();
            Thread.Sleep(3000);
            Assert.Equal("LinkedIn Login, Sign in | LinkedIn", driver.Title);
            driver.Quit();
        }

        [Fact]
        public void LoginProcess()
        {
            AccessURL url = new AccessURL(driver);
            url.AccessAndJoinTheURL();
            HomePage home = new HomePage(driver);
            home.ClickLogin();
            LoginPage login = new LoginPage(driver);
            login.LoginProcessTypeCredentials("aaa098873@gmail.com", "ababab.123");
            Thread.Sleep(5000);
            driver.Quit();
        } 

        [Fact]
        public void SignUpProcess()
        {
            AccessURL url = new AccessURL(driver);
            url.AccessAndJoinTheURL();
            HomePage home = new HomePage(driver);
            home.ClickSignUp();
            SignUpPage signup = new SignUpPage(driver);
            signup.SignUpAllFields("aaa098873", "aaa098873@gmail.com", "ababab.123");
            Thread.Sleep(5000);
            string element = driver.FindElement(By.ClassName("li-name")).Text.Substring(0);
            Assert.Equal("aaa098873", element);
            driver.Quit();
            
        }

        [Fact]
        [Obsolete]
        public void FiboWithCoundown()
        {
            AccessURL url = new AccessURL(driver);
            url.AccessAndJoinTheURL();
            HomePage home = new HomePage(driver);
            home.ClickLogin();
            LoginPage login = new LoginPage(driver);
            login.LoginProcessTypeCredentials("aaa098873@gmail.com", "ababab.123");
            Thread.Sleep(5000);
            YourPokerRooms_VotingProcess room = new YourPokerRooms_VotingProcess(driver);

            // CardsTypeMode => 1 = Scrum, 2 = Fibonacci, 3 = Sequential, 4 = Playing cards, 5 = T-Shirt
            // Time => 0 = 30 seconds, 1 = 1 minute, 2 = 2 minutes, 3 = 3 minutes, 4 = 4 minutes, 5 = 5 minutes
            room.CreatingAndCustomizeTheRoom("First Room", "1", "3", "story", "?", "1_2");
            bool finish = driver.FindElement(By.XPath("/html/body/div[5]/div/div")).Displayed;
            Assert.True(finish);
            driver.Quit();


        }
        
    }
}
