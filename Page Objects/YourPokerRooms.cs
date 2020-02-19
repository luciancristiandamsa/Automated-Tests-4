using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelTry.Page_Objects
{
    public class YourPokerRooms
    {
        IWebDriver driver;
        public static string roomName = "Test Room";
        By ImageProfile = By.Id("profile-img");
        By MyProfile = By.CssSelector("a[href *= '/board//#/profile']");
        By Rooms = By.CssSelector("a[href *= '/board//#/rooms']");
        By SignOut = By.CssSelector("a[href *= '/authentication/logout/']");
        By CreateRoom = By.ClassName("btn-create-room");
        By EnterNewRoomName = By.Id("createRoomNameInput");
        By CardSetType = By.ClassName("card-set-type");
        By PanelHeading = By.ClassName("panel-heading-text");
        By UseAllCards = By.CssSelector("#cardValues > div > div.row.all-cards > div > label > span.custom-checkbox.selected > input");
        By MarkSignForEnterStoriesInTheRoom = By.CssSelector("#cardValues > div > div.row.all-cards > div > label > span.custom-checkbox.selected > input");
        By MarkSignRequestConfirmationSkipStory = By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(4) > div > label > span > input");
        By MarkSignObserversSeeTheOthersVotes = By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(5) > div > label > span > input");
        By MarkSignAutoRevealWhenVoteIsComplete = By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(6) > div > label > span > input");
        By MarkSignAllowPlayersToChangeTheVoteAfterScoresShown = By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(7) > div > label > span > input");
        By MarkSignForCountDown = By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(8) > div.col-sm-8 > label > span > input");
        By ChooseTheTimeForCountdown = By.CssSelector("#createRoomModal > div > div > div.modal-body > form > div:nth-child(8) > div.col-sm-4 > div > select");
        By CreateButton = By.ClassName("btn-ok");
        By CancelButton = By.ClassName("btn-cancel");

        public YourPokerRooms(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnTheProfileImage()
        {
            driver.FindElement(ImageProfile).Click();
        }

        public void MyProfileAccount()
        {
            driver.FindElement(ImageProfile).Click();
            driver.FindElement(MyProfile).Click();
        }

        public void RoomsPage()
        {
            driver.FindElement(ImageProfile).Click();
            driver.FindElement(Rooms).Click();
        }

        public void SignOutFromAccount()
        {
            driver.FindElement(ImageProfile).Click();
            driver.FindElement(SignOut).Click();
        }

        public void ClickOnCreateRoom()
        {
            driver.FindElement(CreateRoom).Click();
        }

        public void EnterTheNewRoomName()
        {
            driver.FindElement(EnterNewRoomName).SendKeys(roomName);
        }

        public void CardSetTypeMode()
        {
            SelectElement cardType = new SelectElement(driver.FindElement(CardSetType));
            cardType.SelectByValue("2");
        }

        public void ClickOnTheMarkSignCountdown()
        {
            driver.FindElement(MarkSignForCountDown).Click();
        }

        public void InsertCountdown()
        {
            SelectElement timeForCountdown = new SelectElement(driver.FindElement(ChooseTheTimeForCountdown));
            timeForCountdown.SelectByValue("4");
        }

        public void ClickOnTheCreateButton()
        {
            driver.FindElement(CreateButton).Click();
        }
       

    }
}
