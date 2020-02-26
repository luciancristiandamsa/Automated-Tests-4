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
            IWebElement ClickSaveAndClose = driver.FindElementByXPath("/html/body/div[1]/div/div[1]/div/div/div[1]/div/div/div/form/div[2]/div[4]/div[2]/button");
            ClickSaveAndClose.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn-start")));
            driver.FindElementById("btn-start").Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[2]/div/div[3]/button")));
            driver.FindElementByXPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[4]/button/div[2]").Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));
            SelectElement element = new SelectElement(driver.FindElementById("finalEstimate"));
            element.SelectByValue("7");
            driver.FindElementByClassName("btn-one").Click();

            return new CreateStoriesAndVotingProcess(driver);
        }

        [Obsolete]
        public CreateStoriesAndVotingProcess VotingProcessQuickPlay(string storyName)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("inputName")));
            driver.FindElementByName("inputName").SendKeys(storyName);
            IWebElement ClickSaveAndClose = driver.FindElementByXPath("/html/body/div[1]/div/div[1]/div/div/div[1]/div/div/div/form/div[2]/div[4]/div[2]/button");
            ClickSaveAndClose.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[5]/div[3]/button[3]")));
            IWebElement clickEndTour = driver.FindElementByXPath("/html/body/div[5]/div[3]/button[3]");
            clickEndTour.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("btn-start")));
            driver.FindElementById("btn-start").Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[2]/div[1]/section[2]/div/div[2]/div/div[3]/button")));
            driver.FindElementByXPath("/html/body/div[1]/div/div[1]/div/div/section/div/div[2]/div[2]/div[1]/div/section/div[2]/ul/li[4]/button/div[2]").Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("finalEstimate")));
            SelectElement element = new SelectElement(driver.FindElementById("finalEstimate"));
            element.SelectByValue("7");
            driver.FindElementByClassName("btn-one").Click();

            return new CreateStoriesAndVotingProcess(driver);
        }
    }
}
