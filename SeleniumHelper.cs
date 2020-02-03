using LoginProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace LoginProject
{
    class SeleniumHelper : BasePage
    {
        public static void EnterText(string element, string value, string elementType)
        {
            switch (elementType)
            {
                case "Id":
                    Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element))).SendKeys(value);
                    break;
                case "Name":
                    Wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element))).SendKeys(value);
                    break;
            }
        }

        public static void ClickElement(string element, string elementType)
        {
            switch (elementType)
            {
                case "Id":
                    Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element))).Click();
                    break;
                case "Name":
                    Wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element))).Click();
                    break;
                case "Xpath":
                    Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element))).Click();
                    break;
            }
        }

        public static void SelectDropdown(string element, string value, string elementType)
        {
            switch (elementType)
            {
                case "Id":
                    new SelectElement(Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)))).SelectByText(value);
                    break;
                case "Name":
                    new SelectElement(Wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element)))).SelectByText(value);
                    break;
            }
        }
    }
}
