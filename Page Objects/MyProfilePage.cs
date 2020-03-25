using AutoItX3Lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace PageObjectModelTry.Page_Objects
{
    public class MyProfilePage
    {
        private readonly ChromeDriver driver;
        private readonly WebDriverWait wait;

        public MyProfilePage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public MyProfilePage ChangeTheProfileImage()
        {
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='fileUpload']")));
            IWebElement clickOnTheCircleWithProfileImage = driver.FindElementByXPath("//*[@class='fileUpload']");
            clickOnTheCircleWithProfileImage.Click();
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            Thread.Sleep(1000);
            autoIt.Send(@"C:\SeleniumWebDriver\lynx.jpg.jpg");
            autoIt.Send("{ENTER}");
            Thread.Sleep(3000);

            return new MyProfilePage(driver);
        }

        public string TitlePage()
        {
            string title = this.driver.Title;
            return title;
        }

        public MyProfilePage SignInWithAgoogleAccount()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(@ng-submit-form-value, 'Google')]")));
            IWebElement clickOnGoogleLink = driver.FindElementByXPath("//button[contains(@ng-submit-form-value, 'Google')]");
            clickOnGoogleLink.Click();
            wait.Until(ExpectedConditions.TitleIs("Conectați-vă – Conturi Google"));

            return new MyProfilePage(driver);
        }
    }
}
