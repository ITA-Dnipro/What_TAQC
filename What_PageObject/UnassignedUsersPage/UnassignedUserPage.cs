using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.UnassignedUsersPage
{
    public class UnassignedUserPage : BasePageWithSideBar
    {
        protected WebDriverWait wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));
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

        public UnassignedUserPage ClickPageButton(int row)
        {
            ClickElement(Locators.UnassignedUser.ClickPagination(row));

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

        public UnassignedUserPage ClickAddRoleButton(int row)
        {
            ClickElement(Locators.UnassignedUser.ClickToAddRoleButton(row));
            wait.Until(e => e.FindElement(Locators.UnassignedUser.TableData));
            Thread.Sleep(100);
            return this;
        }

        public UnassignedUserPage SetRoleToCurrentUser(int row, int role)
        {
            ClickElement(Locators.UnassignedUser.ChooseRoleAtCurrentRow(row, role));

            return this;
        }

        public int GetPageCount()
        {
            return Convert.ToInt32(GetTextValue(Locators.UnassignedUser.LastPagePagination));
        }

        public int GetCurretnPageTableDataCount()
        {
            wait.Until(e => e.FindElement(Locators.UnassignedUser.TableData));
            var list = Driver.Current.FindElements(Locators.UnassignedUser.TableData);

            return list.Count;
        }

        public List<string> GetCurretnPageTableData()
        {
            List<string> data = new List<string>();

            wait.Until(e => e.FindElement(Locators.UnassignedUser.TableData));

            var firstNameList = Driver.Current.FindElements(Locators.UnassignedUser.TableData);

            foreach (var item in firstNameList)
            {
                data.Add(item.Text);
            }

            return data;
        }

        public UnassignedUserPage WaitClickLastPagination()
        {
            wait.Until(e => e.FindElement(Locators.UnassignedUser.TableData));

            ClickElement(Locators.UnassignedUser.LastPagePagination);

            return this;
        }

        public List<string> GetFirstNameFromTableData()
        {
            List<string> data = new List<string>();

            var firstNameList = Driver.Current.FindElements(Locators.UnassignedUser.FirstNameTableData);

            foreach (var item in firstNameList)
            {
                data.Add(item.Text);
            }

            return data;
        }

        public List<string> GetLastNameFromTableData()
        {
            List<string> data = new List<string>();

            var firstNameList = Driver.Current.FindElements(Locators.UnassignedUser.LastNameTableData);

            foreach (var item in firstNameList)
            {
                data.Add(item.Text);
            }

            return data;
        }

        public List<string> GetEmailFromTableData()
        {
            List<string> data = new List<string>();

            var firstNameList = Driver.Current.FindElements(Locators.UnassignedUser.EmailTableData);

            foreach (var item in firstNameList)
            {
                data.Add(item.Text);
            }

            return data;
        }

        public UnassignedUserPage GetUserFromRow(int row, out string user)
        {
            user = GetUnassignedUserFirstNameByRow(row)
                 + " "
                 + GetUnassignedUserLastNameByRow(row)
                 + " "
                 + GetUnassignedUserEmailByRow(row);

            return this;
        }

        public UnassignedUserPage VerifySortingByFirstNameByAsc()
        {
            List<string> dataSortedByTable = GetFirstNameFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderBy(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public UnassignedUserPage VerifySortingByLastNameByAsc()
        {
            List<string> dataSortedByTable = GetLastNameFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderBy(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public UnassignedUserPage VerifySortingByEmailByAsc()
        {
            List<string> dataSortedByTable = GetEmailFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderBy(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public UnassignedUserPage VerifySortingByFirstNameByDesc()
        {
            List<string> dataSortedByTable = GetFirstNameFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderByDescending(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public UnassignedUserPage VerifySortingByLastNameByDesc()
        {
            List<string> dataSortedByTable = GetLastNameFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderByDescending(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public UnassignedUserPage VerifySortingByEmailByDesc()
        {
            List<string> dataSortedByTable = GetEmailFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderByDescending(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public UnassignedUserPage VerifyUserExistInTable(string user)
        {
            for (int i = GetPageCount(); i >= 1; i--)
            {
                ClickPageButton(i);

                wait.Until(e => e.FindElement(Locators.UnassignedUser.TableData));
                var data = GetCurretnPageTableData();

                if (data.Contains(user))
                {
                    Assert.Pass();
                    return this;
                }
            }

            Assert.Fail();
            return this;
        }

        public string GetUnassignedUserFirstNameByRow(int row)
        {
            return GetTextValue(Locators.UnassignedUser.UnassignedUserFirstName(row));
        }

        public string GetUnassignedUserLastNameByRow(int row)
        {
            return GetTextValue(Locators.UnassignedUser.UnassignedUserLastName(row));
        }

        public string GetUnassignedUserEmailByRow(int row)
        {
            return GetTextValue(Locators.UnassignedUser.UnassignedUserEmail(row));
        }

        public string GetTextValue(By locator)
        {
            return Driver.Current.FindElement(locator).Text;
        }
    }
}