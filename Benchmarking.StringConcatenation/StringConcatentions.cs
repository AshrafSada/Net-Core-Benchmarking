using System;
using System.Text;

namespace Benchmarking.StringConcatenation
{
    public static class StringConcatenations
    {
        public static string AddStrings()
        {
            string s1 = new String('A', 100);
            string s2 = new String('A', 100);
            string s3 = new String('A', 100);
            string s4 = new String('A', 100);
            string s5 = new String('A', 100);
            string s6 = new String('A', 100);
            string s7 = new String('A', 100);
            string s8 = new String('A', 100);
            string s9 = new String('A', 100);
            string s10 = new String('A', 100);

            string sx = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;

            return sx;
        }

        public static string ConcatenateStrings()
        {
            string s1 = new String('A', 100);
            string s2 = new String('A', 100);
            string s3 = new String('A', 100);
            string s4 = new String('A', 100);
            string s5 = new String('A', 100);
            string s6 = new String('A', 100);
            string s7 = new String('A', 100);
            string s8 = new String('A', 100);
            string s9 = new String('A', 100);
            string s10 = new String('A', 100);

            string xy = String.Concat(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);

            return xy;
        }

        public static string ConcatStringBuilderStrings()
        {
            string s1 = new String('A', 100);
            string s2 = new String('A', 100);
            string s3 = new String('A', 100);
            string s4 = new String('A', 100);
            string s5 = new String('A', 100);
            string s6 = new String('A', 100);
            string s7 = new String('A', 100);
            string s8 = new String('A', 100);
            string s9 = new String('A', 100);
            string s10 = new String('A', 100);

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

        public static string ConcatStringWithStringFormat()
        {
            string s1 = new String('A', 100);
            string s2 = new String('A', 100);
            string s3 = new String('A', 100);
            string s4 = new String('A', 100);
            string s5 = new String('A', 100);
            string s6 = new String('A', 100);
            string s7 = new String('A', 100);
            string s8 = new String('A', 100);
            string s9 = new String('A', 100);
            string s10 = new String('A', 100);

            string sf = String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);

            return sf;
        }

        public static string ConcatStringWithStringInterpolation()
        {
            string s1 = new String('A', 100);
            string s2 = new String('A', 100);
            string s3 = new String('A', 100);
            string s4 = new String('A', 100);
            string s5 = new String('A', 100);
            string s6 = new String('A', 100);
            string s7 = new String('A', 100);
            string s8 = new String('A', 100);
            string s9 = new String('A', 100);
            string s10 = new String('A', 100);

            string si = $"{s1}{s2}{s3}{s4}{s5}{s6}{s7}{s8}{s9}{s10}";

            return si;
        }

        public static string ConcatStringWithStringJoin()
        {
            string s1 = new String('A', 100);
            string s2 = new String('A', 100);
            string s3 = new String('A', 100);
            string s4 = new String('A', 100);
            string s5 = new String('A', 100);
            string s6 = new String('A', 100);
            string s7 = new String('A', 100);
            string s8 = new String('A', 100);
            string s9 = new String('A', 100);
            string s10 = new String('A', 100);
            string[] arr = { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };
            string sj = String.Join("", arr);
            return sj;
        }
    }
}
