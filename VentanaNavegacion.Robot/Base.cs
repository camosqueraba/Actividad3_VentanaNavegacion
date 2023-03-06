using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace VentanaNavegacion.Robot
{
    public class Base
    {
        IWebDriver driver;
        WebDriverWait wait;

        public Base(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public IWebDriver ChromeDriverConnection()
        {
            driver = new ChromeDriver();

            return driver;
        }

        public IWebElement FindElement(By locator)
        {
            return driver.FindElement(locator);
        }

        public IEnumerable<IWebElement> FindElements(By locator)
        {
            return driver.FindElements(locator);
        }

        public void SelectFromDropDown(By locator, string value)
        {
            IWebElement elementDropdown = wait.Until(ExpectedConditions.ElementExists(locator));
            //IWebElement elementDropdown = driver.FindElement(locator);
            SelectElement dropdown = new SelectElement(elementDropdown);
            dropdown.SelectByValue(value);
        }

        public void SelectFromDropDownWithClick(By locator, string value)
        {
            //IWebElement elementDropdown = wait.Until(d => d.FindElement(locator));
            IWebElement elementDropdown = wait.Until(ExpectedConditions.ElementExists(locator));
            elementDropdown.Click();
            SelectElement dropdown = new SelectElement(elementDropdown);
            dropdown.SelectByValue(value);
        }

        public string GetText(IWebElement element)
        {
            return element.Text;
        }

        public string GetText(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            return driver.FindElement(locator).Text;
        }

        public void Type(By locator, string text)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            driver.FindElement(locator).SendKeys(text);
        }

        public void Click(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            driver.FindElement(locator).Click();
        }

        public bool IsDisplayed(By locator)
        {
            try
            {
                return driver.FindElement(locator).Displayed;
            }
            catch (OpenQA.Selenium.NoSuchElementException exception)
            {

                return false;
            }
        }

        public void Visit(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
