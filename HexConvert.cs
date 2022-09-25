using System;

namespace MyApp {

    public static class HexConvert
    {
        public static string ToHex(int n) => n.ToString("X");
        public static int ToInt(string hex) => int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
    }
}