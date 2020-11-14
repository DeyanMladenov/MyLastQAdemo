using LastOne.Factori;
using LastOne.Model;
using LastOne.Pages.DemoQA;
using LastOne.Test;
using NUnit.Framework;
using System.Runtime.InteropServices.ComTypes;

namespace LastOne
{
    public class Tests : BaseTest
    {
        private DemoQA demoQA;
        private RegistrationFormModel _model;

        [SetUp]
        public void Setup()
        {
            Initialize();
            demoQA = new DemoQA(Driver);
           Driver.WrapperDriver.Navigate().GoToUrl("https://demoqa.com/");
           
        }

        [Test]
        public void NavigateToCorrectSection()
        {
            demoQA.NavigateToSelectedMenu("Elements");
        }

        [Test]
        public void FillForm()
        {
            demoQA.NavigateToWebSite();
           // demoQA.NavigateToFormAndTypeName("Practice Form", "Gosho420");
        }

        [Test]
        public void AutoCompleteFillForm()
        {  
            demoQA.NavigateToWebSite();
            _model = RegistrationFormFactori.FillForm();
            demoQA.NavigateToFormAndTypeName("Practice Form",_model);
        }
    }
}