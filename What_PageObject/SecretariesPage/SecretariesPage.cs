using System;
using System.Collections.Generic;
using NUnit.Framework;
using What_Common.DriverManager;
using What_Common.Resources;
using System.Linq;

namespace What_PageObject.SecretariesPage
{
    public class SecretariesPage : BasePageWithSideBar
    {
        string randomNameFromTable;
        string tableData;
        string cardsData;

        public SecretariesPage WaitTableData()
        {
            WaitUntilElementLoads<SecretariesPage>(Locators.SecretaryPage.tableData);
            return this;
        }
        public SecretariesPage WaitCardsData()
        {
            WaitUntilElementLoads<SecretariesPage>(Locators.SecretaryPage.cardData);
            return this;
        }
        public SecretariesPage GetTableData()
        {
            var table = Driver.Current.FindElements(Locators.SecretaryPage.tableData);
            foreach (var item in table)
            {
                tableData += item.Text + Resources.Secretary.space; 
            }
            return this;
        }
        public SecretariesPage GetCardsData()
        {
            var cards = Driver.Current.FindElements(Locators.SecretaryPage.cardData);
            foreach (var item in cards)
            {
                cardsData += item.Text.Replace(Environment.NewLine, Resources.Secretary.space).Replace(Resources.Secretary.details, Resources.Secretary.empty);
            }
            cardsData = cardsData.Replace(Resources.Secretary.doublespace, Resources.Secretary.space);
            return this;
        }
        public SecretariesPage ClickCardsButton()
        {
            ClickElement(Locators.SecretaryPage.cardsButton);
            return this;
        }
        public SecretariesPage CompareCardsDataWithTableData()
        {
            CollectionAssert.AreEqual(tableData, cardsData);
            return this;
        }
        public SecretariesPage FillSearchField()
        {
            FillField(Locators.SecretaryPage.searchField, randomNameFromTable);
            return this;
        }
        public SecretariesPage FillSearchField(string text)
        {
            FillField(Locators.SecretaryPage.searchField, text);
            return this;
        }
        public string GetNameFromTable(int number)
        {
            return Driver.Current.FindElement(Locators.SecretaryPage.CurrentTableNameData(number)).Text;
        }
        public SecretariesPage GetRandomNameFromTable()
        {
            int number = new Random().Next(1, Driver.Current.FindElements(Locators.SecretaryPage.tableButton).Count + 1);
            randomNameFromTable = GetNameFromTable(number);
            return this;
        }
        public SecretariesPage CompareSearchData()
        {
            Assert.AreEqual(randomNameFromTable, GetNameFromTable(1));
            return this;
        }
        public SecretariesPage CompareSearchDataInvalid()
        {
            Assert.AreEqual(Resources.Secretary.searchNotFound, Driver.Current.FindElement(Locators.SecretaryPage.searchNotFound).Text);
            return this;
        }
        public SecretariesPage ClickSortByName()
        {
            ClickElement(Locators.SecretaryPage.sortByName);
            return this;
        }
        public SecretariesPage ClickSortBySurname()
        {
            ClickElement(Locators.SecretaryPage.sortBySurname);
            return this;
        }
        public SecretariesPage ClickSortByEmail()
        {
            ClickElement(Locators.SecretaryPage.sortByEmail);
            return this;
        }
        public SecretariesPage VerifySortingByFirstNameByAsc()
        {
            List<string> dataSortedByTable = GetFirstNameFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderBy(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public SecretariesPage VerifySortingByLastNameByAsc()
        {
            List<string> dataSortedByTable = GetLastNameFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderBy(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public SecretariesPage VerifySortingByEmailByAsc()
        {
            List<string> dataSortedByTable = GetEmailFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderBy(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public SecretariesPage VerifySortingByFirstNameByDesc()
        {
            List<string> dataSortedByTable = GetFirstNameFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderByDescending(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public SecretariesPage VerifySortingByLastNameByDesc()
        {
            List<string> dataSortedByTable = GetLastNameFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderByDescending(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

            return this;
        }

        public SecretariesPage VerifySortingByEmailByDesc()
        {
            List<string> dataSortedByTable = GetEmailFromTableData();
            List<string> dataSortedByTest = new List<string>(dataSortedByTable);

            dataSortedByTest.OrderByDescending(x => x);

            CollectionAssert.AreEqual(dataSortedByTest, dataSortedByTable);

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
        public SecretariesPage ClickDisabledCheckbox()
        {
            ClickElement(Locators.SecretaryPage.disabledCheckbox);
            return this;
        }
        public SecretariesPage ClickNextTopButton()
        {
            ClickElement(Locators.SecretaryPage.paginationArrowRightInTop);
            return this;
        }
        public SecretariesPage ClickPrevTopButton()
        {
            ClickElement(Locators.SecretaryPage.paginationArrowLeftInTop);
            return this;
        }
        public SecretariesPage ClickNextBottomButton()
        {
            ClickElement(Locators.SecretaryPage.paginationArrowRightInTop);
            return this;
        }
        public SecretariesPage ClickPrevBottomButton()
        {
            ClickElement(Locators.SecretaryPage.paginationArrowLeftInBottom);
            return this;
        }
    }
}
