using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace BookStoreAutomationTest.Helpers
{
    public static class LocalHelpers
    {
        private static IDictionary<string, object> _dictionary = new Dictionary<string, object>();

        /// <summary>Writes out to the console: Log: <paramref name="message"/>.</summary>
        public static void Log(string message)
        {
            Console.WriteLine($"Log: {message}.");
        }

        #region Dictionary Helpers
        /// <summary>Adds the value of <paramref name="value"/> to the dictionary with the specified <paramref name="key"/></summary>
        public static T AddContext<T>(T value, string key)
        {
            _dictionary[key] = value;
            return value;
        }

        /// <summary>Gets the value of the specified <paramref name="key"/> from the dictionary</summary>
        public static T GetContext<T>(string key)
        {
            return (T)_dictionary[key];
        }

        /// <summary>Removes the specified <paramref name="key"/> from the dictionary</summary>
        public static void RemoveContext(string key)
        {
            _dictionary.Remove(key);
        }

        /// <summary>Used in SetUp.</summary>
        public static IWebDriver AddDriverContext(IWebDriver driver)
        {
            return AddContext(driver, "drivercontext");
        }

        /// <summary>Used in PageObjects.</summary>
        public static IWebDriver GetDriverContext
        {
            get
            {
                return GetContext<IWebDriver>("drivercontext");
            }
        }
        #endregion

        #region Wait Helpers
        /// <summary>Waits until a page element is visible for a maximum of 15 seconds. If the element is found before 15 seconds elapses, then waiting stops.</summary>
        public static bool WaitUntilElementVisible(this IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch
            {
                Log($"Unable to find element by locator: {locator}.");
                return false;
            }
        }
        #endregion
    }
}
