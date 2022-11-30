using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice  
{
    [TestFixture]
    public class SeleniumScreenShot :BaseTest
    {
        [Test , Author("Omer","omerakber97@gmail.com")]
        [Description("Facebook Login Verify")]
        public void TestSc()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            //send email
            IWebElement emailElement = driver.FindElement(By.Id("email"));
            emailElement.SendKeys("EnterYourEmail");
            driver.Quit();

        }

    }
}
