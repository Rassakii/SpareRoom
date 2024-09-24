using OpenQA.Selenium;
using SpareRoomAuto.Configuration;




namespace SpareRoomAuto.Pages
{


    public class BasePage
    {
        public IWebDriver Driver;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void LoadApplicationUnderTest()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.Url);
            Driver.Manage().Window.Maximize();
        }

    }
}
