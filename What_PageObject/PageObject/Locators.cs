using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.PageObject
{
    public class Locators
    {
        private By UserIcon = By.XPath("//*[@id=\"root\"]/nav/div/div[2]/div[1]/a/svg");
        private By FullNameAccountUser = By.XPath("//*[@id=\"root\"]/nav/div/div[2]/div[1]/span");
        private By DropdownIconUserInformation = By.XPath("//*[@id=\"root\"]/nav/div/div[2]/div[2]/span");
        private By MentorSidebarButton = By.XPath("//*[@id=\"root\"]/div/nav/div[2]/div/a[2]/svg/use");
        private By SectionName = By.XPath("//*[@id=\"root\"]/div/div/div[1]/h2");
        private By NumberOfDisplayedUsers = By.XPath("//*[@id=\"root\"]/div/div/div[1]/span");
        private By LeftSymbolPagination = By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/nav/ul[1]/li/button");
        private By SearchField = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/div/div[2]/div/input");
        private By ButtonAddMentor = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/div/div[5]/button");
        private By CheckBoxRightButtonDisabledMentors = By.XPath("");
        private By NumberRowsInPage = By.XPath("//*[@id=\"change - visible - people\"]");
    }
}
