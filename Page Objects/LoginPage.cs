using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjectModelTry.Page_Objects
{
    public class LoginPage
    {
        public IWebDriver driver;
        By Email = By.Name("inputEmail");
        By Password = By.Name("inputPassword");
        By LoginButton = By.ClassName("btn-login");
        By ForgottenPassword = By.CssSelector("a[href*='/authentication/restorepassword/']");
        By LinkedInIconSignUp = By.CssSelector("body > div.grayed > div > section > form.ng-pristine.ng-valid > ul > li:nth-child(1) > button > img");
        By SignUpFromLoginPageLink = By.CssSelector("a[href*='/signup/']");
        public static string validName = "aaa098873";
        public static string invalidNameAndEmail = "";
        public static string validEmail = "aaa098873@gmail.com";
        public static string invalidEmail = "qqqqqqqqqq";
        public static string validPassword = "ababab.123";
        public static string invalidPassword = "qqqqqqqqqq";


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ValidTypeUserEmail()
        {
            driver.FindElement(Email).SendKeys(validEmail);
        }

        public void InvalidTypeUserEmail()
        {
            driver.FindElement(Email).SendKeys(invalidNameAndEmail);
        }

        public void ValidTypePassword()
        {
            driver.FindElement(Password).SendKeys(validPassword);
        }

        public void InvalidTypePassword()
        {
            driver.FindElement(Password).SendKeys(invalidPassword);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(LoginButton).Click();
        }

        public void ClickForgottenPassword()
        {
            driver.FindElement(ForgottenPassword).Click();
        }

        public void LoginWIthLinkedInAccount()
        {
            driver.FindElement(LinkedInIconSignUp).Click();
        }

        public void SignUpFromLoginPage()
        {
            driver.FindElement(SignUpFromLoginPageLink).Click();
        }
    }

}

