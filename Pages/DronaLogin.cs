
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using SpecflowProjectdotnet.Methods;

namespace SpecflowProjectdotnet.Pages
{
    class DronaLogin
    {
        public DronaLogin()
        {


            PageFactory.InitElements(PropertyCollection.driver, this);
           


        }
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder1_txtUserName")]
        public IWebElement txtuserName { get; set; }
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder1_txtPass")]
        public IWebElement txtpassword { get; set; }
        [FindsBy(How = How.Id, Using = "Button1")]
        public IWebElement btnlogin { get; set; }
        [FindsBy(How = How.Id, Using = "lblUname")]
        public IWebElement GetUserName { get; set; }

        public void CheckdronaLogin(string UserName, String Password)
        {
            txtuserName.EnterText(UserName);
            txtpassword.EnterText(Password);

        }

        public Dashboard ClickLOginButton()
        {
            btnlogin.Clicks();
            return new Dashboard();
        }
        //public GetMethod VarifyUserName(string ExpectedUserName)
        // {
        //     GetUserName.Get(ExpectedUserName);
        //     return GetMethod;
        // }
    }
}
