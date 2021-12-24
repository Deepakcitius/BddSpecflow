using OpenQA.Selenium;
using SpecflowDemo.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowDemo.Hooks
{
    [Binding]
    public sealed class HooksInitilization
    {
       // SeleniumDriver Driver = new SeleniumDriver();
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly ScenarioContext _scenariocontext;
        //public IWebDriver drivers { get; }
        public HooksInitilization(ScenarioContext scenarioContext) => _scenariocontext = scenarioContext;

        [BeforeScenario]
        public void BeforeScenario()
        {
            SeleniumDriver seleniumdriver = new SeleniumDriver(_scenariocontext);
            _scenariocontext.Set(seleniumdriver, "Seleniumdriver");
            //IWebDriver driver = Driver.Setup("chrome");
            //driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            //driver.Manage().Window.Maximize();


        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Selenium webdriver quit");
            _scenariocontext.Get<IWebDriver>("WebDriver").Quit();
            // Driver.Setup("chrome").Quit();

           // Driver.QuitBrowserss();
        }
    }
}
