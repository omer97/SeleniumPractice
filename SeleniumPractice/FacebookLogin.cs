namespace SeleniumPractice
{
    using NUnit.Framework;
    using OpenQA;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;

    public class Tests : BaseTest
    {


        [SetUp]
        public void Setup()
        {
            
        }

        [Test , Category("Smopke Testing")]
      //  [Ignore("Ignore a test")]
        public void Test1()
        {
           
           // webDriver.Url = "https://www.facebook.com/";

            //send email
            IWebElement emailElement = webDriver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");

            //send password
            IWebElement passElement = webDriver.FindElement(By.Id("pass"));
            passElement.SendKeys("EnterYourPassword");

            IWebElement submitElement = webDriver.FindElement(By.Name("login"));
            submitElement.Click();


            //comment the following line if you want the browser to stay instead of closing it.
          //  webDriver.Close();
        }

        [Test, Category("Regression Testing")]
        public void Test2()
        {
            //open Create account pop up
            //IWebElement createAccount = webDriver.FindElement(By.CssSelector("div ._6ltg > a:first-child"));
            //createAccount.Click();



            //IWebElement selectDobDropDownDay = webDriver.FindElement(By.Id("day"));
            //if (selectDobDropDownDay != null)
            //{
            //    SelectElement ele = new SelectElement(selectDobDropDownDay);
            //    ele.SelectByValue("21");

            //}


            //send email
            IWebElement emailElement = webDriver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");

            //send password
            IWebElement passElement = webDriver.FindElement(By.Id("pass"));
            passElement.SendKeys("EnterYourPassword");
             

        }

    }
}