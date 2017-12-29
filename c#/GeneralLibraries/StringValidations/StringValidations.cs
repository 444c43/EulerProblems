namespace Extensions
{
    public static class StringValidations
    {
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
