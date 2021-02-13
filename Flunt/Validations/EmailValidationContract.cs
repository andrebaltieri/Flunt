namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        public Contract<T> IsEmail(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsEmailOrEmpty(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotEmail(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> IsNotEmailOrEmpty(string val, string key, string message)
        {
            return this;
        }
    }
}