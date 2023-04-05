using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HotelAdactineCompleteFramework
{
    public class BasePage
    {
        public static IWebDriver driver;
        public static void DriverInit()
        {
        driver =   new ChromeDriver();

        }
        public static void DriverCLose()
        {
           
           driver.Close();
        }
        public static void GetUrl(string link)
        {
            driver.Url = link;
        }
        public static void Write(By locator, string value)
        {
            driver.FindElement(locator).SendKeys(value);
        }
        public static void Click(By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
