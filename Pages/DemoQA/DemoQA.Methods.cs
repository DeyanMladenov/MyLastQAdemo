using LastOne.Core;
using System;
using System.Collections.Generic;
using System.Text;
using LastOne.Extensions;
using System.Security.Cryptography.X509Certificates;
using LastOne.Model;
using OpenQA.Selenium.Support.UI;

namespace LastOne.Pages.DemoQA
{
    public partial class DemoQA
    {
        public DemoQA(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/forms";
        public void NavigateToSelectedMenu(string el)
        {
            Driver.WrapperDriver.ScrollDown(300);
            currentOption($"{el}").ClicK();
        }

        public void NavigateToFormAndTypeName(string subMenu,RegistrationFormModel model)
        {
            
           // NavigateToSelectedMenu($"{menu}");
            practiceFormButton($"{subMenu}").ClicK();
            // firstNameField.SetText($"{name}");
            firstNameField.SetText(model.FirstName);
            
        
        }

    }
}
