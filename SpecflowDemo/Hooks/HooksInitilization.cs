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
    public sealed class HooksInitilization : SeleniumDriver
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Launching the browser");
            Setup("chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Closing the browser");
            driver.Quit();
        }
    }
}
