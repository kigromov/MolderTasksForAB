using NUnit.Framework;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace AlfaBankTestTasks.Steps
{
    [Binding]
    public class AlfaBankTestsSteps
    {
        private readonly Molder.Web.Steps.Steps _web;

        public AlfaBankTestsSteps(Molder.Web.Steps.Steps web)
        {
            _web = web;
        }

        [OneTimeSetUp]
        public void Init()
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
        }

        [Given(@"Login on Mantis page with UserName=\""(.+)\"" and Password=\""(.+)\""")]
        public void GivenLogin(string userName, string password)
        {
            _web.MaximizeWindow();
            _web.SetCurrentPage("Login Page");
            _web.InputValueIntoField("UserName", userName);
            _web.ClickToWebElement("LoginButton");
            _web.UpdateCurrentPage("LoginPasswordPage");
            _web.InputValueIntoField("Password", password);
            _web.ClickToWebElement("LoginButton");
        }
    }
}
