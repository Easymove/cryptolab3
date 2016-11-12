using System;
using System.Linq;

namespace cryptolab2
{
    internal class Utils
    {
        public static int ConvertToInt(bool[] bin)
        {
            var res = 0;
            for (var i = 0; i < bin.Length; i++)
            {
                res = bin[i] ? res + (int) Math.Pow(2, i) : res;
            }
            return res;
        }

        public static bool[] ByteToBoolArray(byte block)
        {
            return Convert.ToString(block, 2).PadLeft(8, '0').Select(s => s.Equals('1')).ToArray();
        }

        public static byte[] XorByteArrays(byte[] a, byte[] b)
        {
            var res = new byte[a.Length];
            for (var i = 0; i < a.Length; i++)
            {
                res[i] = (byte) (a[i] ^ b[i]);
            }
            return res;
        }

        public static bool GetNthBit(byte block, int n)
        {
            return ByteToBoolArray(block)[n];
        }
    }
}