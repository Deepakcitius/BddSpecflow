using OpenQA.Selenium;
using SpecflowDemo.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowDemo.Pages
{
     public class Locators :SeleniumDriver
    {
        //public IWebDriver driver { get; }
      

        //UI Elements
        public IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));
        public IWebElement txtUsername => driver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => driver.FindElement(By.Name("Password"));
        public IWebElement btnLogin => driver.FindElement(By.CssSelector(".btn-default"));
        public IWebElement lnkEmployeeDetails => driver.FindElement(By.LinkText("Employee Details"));

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
