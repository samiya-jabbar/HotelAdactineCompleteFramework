using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.DOM;

namespace HotelAdactineCompleteFramework
{
    internal class SearchPage : BasePage
    {
        By locationLoc = By.Id("location");
        By submitLoc = By.Id("Submit");

        public void Search(string location)
        {
            Write(locationLoc, location);
            Click(submitLoc);


        }
    }
}
