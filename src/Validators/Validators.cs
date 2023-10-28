using System;
using System.Text.RegularExpressions;

namespace MovieTicketApp
{
    public static class Validators
    {
        public static bool ValidateCardName(string name)
        {
            if (string.IsNullOrEmpty(name)) 
                return false;

            string formattedName = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            return Regex.IsMatch(formattedName, @"^[A-Za-z\s]+$");
        }

        public static bool ValidateCardNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
                return false;

            return Regex.IsMatch(number, @"^\d{16}$");
        }

        public static bool ValidateExpiryDate(string date)
        {
            if (string.IsNullOrEmpty(date))
                return false;

            return Regex.IsMatch(date, @"^\d{2}/\d{2}$");
        }

        public static bool ValidateCVV(string cvv)
        {
            if (string.IsNullOrEmpty (cvv))
                return false;

            return Regex.IsMatch(cvv, @"^\d{3}$");
        }
    }
}
