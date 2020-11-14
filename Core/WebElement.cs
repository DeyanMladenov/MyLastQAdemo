using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastOne.Core
{
    public class WebElement
    {
        private IWebElement _element;
        private IWebDriver _driver;
        private By _by;
        private WebDriverWait _wait;

        public By By => _by;
        public IWebElement WrappedElement => _element;
       

        public WebElement(IWebDriver driver, IWebElement element, By by)
        {
            this._element = element;
            this._driver = driver;
            this._by = by;
        }

        public WebElement FindExistingElement(By by)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            IWebElement element = _wait.Until(ExpectedConditions.ElementExists(by));
            WebElement currentElement = new WebElement(_driver, element, by);
            return currentElement;
        }

        public void WaitElementToBeClickable(By by)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            _wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public void ClicK()
        {
            WaitElementToBeClickable(By);
            _element.Click();

        }

        public void SetText(string text)
        {
            _element.Click();
            _element.Clear();
            _element.SendKeys(text);
        }


    }
}
