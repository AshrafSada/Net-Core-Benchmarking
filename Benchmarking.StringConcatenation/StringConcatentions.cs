using System.Text;

namespace Benchmarking.StringConcatenation
{
    public static class StringConcatenations
    {
        public static string ConcatenateByAppendToStringBuilder()
        {
            string s1 = new string('A', 100);
            string s2 = new string('A', 100);
            string s3 = new string('A', 100);
            string s4 = new string('A', 100);
            string s5 = new string('A', 100);
            string s6 = new string('A', 100);
            string s7 = new string('A', 100);
            string s8 = new string('A', 100);
            string s9 = new string('A', 100);
            string s10 = new string('A', 100);

            StringBuilder sb = new StringBuilder();

            _ = sb.Append(s1);
            _ = sb.Append(s2);
            _ = sb.Append(s3);
            _ = sb.Append(s4);
            _ = sb.Append(s5);
            _ = sb.Append(s6);
            _ = sb.Append(s7);
            _ = sb.Append(s8);
            _ = sb.Append(s9);
            _ = sb.Append(s10);

            return sb.ToString();
        }

        public static string ConcatenateByDirectAdding()
        {
            string s1 = new string('A', 100);
            string s2 = new string('A', 100);
            string s3 = new string('A', 100);
            string s4 = new string('A', 100);
            string s5 = new string('A', 100);
            string s6 = new string('A', 100);
            string s7 = new string('A', 100);
            string s8 = new string('A', 100);
            string s9 = new string('A', 100);
            string s10 = new string('A', 100);

            return s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
        }

        public static string ConcatenateByRawStringLiteralsByAddition()
        {
            string s1 = new string('A', 100);
            string s2 = new string('A', 100);
            string s3 = new string('A', 100);
            string s4 = new string('A', 100);
            string s5 = new string('A', 100);
            string s6 = new string('A', 100);
            string s7 = new string('A', 100);
            string s8 = new string('A', 100);
            string s9 = new string('A', 100);
            string s10 = new string('A', 100);

            var CRLF = Environment.NewLine; // CRLF = \r\n
            var tab4spaces = "\t\t\t\t";
            var rawStrLitTabbedCRLF = $"""
        {tab4spaces}{s1}
        {CRLF}
        """;
            rawStrLitTabbedCRLF += $"""
        {tab4spaces}{s2}
        {CRLF}
        """;
            rawStrLitTabbedCRLF += $"""
        {tab4spaces}{s3}
        {CRLF}
        """;
            rawStrLitTabbedCRLF += $"""
        {tab4spaces}{s4}
        {CRLF}
        """;
            rawStrLitTabbedCRLF += $"""
        {tab4spaces}{s5}
        {CRLF}
        """;
            rawStrLitTabbedCRLF += $"""
        {tab4spaces}{s6}
        {CRLF}
        """;
            rawStrLitTabbedCRLF += $"""
        {tab4spaces}{s7}
        {CRLF}
        """;
            rawStrLitTabbedCRLF += $"""
        {tab4spaces}{s8}
        {CRLF}
        """;
            rawStrLitTabbedCRLF += $"""
        {tab4spaces}{s9}
        {CRLF}
        """;
            rawStrLitTabbedCRLF += $"""
        {tab4spaces}{s10}
        {CRLF}
        """;
            return rawStrLitTabbedCRLF;
        }

        public static string ConcatenateByRawStringLiteralsByInterpolation()
        {
            string s1 = new string('A', 100);
            string s2 = new string('A', 100);
            string s3 = new string('A', 100);
            string s4 = new string('A', 100);
            string s5 = new string('A', 100);
            string s6 = new string('A', 100);
            string s7 = new string('A', 100);
            string s8 = new string('A', 100);
            string s9 = new string('A', 100);
            string s10 = new string('A', 100);

            var CRLF = Environment.NewLine; // CRLF = \r\n
            var tab4spaces = "\t\t\t\t";
            return $"""
        {tab4spaces}{s1}
        {CRLF}
        {tab4spaces}{s2}
        {CRLF}
        {tab4spaces}{s3}
        {CRLF}
        {tab4spaces}{s4}
        {CRLF}
        {tab4spaces}{s5}
        {CRLF}
        {tab4spaces}{s6}
        {CRLF}
        {tab4spaces}{s7}
        {CRLF}
        {tab4spaces}{s8}
        {CRLF}
        {tab4spaces}{s9}
        {CRLF}
        {tab4spaces}{s10}
        {CRLF}
        """;
        }

        public static string ConcatenateByStringConcatFunc()
        {
            string s1 = new string('A', 100);
            string s2 = new string('A', 100);
            string s3 = new string('A', 100);
            string s4 = new string('A', 100);
            string s5 = new string('A', 100);
            string s6 = new string('A', 100);
            string s7 = new string('A', 100);
            string s8 = new string('A', 100);
            string s9 = new string('A', 100);
            string s10 = new string('A', 100);

            return string.Concat(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
        }

        public static string ConcatenateByStringInterpolation()
        {
            string s1 = new string('A', 100);
            string s2 = new string('A', 100);
            string s3 = new string('A', 100);
            string s4 = new string('A', 100);
            string s5 = new string('A', 100);
            string s6 = new string('A', 100);
            string s7 = new string('A', 100);
            string s8 = new string('A', 100);
            string s9 = new string('A', 100);
            string s10 = new string('A', 100);

            return $"{s1}{s2}{s3}{s4}{s5}{s6}{s7}{s8}{s9}{s10}";
        }

        public static string ConcatenateByStringJoin()
        {
            string s1 = new string('A', 100);
            string s2 = new string('A', 100);
            string s3 = new string('A', 100);
            string s4 = new string('A', 100);
            string s5 = new string('A', 100);
            string s6 = new string('A', 100);
            string s7 = new string('A', 100);
            string s8 = new string('A', 100);
            string s9 = new string('A', 100);
            string s10 = new string('A', 100);
            string[] arr = { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };
            return string.Join("", arr);
        }

        public static string ConcatenateByUsingStringFormatFunc()
        {
            string s1 = new string('A', 100);
            string s2 = new string('A', 100);
            string s3 = new string('A', 100);
            string s4 = new string('A', 100);
            string s5 = new string('A', 100);
            string s6 = new string('A', 100);
            string s7 = new string('A', 100);
            string s8 = new string('A', 100);
            string s9 = new string('A', 100);
            string s10 = new string('A', 100);

            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
        }
    }
}
