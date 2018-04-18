using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.HelperMethods;
using TestProject.TestScripts.UIMaps;
using System.Configuration;

namespace TestProject.TestScripts.TCs
{
    [TestClass]
    public class VerifyTheEnteredTextAtHomePage
    {
        Home homeObj = new Home();
        [TestCategory("Regression_Chrome")]
        [TestMethod]
        public void LaunchBrowserChrome()
        {
            Base.LaunchBrowser();
            homeObj.VerifyTheNextPage();
        }

        [TestCategory("Regression_Chrome")]
        [TestMethod]
        public void VerifyTextOnHomePage()
        {
            Base.LaunchBrowser();
            homeObj.VerifyTheNextPage();
        }

    }
}
