using NUnit.Framework;
using What_Common.DataProvider;
using What_Common.Resources;
using What_PageObject.MentorsPage;
using What_PageObject.SignInPage;


namespace What_UITest.MentorsPageTest
{
    internal class EditMentorDetailsValid : BaseTest
    {
        private SignInPage signInPage;
        private MentorsPage mentorsPage;        
        private LoginDetails user = Controller.GetUser(Controller.UserRole.Admin);

        [SetUp]
        public void Setup()
        {
            signInPage = new SignInPage();
            signInPage.IsAtPage();
            signInPage.LogIn(user.Email, user.Password);
            mentorsPage = new MentorsPage();
        }

        [Test(Description = "DP220TAQC-111")]
        public void VerifyAccessAdminSecretaryRoleToEditMentorDetails()
        {
            mentorsPage.ClickOnSideBar()
                .VerifyMentorsPage("Mentors")
                .ClickMentorInTable()
                .VerifyMentorDetails("Mentor Details")
                .ClickEditMentorPage()
                .VerifyEditMentorPage("Mentor Editing");
        }
    }
}
