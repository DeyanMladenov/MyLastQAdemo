using LastOne.Core;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastOne.Pages
{
    public class BasePage
    {
        public WebDriver Driver { get; }
        public SelectElement SelectElement { get; set; }
        public Actions Builderr { get; set; }
        public virtual string Url { get; }
        public BasePage(WebDriver driver)
        {
            this.Driver = driver;
        }

        public void NavigateToWebSite()
        {
            Driver.WrapperDriver.Navigate().GoToUrl(Url);
        }

      
    }
}
