namespace What_Common.Resources
{
    public class Endpoints
    {
        public static readonly string authorization = "authorization";
        public static class Accounts
        {
            public static readonly string
                accountsAuth = "/api/v2/accounts/auth",
                accountsGrant = "/api/v2/accounts/role/grant",
                accountsRevoke = "/api/v2/accounts/role/revoke",
                accountsReg = "/api/v2/accounts/reg",
                accounts = "/api/v2/accounts",
                accountsNotAssigned = "/api/v2/accounts/NotAssigned",
                accountsPassword = "/api/v2/accounts/password",
                accountsPasswordForgot = "/api/v2/accounts/password/forgot";
            public static string AccountsPasswordReset(string guid) => $"/api/v2/accounts/password/reset/{guid}";
        }

        public static class Attachments
        {
            public static readonly string
                attachments = "/api/v2/attachments",
                attachmentsAvatar = "/api/v2/attachments/avatar",
                attachmentsAvatarUrl = "/api/v2/attachments/avatar/url",
                attachmentsAttachments = "/api/v2/attachments/attachments";
            public static string AttachmentById(string attachmentId) => $"/api/v2/attachments/{attachmentId}";
        }
        public static class Courses
        {
            public static readonly string courses = "/api/v2/courses";
            public static string CourseById(string id) => $"/api/v2/courses/{id}";
        }

        public static class Dashboard
        {
            public static readonly string
                dashboardClassbook = "/api/v2/dashboard/studentsClassbook",
                dashboardResults = "/api/v2/dashboard/studentsResults";
            public static string DashboardClassbook(string studentId) => $"/api/v2/dashboard/studentClassbook/{studentId}";
            public static string DashboardResults(string studentId) => $"/api/v2/dashboard/studentResults/{studentId}";
            public static string DashboardGroupResults(string courseId) => $"/api/v2/dashboard/studentGroupResults/{courseId}";
        }

        public static class Events
        {
            public static string EventById(string id) => $"/api/v2/events/{id}";
        }

        public static class Export
        {
            public static string ExportClassbook(string extension) => $"/api/v2/exports/studentsClassbook/{extension}";
            public static string ExportResults(string extension) => $"/api/v2/exports/studentsResults/{extension}";
            public static string ExportClassbook(string studentId, string extension) => $"/api/v2/exports/studentClassbook/{studentId}/{extension}";
            public static string ExportResults(string studentId, string extension) => $"/api/v2/exports/studentResults/{studentId}/{extension}";
            public static string ExportGroupResults(string courseId, string extension) => $"/api/v2/exports/studentGroupResults/{courseId}/{extension}";
            public static string ExportOfGroup(string groupId, string extension) => $"/api/v2/exports/studentsOfGroup/{groupId}/{extension}";
        }

        public static class Homeworks
        {
            public static readonly string
                homeworks = "/api/v2/homeworks",
                homeworksGetHomeworks = "/api/v2/homeworks/getHomeworks";
            public static string HomeworkById(string id) => $"/api/v2/homeworks/{id}";
            public static string NotDoneHomework(string studentGroupId) => $"/api/v2/homeworks/notdonehomework/{studentGroupId}";
        }

        public static class HomeworkStudent
        {
            public static readonly string
                homeworksStudent = "/api/v2/homeworkstudent",
                homeworksStudentDone = "/api/v2/homeworkstudent/done",
                homeworksUpdateMark = "/api/v2/homeworkstudent/updatemark";
            public static string HomeworkStudentById(string id) => $"/api/v2/homeworkstudent/{id}";
            public static string HomeworkStudentByHomeworkId(string homeworkId) => $"/api/v2/homeworkstudent/{homeworkId}";
            public static string HomeworkStudentHistory(string homeworkStudentId) => $"/api/v2/homeworkstudent/history/{homeworkStudentId}";
        }

        public static class Import
        {
            public static readonly string importThemes = "/api/v2/imports/themes";
            public static string ImportById(string courseId) => $"/api/v2/imports/group/{courseId}";
        }

        public static class Lessons
        {
            public static readonly string
                lessons = "/api/v2/lessons",
                lessonsAssign = "/api/v2/lessons/assign";
            public static string LessonById(string id) => $"/api/v2/lessons/{id}";
            public static string LessonIsDone(string id) => $"/api/v2/lessons/{id}/isdone";
        }

        public static class Mentors
        {
            public static readonly string
                mentors = "/api/v2/mentors",
                mentorsActive = "/api/v2/mentors/active",
                mentorsLessons = "/api/v2/mentors/lessons";
            public static string MentorById(string id) => $"/api/v2/mentors/{id}";
            public static string MentorsByAccountId(string accountId) => $"/api/v2/mentors/{accountId}";
            public static string MentorByMentorId(string mentorId) => $"/api/v2/mentors/{mentorId}";
            public static string MentorsGroups(string id) => $"/api/v2/mentors/{id}/groups";
            public static string MentorsCourses(string id) => $"/api/v2/mentors/{id}/courses";
            public static string MentorsLessons(string id) => $"/api/v2/mentors/{id}/lessons";
        }

        public static class Schedules
        {
            public static readonly string
                schedules = "/api/v2/schedules",
                schedulesEvents = "/api/v2/schedules/events",
                schedulesUpdateRange = "/api/v2/schedules/events/updateRange",
                schedulesEventsOccurrences = "/api/v2/schedules/event-occurrences";
            public static string SchedulesById(int id) => $"/api/v2/schedules/{id}";
            public static string SchedulesDetailed(int id) => $"/api/v2/schedules/detailed/{id}";
            public static string SchedulesEvents(string eventOccurrenceID) => $"/api/v2/schedules/{eventOccurrenceID}";
            public static string SchedulesEventsOccurrences(int eventOccurrenceID) => $"/api/v2/schedules/eventOccurrences/{eventOccurrenceID}";
        }

        public static class Secretaries
        {
            public static readonly string
                secretaries = "/api/v2/secretaries",
                secretariesActive = "/api/v2/secretaries/active";
            public static string SecretariesByAccountId(string accountId) => $"/api/v2/secretaries/{accountId}";
            public static string SecretariesById(string secretaryId) => $"/api/v2/secretaries/{secretaryId}";
        }

        public static class StudentGroups
        {
            public static readonly string
               studentGroups = "/api/v2/student_groups",
               studentGroupsMerge = "/api/v2/student_groups/merge";
            public static string StudentGroupsById(string id) => $"/api/v2/student_groups/{id}";
            public static string StudentGroupsLessons(string id) => $"/api/v2/student_groups/{id}/lessons";
            public static string StudentGroupsHomeworks(string id) => $"/api/v2/student_groups/{id}/homeworks";
        }

        public static class Students
        {
            public static readonly string
              students = "/api/v2/students",
              studentsActive = "/api/v2/students/active",
              studentsLessons = "/api/v2/students/lessons";
            public static string StudentById(string id) => $"/api/v2/students/{id}";
            public static string StudentByAccountId(string accountId) => $"/api/v2/students/{accountId}";
            public static string StudentLessons(string id) => $"/api/v2/students/{id}/lessons";
            public static string StudentGroups(string id) => $"/api/v2/students/{id}/groups";
            public static string StudentByStudentId(string studentId) => $"/api/v2/students/{studentId}";
        }

        public static class Themes
        {
            public static readonly string themes = "/api/v2/themes";
            public static string ThemesById(string themeId) => $"/api/v2/themes/{themeId}";
        }
    }
}
