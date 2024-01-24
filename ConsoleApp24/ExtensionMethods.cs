using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24 {
    internal static class ExtensionMethods {
        public static bool IsOdd(this int value) {
            if (value % 2 == 0) return false;
            return true;
        }

        public static bool IsEven(this int value) {
            if ((value % 2) == 0) return true;
            return false;
        }

        public static bool IsContainsDigit(this string value) {
            if (string.IsNullOrWhiteSpace(value)) return false;
            for (int i = 0; i < value.Length; i++) {
                if (char.IsDigit(value[i])) return true;
            }
            return false;
        }

        public static string ToCapitalize(this string value) {
            if (string.IsNullOrWhiteSpace(value))
                return value;
            value = value.Trim();
            if (value.Length > 0) {
                char firstChar = char.ToUpper(value[0]);
                string restOfString = value.Length > 1 ? value.Substring(1) : string.Empty;
                return firstChar + restOfString;
            }
            return value;
        }

        public static int[] GetValueIndexes(this string value, char cr) {
            int[] indexes = Array.Empty<int>();
            if (string.IsNullOrWhiteSpace(value))
                return indexes;
            int index = -1;
            while ((index = value.IndexOf(cr, index + 1)) != -1) {
                Array.Resize(ref indexes, indexes.Length + 1);
                indexes[indexes.Length - 1] = index;
            }
            return indexes;
        }


        public static string GetFirstSentence(this string value) {
            if (string.IsNullOrWhiteSpace(value)) return value;
            int wantedIndex = value.IndexOf('.');
            return value.Substring(0, wantedIndex);
        }

        public static string GetSecondWord(this string value) {
            if (string.IsNullOrWhiteSpace(value)) return value;
            value = value.Trim();
            string[] words = value.Split(' ');
            string[] cleanWords = Array.Empty<string>();
            foreach (string word in words) {
                if (word != " ") {
                    Array.Resize(ref cleanWords, cleanWords.Length + 1);
                    cleanWords[cleanWords.Length - 1] = word;
                }
            }
            return cleanWords[1];
        }

    }
}
