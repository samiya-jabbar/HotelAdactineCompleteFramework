using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelAdactineCompleteFramework
{
    [TestClass]
    public class TestExecution : BasePage
    {
        public string url = "https://adactinhotelapp.com/";
        public string user = "jabbasam";
        public string pass = "123456";
        public string location = "Sydney";

        #region ObjectInitialization
        LoginPage loginPage = new LoginPage();
        SearchPage searchPage = new SearchPage();
        #endregion

        [TestInitialize]
        public void TestInit()
        {
            DriverInit();
            GetUrl(url);
        }

        [TestCleanup]
        public void TestCleanup() 
        {
            DriverCLose();
        }

        [TestMethod]
        public void LoginWithValidData()
        {           
            loginPage.Login(url, user, pass);          
        }
        public void LoginWithInvalidData()
        {
            loginPage.Login(url, user, pass);
        }

        [TestMethod]
        public void Search()
        {
            loginPage.Login(url, user, pass);
            searchPage.Search(location);
        }
    }
}
