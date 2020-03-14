using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace PageObjectModelTry.Page_Objects
{
    public class CreateStoriesAndVotingProcess
    {
        private readonly ChromeDriver driver;
        private readonly WebDriverWait wait;

        public CreateStoriesAndVotingProcess(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public CreateStoriesAndVotingProcess VotingProcess(string storyName)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));
            driver.FindElementByName("inputName").SendKeys(storyName);
            IWebElement ClickSaveAndClose = driver.FindElementByXPath("//*[@ng-bs-click='createAndClose']");
            ClickSaveAndClose.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn-start")));
            IWebElement clickStart = driver.FindElementById("btn-start");
            clickStart.Click();                                                                    
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@ng-bs-click, 'resetTimer')]")));
            IWebElement clickOnTheCard = driver.FindElementByXPath("//*[text()='2']");
            clickOnTheCard.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));
            SelectElement element = new SelectElement(driver.FindElementById("finalEstimate"));
            element.SelectByValue("2");
            IWebElement clickOnFinish = driver.FindElementByXPath("//*[@ng-bs-click='finish']");
            clickOnFinish.Click();

            return new CreateStoriesAndVotingProcess(driver);
        }

        public CreateStoriesAndVotingProcess VotingProcessQuickPlay(string storyName)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));
            driver.FindElementByName("inputName").SendKeys(storyName);
            IWebElement ClickSaveAndClose = driver.FindElementByXPath("//*[@ng-bs-click='createAndClose']");
            ClickSaveAndClose.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@data-role='end']")));
            IWebElement clickEndTour = driver.FindElementByXPath("//*[@data-role='end']");
            clickEndTour.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn-start")));
            IWebElement clickStart = driver.FindElementById("btn-start");
            clickStart.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@ng-bs-click, 'resetTimer')]")));
            IWebElement clickOnTheCard = driver.FindElementByXPath("//*[text()='2']");
            clickOnTheCard.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));
            SelectElement element = new SelectElement(driver.FindElementById("finalEstimate"));
            element.SelectByValue("3");
            driver.FindElementByClassName("btn-one").Click();

            return new CreateStoriesAndVotingProcess(driver);
        }

        public CreateStoriesAndVotingProcess VotingProcessQuickPlayOnObserverMode(string storyName)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));
            driver.FindElementByName("inputName").SendKeys(storyName);
            IWebElement ClickSaveAndClose = driver.FindElementByXPath("//*[@ng-bs-click='createAndClose']");
            ClickSaveAndClose.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@data-role='end']")));
            IWebElement clickEndTour = driver.FindElementByXPath("//*[@data-role='end']");
            clickEndTour.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@class='img-border dropdown-toggle']")));
            IWebElement clickOnProfileImage = driver.FindElementByXPath("//*[@class='img-border dropdown-toggle']");
            clickOnProfileImage.Click();
            IWebElement clickOnObserver = driver.FindElementByXPath("//*[text()='Observer ']");
            clickOnObserver.Click();
            IWebElement clickStart = driver.FindElementById("btn-start");
            clickStart.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));
            SelectElement element = new SelectElement(driver.FindElementById("finalEstimate"));
            element.SelectByValue("3");
            driver.FindElementByClassName("btn-one").Click();

            return new CreateStoriesAndVotingProcess(driver);
        }

        public CreateStoriesAndVotingProcess VotingProcessWithTwoPlayers(string storyName, string playerName)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));
            driver.FindElementByName("inputName").SendKeys(storyName);
            IWebElement ClickSaveAndClose = driver.FindElementByXPath("//*[@ng-bs-click='createAndClose']");
            ClickSaveAndClose.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("invite-link")));
            IWebElement ClickOnTheLink = driver.FindElementById("invite-link");
            ClickOnTheLink.Click();
            IWebElement CopyLink = driver.FindElementById("invite-link");
            CopyLink.SendKeys(Keys.Control + "c");
            Thread.Sleep(4000);
            driver.FindElementByXPath("//*[@class='game-name']").Click();
            IWebElement ClickToSelectTheField = driver.FindElementByXPath("//*[@class='form-control input-sm']");
            ClickToSelectTheField.SendKeys(Keys.Control + "a");
            IWebElement PasteLink = driver.FindElementByXPath("//*[@class='form-control input-sm']");
            PasteLink.SendKeys(Keys.Control + "v");
            driver.FindElementByXPath("//*[@class='btn btn-primary btn-sm editable-submit']").Click();
            string linkToAccess = driver.FindElementByXPath("//div[contains(@class, 'page-header')]").Text.Substring(0);

            IWebDriver driver1;
            driver1 = new ChromeDriver();
            driver1.Navigate().GoToUrl(linkToAccess);
            driver1.Manage().Window.FullScreen();
            driver1.FindElement(By.Name("inputName")).SendKeys(playerName);
            IWebElement ClickOnEnterButton = driver1.FindElement(By.XPath("//button[@type='submit']"));
            ClickOnEnterButton.Click();
            Thread.Sleep(3000);
            driver1.Manage().Window.Minimize();
            driver.Manage().Window.FullScreen();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn-start")));
            IWebElement clickStart = driver.FindElementById("btn-start");
            clickStart.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='3']")));
            driver.Manage().Window.Minimize();
            driver1.Manage().Window.FullScreen();
            IWebElement clickOnTheCardPlayer = driver1.FindElement(By.XPath("//*[text()='3']"));
            clickOnTheCardPlayer.Click();
            driver1.Manage().Window.Minimize();
            driver.Manage().Window.FullScreen();
            IWebElement clickOnTheCardModerator = driver.FindElement(By.XPath("//*[text()='2']"));
            clickOnTheCardModerator.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));
            SelectElement element = new SelectElement(driver.FindElementById("finalEstimate"));
            element.SelectByValue("3");
            Thread.Sleep(5000);
            IWebElement clickOnFinish = driver.FindElementByXPath("//*[@ng-bs-click='finish']");
            clickOnFinish.Click();
            driver1.Quit();

            return new CreateStoriesAndVotingProcess(driver);
        }

        public CreateStoriesAndVotingProcess VotingProcessQuickPlayWithAnotherPlayer(string storyName, string playerName)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));
            driver.FindElementByName("inputName").SendKeys(storyName);
            IWebElement ClickSaveAndClose = driver.FindElementByXPath("//*[@ng-bs-click='createAndClose']");
            ClickSaveAndClose.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@data-role='end']")));
            IWebElement clickEndTour = driver.FindElementByXPath("//*[@data-role='end']");
            clickEndTour.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("invite-link")));
            IWebElement ClickOnTheLink = driver.FindElementById("invite-link");
            ClickOnTheLink.Click();
            IWebElement CopyLink = driver.FindElementById("invite-link");
            CopyLink.SendKeys(Keys.Control + "c");
            Thread.Sleep(4000);
            driver.FindElementByXPath("//*[@class='game-name']").Click();
            IWebElement ClickToSelectTheField = driver.FindElementByXPath("//*[@class='form-control input-sm']");
            ClickToSelectTheField.SendKeys(Keys.Control + "a");
            IWebElement PasteLink = driver.FindElementByXPath("//*[@class='form-control input-sm']");
            PasteLink.SendKeys(Keys.Control + "v");
            driver.FindElementByXPath("//*[@class='btn btn-primary btn-sm editable-submit']").Click();
            string linkToAccess = driver.FindElementByXPath("//div[contains(@class, 'page-header')]").Text.Substring(0);

            IWebDriver driver1;
            driver1 = new ChromeDriver();
            driver1.Navigate().GoToUrl(linkToAccess);
            driver1.Manage().Window.FullScreen();
            driver1.FindElement(By.Name("inputName")).SendKeys(playerName);
            IWebElement ClickOnEnterButton = driver1.FindElement(By.XPath("//button[@type='submit']"));
            ClickOnEnterButton.Click();
            Thread.Sleep(3000);
            driver1.Manage().Window.Minimize();
            driver.Manage().Window.FullScreen();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn-start")));
            IWebElement clickStart = driver.FindElementById("btn-start");
            clickStart.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='3']")));
            driver.Manage().Window.Minimize();
            driver1.Manage().Window.FullScreen();
            IWebElement clickOnTheCardPlayer = driver1.FindElement(By.XPath("//*[text()='3']"));
            clickOnTheCardPlayer.Click();
            driver1.Manage().Window.Minimize();
            driver.Manage().Window.FullScreen();
            IWebElement clickOnTheCardModerator = driver.FindElement(By.XPath("//*[text()='2']"));
            clickOnTheCardModerator.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));
            SelectElement element = new SelectElement(driver.FindElementById("finalEstimate"));
            element.SelectByValue("3");
            Thread.Sleep(5000);
            IWebElement clickOnFinish = driver.FindElementByXPath("//*[@ng-bs-click='finish']");
            clickOnFinish.Click();
            driver1.Quit();

            return new CreateStoriesAndVotingProcess(driver);
        }
    }
}
