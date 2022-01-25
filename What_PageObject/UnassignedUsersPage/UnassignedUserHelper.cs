using What_Common.Resources;

namespace What_PageObject.UnassignedUsersPage
{
    public class UnassignedUserHelper
    {
        public enum ChooseRole
        {
            student = 2,
            mentor,
            secretary,
        }

        RegistrationPage.RegistrationPage registration = new RegistrationPage.RegistrationPage();
        private Random rnd = new Random();

        public const string Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public const string AlphaCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string AlphaSmall = "abcdefghijklmnopqrstuvwxyz";
        public const string Numeric = "1234567890";
        public const string Symbol = "!@#$%^&*()_+=";

        private string GetRandomString(int length, string chars)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public void GenerateNewUser()
        {
            var name = GetRandomString(rnd.Next(2, 30), Alpha);
            var surname = GetRandomString(rnd.Next(2, 30), Alpha);
            var email = GetRandomString(rnd.Next(3, 10), Alpha)
                + "@"
                + GetRandomString(rnd.Next(3, 10), Alpha)
                + "."
                + GetRandomString(rnd.Next(3, 10), Alpha);
            var password = GetRandomString(rnd.Next(1, 2), AlphaCaps)
                + GetRandomString(rnd.Next(1, 2), AlphaSmall)
                + GetRandomString(rnd.Next(2, 4), Alpha)
                + GetRandomString(rnd.Next(1, 2), Symbol)
                + GetRandomString(rnd.Next(2, 4), Alpha)
                + GetRandomString(rnd.Next(1, 4), Numeric)
                + GetRandomString(rnd.Next(2, 4), Alpha);

            registration.ClickRegistrationButton(Locators.RegistrationPage.Registration)
                        .FillFirstName(name)
                        .FillLastName(surname)
                        .FillEmailAdress(email)
                        .FillPassword(password)
                        .FillConfirmPassword(password)
                        .ClickSignUpButton(Locators.RegistrationPage.SignUpButton)
                        .ClickSignUpButton(Locators.RegistrationPage.BackButton);
        }
    }
}
