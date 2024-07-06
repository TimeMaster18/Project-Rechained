using System;

namespace SingleplayerLauncher.Utils
{
    /// <summary>
    /// Provides methods for encoding integers to Base62 strings and decoding Base62 strings to integers.
    /// </summary>
    public static class Base62Converter
    {
        /// <summary>
        /// The character set used for Base62 encoding, consisting of digits, uppercase letters, and lowercase letters.
        /// </summary>
        private const string Base62Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// Encodes an integer value to a Base62 string.
        /// </summary>
        /// <param name="value">The integer value to encode. Must be between 0 and 3843, inclusive.</param>
        /// <param name="forceLengthTwo">If true, always returns a two-character string. If false, returns a one-character string for values less than 62.</param>
        /// <returns>A Base62 encoded string representation of the input value.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the input value is less than 0 or greater than or equal to 3844.</exception>
        public static string Encode(int value, bool forceLengthTwo = false)
        {
            if (value < 0 || value >= 3844) // 62 * 62 = 3844
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be in the range 0-3843.");
            }

            if (value < 62 && !forceLengthTwo)
            {
                return Base62Chars[value].ToString();
            }

            int high = value / 62;
            int low = value % 62;
            return $"{Base62Chars[high]}{Base62Chars[low]}";
        }

        /// <summary>
        /// Decodes a Base62 encoded string to its integer value.
        /// </summary>
        /// <param name="str">The Base62 encoded string to decode. Must be either one or two characters long.</param>
        /// <returns>The integer value represented by the Base62 encoded string.</returns>
        /// <exception cref="ArgumentException">Thrown when the input string length is not 1 or 2.</exception>
        public static int Decode(string str)
        {
            if (str.Length == 1)
            {
                return Base62Chars.IndexOf(str[0]);
            }
            else if (str.Length == 2)
            {
                int high = Base62Chars.IndexOf(str[0]);
                int low = Base62Chars.IndexOf(str[1]);
                return high * 62 + low;
            }
            else
            {
                throw new ArgumentException("Invalid Base62 encoded string length.", nameof(str));
            }
        }
    }
}