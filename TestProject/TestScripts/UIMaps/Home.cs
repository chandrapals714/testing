using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.HelperMethods;

namespace TestProject.TestScripts.UIMaps
{
    class Home
    {
        
        private By UISearchField
        {
            get
            {
                return By.XPath("//input[@title='Search']");
            }
        }

        private By UIAllTextPage
        {
            get
            {
                return By.XPath("//div[@id='hdtb-msb-vis']");
            }
        }

        public void VerifyTheNextPage()
        {
            Base.driver.FindElement(UISearchField);
            Base.driver.FindElement(UISearchField).Click();
            Base.driver.FindElement(UISearchField).SendKeys("Home");
            Base.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Base.driver.FindElement(UISearchField).SendKeys(Keys.Enter);

            Base.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            //Actions builder = new Actions(Base.driver);
            //builder.SendKeys(Keys.Enter);

            Assert.IsTrue(Base.driver.FindElement(UIAllTextPage).Displayed);
        }
    }
}
