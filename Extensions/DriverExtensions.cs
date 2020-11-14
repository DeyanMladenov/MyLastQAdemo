using LastOne.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastOne.Extensions
{
    public static class DriverExtensions
    {
        public static void ScrollUp(IWebDriver driver, int pixels)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript($"window.scrollBy (0, {-pixels})");
        }

        public static void ScrollDown(this IWebDriver driver, int pixels)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript($"window.scrollBy (0, {pixels})");
        }

        public static IWebElement NavigateToCurrentElement(IWebDriver driver,IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
        public static void WaitForDropDown(this WebElement element, string value)
        {
            new SelectElement(element.WrappedElement).SelectByText(value);
        }

        public static string GetTextFromBox(this WebElement element)
        {
            return new SelectElement(element.WrappedElement).AllSelectedOptions.SingleOrDefault().Text;
        }

        






    }
}
