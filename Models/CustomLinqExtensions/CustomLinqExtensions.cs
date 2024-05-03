using CrawlerHTML.CustomDataStructures;
using HTML.Models.CustomStringBuilder;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerHTML
{
    public static class CustomLinqExtensions
    {
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            foreach (T item in source)
            {
                if (func(item))
                {
                    yield return item;
                }
            }
        }

        public static bool CustomIsWhiteSpace(char c)
        {
            return (c == ' ' || c == '\t' || c == '\n' || c == '\r');
        }

        public static string[] CustomSplit(this string input, string delimiter)
        {
            CustomList<string> substrings = new CustomList<string>();
            int startIndex = 0;
            int delimiterLength = delimiter.Length;

            for (int i = 0; i <= input.Length - delimiterLength; i++)
            {
                if (input.CustomSubstring(i, delimiterLength) == delimiter)
                {
                    if (i > startIndex)
                    {
                        substrings.Add(input[startIndex..i]);
                    }

                    startIndex = i + delimiterLength;
                    i += delimiterLength - 1;
                }
            }

            if (startIndex < input.Length)
            {
                substrings.Add(input.CustomSubstring(startIndex));
            }

            return substrings.ToArray();
        }

        public static string CustomSubstring(this string input, int startIndex)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (startIndex >= input.Length)
            {
                return string.Empty;
            }

            int length = input.Length - startIndex;
            char[] result = new char[length];

            for (int i = startIndex, j = 0; i < input.Length; i++, j++)
            {
                result[j] = input[i];
            }

            return new string(result);
        }

        public static string CustomSubstring(this string input, int startIndex, int length)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (startIndex >= input.Length)
            {
                return string.Empty;
            }

            if (length <= 0)
            {
                return string.Empty;
            }

            int endIndex = startIndex + length;
            if (endIndex > input.Length)
            {
                endIndex = input.Length;
            }

            char[] result = new char[endIndex - startIndex];

            for (int i = startIndex, j = 0; i < endIndex; i++, j++)
            {
                result[j] = input[i];
            }

            return new string(result);
        }

        public static bool CustomStartsWith(this string input, string prefix)
        {
            if (input.Length < prefix.Length)
            {
                return false;
            }

            for (int i = 0; i < prefix.Length; i++)
            {
                if (input[i] != prefix[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static int CustomIndexOfString(this string str, string value)
        {
            return CustomIndexOfString(str, value, 0, str.Length);
        }

        public static int CustomIndexOfString(this string str, string value, int startIndex)
        {
            return CustomIndexOfString(str, value, startIndex, str.Length - startIndex);
        }

        public static int CustomIndexOfString(this string str, string value, int startIndex, int count)
        {
            int endIndex = startIndex + count;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (str.CustomSubstring(i, value.Length) == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int CustomIndexOf(this string str, char value, int startIndex)
        {
            return CustomIndexOf(str, value, startIndex, str.Length - startIndex);
        }

        public static int CustomIndexOf(this string str, char value)
        {
            return CustomIndexOf(str, value, 0, str.Length);
        }

        public static int CustomIndexOf(this string str, char value, int startIndex, int count)
        {
            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (str[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool CustomContains(this string input, string substring)
        {
            if (CustomLinqExtensions.CustomIsNullOrEmpty(input) || CustomLinqExtensions.CustomIsNullOrEmpty(substring))
            {
                return false;
            }

            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                bool found = true;

                for (int j = 0; j < substring.Length; j++)
                {
                    if (input[i + j] != substring[j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CustomIsNullOrEmpty(string value)
        {
            return value == null || value.Length == 0;
        }

        public static bool CustomEndsWith(this string input, string suffix)
        {
            if (input.Length < suffix.Length)
            {
                return false;
            }

            int startIndex = input.Length - suffix.Length;

            for (int i = 0; i < suffix.Length; i++)
            {
                if (input[startIndex + i] != suffix[i])
                {
                    return false;
                }
            }

            return false;
        }

        public static bool EndsWithCustom(this string source, string value)
        {
            if (source.Length < value.Length)
            {
                return false;
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (source[source.Length - value.Length + i] != value[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static string CustomTrim(this string input)
        {
            return CustomTrim(input, ' ');
        }

        public static string CustomTrim(this string input, params char[] charsToTrim)
        {
            if (CustomLinqExtensions.CustomIsNullOrEmpty(input) || charsToTrim == null || charsToTrim.Length == 0)
            {
                return input;
            }

            int startIndex = 0;
            int endIndex = input.Length - 1;

            while (startIndex <= endIndex && CustomContains(new string(charsToTrim), input[endIndex].ToString()))
            {
                endIndex--;
            }

            return input.CustomSubstring(startIndex, endIndex - startIndex + 1);
        }

        public static string CustomTrimStart(this string input)
        {
            return input.CustomTrimStart(string.Empty);
        }

        public static string CustomTrimStart(this string input, string prefix)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (prefix == null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            if (input.Length >= prefix.Length && input.CustomSubstring(0, prefix.Length) == prefix)
            {
                return input.CustomSubstring(prefix.Length);
            }

            return input;
        }

        public static IEnumerable<TResult> CustomSelect<TSource, TResult>(
            this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (TSource item in source)
            {
                yield return selector(item);
            }
        }

        public static IEnumerable<T> CustomSkip<T>(this IEnumerable<T> source, int count)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count must not be negative.");
            }

            return InternalCustomSkip(source, count);
        }

        private static IEnumerable<T> InternalCustomSkip<T>(IEnumerable<T> source, int count)
        {
            foreach (var item in source)
            {
                if (count > 0)
                {
                    count--;
                }
                else
                {
                    yield return item;
                }
            }
        }

        public static bool CustomIsNullOrWhiteSpace(this string value)
        {
            if (value == null)
            {
                return true;
            }

            foreach (var item in value)
            {
                if (!CustomLinqExtensions.CustomIsWhiteSpace(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
