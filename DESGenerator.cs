using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace cryptolab2
{
    class DESGenerator
    {
        private readonly DESUtils _cryptolizer;
        private readonly TextBox _output;
        private byte[] _initVector;
        private byte[] _startVector;
        private int nthBit;

        public DESGenerator(TextBox outpuTextBox)
        {
            _output = outpuTextBox;
            _cryptolizer = new DESUtils(outpuTextBox);
            nthBit = 7;
        }

        public void SetStartVector(string fileName)
        {
            _startVector = GetStartBytes(fileName);
        }

        public byte[] GetStartBytes(string fileName)
        {
            using (var stream = File.OpenRead(fileName))
            {
                return MD5.Create().ComputeHash(stream).Take(_cryptolizer.GetKey1().Length).ToArray();
            }
        }

        public byte[] GetDateBytes()
        {
            return BitConverter.GetBytes(DateTime.Now.Ticks).Take(_cryptolizer.GetKey1().Length).ToArray();
        }

        public void GenerateBytesToFile(int length, string fileName)
        {
            try 
            {
                _initVector = _cryptolizer.EncryptBytes(GetDateBytes(), true);
                var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                fileStream.Write(GenerateBytes(length), 0, length);
                fileStream.Close();
            }
           catch (Exception e)
           {
              _output.AppendText(string.Format("Exception caught while working with file: {0}", e));
           }
        }

        public byte[] GenerateBytes(int length)
        {
            _initVector = _cryptolizer.EncryptBytes(GetDateBytes(), true);
            var res = new byte[length];
            for (var i = 0; i < length; i++)
            {
                res[i] = GenerateByte();
            }
            return res;
        }

        public byte GenerateByte()
        {
            byte res = 0;
            for (var i = 0; i < 8; i++)
            {
                if (GenerateBit())
                {
                    res += (byte)Math.Pow(2, i);
                }
            }
            return res;
        }

        public bool GenerateBit()
        {
            var R = Utils.XorByteArrays(_initVector, _startVector);
            var X = _cryptolizer.EncryptBytes(R, true);
            var T = Utils.XorByteArrays(X, _initVector);
            _startVector = _cryptolizer.EncryptBytes(T, true);
            return Utils.GetNthBit(_startVector.Last(), nthBit);
        }
    }
}
