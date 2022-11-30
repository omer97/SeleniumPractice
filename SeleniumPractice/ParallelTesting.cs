namespace SeleniumPractice
{
    using NUnit.Framework;
    using OpenQA;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using SeleniumPractice.Utilities;

     
    public class ParallelTesting
    {
        IWebDriver driver; 
        [Test , Category("UAT Testing"), Category("Module1")]       
        public void Test1()
        {
             var Driver =  new BrowserUtility().init(driver);
            
            //send email
            IWebElement emailElement = Driver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");
            Driver.Close();
        }


        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test2()
        {
            var Driver = new BrowserUtility().init(driver);

            //send email
            IWebElement emailElement = Driver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");
            Driver.Close();
        }



        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test3()
        {
            var Driver = new BrowserUtility().init(driver);

            //send email
            IWebElement emailElement = Driver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");
            Driver.Close();
        }


        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test4()
        {
            var Driver = new BrowserUtility().init(driver);

            //send email
            IWebElement emailElement = Driver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test5()
        {
            var Driver = new BrowserUtility().init(driver);

            //send email
            IWebElement emailElement = Driver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");
            Driver.Close();
        }


    }
}