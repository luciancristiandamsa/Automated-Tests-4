using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectModelTry.Page_Objects
{
    public class YourPokerRooms_VotingProcess
    {
        IWebDriver driver;
        By ImageProfile = By.Id("profile-img");
        By MyProfile = By.CssSelector("a[href *= '/board//#/profile']");
        By Rooms = By.CssSelector("a[href *= '/board//#/rooms']");
        By SignOut = By.CssSelector("a[href *= '/authentication/logout/']");
        By CreateNewRoom = By.ClassName("btn-create-room");
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

        // CreatedRoomAndVotingProcess

        By StoryName = By.Name("inputName");
        By SaveAndAddNewButton = By.CssSelector("#createStoryModal > div > div > form > div.modal-body > div:nth-child(4) > div:nth-child(1) > button");
        By SaveAndCloseButton = By.CssSelector("#createStoryModal > div > div > form > div.modal-body > div:nth-child(4) > div:nth-child(2) > button");
        By UploadButton = By.CssSelector("#createStoryModal > div > div > form > div.modal-body > div:nth-child(4) > div:nth-child(3) > div > span");
        By CancelButton1 = By.CssSelector("#createStoryModal > div > div > form > div.modal-body > div:nth-child(4) > div:nth-child(4) > button");
        By StartButton = By.Id("btn-start");
        By DropDownThePlayersTypeOnClick = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[1]/div/div[3]/div/div/div[1]/div/div/img");
        By ChooseModeratorType = By.ClassName("moderator");
        By ChoosePlayerType = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[1]/div/div[3]/div/div/div[1]/div/ul/li[2]/a");
        By ChooseObserverType = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[1]/div/div[3]/div/div/div[1]/div/ul/li[3]/a");
        By InviteTeamMateLink = By.Id("invite-link-container");
        By ActiveStoriesField = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/section/div/div[1]/div/div/ul/li[1]/a/span[1]");
        By CompletedStoriesField = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/section/div/div[1]/div/div/ul/li[2]/a/span[1]");
        By AllStoriesField = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/section/div/div[1]/div/div/ul/li[3]/a/span[1]");
        By NewStoryButton = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/section/div/div[1]/div/div/ul/li[4]/div[1]/button/span");
        By EditStoriesButton = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/section/div/div[1]/div/div/ul/li[4]/div[2]/button/span");
        By ExportStoriesFromEditButton = By.CssSelector("a[href *= '/board/exportstories//463106']");
        By CustomizeStoriesFromEditButton = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/section/div/div[1]/div/div/ul/li[4]/div[2]/ul/li[2]/a");
        // Scrum Cards
        By Card_0 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[1]/button/div[2]");
        By Card_1_2 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[2]/button/div[2]");
        By Card_1 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[3]/button/div[2]");
        By Card_2 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[4]/button/div[2]");
        By Card_3 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[5]/button/div[2]");
        By Card_5 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[6]/button/div[2]");
        By Card_8 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[7]/button/div[2]");
        By Card_13 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[8]/button/div[2]");
        By Card_20 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[9]/button/div[2]");
        By Card_40 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[10]/button/div[2]");
        By Card_100 = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[11]/button/div[2]");
        By Card_QuestionMark = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[12]/button/div[2]");
        By Card_Cofee = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[13]/button/div[2]/img[1]");

        By asd = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[8]/button/div[2]/img[1]");

        By FindOutMoreButton = By.CssSelector("a[href *= 'https://www.codefirst.co.uk/hire-developers']");
        By ResetTimeButton = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[2]/div/div[1]/button");
        By FlipCardsButton = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[2]/div/div[2]/button");
        By ClearVotesButton = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[2]/div/div[3]/button");
        By SkipStoryButton = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[2]/div/div[4]/button");
        By NextStoryButton = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[2]/div/div[4]/button");
        By FinalEstimateDropDown = By.Id("finalEstimate");
        By FinishVotingButton = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[1]/div[2]/button/span");
        By ChangeTheRoomName = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[1]/div/div/div/div");
        By MarkSignAfterRoomsOrStorysNameChanged_Ok = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[1]/div/div/div/span/div/form/div/div[1]/div[2]/button[1]/i");
        By MarkSignAfterRoomsNameOrStorysChanged_Cancel = By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[1]/div/div/div/span/div/form/div/div[1]/div[2]/button[2]/i");
        By ChangeTheStoryName = By.Id("storyEditable");
        By MessageAlertCreatedNewStory = By.ClassName("toast-message");

        public YourPokerRooms_VotingProcess(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnTheProfileImage()
        {
            driver.FindElement(ImageProfile).Click();
        }

        [Obsolete]
        public void CreatingAndCustomizeTheRoom(string roomName, string cardsTypeMode, string time, string storyName, string choosenCard, string finalEstimate)
        {
            driver.FindElement(CreateNewRoom).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(EnterNewRoomName));
            driver.FindElement(EnterNewRoomName).SendKeys(roomName);
            SelectElement cardType = new SelectElement(driver.FindElement(CardSetType));
            cardType.SelectByValue(cardsTypeMode);
            driver.FindElement(MarkSignForCountDown).Click();
            SelectElement timeForCountdown = new SelectElement(driver.FindElement(ChooseTheTimeForCountdown));
            timeForCountdown.SelectByValue(time);
            driver.FindElement(CreateButton).Click();


            wait.Until(ExpectedConditions.ElementToBeClickable(StoryName));
            driver.FindElement(StoryName).SendKeys(storyName);
            driver.FindElement(SaveAndCloseButton).Click();
            wait.Until(ExpectedConditions.ElementExists(StartButton));
            Thread.Sleep(4000);
            driver.FindElement(StartButton).Click();
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(MessageAlertCreatedNewStory));
            Thread.Sleep(4000);
            if (cardsTypeMode == "1")   // Scrum
            {
                switch (choosenCard)
                {
                    case "0":
                        driver.FindElement(Card_0).Click();
                        break;
                    case "1_2":
                        driver.FindElement(Card_1_2).Click();
                        break;
                    case "1":
                        driver.FindElement(Card_1).Click();
                        break;
                    case "2":
                        driver.FindElement(Card_2).Click();
                        break;
                    case "3":
                        driver.FindElement(Card_3).Click();
                        break;
                    case "5":
                        driver.FindElement(Card_5).Click();
                        break;
                    case "8":
                        driver.FindElement(Card_8).Click();
                        break;
                    case "13":
                        driver.FindElement(Card_13).Click();
                        break;
                    case "20":
                        driver.FindElement(Card_20).Click();
                        break;
                    case "40":
                        driver.FindElement(Card_40).Click();
                        break;
                    case "100":
                        driver.FindElement(Card_100).Click();
                        break;
                    case "?":
                        driver.FindElement(Card_QuestionMark).Click();
                        break;
                    case "cofee":
                        driver.FindElement(Card_Cofee).Click();
                        break;
                }
            }

            else if (cardsTypeMode == "2")  // Fibonacci
            {
                switch (choosenCard)
                {
                    case "0":
                        driver.FindElement(Card_0).Click();
                        break;
                    case "1":
                        driver.FindElement(Card_1_2).Click();
                        break;
                    case "2":
                        driver.FindElement(Card_1).Click();
                        break;
                    case "3":
                        driver.FindElement(Card_2).Click();
                        break;
                    case "5":
                        driver.FindElement(Card_3).Click();
                        break;
                    case "8":
                        driver.FindElement(Card_5).Click();
                        break;
                    case "13":
                        driver.FindElement(Card_8).Click();
                        break;
                    case "21":
                        driver.FindElement(Card_13).Click();
                        break;
                    case "34":
                        driver.FindElement(Card_20).Click();
                        break;
                    case "55":
                        driver.FindElement(Card_40).Click();
                        break;
                    case "89":
                        driver.FindElement(Card_100).Click();
                        break;
                    case "?":
                        driver.FindElement(Card_QuestionMark).Click();
                        break;
                    case "cofee":
                        driver.FindElement(Card_Cofee).Click();
                        break;
                }
            }

            else if (cardsTypeMode == "3")  // Sequential
            {
                switch (choosenCard)
                {
                    case "0":
                        driver.FindElement(Card_0).Click();
                        break;
                    case "1":
                        driver.FindElement(Card_1_2).Click();
                        break;
                    case "2":
                        driver.FindElement(Card_1).Click();
                        break;
                    case "3":
                        driver.FindElement(Card_2).Click();
                        break;
                    case "4":
                        driver.FindElement(Card_3).Click();
                        break;
                    case "5":
                        driver.FindElement(Card_5).Click();
                        break;
                    case "6":
                        driver.FindElement(Card_8).Click();
                        break;
                    case "7":
                        driver.FindElement(Card_13).Click();
                        break;
                    case "8":
                        driver.FindElement(Card_20).Click();
                        break;
                    case "9":
                        driver.FindElement(Card_40).Click();
                        break;
                    case "10":
                        driver.FindElement(Card_100).Click();
                        break;
                    case "?":
                        driver.FindElement(Card_QuestionMark).Click();
                        break;
                    case "cofee":
                        driver.FindElement(Card_Cofee).Click();
                        break;
                }
            }

            else if (cardsTypeMode == "4")  // Playing cards
            {
                switch (choosenCard)
                {
                    case "ace":
                        driver.FindElement(Card_0).Click();
                        break;
                    case "2":
                        driver.FindElement(Card_1_2).Click();
                        break;
                    case "3":
                        driver.FindElement(Card_1).Click();
                        break;
                    case "5":
                        driver.FindElement(Card_2).Click();
                        break;
                    case "8":
                        driver.FindElement(Card_3).Click();
                        break;
                    case "king":
                        driver.FindElement(Card_5).Click();
                        break;
                    case "?":
                        driver.FindElement(Card_8).Click();
                        break;
                    case "cofee":
                        driver.FindElement(Card_13).Click();
                        break;
                }
            }

            else if (cardsTypeMode == "5")  // T-Shirt
            {
                switch (choosenCard)
                {
                    case "xs":
                        driver.FindElement(Card_0).Click();
                        break;
                    case "s":
                        driver.FindElement(Card_1_2).Click();
                        break;
                    case "m":
                        driver.FindElement(Card_1).Click();
                        break;
                    case "l":
                        driver.FindElement(Card_2).Click();
                        break;
                    case "xl":
                        driver.FindElement(Card_3).Click();
                        break;
                    case "xxl":
                        driver.FindElement(Card_5).Click();
                        break;
                    case "?":
                        driver.FindElement(Card_8).Click();
                        break;
                    case "cofee":
                        driver.FindElement(Card_13).Click();
                        break;
                }
            }

            Thread.Sleep(4000);
            if (cardsTypeMode == "1")   // Scrum
            {
                switch (finalEstimate)
                {
                    case "0":
                        SelectElement estimate0 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate0.SelectByValue("0");
                        break;
                    case "1_2":
                        SelectElement estimate1_2 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate1_2.SelectByValue("1");
                        break;
                    case "1":
                        SelectElement estimate1 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate1.SelectByValue("2");
                        break;
                    case "2":
                        SelectElement estimate2 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate2.SelectByValue("3");
                        break;
                    case "3":
                        SelectElement estimate3 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate3.SelectByValue("4");
                        break;
                    case "5":
                        SelectElement estimate5 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate5.SelectByValue("5");
                        break;
                    case "8":
                        SelectElement estimate8 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate8.SelectByValue("6");
                        break;
                    case "13":
                        SelectElement estimate13 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate13.SelectByValue("7");
                        break;
                    case "20":
                        SelectElement estimate20 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate20.SelectByValue("8");
                        break;
                    case "40":
                        SelectElement estimate40 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate40.SelectByValue("9");
                        break;
                    case "100":
                        SelectElement estimate100 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate100.SelectByValue("10");
                        break;
                    case "?":
                        SelectElement estimateQuestionMark = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimateQuestionMark.SelectByValue("-1");
                        break;
                    case "cofee":
                        SelectElement estimateCofee = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimateCofee.SelectByValue("-2");
                        break;
                }

            }

            else if (cardsTypeMode == "2")   // Fibonacci
            {
                switch (finalEstimate)
                {
                    case "0":
                        SelectElement estimate0 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate0.SelectByValue("0");
                        break;
                    case "1":
                        SelectElement estimate1 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate1.SelectByValue("1");
                        break;
                    case "2":
                        SelectElement estimate2 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate2.SelectByValue("2");
                        break;
                    case "3":
                        SelectElement estimate3 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate3.SelectByValue("3");
                        break;
                    case "5":
                        SelectElement estimate5 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate5.SelectByValue("4");
                        break;
                    case "8":
                        SelectElement estimate8 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate8.SelectByValue("5");
                        break;
                    case "13":
                        SelectElement estimate13 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate13.SelectByValue("6");
                        break;
                    case "21":
                        SelectElement estimate21 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate21.SelectByValue("7");
                        break;
                    case "34":
                        SelectElement estimate34 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate34.SelectByValue("8");
                        break;
                    case "55":
                        SelectElement estimate55 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate55.SelectByValue("9");
                        break;
                    case "89":
                        SelectElement estimate89 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate89.SelectByValue("10");
                        break;
                    case "?":
                        SelectElement estimateQuestionMark = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimateQuestionMark.SelectByValue("-1");
                        break;
                    case "cofee":
                        SelectElement estimateCofee = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimateCofee.SelectByValue("-2");
                        break;
                }
            }

            else if (cardsTypeMode == "3")   // Sequential
            {
                switch (finalEstimate)
                {
                    case "0":
                        SelectElement estimate0 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate0.SelectByValue("0");
                        break;
                    case "1":
                        SelectElement estimate1 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate1.SelectByValue("1");
                        break;
                    case "2":
                        SelectElement estimate2 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate2.SelectByValue("2");
                        break;
                    case "3":
                        SelectElement estimate3 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate3.SelectByValue("3");
                        break;
                    case "4":
                        SelectElement estimate5 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate5.SelectByValue("4");
                        break;
                    case "5":
                        SelectElement estimate8 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate8.SelectByValue("5");
                        break;
                    case "6":
                        SelectElement estimate13 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate13.SelectByValue("6");
                        break;
                    case "7":
                        SelectElement estimate21 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate21.SelectByValue("7");
                        break;
                    case "8":
                        SelectElement estimate34 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate34.SelectByValue("8");
                        break;
                    case "9":
                        SelectElement estimate55 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate55.SelectByValue("9");
                        break;
                    case "10":
                        SelectElement estimate89 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate89.SelectByValue("10");
                        break;
                    case "?":
                        SelectElement estimateQuestionMark = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimateQuestionMark.SelectByValue("-1");
                        break;
                    case "cofee":
                        SelectElement estimateCofee = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimateCofee.SelectByValue("-2");
                        break;
                }
            }

            else if (cardsTypeMode == "4")   // Playing cards
            {
                switch (finalEstimate)
                {
                    case "ace":
                        SelectElement estimate0 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate0.SelectByValue("0");
                        break;
                    case "2":
                        SelectElement estimate1 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate1.SelectByValue("1");
                        break;
                    case "3":
                        SelectElement estimate2 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate2.SelectByValue("2");
                        break;
                    case "5":
                        SelectElement estimate3 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate3.SelectByValue("3");
                        break;
                    case "8":
                        SelectElement estimate5 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate5.SelectByValue("4");
                        break;
                    case "king":
                        SelectElement estimate8 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate8.SelectByValue("5");
                        break;
                    case "?":
                        SelectElement estimate13 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate13.SelectByValue("6");
                        break;
                    case "cofee":
                        SelectElement estimate21 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate21.SelectByValue("7");
                        break;
                }
            }

            else if (cardsTypeMode == "5")   // T-Shirt
            {
                switch (finalEstimate)
                {
                    case "xs":
                        SelectElement estimate0 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate0.SelectByValue("0");
                        break;
                    case "s":
                        SelectElement estimate1 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate1.SelectByValue("1");
                        break;
                    case "m":
                        SelectElement estimate2 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate2.SelectByValue("2");
                        break;
                    case "l":
                        SelectElement estimate3 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate3.SelectByValue("3");
                        break;
                    case "xl":
                        SelectElement estimate5 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate5.SelectByValue("4");
                        break;
                    case "xxl":
                        SelectElement estimate8 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate8.SelectByValue("5");
                        break;
                    case "?":
                        SelectElement estimate13 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate13.SelectByValue("6");
                        break;
                    case "cofee":
                        SelectElement estimate21 = new SelectElement(driver.FindElement(FinalEstimateDropDown));
                        estimate21.SelectByValue("7");
                        break;
                }
            }

            wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[5]/div/div")));
            driver.FindElement(FinishVotingButton).Click();







        }
    }
}
