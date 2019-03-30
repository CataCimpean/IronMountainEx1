using System.Text.RegularExpressions;
namespace IronMountainEx1.Utils.RegExr
{
    public class RegexUtil
    {
        private static string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        public static bool CheckMatchRegexEmail(string text)
        {
            return Regex.IsMatch(text, emailPattern);
        }
    }
}
