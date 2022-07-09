using System;
using System.Text.RegularExpressions;

namespace UserRegistration_in_Regex
{
    internal class CheckEmail
    {
        public static string REGEX_EMail = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$"; //abc.xyz@bl.co.in

        public bool ValidateEMail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMail);
        }
    }
}