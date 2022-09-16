using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumPractice
{
    public class BaseTest
    {
        public IWebDriver webDriver;

        [OneTimeSetUp]
        public void Open()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "https://www.facebook.com";
        }

        [OneTimeTearDown]
        public void Quit()
        {
            webDriver.Quit();
        }
    }
}
