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

        public Contract AreEquals(string val, string text, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (val != text)
                AddNotification(property, message);

            return this;
        }

        public Contract AreNotEquals(string val, string text, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (val == text)
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
    }
}
