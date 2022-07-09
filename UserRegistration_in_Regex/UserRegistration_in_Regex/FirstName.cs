using System;
using System.Text.RegularExpressions;

namespace UserRegistration_in_Regex
{
    internal class FirstName
    {
        public bool ValidateFirstName(string fName)
        {
            string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

            return Regex.IsMatch(fName, FIRST_NAME_REGEX);
        }
    }
}