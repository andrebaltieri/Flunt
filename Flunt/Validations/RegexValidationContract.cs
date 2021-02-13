namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        public Contract<T> Matches(string val, string key, string message)
        {
            return this;
        }

        public Contract<T> NotMatches(string val, string key, string message)
        {
            return this;
        }
    }
}