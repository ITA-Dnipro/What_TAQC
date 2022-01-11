using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.RegistrationPage
{
    public class RegistrationPage : BasePage.BasePage
    {
        public RegistrationPage()
        {
        }

        public RegistrationPage EnterFirstName(string FirstName)
        {
            EnterField(Locators.FieldFirstName, FirstName);
            return this;
        }
        public RegistrationPage EnterLastName(string LastName)
        {
            EnterField(Locators.FieldLastName, LastName);
            return this;
        }
        public RegistrationPage EnterEmailAdress(string Email)
        {
            EnterField(Locators.FieldEmailAdress, Email);
            return this;
        }
        public RegistrationPage EnterPassword(string Password)
        {
            EnterField(Locators.FieldPassword, Password);
            return this;
        }
        public RegistrationPage EnterConfirmPassword(string Password)
        {
            EnterField(Locators.FieldConfirmPassword, Password);
            return this;
        }
    }
}
