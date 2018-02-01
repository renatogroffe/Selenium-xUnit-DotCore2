using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Selenium.Utils
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(
            Browser browser, string pathDriver)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Firefox:
                    FirefoxDriverService service =
                        FirefoxDriverService.CreateDefaultService(pathDriver);

                    /*FirefoxOptions optionsFF = new FirefoxOptions();
                    optionsFF.AddArgument("--headless");

                    webDriver = new FirefoxDriver(
                        service, optionsFF, TimeSpan.FromSeconds(30));*/
                    webDriver = new FirefoxDriver(service);

                    break;
                case Browser.Chrome:
                    //ChromeOptions options = new ChromeOptions();
                    //options.AddArgument("--headless");

                    //webDriver = new ChromeDriver(pathDriver, options);
                    webDriver = new ChromeDriver(pathDriver);

                    break;
            }

            return webDriver;
        }
    }
}