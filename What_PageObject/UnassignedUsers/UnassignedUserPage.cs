using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using What_Common.DriverManager;
using What_PageObject.BasePage;
using What_PageObject.UnassignedUsers;

namespace WHAT_PageObject.UnassignedUsers
{
    public class UnassignedUserPage : BasePage
    {
        private WebDriverWait wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));

        public UnassignedUserPage ClickNextTopButton()
        {
            ClickElement(Locators.TopRightArrowButton);

            return this;
        }

        public UnassignedUserPage ClickPrevTopButton()
        {
            ClickElement(Locators.TopLeftArrowButton);

            return this;
        }

        public UnassignedUserPage ClickNextBottomButton()
        {
            ClickElement(Locators.BottomRightArrowButton);

            return this;
        }

        public UnassignedUserPage ClickPrevBottomButton()
        {
            ClickElement(Locators.BottomLeftArrowButton);

            return this;
        }

        public UnassignedUserPage ClickSearchField()
        {
            ClickElement(Locators.SearchInputField);

            return this;
        }

        public UnassignedUserPage FillSearchField(string text)
        {
            FillField(Locators.SearchInputField, text);

            return this;
        }

        public UnassignedUserPage ClickNavbarMenuListOfUnassignedButton()
        {
            ClickElement(Locators.ClickToNavbarMenuListOfUnassignedButton);

            return this;
        }

        public UnassignedUserPage ClickSortByName()
        {
            ClickElement(Locators.SortedByName);

            return this;
        }

        public UnassignedUserPage ClickSortBySurname()
        {
            ClickElement(Locators.SortedBySurname);

            return this;
        }

        public UnassignedUserPage ClickSortByEmail()
        {
            ClickElement(Locators.SortedByEmail);

            return this;
        }

        public UnassignedUserPage ClickFirstPagination()
        {
            ClickElement(Locators.FirstPagePagination);

            return this;
        }

        public UnassignedUserPage ClickLastPagination()
        {
            ClickElement(Locators.LastPagePagination);

            return this;
        }

        public UnassignedUserPage WaitClickNavbarMenuListOfUnassignedButton()
        {
            wait.Until(e => e.FindElement(Locators.TableData));

            ClickElement(Locators.ClickToNavbarMenuListOfUnassignedButton);

            return this;
        }

        public UnassignedUserPage WaitClickLastPagination()
        {
            wait.Until(e => e.FindElement(Locators.TableData));

            ClickElement(Locators.LastPagePagination);

            return this;
        }

        public UnassignedUserPage WaitNavigateToPage(int page)
        {
            wait.Until(e => e.FindElement(Locators.TableData));

            ClickElement(Locators.NavigateToPage(page));

            return this;
        }

        public string GetUnassignedUserFirstName(int row)
        {
            return GetTextValue(Locators.UnassignedUserFirstName(row));
        }

        public string GetUnassignedUserLastName(int row)
        {
            return GetTextValue(Locators.UnassignedUserLastName(row));
        }

        public string GetUnassignedUserEmail(int row)
        {
            return GetTextValue(Locators.UnassignedUserEmail(row));
        }

        public string GetTextValue(By locator)
        {
            return Driver.Current.FindElement(locator).Text;
        }
    }
}
