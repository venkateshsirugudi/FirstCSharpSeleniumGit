using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace csharpseleniumwithgit
{
    [TestFixture]
    public class Class1
    {
        IWebDriver driver;
        [SetUp]
        public void init()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https:\\www.google.com");
            driver.Manage().Window.Maximize();
            Console.WriteLine("window maximized");
        }
        [Test]
        public void SearchGoogle()
        {
            driver.FindElement(By.Name("q")).SendKeys("selenium testing");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("in Google search page");
        }

        [TearDown]
        public void cleanup()
        {
            Console.WriteLine("Closing driver instance");
            driver.Close();
            driver.Quit();
        }

    }
}
