using System;
using System.Linq;
using System.Text.RegularExpressions;	

namespace Flunt.Validations
{
    public partial class Contract
    {
        public Contract IsNotNullOrEmpty(string val, string property, string message)
        {
            if (string.IsNullOrEmpty(val))
                AddNotification(property, message);

            return this;
        }

        public Contract IsNotNullOrWhiteSpace(string val, string property, string message)
        {
            if (string.IsNullOrWhiteSpace(val))
                AddNotification(property, message);

            return this;
        }


        public Contract IsNullOrEmpty(string val, string property, string message)
        {
            if (!string.IsNullOrEmpty(val))
                AddNotification(property, message);

            return this;
        }

        public Contract HasMinLen(string val, int min, string property, string message)
        {
            if (string.IsNullOrEmpty(val) || val.Length < min)
                AddNotification(property, message);

            return this;
        }

        public Contract HasMaxLen(string val, int max, string property, string message)
        {
            if (string.IsNullOrEmpty(val) || val.Length > max)
                AddNotification(property, message);

            return this;
        }

        public Contract HasLen(string val, int len, string property, string message)
        {
            if (string.IsNullOrEmpty(val) || val.Length != len)
                AddNotification(property, message);

            return this;
        }

        public Contract Contains(string val, string text, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (!val.Contains(text))
                AddNotification(property, message);

            return this;
        }

        public Contract AreEquals(string val, string text, string property, string message, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            if (!val.Equals(text, comparisonType))
                AddNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(string val, string text, string property, string message, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            if (val.Equals(text, comparisonType))
                AddNotification(property, message);

            return this;
        }

        public Contract IsEmail(string email, string property, string message)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Matchs(email, pattern, property, message);
        }

        public Contract IsEmailOrEmpty(string email, string property, string message)
        {
            if (string.IsNullOrEmpty(email))
                return this;

            return IsEmail(email, property, message);
        }

        public Contract IsUrl(string url, string property, string message)
        {
            const string pattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";
            return Matchs(url, pattern, property, message);
        }

        public Contract IsUrlOrEmpty(string url, string property, string message)
        {
            if (string.IsNullOrEmpty(url))
                return this;

            return IsUrl(url, property, message);
        }

        public Contract Matchs(string text, string pattern, string property, string message)
        {
            if (!Regex.IsMatch(text ?? "", pattern))
                AddNotification(property, message);

            return this;
        }

        public Contract IsDigit(string text, string property, string message)
        {
            const string pattern = @"^\d+$";
            return Matchs(text, pattern, property, message);
        }

        public Contract HasMinLengthIfNotNullOrEmpty(string text, int min, string property, string message)
        {
            if (!string.IsNullOrEmpty(text) && text.Length < min)
                AddNotification(property, message);

            return this;
        }

        public Contract HasMaxLengthIfNotNullOrEmpty(string text, int max, string property, string message)
        {
            if (!string.IsNullOrEmpty(text) && text.Length > max)
                AddNotification(property, message);

            return this;
        }

        public Contract HasExactLengthIfNotNullOrEmpty(string text, int len, string property, string message)
        {
            if (!string.IsNullOrEmpty(text) && text.Length != len)
                AddNotification(property, message);

            return this;
        }

        public Contract IsCreditCard(string creditcard, string property, string message)
        {
            creditcard = Regex.Replace(creditcard, @"[^0-9]+", "");

            if (string.IsNullOrWhiteSpace(creditcard))
            {
                AddNotification(property, message);
                return this;
            }
            
            bool even = false;
            int checksum = 0;

            foreach (char digit in creditcard.ToCharArray().Reverse())
            {
                if (!char.IsDigit(digit))
                {
                    AddNotification(property, message);
                    return this;
                }

                int value = (digit - '0') * (even ? 2 : 1);
                even = !even;

                while (value > 0)
                {
                    checksum += value % 10;
                    value /= 10;
                }
            }

            if (checksum % 10 != 0)
            {
                AddNotification(property, message);
            }
            return this;
        }

    }
}
