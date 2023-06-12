using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    internal class Localizadores
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()

        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://automationteststore.com/";
        }
        [Test]
        public void LocatorsIdentification()

        {
            driver.FindElement(By.XPath("//a[@href='https://automationteststore.com/index.php?rt=account/login'][contains(.,'Login or register')]")).Click();
            driver.FindElement(By.Id("loginFrm_loginname")).SendKeys("andres");
            driver.FindElement(By.Id("loginFrm_password")).SendKeys("andres12345");
            driver.FindElement(By.XPath("//button[@type='submit'][contains(.,'Login')]")).Click();
            Thread.Sleep(3000);
            String successfull = driver.FindElement(By.XPath("//span[@class='subtext'][contains(.,'Andres')]")).Text;
            TestContext.Progress.WriteLine(successfull);
        }
        [Test]

        public void LocatorsIdentification2() 
        {
            driver.FindElement(By.XPath("//a[@href='https://automationteststore.com/index.php?rt=account/login'][contains(.,'Login or register')]")).Click();
            driver.FindElement(By.Id("loginFrm_loginname")).SendKeys("65123");
            driver.FindElement(By.Id("loginFrm_password")).SendKeys("andres12345");
            driver.FindElement(By.XPath("//button[@type='submit'][contains(.,'Login')]")).Click();
            Thread.Sleep(3000);
            String errorMessage = driver.FindElement(By.ClassName("alert-error")).Text;
            TestContext.Progress.WriteLine(errorMessage);
        }
        [Test]
        public void LocatorsIdentification3() 
        {
            driver.FindElement(By.XPath("//a[@href='https://automationteststore.com/index.php?rt=account/login'][contains(.,'Login or register')]")).Click();
            IWebElement link = driver.FindElement(By.LinkText("Forgot your password?"));
            String hrftAtribute = link.GetAttribute("href");
            String expectedValueUrl = "https://automationteststore.com/index.php?rt=account/forgotten/password";
            Assert.That(hrftAtribute, Is.EqualTo(expectedValueUrl));

            //validate url of the ink text

        }
    }
    
}
