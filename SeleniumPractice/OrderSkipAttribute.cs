namespace SeleniumPractice
{
    using NUnit.Framework;
    using OpenQA;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Support.UI;
    using SeleniumPractice.Utilities;

    public class OrderSkipAttribute
    {

        [Test, Order(2), Category("OrderSkipAttribute")]
    //    [Ignore("ignore this")]
        public void Test1()
        {
            Assert.Ignore("Defect Id 1");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";    
            //send email
            IWebElement emailElement = driver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");
            driver.Close();
        }

        [Test, Order(0),  Category("OrderSkipAttribute")]
        public void Test2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com";
            //send email
            IWebElement emailElement = driver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");
            driver.Close();
        }


        [Test,Order(1), Category("OrderSkipAttribute")]
       // [Ignore("ignore")]
        public void Tes3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com";
            //send email
            IWebElement emailElement = driver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");
            driver.Close();
        }


    }
}