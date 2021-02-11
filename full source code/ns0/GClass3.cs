using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    public sealed class GClass3
    {

        private TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider_0;

        public GClass3(string string_0)
        {
            tripleDESCryptoServiceProvider_0 = new TripleDESCryptoServiceProvider();
            tripleDESCryptoServiceProvider_0.Key = method_0(string_0, tripleDESCryptoServiceProvider_0.KeySize / 8);
            tripleDESCryptoServiceProvider_0.IV = method_0("", tripleDESCryptoServiceProvider_0.BlockSize / 8);
        }

        private byte[] method_0(string string_0, int int_0)
        {
            SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
            byte[] bArr1 = Encoding.Unicode.GetBytes(string_0);
            byte[] bArr2 = sha1CryptoServiceProvider.ComputeHash(bArr1);
            return (byte[])Utils.CopyArray((Array)bArr2, new byte[checked(checked(int_0 - 1) + 1)]);
        }

        public string method_1(string string_0)
        {
            byte[] bArr = Encoding.Unicode.GetBytes(string_0);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider_0.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(bArr, 0, checked((int)bArr.Length));
            cryptoStream.FlushFinalBlock();
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        public string method_2(string string_0)
        {
            byte[] bArr = Convert.FromBase64String(string_0);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider_0.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(bArr, 0, checked((int)bArr.Length));
            cryptoStream.FlushFinalBlock();
            return Encoding.Unicode.GetString(memoryStream.ToArray());
        }

    } // class GClass3

}

