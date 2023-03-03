using System;

namespace CommonsLibrary.Maths
{
    public static class Converts
    {
        public static string BinToOct(string input) => Convert.ToString(Convert.ToInt32(input, 2), 8);
        public static int BinToDec(string input) => Convert.ToInt32(input, 2);
        public static string BinToHex(string input) => Convert.ToInt32(input, 2).ToString("X");

        public static string OctToBin(string input) => Convert.ToString(Convert.ToInt32(input, 8), 2);
        public static int OctToDec(string input) => Convert.ToInt32(input, 8);
        public static string OctToHex(string input) => Convert.ToInt32(input, 8).ToString("X");

        public static string DecToBin(string input) => Convert.ToString(int.Parse(input), 2);
        public static string DecToOct(string input) => Convert.ToString(int.Parse(input), 8);
        public static string DecToHex(string input) => Convert.ToString(int.Parse(input), 16);

        public static string HexToBin(string input) => Convert.ToString(Convert.ToInt32(input, 16), 2);
        public static string HexToOct(string input) => Convert.ToString(Convert.ToInt32(input, 16), 8);
        public static int HexToDec(string input) => Convert.ToInt32(input, 16);
    }
}