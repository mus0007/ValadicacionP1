﻿using System;
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
    public class ValorarEncuestasValidasYNoValidas
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
        public void TheValorarEncuestasValidasYNoValidasTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Principal.aspx");
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).Clear();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).SendKeys("Encuesta1");
            driver.FindElement(By.Id("btnSeleccionar")).Click();
            driver.FindElement(By.Id("Boton3")).Click();
            driver.FindElement(By.Id("tdxcomentario")).Clear();
            driver.FindElement(By.Id("tdxcomentario")).SendKeys("comentarioEncuesta1");
            driver.FindElement(By.Id("btnEnviar")).Click();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).Clear();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).SendKeys("Encuesta2");
            driver.FindElement(By.Id("btnSeleccionar")).Click();
            driver.FindElement(By.Id("Boton1")).Click();
            driver.FindElement(By.Id("btnEnviar")).Click();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).Clear();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).SendKeys("Encuesta3");
            driver.FindElement(By.Id("btnSeleccionar")).Click();
            driver.FindElement(By.Id("Boton3")).Click();
            driver.FindElement(By.Id("btnEnviar")).Click();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).Clear();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).SendKeys("");
            driver.FindElement(By.Id("btnSeleccionar")).Click();
            driver.FindElement(By.Id("btnEnviar")).Click();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).Clear();
            driver.FindElement(By.Id("txtEncuestaSeleccionada")).SendKeys("Encuesta2");
            driver.FindElement(By.Id("btnSeleccionar")).Click();
            driver.FindElement(By.Id("Boton4")).Click();
            driver.FindElement(By.Id("tdxcomentario")).Clear();
            driver.FindElement(By.Id("tdxcomentario")).SendKeys("comentarioEncuesta2");
            driver.FindElement(By.Id("btnEnviar")).Click();
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
