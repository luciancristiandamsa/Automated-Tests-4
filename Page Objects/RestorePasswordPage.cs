using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelTry.Page_Objects
{
    class RestorePasswordPage
    {
        IWebDriver driver;
        By TypeEmail = By.Name("inputEmail");
        By RestorePasswordButton = By.XPath("/html/body/div[1]/div/section/form/div[3]/div/button");
        By ReturnToLoginLink = By.CssSelector("a[href *= '/authentication/']");


        public RestorePasswordPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void InsertTheEmail()
        {
            driver.FindElement(TypeEmail).SendKeys(LoginPage.validEmail);
        }

        public void ClickOnTheRestorePasswordButton()
        {
            driver.FindElement(RestorePasswordButton).Click();
        }
    }

    
}
