using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecflowProjectdotnet.Steps
{
    [Binding]
    public class Check_Drona_Academy_LoginSteps

    {
        

        
        public void LonchTheBrowser()
        {
            
            //PropertyCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);
            //PropertyCollection.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            //PropertyCollection.driver.Manage().Window.Maximize();
        }
        [OneTimeSetUp]
        [Given(@"Navigate to the login Page")]
        public void GivenNavigateToTheLoginPage()
        {
            PropertyCollection.driver = new ChromeDriver();
            PropertyCollection.driver.Navigate().GoToUrl("http://cloudacademy.nxglabs.in/");
        }

        [Given(@"and Enter valid username '(.*)' and Password '(.*)'")]
        public void GivenAndEnterValidCredentials(string username, string password)
        {
            Pages.DronaLogin Obj = new Pages.DronaLogin();
            Obj.CheckdronaLogin(username, password);
        }

        [When(@"When click login Button")]
        public void WhenWhenClickLoginButton()
        {
            Pages.DronaLogin obj1 = new Pages.DronaLogin();
            obj1.ClickLOginButton();
        }
        
        [Then(@"User should be login and redirected to the Dashboard")]
        
        public void ThenUserShouldBeLoginAndRedirectedToTheDashboard()
        {
            //Pages.DronaLogin obj1 = new Pages.DronaLogin();
            //var actualUser = obj1.
            //Assert.IsTrue(actualUser.Contains(ExpectedUser));
            PropertyCollection.driver.Close();

        }
    }
}
