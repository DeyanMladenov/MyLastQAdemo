using LastOne.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastOne.Pages.DemoQA
{
    public partial class DemoQA : BasePage
    {
        public WebElement currentOption(string el) => Driver.FindExistingElement(By.XPath($"//h5[.='{el}']"));
        public WebElement practiceFormButton(string pF) => Driver.FindExistingElement(By.XPath($"//span[.='{pF}']"));
        public WebElement firstNameField => Driver.FindExistingElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[1]/div[2]/input"));















    }

}
