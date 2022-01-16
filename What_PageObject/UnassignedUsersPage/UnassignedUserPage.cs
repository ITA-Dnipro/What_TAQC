using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.UnassignedUsersPage
{
    public class UnassignedUserPage : BasePage
    {
        private WebDriverWait wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));

        public UnassignedUserPage ClickNextTopButton()
        {
            ClickElement(Locators.UnassignedUser.TopRightArrowButton);

            return this;
        }

        public UnassignedUserPage ClickPrevTopButton()
        {
            ClickElement(Locators.UnassignedUser.TopLeftArrowButton);

            return this;
        }

        public UnassignedUserPage ClickNextBottomButton()
        {
            ClickElement(Locators.UnassignedUser.BottomRightArrowButton);

            return this;
        }

        public UnassignedUserPage ClickPrevBottomButton()
        {
            ClickElement(Locators.UnassignedUser.BottomLeftArrowButton);

            return this;
        }

        public UnassignedUserPage ClickSearchField()
        {
            ClickElement(Locators.UnassignedUser.SearchInputField);

            return this;
        }

        public UnassignedUserPage FillSearchField(string text)
        {
            FillField(Locators.UnassignedUser.SearchInputField, text);

            return this;
        }

        public UnassignedUserPage ClickNavbarMenuListOfUnassignedButton()
        {
            ClickElement(Locators.UnassignedUser.ClickToNavbarMenuListOfUnassignedButton);

            return this;
        }

        public UnassignedUserPage ClickSortByName()
        {
            ClickElement(Locators.UnassignedUser.SortedByName);

            return this;
        }

        public UnassignedUserPage ClickSortBySurname()
        {
            ClickElement(Locators.UnassignedUser.SortedBySurname);

            return this;
        }

        public UnassignedUserPage ClickSortByEmail()
        {
            ClickElement(Locators.UnassignedUser.SortedByEmail);

            return this;
        }

        public UnassignedUserPage ClickFirstPagination()
        {
            ClickElement(Locators.UnassignedUser.FirstPagePagination);

            return this;
        }

        public UnassignedUserPage ClickLastPagination()
        {
            ClickElement(Locators.UnassignedUser.LastPagePagination);

            return this;
        }

        public UnassignedUserPage WaitClickNavbarMenuListOfUnassignedButton()
        {
            wait.Until(e => e.FindElement(Locators.UnassignedUser.TableData));

            ClickElement(Locators.UnassignedUser.ClickToNavbarMenuListOfUnassignedButton);

            return this;
        }

        public UnassignedUserPage WaitClickLastPagination()
        {
            wait.Until(e => e.FindElement(Locators.UnassignedUser.TableData));

            ClickElement(Locators.UnassignedUser.LastPagePagination);

            return this;
        }

        public UnassignedUserPage WaitNavigateToPage(int page)
        {
            wait.Until(e => e.FindElement(Locators.UnassignedUser.TableData));

            ClickElement(Locators.UnassignedUser.NavigateToPage(page));

            return this;
        }

        public string GetUnassignedUserFirstName(int row)
        {
            return GetTextValue(Locators.UnassignedUser.UnassignedUserFirstName(row));
        }

        public string GetUnassignedUserLastName(int row)
        {
            return GetTextValue(Locators.UnassignedUser.UnassignedUserLastName(row));
        }

        public string GetUnassignedUserEmail(int row)
        {
            return GetTextValue(Locators.UnassignedUser.UnassignedUserEmail(row));
        }

        public string GetTextValue(By locator)
        {
            return Driver.Current.FindElement(locator).Text;
        }
    }
}
