namespace Extensions
{
    public static class StringValidations
    {
        /// <summary>
        /// returns if string is null
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <returns></returns>
        public static bool IsNull(this string stringvalue)
        {
            return stringvalue == null;
        }

        /// <summary>
        /// returns if string length is greater than specified value
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static bool IsLengthGreaterThan(this string stringvalue, int length)
        {
            return stringvalue.Length > length;
        }

        /// <summary>
        /// returns if length is lesser than specified value
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static bool IsLengthLesserThan(this string stringvalue, int length)
        {
            return stringvalue.Length < length;
        }

        /// <summary>
        /// returns if first character of string is a space
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <returns></returns>
        public static bool IsSpaceFirstChr(this string stringvalue)
        {
            return stringvalue.StartsWith(" ");
        }

        /// <summary>
        /// returns if string can parse to byte
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <returns></returns>
        public static bool IsParsableByte(this string stringvalue)
        {
            byte bytevalue;
            return byte.TryParse(stringvalue, out bytevalue);
        }

        /// <summary>
        /// returns if string can parse to integer
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <returns></returns>
        public static bool IsParsableInt(this string stringvalue)
        {
            int integer;
            return int.TryParse(stringvalue, out integer);
        }

        /// <summary>
        /// returns if string can parse to long
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <returns></returns>
        public static bool IsParsableLong(this string stringvalue)
        {
            long longvalue;
            return long.TryParse(stringvalue, out longvalue);
        }

        /// <summary>
        /// returns if string can parse to double
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <returns></returns>
        public static bool IsParsableDouble(this string stringvalue)
        {
            double doublevalue;
            return double.TryParse(stringvalue, out doublevalue);
        }

        /// <summary>
        /// returns if string can parse to float
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <returns></returns>
        public static bool IsParsableFloat(this string stringvalue)
        {
            float floatvalue;
            return float.TryParse(stringvalue, out floatvalue);
        }

        /// <summary>
        /// returns if string can parse to decimal
        /// </summary>
        /// <param name="stringvalue"></param>
        /// <returns></returns>
        public static bool IsParsableDecimal(this string stringvalue)
        {
            decimal decimalvalue;
            return decimal.TryParse(stringvalue, out decimalvalue);
        }
    }
}
