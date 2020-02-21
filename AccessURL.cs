using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelTry
{
    class AccessURL
    {
        public IWebDriver driver;

        public AccessURL(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public void AccessAndJoinTheURL()
        {
          //  driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.planitpoker.com");
        }
    }
}
