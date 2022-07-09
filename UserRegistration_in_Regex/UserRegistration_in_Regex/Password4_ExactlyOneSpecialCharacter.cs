using System;
using System.Text.RegularExpressions;

namespace UserRegistration_in_Regex
{
    internal class Password4_ExactlyOneSpecialCharacter
    {
        public static string REGEX_Password4 = "^[A-Z]{1}[A-Z a-z]{7,}[!*@#$%^&+=]?[0-9]{1,}$"; //Phanindra@1234

        public bool ValidatePassword4(string password)
        {
            return Regex.IsMatch(password, REGEX_Password4);
        }
    }
}