using What_Common.DriverManager;
using What_PageObject.SignInPage;

namespace What_PageObject
{
    public class Header : BasePage
    {
        public Header ClickMyProfile()//MyProfilePage
        {
            ClickElement(What_Common.Resources.Locators.CommonLocator.DropdownNameElement);
            ClickElement(What_Common.Resources.Locators.CommonLocator.MyProfile);

            return new Header();
        }

        public Header ClickChangePassword() //ChangePasswordPage
        {
            ClickElement(What_Common.Resources.Locators.CommonLocator.DropdownNameElement);
            ClickElement(What_Common.Resources.Locators.CommonLocator.MyProfile);

            return new Header();
        }

        public SignInPage.SignInPage Logout()
        {
            ClickElement(What_Common.Resources.Locators.CommonLocator.DropdownNameElement);
            ClickElement(What_Common.Resources.Locators.CommonLocator.MyProfile);

            return new SignInPage.SignInPage();
        }
    }
}