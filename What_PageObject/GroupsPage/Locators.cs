using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.GroupsPage
{
    internal class Locators
    {
        public static By groupsOnPageLabel = By.CssSelector(".col-2 text-right");
        public static By groupsNameSearchField = By.XPath("//*[@class = 'search__searchInput___34nMl']");
        public static By tableButton = By.CssSelector("[href ='/assets/svg/List.svg#List']");
        public static By cardsButton = By.XPath("//div[@class='btn-group']/child::button/following-sibling::button");
        public static By addGroupButton = By.CssSelector("button[span]");
        public static By uploadsGroupButton = By.XPath("//*[@id='root']/div/div/div[2]/div[1]/div[1]/div[5]/button[1]");
        public static By filterButton = By.XPath("//*[@id='root']/div/div/div[2]/div[1]/div[2]/div/form/div[3]/button");
        public static By rowsSelectButton = By.CssSelector("#change-visible-people");
        public static By startDateForm = By.CssSelector("input[name='startDate']");
        public static By finishDateForm = By.CssSelector("input[name='finishDate']");
        public static By groupNameArrowButton = By.XPath("//*[text()='Group Name']");
        public static By quantityOfStudentsArrowButton = By.CssSelector("span[data-sorting-param='quantity']");
        public static By dateOfStartArrowButton = By.CssSelector("span[data - sorting - param = 'startDate']");
        public static By dateOfFinishArrowButton = By.CssSelector("span[data-sorting-param='Date of finish']");
        public static By listOfGroupsCalendar = By.CssSelector("[name='group_date']");


        public static By TableData = By.XPath("//tbody/tr");

        public static By GroupName(int row) => By.XPath($"//tbody/tr[{row}]/td[1]");
        public static By QuantityOfStudents(int row) => By.XPath($"//tbody/tr[{row}]/td[2]");
        public static By DateOfStart(int row) => By.XPath($"//tbody/tr[{row}]/td[3]");

        public static By DateOfFinish(int row) => By.XPath($"//tbody/tr[{row}]/td[4]");
        public static By NavigateToPage(int page) => By.XPath($"//ul[2]/li[{page}]");

        public static By CurrentCardData(int cardNumber) => By.XPath($"//*[@id='root']//div[3]/div[{cardNumber}]");

        public static By AllCardData = By.XPath("//*[@id='root']/div/div/div[2]/div[1]/div[3]/div");



    }
}
