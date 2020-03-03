using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
