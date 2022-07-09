using System;
using System.Text.RegularExpressions;

namespace UserRegistration_in_Regex
{
    internal class Password1_Min8Char
    {
        public static string REGEX_Password1 = "^[A-Z a-z]{8,}$"; //Phanindra, ViratKohli

        public bool ValidatePassword1(string password)
        {
            return Regex.IsMatch(password, REGEX_Password1);
        }
    }
}