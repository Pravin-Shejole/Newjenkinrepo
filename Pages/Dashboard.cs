using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowProjectdotnet.Pages
{
    class Dashboard
    {
        public Dashboard()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }
    }
}
