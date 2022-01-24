using NUnit.Framework;
using System.Text.RegularExpressions;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.GroupsPage
{
    public class GroupsPage : BasePageWithSideBar
    {
        public GroupsPage TableIconSwitchButton()
        {
            ClickElement(Locators.GroupsPage.tableButton);
            return this;
        }

        private List<string> CardsData = new List<string>();
        private List<string> TableData = new List<string>();

        public GroupsPage CardsIconSwitchButton()
        {
            ClickElement(Locators.GroupsPage.cardsButton);
            return this;
        }

        public GroupsPage GetTableData()
        {
            var tableData = Driver.Current.FindElements(Locators.GroupsPage.TableData);

            foreach (var item in tableData)
            {
                TableData.Add(item.Text);
            }

            return this;
        }

        public GroupsPage GetCardsData()
        {
            Regex regex = new Regex("(?<=(\\r\\n))(.*?)(?=(:))");
            var cardsData = Driver.Current.FindElements(Locators.GroupsPage.AllCardData);

            foreach (var item in cardsData)
            {
                string cardName = regex.Replace(item.Text, "");
                string cardNameData = cardName.Replace(Environment.NewLine, "").Replace(":", "");
                CardsData.Add(cardNameData);
            }
            return this;
        }

        public GroupsPage VerifyCardsTableData()
        {
            CollectionAssert.AreEqual(TableData, CardsData);
            return this;
        }

        public string GetNameFromTable(int number)
        {
            return Driver.Current.FindElement(Locators.GroupsPage.CurrentTableData(number)).Text;
        }

        public GroupsPage FillSearchField(string text)
        {
            FillField(Locators.GroupsPage.searchField, text);
            return this;
        }

        public GroupsPage VerifySearch()
        {
            int number = new Random().Next(1, Driver.Current.FindElements(Locators.GroupsPage.tableButton).Count + 1);
            string expected = GetNameFromTable(number);
            FillSearchField(GetNameFromTable(number));
            Assert.AreEqual(expected, GetNameFromTable(1));
            return this;
        }

    }
}
