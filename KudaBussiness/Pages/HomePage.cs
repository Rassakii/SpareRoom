using OpenQA.Selenium;

namespace SpareRoomAuto.Pages
{

    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement ConsentMessage => _driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        private IWebElement RegisterButton => _driver.FindElement(By.Id("registerButtonNav"));
        private IWebElement DisplayedImage => _driver.FindElement(By.XPath("//section[@class='hero']"));
        private IWebElement DisplayedName => _driver.FindElement(By.XPath("//h3[contains(text(),'Welcome')]"));
        private IWebElement EmailSentMessage => _driver.FindElement(By.XPath("//div[@class='confirm-email__message hide-email']"));
        private IWebElement PosTAddButton => _driver.FindElement(By.LinkText("Help"));
        private IWebElement LoginButton => _driver.FindElement(By.XPath("//a[@id='loginButtonNav']"));
        private IWebElement EmailTextField => _driver.FindElement(By.XPath("//input[@id='loginemail']"));
        private  IWebElement  LoginPasswordTextField => _driver.FindElement(By.Id("loginpass"));
        private IWebElement RememberMeCheckbox => _driver.FindElement(By.CssSelector("label[for='remember_me_checkbox']"));
        private IWebElement LoginINButton => _driver.FindElement(By.XPath("//button[@id='sign-in-button']"));
        private IWebElement WelcomeMessage => _driver.FindElement(By.XPath("//p[@class='brand-header__welcome']"));
        private IWebElement MyAdds => _driver.FindElement(By.XPath("//a[@id='myListingsNav']"));
        private IWebElement WhoIsInterestedlink => _driver.FindElement(By.XPath("//a[@id='whoIsInterestedNav']"));
        private IWebElement SearchTextfield => _driver.FindElement(By.Id("search_by_location_field"));
        private IWebElement SearchButton => _driver.FindElement(By.Id("search_by_location_submit_button"));
      
        public void ClickRegister()
        {
            RegisterButton.Click();
        }
        public void AcceptConsent()
        {
            ConsentMessage.Click();
        }
        public bool IsSpareroomImageDisplayed() 
        {
            return DisplayedImage.Displayed;
        }
        public void EmailMessageDisplayed()
        {
            string EmailsentMessage = EmailSentMessage.Text;
            StringAssert.Contains("Confirm your email to activate your account.", EmailsentMessage);

        }
        public bool IsHelpDisplayed()
        {
            return PosTAddButton.Displayed;
        }
        public void CliclLoginButton()
        {
            LoginButton.Click();
        }
        public void InsertEmail(string email) 
        { 
            EmailTextField.SendKeys(email);
        }
        public void InsertLoginPassword(string password) 
        {
            LoginPasswordTextField.SendKeys(password);

        }
        public void ClickRememberMeCheckbox() 
        { 
            RememberMeCheckbox.Click();
      
        }
        public void ClickLoginButton() 
        {
            LoginINButton.Click();
        }
        public void DisplayWelcomeMessage()
        {
            string welcomemessage = WelcomeMessage.Text;
            StringAssert.Contains("Hi Abdulrasaq", welcomemessage);

        }
        public bool DisplayMyAdds() 
        {
            return MyAdds.Displayed;
        }
        public void InsertLocation(string location) 
        { 
            SearchTextfield.SendKeys(location);
        }
        public void ClickSearchButton() 
        { SearchButton.Click(); 

        }
       
       
    }
}
