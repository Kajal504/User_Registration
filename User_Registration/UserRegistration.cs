using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class UserRegistration
    {
        public static string REGEX_FIRSTNAME = "[A-Z]{1}[A-Za-z]{2,}$";

        public static string REGEX_LASTNAME = "[A-Z]{1}[A-Za-z]{2,}$";

       public static string REGEX_EMAIL = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public static string REGEX_PHONENUMBER = "^[/+91]*[ ]*[/-]*[0-9]{10}$";

        public static string REGEX_PASSWORD = "^[A-Za-z]{8,}$";

        public static string REGEX_PASSWORD2 = "^[A-Z]+[A-Za-z]{7,}$";

        public static string REGEX_PASSWORD3 = "^[A-Z0-9]+[A-Za-z0-9]{7,}$";

        public static string REGEX_PASSWORD4 = "^[A-Z0-9]+[A-Za-z0-9]{7,}[&^%$#@!]$";

        public bool ValidateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);

        } 
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAME);
        }
       public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidatePhoneNumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_PHONENUMBER);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
        public bool ValidatePassword2(string password2)
        {
            return Regex.IsMatch(password2, REGEX_PASSWORD2);
        }

        public bool ValidatePassword3(string password3)
        {
            return Regex.IsMatch(password3, REGEX_PASSWORD3);
        }
        public bool ValidatePassword4(string password4)
        {
            return Regex.IsMatch(password4, REGEX_PASSWORD4);
        }


    }
}
