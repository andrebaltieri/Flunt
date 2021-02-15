namespace Flunt.Localization
{
    public static class FluntRegexPatterns
    {
        public static string EmailRegexPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        public static string OnlyNumbersPattern = @"[^0-9]+";
        public static string OnlyLettersAndNumbersPatter = @"[A-Za-z0-9_-]";
    }
}
