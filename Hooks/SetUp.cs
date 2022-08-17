using BookStoreAutomationTest.Helpers;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace BookStoreAutomationTest.Hooks
{
    public class SetUp
    {
        private static IWebDriver _driver;

        private static ChromeDriver SetUpChromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), version: VersionResolveStrategy.MatchingBrowser);
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            return new ChromeDriver();
        }

        private static void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        private static string SiteUrl
        {
            get
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
                return config["AppSettings:url"];
            }
        }

        public static void DriverSetUp()
        {
            _driver = SetUpChromeDriver();
            _driver.Manage().Window.Maximize();
            GoToUrl(SiteUrl);
            LocalHelpers.AddDriverContext(_driver);
        }

        public static void TearDown()
        {
            _driver.Dispose();
        }
    }
}
