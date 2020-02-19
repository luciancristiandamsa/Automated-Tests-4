using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelTry.Page_Objects
{
    class SignUpPage
    {
        IWebDriver driver;
        By Name = By.Name("inputName");
        By Email = By.Name("inputEmail");
        By Password = By.Name("inputPassword");
        By SighUpButton = By.CssSelector("body > div.grayed > div > section > form.ng-pristine.ng-invalid.ng-invalid-required > div:nth-child(5) > div > button");
        By LoginFromSignUpPageLink = By.CssSelector("a[href *= '/authentication/']");

        public SignUpPage (IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ValidTypeName()
        {
            driver.FindElement(Name).SendKeys(LoginPage.validName);
        }

        public void InvalidTypeName()
        {
            driver.FindElement(Name).SendKeys(LoginPage.invalidNameAndEmail);
        }

        public void ValidTypeEmail()
        {
            driver.FindElement(Email).SendKeys(LoginPage.validEmail);
        }

        public void InvalidTypeEmail()
        {
            driver.FindElement(Email).SendKeys(LoginPage.invalidEmail);
        }

        public void ValidTypePassword()
        {
            driver.FindElement(Password).SendKeys(LoginPage.validPassword);
        }

        public void InvalidTypePassword()
        {
            driver.FindElement(Password).SendKeys(LoginPage.invalidPassword);
        }

        public void ClickSignUpButton()
        {
            driver.FindElement(SighUpButton).Click();
        }

        public void ClickLoginButtonFromSignUpPage()
        {
            driver.FindElement(LoginFromSignUpPageLink).Click();
        }


    }

   
}
