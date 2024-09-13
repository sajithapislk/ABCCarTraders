using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ABCCarTraders.Utils
{
    public static class Validation
    {
        // 1. Check if a string is empty or null
        public static bool IsEmpty(params string[] inputs)
        {
            // Loop through each input and check if it's empty or null
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return true; // Return true if any input is empty
                }
            }
            return false; // Return false if none are empty
        }

        // 2. Validate email format
        public static bool IsValidEmail(string email)
        {
            if (IsEmpty(email)) return false;

            // Regular expression for validating email format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // 3. Validate phone number (example: 10 digits for a typical US phone number)
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (IsEmpty(phoneNumber)) return false;

            // Regular expression for a basic 10-digit phone number (without country code)
            string phonePattern = @"^\d{10}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        // 4. Validate if the input length is within a specific range
        public static bool IsValidLength(string input, int minLength, int maxLength)
        {
            if (IsEmpty(input)) return false;

            return input.Length >= minLength && input.Length <= maxLength;
        }

        // 5. Validate if the input contains only alphabets
        public static bool IsAlpha(string input)
        {
            if (IsEmpty(input)) return false;

            // Regular expression for alphabets only
            string alphaPattern = @"^[a-zA-Z]+$";
            return Regex.IsMatch(input, alphaPattern);
        }

        // 6. Validate if the input is a valid date
        public static bool IsValidDate(string input)
        {
            if (IsEmpty(input)) return false;

            DateTime parsedDate;
            return DateTime.TryParse(input, out parsedDate);
        }

        // 7. Validate custom regular expression
        public static bool IsValidPattern(string input, string pattern)
        {
            if (IsEmpty(input)) return false;

            return Regex.IsMatch(input, pattern);
        }
    }
}
