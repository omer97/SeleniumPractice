namespace SeleniumPractice
{
    using OpenQA;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.facebook.com/";

            //send email
            IWebElement emailElement = webDriver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");



            //send password
            IWebElement passElement = webDriver.FindElement(By.Id("pass"));
            passElement.SendKeys("EnterYourPassword");

            IWebElement submitElement = webDriver.FindElement(By.Name("login"));
            submitElement.Click();


            //comment the following line if you want the browser to stay instead of closing it.
            webDriver.Close();
        }
    }
}