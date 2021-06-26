using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowProjectdotnet.Methods
{
    class GetMethod
    {
        public static string GetText(string element, string elementType)
        {
            if (elementType == "Id")
                return PropertyCollection.driver.FindElement(By.Id(element)).GetAttribute("Value");
            if (elementType == "Name")
                return PropertyCollection.driver.FindElement(By.Name(element)).GetAttribute("Value");
            else return string.Empty;

        }
        public static string GetTextFromDDl(string element, string elementType)
        {
            if (elementType == "Id")
                return new SelectElement(PropertyCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == "Name")
                return new SelectElement(PropertyCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;
        }
    }
}
