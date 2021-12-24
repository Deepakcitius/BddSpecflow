using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowDemo.Pages
{
     public class Locators
    {
        public IWebDriver WebDriver { get; }
        public Locators(IWebDriver webDriver)
        { 
            WebDriver = webDriver;
        }
        //UI Elements
        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtUsername => WebDriver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Name("Password"));
        public IWebElement btnLogin => WebDriver.FindElement(By.CssSelector(".btn-default"));
        public IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee Details"));

        public void Clicklogin() => lnkLogin.Click();

        public void Login(string username , string password)
        {
            txtUsername.SendKeys(username);
            txtPassword.SendKeys(password);
        }

        public void ClickloginButton() => btnLogin.Click();

        public bool IsEmployeeDetailsExist() => lnkEmployeeDetails.Displayed;







    }
}
