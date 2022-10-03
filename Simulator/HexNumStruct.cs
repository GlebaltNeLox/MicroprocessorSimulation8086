using System;

namespace MyApp
{
    public struct HexNum
    {

        private int _hexNum;
        public string hexNum
        {
            get
            {
                return HexConvert.ToHex(_hexNum);
            }

            set
            {
                int setHexNumber = HexConvert.ToInt(value);
                _hexNum = ValidRangeOfHexNumber(setHexNumber, HexConvert.ToInt("0"), HexConvert.ToInt("FF"));
            }

        }
        public HexNum(string hexnum) : this()
        {
            hexNum = hexnum ?? "0";
        }


        private int ValidRangeOfHexNumber(int num, int min, int max)
        {
            if (num >= min && num <= max)
                return num;
            else
                throw new ArgumentOutOfRangeException($"\n\n##########################################\n" +
                    $"Number range is from {min} to {max}\n" +
                    "##########################################\n\n");
        }

        
    }
}
