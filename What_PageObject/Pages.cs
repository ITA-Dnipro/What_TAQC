using What_PageObject.SchedulesPage;
using What_PageObject.UnassignedUsersPage;

namespace What_PageObject
{
    public static class Pages
    {
        public static SchedulePage Schedule => new SchedulePage();
        public static UnassignedUserPage UnassignedUser => new UnassignedUserPage();
    }
}
