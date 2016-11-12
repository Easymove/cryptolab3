using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace cryptolab2
{
    internal class DESUtils
    {
        private readonly byte[] _IV;
        private readonly byte[] _key1;
        private readonly byte[] _key2;
        private readonly TextBox _output;
        private readonly DES DESalg;

        public DESUtils(TextBox outpuTextBox)
        {
            _output = outpuTextBox;
            DESalg = DES.Create();
            DESalg.Mode = CipherMode.CBC;
            DESalg.BlockSize = 64;
            DESalg.Padding = PaddingMode.Zeros;
            DESalg.KeySize = 64;
            /*DESalg.GenerateKey();
            _key1 = DESalg.Key;
            DESalg.GenerateKey();
            _key2 = DESalg.Key;
            _IV = DESalg.IV;*/
            _key1 = new byte[] {0x14, 0x88, 0x22, 0x88, 0x77, 0x14, 0x88, 0xAA};
            _key2 = new byte[] {0xDE, 0xAD, 0xBE, 0xEF, 0x14, 0x88, 0x22, 0x80};
            _IV = new byte[] {0xA1, 0xB2, 0xC3, 0xD4, 0xE5, 0xF6, 0x07, 0x08};
        }

        public byte[] GetKey1()
        {
            return _key1;
        }

        public byte[] GetKey2()
        {
            return _key2;
        }

        public byte[] GetIV()
        {
            return _IV;
        }

        public byte[] GetBytes(string str)
        {
            if (str != "")
            {
                var arr = str.Split('-');
                var array = new byte[arr.Length];
                for (var i = 0; i < arr.Length; i++) array[i] = Convert.ToByte(arr[i], 16);
                return array;
            }
            return new byte[0];
        }

        public byte[] DecryptBytes(byte[] data, bool useSecondKey)
        {
            try
            {
                var toDecrypt = useSecondKey ? data : data.Take(data.Length - 8).ToArray();

                if (!useSecondKey)
                {
                    var checkSum = DecryptBytes(data.Skip(data.Length - 8).ToArray(), true);
                    if (!checkSum.SequenceEqual(toDecrypt.Skip(toDecrypt.Length - 8).ToArray()))
                    {
                        _output.AppendText(string.Format("Corrupted data detected: {0}\n", BitConverter.ToString(data)));
                        return new byte[0];
                    }
                }

                // Create a new MemoryStream using the passed 
                // array of encrypted data.
                var msDecrypt = new MemoryStream(toDecrypt);

                var curKey = useSecondKey ? GetKey2() : GetKey1();
                // Create a CryptoStream using the MemoryStream 
                // and the passed key and initialization vector (IV).
                var csDecrypt = new CryptoStream(msDecrypt,
                    DESalg.CreateDecryptor(curKey, GetIV()),
                    CryptoStreamMode.Read);

                // Create buffer to hold the decrypted data.
                var fromEncrypt = new byte[toDecrypt.Length];

                // Read the decrypted data out of the crypto stream
                // and place it into the temporary buffer.
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

                return fromEncrypt;
            }
            catch (CryptographicException e)
            {
                _output.AppendText(string.Format("A Cryptographic error occurred: {0}", e.Message));
                return null;
            }
        }

        public byte[] EncryptBytes(byte[] data, bool useSecondKey)
        {
            try
            {
                // Create a MemoryStream.
                var mStream = new MemoryStream();


                var curKey = useSecondKey ? GetKey2() : GetKey1();
                // Create a CryptoStream using the MemoryStream 
                // and the passed key and initialization vector (IV).
                var cStream = new CryptoStream(mStream,
                    DESalg.CreateEncryptor(curKey, GetIV()),
                    CryptoStreamMode.Write);

                // Write the byte array to the crypto stream and flush it.
                cStream.Write(data, 0, data.Length);
                cStream.FlushFinalBlock();

                // Get an array of bytes from the 
                // MemoryStream that holds the 
                // encrypted data.
                var ret = mStream.ToArray();

                // Close the streams.
                cStream.Close();
                mStream.Close();

                // Return the encrypted buffer.
                if (useSecondKey) return ret;
                var newRes = new byte[ret.Length + 8];
                Array.Copy(ret, 0, newRes, 0, ret.Length);
                var checkSum = EncryptBytes(ret.Skip(ret.Length - 8).ToArray(), true);
                Array.Copy(checkSum, 0, newRes, ret.Length, 8);
                return newRes;
            }
            catch (CryptographicException e)
            {
                _output.AppendText(string.Format("A Cryptographic error occurred: {0}", e.Message));
                return null;
            }
        }

        public string DecryptText(string data)
        {
            return new ASCIIEncoding().GetString(DecryptBytes(GetBytes(data), false));
        }

        public byte[] EncryptText(string data)
        {
            return EncryptBytes(new ASCIIEncoding().GetBytes(data), false);
        }
    }
}