﻿using System.Text;

namespace SelfCSharp.Ch08.ExtensionBasic
{
    static class StringExtensions
    {
        public static string Repeat(this string str, int count)
        {
            var builder = new StringBuilder();
            for (int i = 1; i <= count ; i++)
            {
                builder.Append(str);
            }

            return builder.ToString();
        }
    }
}