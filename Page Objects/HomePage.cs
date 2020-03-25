using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModelTry.Page_Objects;

namespace PageObjectModelTry
{
    public class HomePage 
    {
        private readonly ChromeDriver driver;

        public HomePage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public string Title()
        {
            string title = this.driver.Title;
            return title;
        }

        public LoginPage ClickLogin()
        {
            IWebElement element = driver.FindElement(By.XPath("//a[text()='Login']"));
            element.Click();
            return new LoginPage(driver);
        }

        public LoginPage ClickOnStartQuickPlay()
        {
            IWebElement element = driver.FindElementByCssSelector("a[href*='quickplay']");
            element.Click();

            return new LoginPage(driver);
        }

        public SignUpPage ClickOnSignUp()
        {
            IWebElement clickSignUp = driver.FindElementByCssSelector("a[href*='signup']");
            clickSignUp.Click();

            return new SignUpPage(driver);
        }

        
    }
}