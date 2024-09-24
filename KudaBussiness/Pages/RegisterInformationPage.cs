using OpenQA.Selenium;
using TechTalk.SpecFlow.CommonModels;

namespace SpareRoomAuto.Pages
{
    public class RegisterInformationPage
    {
        private IWebDriver _driver;

        public RegisterInformationPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement FirstNameTextField => _driver.FindElement(By.Name("first_name"));
        private IWebElement LastNameTextField => _driver.FindElement(By.Name("last_name"));
        private IWebElement EmailAddressTextField => _driver.FindElement(By.Name("email"));
        private IWebElement PasswordTextField => _driver.FindElement(By.Name("password"));
        private IWebElement ConfirmPasswordTextfield => _driver.FindElement(By.Name("password_again"));
        private IWebElement WhereDidYouHearfromUsTextField => _driver.FindElement(By.Name("where_heard"));
        private IWebElement GenderRadioButton => _driver.FindElement(By.XPath("//input[@name='gender' and @value='F']"));
        private IWebElement DayTextField => _driver.FindElement(By.Id("dofb_day"));
        private IWebElement MonthTextField => _driver.FindElement(By.Id("dofb_month"));
        private IWebElement YearTextField => _driver.FindElement(By.Id("dofb_year"));
        private IWebElement RegisterButton => _driver.FindElement(By.Id("registerbutton"));
        private IWebElement HouseShareCheckBox => _driver.FindElement(By.XPath("//input[@type='checkbox' and @value='lookingforashare']"));
        private IWebElement WhereDidYouHearTextfiled => _driver.FindElement(By.Name("where_heard"));
        private IWebElement SubmitButton => _driver.FindElement(By.Name("submit"));
        private IWebElement SkipButton => _driver.FindElement(By.XPath("//button[normalize-space()='Skip']"));
        private IWebElement SuucessMessage => _driver.FindElement(By.XPath("//p[@class='msg success']"));
        private IWebElement ContinueButton => _driver.FindElement(By.CssSelector("a[class='button']"));


        public void EnterInformaTion(string FirstName, string LastName, string Email, string Password,
            string Confirm_Password, string Where_Did_You_Hear_About_Us)
        {
            FirstNameTextField.SendKeys(FirstName);
            LastNameTextField.SendKeys(LastName);
            EmailAddressTextField.SendKeys(Email);
            PasswordTextField.SendKeys(Password);
            ConfirmPasswordTextfield.SendKeys(Confirm_Password);
            WhereDidYouHearfromUsTextField.SendKeys(Where_Did_You_Hear_About_Us);





        }
        public void SelectFemaleGender()
        {
            GenderRadioButton.Click();
        }
        public void EnterDateOfBirth(string Day, string Month, string Year)
        {
            DayTextField.SendKeys(Day);
            MonthTextField.SendKeys(Month);
            YearTextField.SendKeys(Year);
        }
        public void ClickRegisterButton()
        {
            RegisterButton.Click();
        }
        public void ClickHouseShareCheckBox()
        {
            HouseShareCheckBox.Click();
        }
        public void InsertWhereYouHeardFromUs(string Where_Did_You_Hear_About_Us)
        {
            WhereDidYouHearfromUsTextField.SendKeys(Where_Did_You_Hear_About_Us);
        }
        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }
        public void ClickSkipButton() 
        { 
            SkipButton.Click();
        }
        public void AssertSuccessMessage()
        {
            string Dispayederror = SuucessMessage.Text;
            StringAssert.Contains("Thank you, you have successfully registered with SpareRoommessage", Dispayederror);
        }
        public void ClickContine()
        {
            ContinueButton.Click();
        }
    }
}
