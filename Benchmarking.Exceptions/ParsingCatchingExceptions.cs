using System;

namespace Benchmarking.Exceptions
{
    public static class ParsingCatchingExceptions
    {
        public static string TryParseIntegerConversion()
        {
            string result = string.Empty;
            result = int.TryParse(result, out var value) ? value.ToString() : "There is no int value";
            return $"Final result: {result}";
        }

        public static string TryCatchIntegerConversion()
        {
            string result = string.Empty;
            try
            {
                result = Convert.ToInt32(result).ToString();
            }
            catch (Exception)
            {
                result = "There is no int value";
            }
            return $"Final result: {result}";
        }
    }
}
