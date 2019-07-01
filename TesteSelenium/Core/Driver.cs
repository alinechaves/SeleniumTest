using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TesteSelenium.Core
{
    public static class Driver
    {

        public enum BrowserTypes
        {
            Firefox,
            InternetExplorer,
            Chrome,
            NotSet
        }

        public static IWebDriver driver;

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome, int defaultTimeOut = 3000, bool headless = false)
        {
            ChromeOptions options = new ChromeOptions();

            if (headless)
            {
                options.AddArguments("--window-size=1920,1080");
                options.AddArguments("--start-maximized");
                options.AddArguments("--headless");
            }
            
            switch (browserType)
            {
                case BrowserTypes.Firefox:
                    break;
                case BrowserTypes.InternetExplorer:
                    break;
                case BrowserTypes.Chrome:

                    driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),options);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    break;
                default:
                    break;
            }

           

        }

        public static void StopBrowser()
        {
            driver.Quit();
        }

        public static void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
