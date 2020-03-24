using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace PageObjectModelTry
{
    public class Tests
    {
        private readonly ChromeDriver driver;
        private readonly WebDriverWait wait;

        public Tests()
        {
            this.driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.planitpoker.com");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Fact]
        public void LoginAndPlayOnScrumMode()
        {
            var home = new HomePage(driver);
            var login = home.ClickLogin();
            var room = login.LoginProcessWithValidCredentials("aaa098873@gmail.com", "ababab.123");
            var createNewRoom = room.SetUpAndCreateNewRoom("First Room");
            var createNewStory = createNewRoom.VotingProcess("First Story");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='toast-message']")));

            Assert.True(createNewStory.TitleRoom());
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

            Assert.True(createNewStory.TitleRoom());
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
        public void LoginAndPlayOnPlayingCardsMode()
        {
            var home = new HomePage(driver);
            var login = home.ClickLogin();
            var room = login.LoginProcessWithValidCredentials("aaa098873@gmail.com", "ababab.123");
            var createNewRoom = room.SetUpAndCreateNewRoomWithDifferentModes("First Room");
            var createNewStory = createNewRoom.VotingProcess("First Story");
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='toast-message']")));

            Assert.True(createNewStory.TitleRoom());
            driver.Quit();
        }

        [Fact]
        public void StartQuickPlayWithFourCardsInFibonacciMode()
        {
            var home = new HomePage(driver);
            var login = home.ClickOnStartQuickPlay();
            var room = login.EnterTheName("Test");
            var createNewRoom = room.SetUpAndCreateNewRoomWithFourCards("First Room");
            var createNewStory = createNewRoom.VotingProcessQuickPlay("First Story");

            Assert.True(createNewStory.TitleRoom());
            driver.Quit();
        }

        [Fact]
        public void StartQuickPlayAndPutPlayerOnObserverMode()
        {
            var home = new HomePage(driver);
            var login = home.ClickOnStartQuickPlay();
            var room = login.EnterTheName("Test");
            var createNewRoom = room.SetUpAndCreateNewRoom("First Room QuickPlay");
            var createNewStory = createNewRoom.VotingProcessQuickPlayOnObserverMode("First QuickPlay Story");

            Assert.True(createNewStory.TitleRoom());
            driver.Quit();
        }
        [Fact]
        public void PlayingWithTwoPlayers()
        {
            var home = new HomePage(driver);
            var login = home.ClickLogin();
            var room = login.LoginProcessWithValidCredentials("aaa098873@gmail.com", "ababab.123");
            var createNewRoom = room.SetUpAndCreateNewRoom("First Room");
            var createNewStory = createNewRoom.VotingProcessWithTwoPlayers("First Story", "Player");

            Assert.True(createNewStory.TitleRoom());
            driver.Quit();
        }

        [Fact]
        public void DoNotRememberMyAccountAfterCloseTheWindow()
        {
            var home = new HomePage(driver);
            var login = home.ClickLogin();
            var room = login.LoginProcessWithValidCredentials("aaa098873@gmail.com", "ababab.123");
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[text()='Recent Rooms']")));
            driver.Close();
            IWebDriver driver1 = new ChromeDriver();
            driver1.Navigate().GoToUrl("https://www.planitpoker.com");

            bool elementVisible = driver1.FindElement(By.XPath("//a[text()='Login']")).Displayed;
            driver1.Close();

            Assert.True(elementVisible);
        }

        [Fact]
        public void StartQuickPlayWithTwoPlayersAndCountdownTimer()
        {
            var home = new HomePage(driver);
            string assert = home.Title();
            var login = home.ClickOnStartQuickPlay();
            var room = login.EnterTheName("First Player");
            var createNewRoom = room.SetUpAndCreateNewRoomWithCountdown("First Room");
            var createNewStory = createNewRoom.VotingProcessQuickPlayWithTwoPlayers("First Story", "Second Player");

            Assert.Equal("PlanITpoker: Online Scrum planning poker for Agile project teams", assert);
            driver.Quit();
        }

        [Fact]
        public void StratQuickPlayWithAplayerAndAnObserver()
        {
            var home = new HomePage(driver);
            var login = home.ClickOnStartQuickPlay();
            var room = login.EnterTheName("aaa098873@gmail.com");
            var createNewRoom = room.SetUpAndCreateNewRoomWithCountdown("First Room");
            var createNewStory = createNewRoom.VotingProcessQuickPlayWithAplayerAndAnObserver("First Story", "Second Player");

            Assert.Equal(createNewStory.ChangedOnObserverMode(), createNewStory.TitleRoom());
            driver.Quit();
        }

        [Fact]
        public void StartQuickPlayWithAplayerAndAfterRemoveHimFromGame()
        {
            var home = new HomePage(driver);
            var login = home.ClickOnStartQuickPlay();
            var room = login.EnterTheName("First Player");
            var createNewRoom = room.SetUpAndCreateNewRoom("First Room");
            var createNewStory = createNewRoom.VotingProcessQuickPlayWithAplayerAndAfeterRemoveHim("First Story", "Second Player");

            Assert.True(createNewStory.TitleRoom());
            driver.Quit();
        }

        [Fact]
        public void StartQuickPlayAndAddAnewStoriesFromCSVFile()
        {
            var home = new HomePage(driver);
            var login = home.ClickOnStartQuickPlay();
            var room = login.EnterTheName("First Player");
            var createNewRoom = room.SetUpAndCreateNewRoom("First Room");
            var createNewStory = createNewRoom.VotingProcessQuickPlayAndUploadCSVFile("First Story");

            Assert.True(createNewRoom.TitleRoom());
            driver.Quit();
        }

        [Fact]
        public void ChangeTheProfileImage()
        {
            var home = new HomePage(driver);
            var login = home.ClickLogin();
            var room = login.LoginProcessWithValidCredentials("aaa098873@gmail.com", "ababab.123");
            var createNewRoom = room.EnterInMyProfile();
            var changeTheImage = createNewRoom.ChangeTheProfileImage();

            driver.Quit();

        }
    }
}
