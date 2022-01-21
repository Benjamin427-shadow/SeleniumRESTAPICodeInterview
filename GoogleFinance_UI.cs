using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Code_Interview
{
    internal class GoogleFinance_UI
    {
        public string baseURL = "http://www.google.com/finance/";
        IWebDriver chromeDriver;
        public void SetupExecution()
        {
            // Setup
            chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl(baseURL);
            
            //Search for element to enter text on the search field
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            chromeDriver.FindElement(By.CssSelector(".Ax4B8 ZAGvjd")).SendKeys("SOFI");

            //Search for element to click the button to search
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            chromeDriver.FindElement(By.ClassName("eEMh0d")).Click();
        }
    }
}
