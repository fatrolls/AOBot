using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;

namespace ns0
{

    internal sealed class Class7
    {

        private static readonly int int_0;
        private static readonly int int_1;
        private static readonly MemoryStream memoryStream_0;
        private static readonly MemoryStream memoryStream_1;
        private static readonly object object_0;

        static Class7()
        {
            Class7.memoryStream_0 = null;
            Class7.memoryStream_1 = null;
            Class7.int_0 = 2147483647;
            Class7.int_1 = -2147483648;
            Class7.memoryStream_0 = new MemoryStream(0);
            Class7.memoryStream_1 = new MemoryStream(0);
            Class7.object_0 = new Object();
        }

        public Class7()
        {
        }

        private static string smethod_0(Assembly assembly_0)
        {
            string s = assembly_0.FullName;
            int i = s.IndexOf(',');
            if (i >= 0)
                s = s.Substring(0, i);
            return s;
        }

        private static byte[] smethod_1(Assembly assembly_0)
        {
            byte[] bArr2;

            try
            {
                string s1 = assembly_0.FullName;
                int i = s1.IndexOf("PublicKeyToken=");
                if (i < 0)
                    i = s1.IndexOf("publickeytoken=");
                if (i < 0)
                {
                    return null;
                }
                i += 15;
                if (s1[i] != 110)
                {
                    if (s1[i] == 78)
                    {
                    }
                    else
                    {
                        string s2 = s1.Substring(i, 16);
                        long l = Int64.Parse(s2, NumberStyles.HexNumber);
                        byte[] bArr1 = BitConverter.GetBytes(l);
                        Array.Reverse(bArr1);
                        return bArr1;
                    }
                }
                return null;
            }
            catch 
            {
            }
            return null;
        }

        internal static byte[] smethod_2(Stream stream_0)
        {
            byte[] bArr8;
            int i3, i6;

            object obj = Class7.object_0;
            Monitor.Enter(Class7.object_0);
            try
            {
                Stream stream = stream_0;
                MemoryStream memoryStream = null;
                ushort ush = (ushort)stream_0.ReadByte();
                ush = ~ush;
                for (int i1 = 1; i1 < 2; i1++)
                {
                    stream_0.ReadByte();
                }
                if ((ush & 2) != 0)
                {
                    DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
                    byte[] bArr1 = new byte[8];
                    stream_0.Read(bArr1, 0, 8);
                    descryptoServiceProvider.IV = bArr1;
                    byte[] bArr2 = new byte[8];
                    stream_0.Read(bArr2, 0, 8);
                    bool flag = true;
                    byte[] bArr9 = bArr2;
                    for (int i7 = 0; i7 < bArr9.Length; i7++)
                    {
                        byte b = bArr9[i7];
                        if (b != 0)
                            goto label_1;
                    }
                    goto label_2;
                label_1:
                    flag = false;
                label_2:
                    if (flag)
                        bArr2 = Class7.smethod_1(Assembly.GetExecutingAssembly());
                    descryptoServiceProvider.Key = bArr2;
                    if (Class7.memoryStream_0 == null)
                    {
                        if (Class7.int_0 == 2147483647)
                            Class7.memoryStream_0.Capacity = (int)stream_0.Length;
                        else
                            Class7.memoryStream_0.Capacity = Class7.int_0;
                    }
                    Class7.memoryStream_0.Position = 0L;
                    ICryptoTransform icryptoTransform = descryptoServiceProvider.CreateDecryptor();
                    int i2 = icryptoTransform.InputBlockSize;
                    icryptoTransform.OutputBlockSize;
                    byte[] bArr3 = new byte[icryptoTransform.OutputBlockSize];
                    byte[] bArr4 = new byte[icryptoTransform.InputBlockSize];
                    for (i3 = (int)stream_0.Position; (long)(i3 + i2) < stream_0.Length; i3 = i3 + i2)
                    {
                        stream_0.Read(bArr4, 0, i2);
                        int i4 = icryptoTransform.TransformBlock(bArr4, 0, i2, bArr3, 0);
                        Class7.memoryStream_0.Write(bArr3, 0, i4);
                    }
                    stream_0.Read(bArr4, 0, (int)(stream_0.Length - (long)i3));
                    byte[] bArr5 = icryptoTransform.TransformFinalBlock(bArr4, 0, (int)(stream_0.Length - (long)i3));
                    Class7.memoryStream_0.Write(bArr5, 0, bArr5.Length);
                    stream = Class7.memoryStream_0;
                    stream.Position = 0L;
                    memoryStream = Class7.memoryStream_0;
                }
                if ((ush & 8) != 0)
                {
                    try
                    {
                        if (Class7.memoryStream_1 == null)
                        {
                            if (Class7.int_1 == -2147483648)
                                Class7.memoryStream_1.Capacity = (int)stream.Length * 2;
                            else
                                Class7.memoryStream_1.Capacity = Class7.int_1;
                        }
                        Class7.memoryStream_1.Position = 0L;
                        DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
                        int i5 = 1000;
                        byte[] bArr6 = new byte[1000];
                        goto label_4;
                    label_3:
                        if (i6 >= i5)
                            goto label_4;
                        while (true)
                        {
                            Class7.memoryStream_1.Write(bArr6, 0, i6);
                            goto label_3;
                        label_4:
                            i6 = deflateStream.Read(bArr6, 0, i5);
                            if (i6 <= 0)
                                goto label_3;
                        }
                        memoryStream = Class7.memoryStream_1;
                    }
                    catch (Exception)
                    {
                    }
                }
                if (memoryStream != null)
                {
                    return memoryStream.ToArray();
                }
                byte[] bArr7 = new byte[(stream_0.Length - stream_0.Position)];
                stream_0.Read(bArr7, 0, bArr7.Length);
                bArr8 = bArr7;
            }
            finally
            {
                Monitor.Exit(obj);
            }
            return bArr8;
        }

    } // class Class7

}

