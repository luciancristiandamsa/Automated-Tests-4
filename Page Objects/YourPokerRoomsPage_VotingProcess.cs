using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            IWebElement element = driver.FindElementByClassName("btn-ok");
            element.Click();

            return new CreateStoriesAndVotingProcess(driver);
        }
    }
}
