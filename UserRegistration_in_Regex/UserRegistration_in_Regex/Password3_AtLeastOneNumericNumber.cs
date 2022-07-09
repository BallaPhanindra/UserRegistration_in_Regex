using System;
using System.Text.RegularExpressions;

namespace UserRegistration_in_Regex
{
    internal class Password3_AtLeastOneNumericNumber
    {
        public static string REGEX_Password3 = "^[A-Z]{1}[A-Z a-z]{7,}[0-9]{1,}$";  //Phanindra12
        public bool ValidatePassword3(string password)
        {
            return Regex.IsMatch(password, REGEX_Password3);
        }
    }
}