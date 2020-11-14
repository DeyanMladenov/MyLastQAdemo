using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastOne.Core
{
    public class WebDriver
    {
        private IWebDriver _driver;
       
        private WebDriverWait _wait;

        public IWebDriver WrapperDriver => _driver;
       

        public void Start(Browser browser)
        {
            switch(browser)
            {
                case Browser.Chrome:
                    _driver = new ChromeDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Firefox:
                    _driver = new FirefoxDriver(Environment.CurrentDirectory);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }

            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public WebElement FindExistingElement(By locator)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            IWebElement element = _wait.Until(ExpectedConditions.ElementExists(locator));
            WebElement currentElement = new WebElement(_driver, element, locator);
            return currentElement;
        }

        public void WaitUntilElementIsLoaded(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            WebDriverWait wait = new WebDriverWait(_driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }

    }
}
