using SpareRoomAuto.Model;
using SpareRoomAuto.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpareRoomAuto
{
    [Binding]
    public class SignupStepDefinitions
    {
        BasePage _basepage;
        HomePage _homepage;
        RegisterInformationPage _registerInformationPage;
        public SignupStepDefinitions(BasePage basePage, HomePage homePage, RegisterInformationPage registerInformationPage)
        {
            _basepage = basePage;
            _homepage = homePage;
            _registerInformationPage = registerInformationPage;
        }
        [Given(@"Spareroom has been Loaded Sucessfully")]
        public void GivenSpareroomHasBeenLoadedSucessfully()
        {
            _basepage.LoadApplicationUnderTest();
            _homepage.AcceptConsent();
        }

        [When(@"User Clicks on Register")]
        public void WhenUserClicksOnRegister()
        {
            _homepage.ClickRegister();
        }

        [When(@"user fill the following information")]
        public void WhenUserFillTheFollowingInformation(Table table)
        {
            var SignupDetailsInfo = table.CreateInstance<RegisterModel>();
            _registerInformationPage.EnterInformaTion(SignupDetailsInfo.Firstname, SignupDetailsInfo.Lastname, SignupDetailsInfo.Email,
                SignupDetailsInfo.Password, SignupDetailsInfo.Confirm_Password, SignupDetailsInfo.Where_Did_You_Hear_About_Us
                );
            _registerInformationPage.SelectFemaleGender();
        }

        [When(@"User fIlls the date of Birth with the following")]
        public void WhenUserFIllsTheDateOfBirthWithTheFollowing(Table table)
        {
            var DateOfBirthInfo = table.CreateInstance<DateOfBirthModel>();
            _registerInformationPage.EnterDateOfBirth(DateOfBirthInfo.Day, DateOfBirthInfo.Month, DateOfBirthInfo.Year);
        }

        [When(@"the user clicks Im looking for House share checkbox")]
        public void WhenTheUserClicksImLookingForHouseShareCheckbox()
        {
            _registerInformationPage.ClickHouseShareCheckBox();
            
        }
        
        [When(@"the user inserts ""([^""]*)"" as  Where_Did_You_Hear_About_Us")]
        public void WhenTheUserInsertsAsWhere_Did_You_Hear_About_Us(string newspaper)
        {
           _registerInformationPage.InsertWhereYouHeardFromUs(newspaper);
        }

       
        [When(@"User Clicks  on Register now")]
        public void WhenUserClicksOnRegisterNow()
        {
            _registerInformationPage.ClickSubmitButton();
        }

        [When(@"user clicks on skip")]
        public void WhenUserClicksOnSkip()
        {
            _registerInformationPage.ClickSkipButton();
            _registerInformationPage.ClickContine();
        }

        [Then(@"the user is Signed up successfully")]
        public void ThenTheUserIsSignedUpSuccessfully()
        {
           Assert.IsTrue(_homepage.IsSpareroomImageDisplayed());
          _homepage.EmailMessageDisplayed();
            Assert.IsTrue(_homepage.IsHelpDisplayed());  
        }
    }


       
    
}
