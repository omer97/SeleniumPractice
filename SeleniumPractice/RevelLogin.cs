using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V85.ApplicationCache;
using OpenQA.Selenium.Support.UI;
using SeleniumPractice.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice
{

    public class RevelLogin
    {
        IWebDriver driver;

        [Test]
        public void Login()
        {
            driver = new ChromeDriver();
            driver.Url = "https://revelpk.onescreensolutions.com/b/signin";
            driver.Manage().Window.Maximize();
            IWebElement email = driver.FindElement(By.Id("email"));
            IWebElement password = driver.FindElement(By.Id("password"));
            IWebElement sendBtn = driver.FindElement(By.Id("loginBtn"));
            IWebElement cookieAccept = driver.FindElement(By.Id("cookies-agree-button"));

            if (cookieAccept.Enabled)
            {
                cookieAccept.Click();
            }
            email.SendKeys("omar@onescreensolutions.com");
            password.SendKeys("Teamomer@123");

            var timeout = 10000; // in milliseconds
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));
            Thread.Sleep(10000);
            //if(sendBtn.)
            if (sendBtn.Enabled)
            {
                IWebElement submitBtn = driver.FindElement(By.XPath("//*[@id=\"loginBtn\"]"));
                submitBtn.Submit();
            }

            IWebElement dashboardText = driver.FindElement(By.Id("user-text"));
            if (dashboardText.Enabled)
            {
                Console.WriteLine("Reached Dashboard");
            }

            //driver.Quit();

        }


        [Test, Category("Google Login")]
        public void GoogleLogin()
        {
            driver = new ChromeDriver();
            driver.Url = "https://revelpk.onescreensolutions.com/b/signin";
            driver.Manage().Window.Maximize();


            IWebElement gmailLoginBtn = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div/div/div/div[2]/a[1]"));
            gmailLoginBtn.Click();

            IWebElement gEmail = driver.FindElement(By.Id("identifierId"));
            gEmail.SendKeys("omar@onescreensolutions.com");

            IWebElement nextBtn1 = driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]/div/button"));
            nextBtn1.Click();

            Thread.Sleep(10000);
            IWebElement gPass = driver.FindElement(By.Name("password"));
            gPass.SendKeys("dev@123456");


            IWebElement nextBtn = driver.FindElement(By.Id("passwordNext")).FindElement(By.TagName("button"));
            if (nextBtn != null)
            {
                nextBtn.Click();

            }


        }


        [Test, Category("Office365 Login")]
        public void MicrosoftLogin()
        {
            driver = new ChromeDriver();
            driver.Url = "https://revelpk.onescreensolutions.com/b/signin";
            driver.Manage().Window.Maximize();


            IWebElement msLoginBtn = driver.FindElement(By.ClassName("customBtn-office365"));
            msLoginBtn.Click();

            Thread.Sleep(10000);

            IWebElement msEmail = driver.FindElement(By.Name("loginfmt"));
            msEmail.SendKeys("omerakber97@hotmail.com");

            IWebElement nextBtn1 = driver.FindElement(By.Id("idSIButton9"));
            nextBtn1.Click();

            Thread.Sleep(10000);
            IWebElement gPass = driver.FindElement(By.Name("passwd"));
            gPass.SendKeys("iatcobb1");


            IWebElement nextBtn = driver.FindElement(By.Id("idSIButton9"));
            if (nextBtn != null)
            {
                nextBtn.Click();

            }

            //stay signed in or not
            IWebElement staySignBtn = driver.FindElement(By.Id("idSIButton9"));
            if (staySignBtn != null)
            {
                staySignBtn.Click();

            }

        }

        
        [Test,Ignore("incomplete")]
        public void ForgotPassword()
        {
            driver = new ChromeDriver();
            driver.Url = "https://revelpk.onescreensolutions.com/b/password_resets/new";
            driver.Manage().Window.Maximize();

            IWebElement email = driver.FindElement(By.Name("password_reset[email]"));
            email.SendKeys("omar@onescreensolutions.com");


        }


    }
}
