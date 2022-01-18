using OpenQA.Selenium;
using What_Common.Resources;
using What_PageObject.Course;
using What_PageObject.Lessons;
using What_PageObject.SchedulesPage;
using What_PageObject.Secretaries;
using What_PageObject.UnassignedUsersPage;

namespace What_PageObject
{
    public class BasePageWithSideBar : BasePage
    {
        private readonly Dictionary<Type, string> sidebarLabels = new Dictionary<Type, string>()
        {
            [typeof(StudentsPage.StudentsPage)] = "Students",
            //[typeof(MentorsPage)] = "Mentors",
            [typeof(SecretariesPage)] = "Secretaries",
            [typeof(LessonsPage)] = "Lessons",
            [typeof(GroupsPage.GroupsPage)] = "Groups",
            [typeof(CoursesPage)] = "Courses",
            [typeof(SchedulePage)] = "Schedule",
            [typeof(UnassignedUserPage)] = "Assignment",
        };

        public T SidebarNavigateTo<T>() where T : BasePage
        {
            ClickElement(Locators.CommonLocator.ClickToNavbarMenu(sidebarLabels[typeof(T)]));
            var nextPage = GetPageInstance<T>();

            return nextPage;
        }
    }
}