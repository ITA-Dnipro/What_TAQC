using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using What_Common.DriverManager;

namespace What_PageObject.GroupsPage
{
    public class GroupsPage : BasePageWithSideBar
    {
        public GroupsPage TableIconSwitchButton()
        {
            ClickElement(Locators.tableButton);
            return this;

        }
        private List<string> CardsData;
        private List<string> TableData;

        public GroupsPage CardsIconSwitchButton()
        {
            ClickElement(Locators.cardsButton);
            return this;

        }

        public GroupsPage GetTableData()
        {
            //List<string> data = new List<string>();
            TableData = new List<string>(); 

            var tableData = Driver.Current.FindElements(Locators.TableData);

            foreach (var item in tableData)
            {
                TableData.Add(item.Text);
            }

            return this;
        }

        public List<string> GetCardsData()
        {
            Regex regex = new Regex("(?<=(\\r\\n))(.*?)(?=(:))");
            List<string> data = new List<string>();

            var cardsData = Driver.Current.FindElements(Locators.AllCardData);

            foreach (var item in cardsData)
            {
                string cardName = regex.Replace(item.Text, "");
                string cardNameData = cardName.Replace(Environment.NewLine, "").Replace(":", "");
                data.Add(cardNameData);
            }
            

            // (?<=(\\r\\n))(.*?)(?=(:))
            return data;
        }

        public GroupsPage VerifyCardsTableData()

        {
            var temp = GetCardsData();
            CollectionAssert.AreEqual(TableData, temp);
            return this;

        }


    }
}
