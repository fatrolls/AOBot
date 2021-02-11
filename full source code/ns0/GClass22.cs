using System;
using System.Diagnostics;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    public sealed class GClass22
    {

        public enum GEnum3
        {
            const_0 = 0,
            const_1 = 2035711
        }

        public int int_0;
        public long long_0;

        public GClass22()
        {
        }

        public void method_0()
        {
            Process process = Process.GetCurrentProcess();
            Process[] processArr = Process.GetProcesses();
            for (int i = 0; i < checked((int)processArr.Length); i = checked(i + 1))
            {
                process = processArr[i];
                if (((Operators.CompareString(process.ProcessName, "atlantica", false) == 0) | (Operators.CompareString(process.ProcessName, "Atlantica", false) == 0)))
                {
                    GClass1.GClass2 gclass2 = new GClass1.GClass2();
                    gclass2.method_1(process);
                    GClass1.list_0.Add(gclass2);
                }
            }
        }

        public int method_1(int[] int_1, int int_2)
        {
            byte[] bArr = new byte[checked(checked(int_2 - 1) + 1)];
            int i1 = checked(Information.UBound(int_1, 1) - 1);
            for (int i2 = 0; i2 <= i1; i2 = checked(i2 + 1))
            {
                int i3 = 0;
                GClass22.ReadProcessMemory(int_0, checked(int_1[i2] + BitConverter.ToInt32(bArr, 0)), bArr, int_2, ref i3);
            }
            return checked(int_1[Information.UBound(int_1, 1)] + BitConverter.ToInt32(bArr, 0));
        }

        public bool method_2(int[] int_1, int int_2)
        {
            byte[] bArr = new byte[checked(checked(int_2 - 1) + 1)];
            int i1 = checked(Information.UBound(int_1, 1) - 1);
            for (int i2 = 0; i2 <= i1; i2 = checked(i2 + 1))
            {
                int i3 = 0;
                GClass22.ReadProcessMemory(int_0, checked(int_1[i2] + BitConverter.ToInt32(bArr, 0)), bArr, int_2, ref i3);
                if (BitConverter.ToInt32(bArr, 0) == 0)
                    return false;
            }
            return true;
        }

        public long method_3(int int_1, int int_2)
        {
            byte[] bArr = new byte[checked(checked(int_2 - 1) + 1)];
            int i = 0;
            GClass22.ReadProcessMemory(int_0, int_1, bArr, int_2, ref i);
            switch (int_2)
            {
                case 1:
                    return bArr[0];

                case 2:
                    return (long)BitConverter.ToInt16(bArr, 0);

                case 4:
                    return (long)BitConverter.ToInt32(bArr, 0);

                default:
                    return 0L;

                case 8:
                    return BitConverter.ToInt64(bArr, 0);
            }
        }

        public byte[] method_4(long long_1, long long_2, int int_1)
        {
            byte[] bArr = new byte[checked(checked(int_1 - 1) + 1)];
            int i = 0;
            GClass22.ReadProcessMemory(int_0, checked((int)long_1), bArr, int_1, ref i);
            return bArr;
        }

        public string method_5(int int_1, int int_2)
        {
            byte[] bArr = new byte[checked(checked(int_2 - 1) + 1)];
            int i = 0;
            GClass22.ReadProcessMemory(int_0, int_1, bArr, int_2, ref i);
            string[] sArr = Strings.Split(Encoding.Unicode.GetString(bArr, 0, checked((int)bArr.Length)), "\0", -1, CompareMethod.Binary);
            return sArr[0];
        }

        public bool method_6(int int_1, int int_2, long long_1)
        {
            byte[] bArr = BitConverter.GetBytes(int_2);
            IntPtr intPtr = (IntPtr)0;
            return GClass22.WriteProcessMemory((IntPtr)int_0, (IntPtr)int_1, bArr, checked((uint)long_1), out intPtr);
        }

        public bool method_7(int int_1, float float_0)
        {
            byte[] bArr = BitConverter.GetBytes(float_0);
            IntPtr intPtr = (IntPtr)0;
            return GClass22.WriteProcessMemory((IntPtr)int_0, (IntPtr)int_1, bArr, checked((uint)checked((int)bArr.Length)), out intPtr);
        }

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int CloseHandle(int int_1);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr OpenProcess(GClass22.GEnum3 genum3_0, bool bool_0, int int_1);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ReadProcessMemory(int int_1, int int_2, [Out] byte[] byte_0, int int_3, ref int int_4);

        [PreserveSig]
        [DllImport("kernel32", EntryPoint = "ReadProcessMemory", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool ReadProcessMemory_1(int int_1, int int_2, [Out] byte[] byte_0, int int_3, ref int int_4);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, out IntPtr intptr_2);

    } // class GClass22

}

