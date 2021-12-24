using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowDemo.Drivers
{
   public class SeleniumDriver
    {
        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        public SeleniumDriver()
        {
        }

        public IWebDriver Setup(string browsername)
        {
            dynamic capability = Getbrowseroptions(browsername);
            IWebDriver driver = null;
            driver = new ChromeDriver();
            _scenarioContext.Set(driver, "WebDriver");
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();
            return driver;
        }

        public void QuitBrowserss ()
        {
            IWebDriver dd = Setup("chrome");
            dd.Quit();
           
        }

        //internal IWebDriver Setup()
        //{
        //    throw new NotImplementedException();
        //}

        private dynamic Getbrowseroptions(string browsername)
        {
            if (browsername.ToLower() == "chrome")
            {
                return new ChromeOptions();
            }
            if (browsername.ToLower() == "firefox")
            {
                return new FirefoxOptions();
            }
            if (browsername.ToLower() == "MicrosoftEdge")
            {
                return new EdgeOptions();
            }
            if (browsername.ToLower() == "Safari")
            {
                return new SafariOptions();
            }
            // if none of these return ChromeOptions
            return new ChromeOptions();
        }


    }
}
