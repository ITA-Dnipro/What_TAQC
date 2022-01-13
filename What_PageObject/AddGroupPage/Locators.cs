using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.AddGroupPage
{
    internal class Locators
    {
        private By groupNameField = By.CssSelector("input[name='name']");
        private By selectCourseField = By.CssSelector("select[name='courseId']");
        private By startDateField = By.CssSelector("input[name='startDate']");
        private By finishDateField = By.CssSelector("input[name='finishDate']");
        private By mentorsField = By.CssSelector("input[name='mentors']");
        private By plusMentorsButton = By.CssSelector("//*[@id='root]/div/div/div/div/form/div[5]/div[2]/div[1]/button"); //найти локатор
        private By studentsField = By.CssSelector("input[name='students']");
        private By plusStudentsButton = By.CssSelector("//*[@id='root']/div/div/div/div/form/div[6]/div[2]/div[1]/button"); //найти
        private By clearAllButton = By.XPath("//*[text()='Clear all']");
        private By createButton = By.XPath("//*[text()='Create']");
    }
}
