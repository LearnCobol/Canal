﻿namespace Canal.Utils
{
    using System;
    using System.Text;

    public static class TextUtil
    {
        public static string TrimAllLines(string text)
        {
            var lines = text.Split(new[] { Environment.NewLine, "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            var result = new StringBuilder(lines.Length);

            foreach (var line in lines)
            {
                var length = Math.Min(66, line.Length - 6);
                if (length > 0)
                    result.AppendLine(line.Substring(6, length));
            }

            return result.ToString();
        }
    }
}