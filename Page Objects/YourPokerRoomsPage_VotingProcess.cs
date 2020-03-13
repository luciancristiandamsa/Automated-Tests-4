using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace PageObjectModelTry.Page_Objects
{
    public class YourPokerRoomsPage_VotingProcess
    {

        private readonly ChromeDriver driver;
        private readonly WebDriverWait wait;

        public YourPokerRoomsPage_VotingProcess(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        
        public CreateStoriesAndVotingProcess SetUpAndCreateNewRoom(string roomName)
        {
            Thread.Sleep(5000);
            bool quickPlayOrNotQuickPlay = driver.FindElementById("createRoomNameInput").Displayed;
            if (quickPlayOrNotQuickPlay)
            {
                driver.FindElementById("createRoomNameInput").SendKeys(roomName);
                IWebElement element = driver.FindElementByClassName("btn-ok");
                element.Click();
            }
            else
            {
                IWebElement ClickCreateRoom = driver.FindElementByXPath("//*[text()='Create Room']");
                ClickCreateRoom.Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("createRoomNameInput")));
                driver.FindElementById("createRoomNameInput").SendKeys(roomName);
                IWebElement element = driver.FindElementByClassName("btn-ok");
                element.Click();
            }
            
            return new CreateStoriesAndVotingProcess(driver);
        }

        public CreateStoriesAndVotingProcess SetUpAndCreateNewRoomWithDifferentModes(string roomName)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='Create Room']")));
            IWebElement ClickCreateRoom = driver.FindElementByXPath("//*[text()='Create Room']");
            ClickCreateRoom.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("createRoomNameInput")));
            driver.FindElementById("createRoomNameInput").SendKeys(roomName);
            SelectElement selectCardsMode = new SelectElement(driver.FindElementByXPath("//select[contains(@class, 'card-set-type')]"));
            selectCardsMode.SelectByValue("4");
            IWebElement clickOnCoundownTimer = driver.FindElementByXPath("//*[text()=' Do you want to use a countdown timer?']");
            clickOnCoundownTimer.Click();
            SelectElement selectCountdownTime = new SelectElement(driver.FindElementByXPath("//*[@ng-model='countdownTimerValue']"));
            selectCountdownTime.SelectByValue("4");
            IWebElement clickOnCreate = driver.FindElementByClassName("btn-ok");
            clickOnCreate.Click();

            return new CreateStoriesAndVotingProcess(driver);
        }

        public CreateStoriesAndVotingProcess SetUpAndCreateNewRoomWithFourCards(string roomName)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("createRoomNameInput")));
            driver.FindElementById("createRoomNameInput").SendKeys(roomName);
            SelectElement selectCardsMode = new SelectElement(driver.FindElementByXPath("//select[contains(@class, 'card-set-type')]"));
            selectCardsMode.SelectByValue("2");
            IWebElement clickOnCustomizeCards = driver.FindElementByXPath("//*[contains(text(), 'Customize cards values')]");
            clickOnCustomizeCards.Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("#cardValues > div > div:nth-child(3) > div")));
            IWebElement clickOnOne = driver.FindElementByCssSelector("#cardValues > div > div:nth-child(3) > div > div:nth-child(2) > label > span.custom-checkbox > input");
            clickOnOne.Click();
            IWebElement clickOnTwo = driver.FindElementByCssSelector("#cardValues > div > div:nth-child(3) > div > div:nth-child(3) > label > span.custom-checkbox > input");
            clickOnTwo.Click();
            IWebElement clickOnThree = driver.FindElementByCssSelector("#cardValues > div > div:nth-child(3) > div > div:nth-child(4) > label > span.custom-checkbox > input");
            clickOnThree.Click();
            IWebElement clickOnCofee = driver.FindElementByCssSelector("#cardValues > div > div:nth-child(3) > div > div:nth-child(13) > label > span.custom-checkbox > input");
            clickOnCofee.Click();
            IWebElement clickOnAllowPlayerToVoteAfterScoresDown = driver.FindElementByXPath("//input[contains(@ng-model, 'createForm.changeVote')]");
            clickOnAllowPlayerToVoteAfterScoresDown.Click();
            IWebElement clickOnCreate = driver.FindElementByClassName("btn-ok");
            clickOnCreate.Click();

            return new CreateStoriesAndVotingProcess(driver);
        }
    }
}
