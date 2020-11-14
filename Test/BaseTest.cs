using LastOne.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastOne.Test
{
    public class BaseTest
    {
       public WebDriver Driver { get; set; }

        public void Initialize()
        {
            Driver = new WebDriver();
            Driver.Start(Browser.Chrome);
            Driver.WrapperDriver.Manage().Window.Maximize();
        }
    }
}
