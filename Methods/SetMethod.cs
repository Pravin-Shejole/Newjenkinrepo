﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowProjectdotnet.Methods
{
    public static class SetMethod
    {
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);

        }
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }
        public static void selectDropdown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
