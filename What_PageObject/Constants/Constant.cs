namespace WHAT_PageObject.Constants
{
    public static class Constant
    {
        public const string url = "http://localhost:8080";

        #region Credentials

        public const string adminLoginName = "james.smith@example.com";
        public const string adminPasswordName = "Nj_PJ7K9";

        public const string secretaryLoginName = "john.williams@example.com";
        public const string secretaryPasswordName = "9mw6AJB_";

        public const string mentorLoginName = "michael.taylor@example.com";
        public const string mentorPasswordName = "9td6IO_Z";

        public const string studentLoginName = "thomas.roberts@example.com";
        public const string studentPasswordName = "T_oYiUX5";

        #endregion

        #region CredentialsExpectedResult

        public const string expectedAdminResult = "Students";
        public const string expectedSecretaryResult = "Mentors";
        public const string expectedMentorResult = "Lessons";
        public const string expectedStudentResult = "Courses";

        #endregion

    }
}
