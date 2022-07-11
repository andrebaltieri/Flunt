namespace Flunt.Localization
{
    public static class FluntRegexPatterns
    {
        public static string EmailRegexPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        public static string UrlRegexPattern = @"^(http|https):(\/\/www\.|\/\/www\.|\/\/|\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$|(http|https):(\/\/localhost:\d*|\/\/127\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\/.*)?$";
        public static string OnlyNumbersPattern = @"[^0-9]+";
        public static string OnlyLettersAndNumbersPattern = @"[A-Za-z0-9_-]";
        public static string PassportRegexPattern = @"^(?!^0+$)[a-zA-Z0-9]{3,20}$";
    }
}
