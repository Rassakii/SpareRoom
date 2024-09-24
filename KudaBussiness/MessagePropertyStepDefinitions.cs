using SpareRoomAuto.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpareRoomAuto
{
    [Binding]
    public class MessagePropertyStepDefinitions
    {
        BasePage _basepage;
        HomePage _homepage;
        PropertyAvailablePage _propertyAvailablePage;
        public MessagePropertyStepDefinitions(BasePage basePage, HomePage homePage,PropertyAvailablePage propertyAvailablePage)
        {
            _basepage = basePage;
            _homepage = homePage;
            _propertyAvailablePage = propertyAvailablePage;

        }

        [Given(@"SpareRoom is loaded Succesfully")]
        public void GivenSpareRoomIsLoadedSuccesfully()
        {
           _basepage.LoadApplicationUnderTest();
            _homepage.AcceptConsent();
        }

        [When(@"user  Fills in ""([^""]*)"" in the search box")]
        public void WhenUserFillsInInTheSearchBox(string bolton)
        {
            _homepage.InsertLocation(bolton);
        }

        [When(@"user clicks on search button")]
        public void WhenUserClicksOnSearchButton()
        {
            _homepage.ClickSearchButton();
        }

        [When(@"the user ""([^""]*)""  miles radius in the dropdown")]
        public void WhenTheUserMilesRadiusInTheDropdown(string p0)
        {
            _propertyAvailablePage.SelectRadiusDropdown(p0);
        }

        [When(@"user inserts ""([^""]*)"" in the minimum rent")]
        public void WhenUserInsertsInTheMinimumRent(string p0)
        {
            _propertyAvailablePage.InsertMinimunRent(p0);
        }

        [When(@"user inserts ""([^""]*)"" in the maXimum rent")]
        public void WhenUserInsertsInTheMaXimumRent(string p0)
        {
            _propertyAvailablePage.InsertMaximumRent(p0);
        }

        [When(@"user clicks on apply filter")]
        public void WhenUserClicksOnApplyFilter()
        {
            _propertyAvailablePage.ClickApplyFilter();
        }

        [When(@"user clicks on House in bury ads")]
        public void WhenUserClicksOnHouseInBuryAds()
        {
            _propertyAvailablePage.ClickBl1House();
        }

        [When(@"user clicks on message")]
        public void WhenUserClicksOnMessage()
        {
            _propertyAvailablePage.ClickMessageButton();
        }

        [When(@"User inserts ""([^""]*)""")]
        public void WhenUserInserts(string p0)
        {
            _propertyAvailablePage.EnterMessage(p0);
        }

        [When(@"user inserts ""([^""]*)"" in the login email box")]
        public void WhenUserInsertsInTheLoginEmailBox(string p0)
        {
            _propertyAvailablePage.InsertEmail(p0);
        }


        [When(@"User inserts ""([^""]*)"" as password")]
        public void WhenUserInsertsAsPassword(string p0)
        {
            _propertyAvailablePage.InsertPassword(p0);
        }

        [When(@"user clicks on Login and send button")]
        public void WhenUserClicksOnLoginAndSendButton()
        {
            _propertyAvailablePage.ClickLoginAndSend();
        }

        [Then(@"User is logged in and message sent succesfully")]
        public void ThenUserIsLoggedInAndMessageSentSuccesfully()
        {
            _propertyAvailablePage.VerifySuccessMessage();
            _propertyAvailablePage.VerifyTipMessage();
        }
    }
}
