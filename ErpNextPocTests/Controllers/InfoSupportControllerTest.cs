using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Text;

namespace SeleniumTests
{
    [TestClass]
    public class InfoSupportControllerTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [TestInitialize]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost:56326/";
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TheInfoSupportControllerTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/#/infoSupport");
            driver.FindElement(By.Id("inputTitle")).Clear();
            driver.FindElement(By.Id("inputTitle")).SendKeys("電腦維修服務");
            driver.FindElement(By.Id("inputContext")).Clear();
            driver.FindElement(By.Id("inputContext")).SendKeys("我的電腦已經壞很久了");
            new SelectElement(driver.FindElement(By.XPath("(//select[@id='manager'])[2]"))).SelectByText("萱姐");
            driver.FindElement(By.Id("inputFile")).Clear();
            driver.FindElement(By.Id("inputFile")).SendKeys("C:\\Users\\aken1215\\Desktop\\a04060-0086.jpg");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}