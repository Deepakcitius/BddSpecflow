using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowDemo.Drivers;
using SpecflowDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowDemo.Steps
{
    [Binding]
    public  class LoginSteps :SeleniumDriver
    {
        Locators loc = new Locators();
        //SeleniumDriver Driver = new SeleniumDriver();
        //public IWebDriver drivers { get; }
        [Given(@"I Launch the application")]
        public void GivenILaunchTheApplication()
        {
            Console.WriteLine("Selenium webdriver already launched the application");
            
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            loc.Clicklogin();  
        }

        [Given(@"Enter the Following details")]
        public void GivenEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loc.Login((string)data.Username, (string)data.Password);

        }

        [Given(@"Click login Button")]
        public void GivenClickLoginButton()
        {
            loc.ClickloginButton();
        }

        [Then(@"I Should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            Assert.That(loc.IsEmployeeDetailsExist(), Is.True);
        }

        // Second Test 
        [Given(@"I Launch the app")]
        public void GivenILaunchTheApp()
        {
            Console.WriteLine("Selenium webdriver already launched the application");
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            loc.Clicklogin();
        }

        [Given(@"Enter the Following")]
        public void GivenEnterTheFollowing(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loc.Login((string)data.Username, (string)data.Password);
        }

        [Given(@"Click login")]
        public void GivenClickLogin()
        {
            loc.ClickloginButton();
        }

        [Then(@"I Should see Employee details")]
        public void ThenIShouldSeeEmployeeDetails()
        {
            Assert.That(loc.IsEmployeeDetailsExist(), Is.True);
        }


    }
}
