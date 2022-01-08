using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumTest1
{
    class CoursePage : BasePage
    {
        private IWebElement ElemPreviusButton => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.PREV_PAGE_BTN));

        private IWebElement ElemNextButton => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.NEXT_PAGE_BTN));

        private IWebElement ElemRowView => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.VIEW_ROWS_BTN));

        private IWebElement ElemCardsView => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.VIEW_CARDS_BTN));

        private IWebElement ElemSearch => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.SEARCH_FIELD));

        private IWebElement ElemCoursesCheckbox => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.DISABLED_COURSES_CHECKBOX));

        private IWebElement ElemAddCoursesButton => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.ADD_COURSE_BTN));

        private IWebElement ElemSort => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.SORT_BY_TITLE_ELEMENT));

        private IWebElement ElemCourseInfo => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.COURSE_INFO_ELEMENT));

        private IWebElement ElemEditCourse => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.EDIT_COURSE_ELEMENT));

        private IWebElement ElemCourseInfoCards => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.DETAILS_IN_CARD_VIEW_BTN));

        private IWebElement ElemEditCourseInfoCards => driver.FindElement(By.XPath(Locators.ListOfCoursesPage.EDIT_IN_CARD_VIEW_ELEMENT));

        private IWebElement ElemDropdown => driver.FindElement(By.XPath(Locators.NavBarAsAdmin.DROPDOWN_NAME_ELEMENT));

        private IWebElement ElemMyProfileIcon => driver.FindElement(By.XPath(Locators.NavBarAsAdmin.ICON_LINK));

        private IWebElement ElemMyProfile => driver.FindElement(By.XPath(Locators.NavBarAsAdmin.MY_PROFILE_LINK));

        private IWebElement ElemChangePassword => driver.FindElement(By.XPath(Locators.NavBarAsAdmin.CHANGE_PWD_LINK));

        private IWebElement ElemLogout => driver.FindElement(By.XPath(Locators.NavBarAsAdmin.LOG_OUT_LINK));

        private IWebElement testelem => driver.FindElement(By.XPath(Locators.SideBarAsAdmin.MENTORS_PAGE_LINK));

        public CoursePage(IWebDriver driver) : base(driver)
        {
          
        }

        public void ClickMyProfileIcon()
        {
            ElemMyProfileIcon.Click();
            Thread.Sleep(1000);
        }

        public void MouseHover()
        {
            Actions action = new Actions(driver);
            action.MoveByOffset(0, 100);
            Thread.Sleep(3000);
        }

        public void ClickMentorsMenuItem()
        {
            testelem.Click();
        }

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.PREV_PAGE_BTN)]
        //private IWebElement elem_previus_button;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.NEXT_PAGE_BTN)]
        //private IWebElement elem_next_button;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.VIEW_ROWS_BTN)]
        //private IWebElement elem_row_view;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.VIEW_CARDS_BTN)]
        //private IWebElement elem_cards_view;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.SEARCH_FIELD)]
        //private IWebElement elem_search;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.DISABLED_COURSES_CHECKBOX)]
        //private IWebElement elem_courses_checkbox;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.ADD_COURSE_BTN)]
        //private IWebElement elem_add_courses_button;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.SORT_BY_TITLE_ELEMENT)]
        //private IWebElement elem_sort;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.COURSE_INFO_ELEMENT)]
        //private IWebElement elem_course_info;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.EDIT_COURSE_ELEMENT)]
        //private IWebElement elem_edit_course;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.DETAILS_IN_CARD_VIEW_BTN)]
        //private IWebElement elem_course_info_cards;

        //[FindsBy(How = How.XPath, Using = Locators.ListOfCoursesPage.EDIT_IN_CARD_VIEW_ELEMENT)]
        //private IWebElement elem_edit_course_info_cards;

       

    }
}
