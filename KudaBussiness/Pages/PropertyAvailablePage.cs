using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpareRoomAuto.Pages
{
    public class PropertyAvailablePage
    {
        private IWebDriver _driver;

        public PropertyAvailablePage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement RadiusDropdown => _driver.FindElement(By.XPath("//select[@id='radius']"));
        private IWebElement MinimumRentTextField => _driver.FindElement(By.Id("minRent"));
        private IWebElement MaximumRentTextField => _driver.FindElement(By.Id("maxRent"));
        private IWebElement ApplyFilterButton => _driver.FindElement(By.XPath("//button[normalize-space()='Apply filters']"));
        private IWebElement BL1HouseButton => _driver.FindElement(By.XPath("//p[contains(text(),'Professional Share')]"));
        private IWebElement MessageButton => _driver.FindElement(By.CssSelector("span[class='page-tabs__h2']"));
        private IWebElement MessageTextField => _driver.FindElement(By.XPath("//textarea[@id='message']"));
        private IWebElement EmailTextField => _driver.FindElement(By.XPath("//input[@name='login_email']"));
        private IWebElement PasswordTextField => _driver.FindElement(By.XPath("//input[@name='login_password']"));
        private IWebElement LoGiNAndSendButton => _driver.FindElement(By.XPath("//input[@name='Submit']"));
        private IWebElement SuccessMessage => _driver.FindElement(By.XPath("//p[contains(text(),'Thank you - your message has been sent. Please be ')]"));
        private IWebElement TopTipMessage => _driver.FindElement(By.XPath("//p[contains(text(),'TOP TIP! Complete your profile for better response')]"));
       
        
        public void SelectRadiusDropdown(string Radius)
        {
            SelectElement cd = new SelectElement(RadiusDropdown);
            cd.SelectByValue(Radius);
        }
        public void InsertMinimunRent(string rentfee)
        {
            MinimumRentTextField.SendKeys(rentfee);
        }
        public void InsertMaximumRent(string rentfee) 
        { 
            MaximumRentTextField.SendKeys(rentfee);
        }
        public void ClickApplyFilter()  
        { 
            ApplyFilterButton.Click();
        }
        public void ClickBl1House()
        {
            BL1HouseButton.Click();
        }
        public void ClickMessageButton() 
        { MessageButton.Click();
        }
        public void EnterMessage(string message) 
        { 
            MessageTextField.SendKeys(message);
        }
        public void InsertEmail(string email)
        {  EmailTextField.SendKeys(email); 
        }
        public void InsertPassword(string password) 
        {  PasswordTextField.SendKeys(password);
        }
        public void ClickLoginAndSend()
        {
            LoGiNAndSendButton.Click();
        }
        public void VerifySuccessMessage() 
        { 
            string SucessMessage= SuccessMessage.Text;
            StringAssert.Contains("Thank you - your message has been sent. Please be patient when waiting for a response", SucessMessage);
        }
        public void VerifyTipMessage()
        {
            string TipMessage = TopTipMessage.Text;
            StringAssert.Contains("TOP TIP! Complete your profile for better responses", TipMessage);
        }


    }
}
