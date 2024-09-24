using SpareRoomAuto.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpareRoomAuto
{
   
    [Binding]
    public class LoginStepDefinitions
    {
        BasePage _basepage;
        HomePage _homepage;
        public LoginStepDefinitions(BasePage basePage, HomePage homePage)
        {
            _basepage = basePage;
            _homepage = homePage;


        }

        [Given(@"Spareroom has loaded successfully")]
        public void GivenSpareroomHasLoadedSuccessfully()
        {
            _basepage.LoadApplicationUnderTest();
            _homepage.AcceptConsent();
        }

        [When(@"When user click on login button")]
        public void WhenWhenUserClickOnLoginButton()
        {
            _homepage.CliclLoginButton();
        }

        [When(@"user inserts Email as ""([^""]*)""")]
        public void WhenUserInsertsEmailAs(string p0)
        {
            _homepage.InsertEmail(p0);
        }

        [When(@"user inserts password as ""([^""]*)""")]
        public void WhenUserInsertsPasswordAs(string p0)
        {
            _homepage.InsertLoginPassword(p0);
        }

        [When(@"user clicks Remember me Checkbox")]
        public void WhenUserClicksRememberMeCheckbox()
        {
            _homepage.ClickRememberMeCheckbox();
        }

        [When(@"user clicks on Login")]
        public void WhenUserClicksOnLogin()
        {
            _homepage.ClickLoginButton();
        }

        [Then(@"User is logged in succesfully")]
        public void ThenUserIsLoggedInSuccesfully()
        {
            _homepage.DisplayWelcomeMessage();
            Assert.IsTrue(_homepage.DisplayMyAdds());

        }
    }
}
