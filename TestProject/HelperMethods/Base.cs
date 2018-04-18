using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject.HelperMethods
{
    static class Base
    {
       public static IWebDriver driver;
        public static WebDriverWait wait;

        public static  void LaunchBrowser()
        {
            string driverPath = AppConfig.GetValue("driverPath");
            driver = new ChromeDriver(driverPath);
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(150));
            string appUrl = AppConfig.GetValue("AppUrl");
            driver.Navigate().GoToUrl(appUrl);
            Thread.Sleep(10000);
        }
    }
}
