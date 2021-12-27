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
        public static WebDriver driver = null;
        string Baseurl = "http://eaapp.somee.com/";

       
        public IWebDriver Setup(string browsername)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Baseurl);
            driver.Manage().Window.Maximize();
            return driver;
        }
        

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
