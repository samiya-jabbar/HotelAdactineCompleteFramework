using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;

namespace HotelAdactineCompleteFramework
{
    internal class LoginPage : BasePage
    {
        #region Locators
        By userLoc = By.Id("username");
        By passLoc = By.Id("password");
        By loginLoc = By.Id("login");
        #endregion
        public void Login(string url, string username , string password)
        {
            GetUrl(url);
            Write(userLoc, username);
            Write(passLoc, password);
            Click(loginLoc);
        }     
    }
}
