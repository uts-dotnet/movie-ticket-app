using System;
using System.Text.RegularExpressions;

namespace MovieTicketApp
{
    public static class Validators
    {
        public static bool ValidateCardName(string name)
        {
            string formattedName = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            return Regex.IsMatch(name, @"^[A-Za-z\s]+$");
        }

        public static bool ValidateCardNumber(string number)
        {
            return Regex.IsMatch(number, @"^\d{16}$");
        }

        public static bool ValidateExpiryDate(string date)
        {
            return Regex.IsMatch(date, @"^\d{2}/\d{2}$");
        }

        public static bool ValidateCVV(string cvv)
        {
            return Regex.IsMatch(cvv, @"^\d{3}$");
        }
    }
}
