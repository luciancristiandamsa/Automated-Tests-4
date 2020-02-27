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

        [Obsolete]
        public CreateStoriesAndVotingProcess VotingProcess(string storyName)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));
            driver.FindElementByName("inputName").SendKeys(storyName);
            IWebElement ClickSaveAndClose = driver.FindElementByXPath("//*[@ng-bs-click='createAndClose']");
            ClickSaveAndClose.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn-start")));
            IWebElement clickStart = driver.FindElementById("btn-start");
            clickStart.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[2]/div/div[3]/button")));
            IWebElement clickOnTheCard = driver.FindElementByXPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[4]/button/div[2]");
            clickOnTheCard.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));
            SelectElement element = new SelectElement(driver.FindElementById("finalEstimate"));
            element.SelectByValue("7");
            IWebElement clickOnFinish = driver.FindElementByXPath("//*[@ng-bs-click='finish']");
            clickOnFinish.Click();

            return new CreateStoriesAndVotingProcess(driver);
        }

        [Obsolete]
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
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[2]/div/div[3]/button")));
            IWebElement clickOnTheCard = driver.FindElementByXPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[4]/button/div[2]");
            clickOnTheCard.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));
            SelectElement element = new SelectElement(driver.FindElementById("finalEstimate"));
            element.SelectByValue("7");
            driver.FindElementByClassName("btn-one").Click();

            return new CreateStoriesAndVotingProcess(driver);
        }
    }
}
