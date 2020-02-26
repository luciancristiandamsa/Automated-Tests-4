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


        [Obsolete]
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
                IWebElement ClickCreateRoom = driver.FindElementByXPath("//*[@class='btn btn-default btn-create-room btn-block']");
                ClickCreateRoom.Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("createRoomNameInput")));
                driver.FindElementById("createRoomNameInput").SendKeys(roomName);
                IWebElement element = driver.FindElementByClassName("btn-ok");
                element.Click();
            }
            
            return new CreateStoriesAndVotingProcess(driver);
        }

        
    }
}
