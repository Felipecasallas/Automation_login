using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class SeleniumFirst
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()

        {
         new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
         driver= new ChromeDriver();
         driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1() 
        {
            driver.Url = "https://automationteststore.com/";
            TestContext.Progress.WriteLine(driver.Title); //test para verificar el titulo
            TestContext.Progress.WriteLine(driver.Url); // test para verificarf eñ url
            
            driver.Close(); //1 ventana
            //driver Quit(); 2 ventanas
        }
    }
}
