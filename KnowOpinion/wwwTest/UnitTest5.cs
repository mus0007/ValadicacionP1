using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTests
{
    [TestClass]
    public class BorrarEncuesta
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [TestInitialize]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:50465/Principal.aspx";
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
        public void TheBorrarEncuestaTest()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("Button1")).Click();
            driver.FindElement(By.Id("txtcuenta")).Clear();
            driver.FindElement(By.Id("txtcuenta")).SendKeys("Usuario1@gmail.com");
            driver.FindElement(By.Id("txtcontrena")).Clear();
            driver.FindElement(By.Id("txtcontrena")).SendKeys("usuario1");
            driver.FindElement(By.Id("btnLogin")).Click();
            driver.FindElement(By.Id("btnborrar")).Click();
            driver.FindElement(By.Id("btnBorrar")).Click();
            driver.FindElement(By.Id("btnSeleccionar")).Click();
            driver.FindElement(By.Id("btnBorrar")).Click();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).Clear();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).SendKeys("Encuesta3");
            driver.FindElement(By.Id("btnSeleccionar")).Click();
            driver.FindElement(By.Id("btnBorrar")).Click();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).Clear();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).SendKeys("Encuesta2");
            driver.FindElement(By.Id("btnSeleccionar")).Click();
            driver.FindElement(By.Id("btnBorrar")).Click();
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
