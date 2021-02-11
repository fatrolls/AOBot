using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    public sealed class GClass31
    {

        public struct GStruct1
        {

            public uint uint_0;
            public uint uint_1;
            public uint uint_2;
            public uint uint_3;
            public uint uint_4;
            public uint uint_5;
            public uint uint_6;
            public uint uint_7;
            public uint uint_8;
            public uint uint_9;

        }

        public struct GStruct2
        {

            public int int_0;
            public int int_1;
            public int int_2;
            public int int_3;
            public int int_4;
            public int int_5;
            public int int_6;

        }

        public sealed class GClass32
        {

            public int int_0;
            public int int_1;

            public GClass32()
            {
            }

        } // class GClass32

        public sealed class GClass33
        {

            public byte[] byte_0;
            public int int_0;

            public GClass33()
            {
            }

        } // class GClass33

        public const int int_0 = 1;
        public const int int_1 = 2035711;
        public const int int_2 = 16;
        public const int int_3 = 32;
        public const int int_4 = 8;
        public const int int_5 = 1024;
        public const int int_6 = 1080;
        public const long long_0 = 2L;
        public const long long_1 = 4L;
        public const long long_10 = 4096L;
        public const long long_2 = 8L;
        public const long long_3 = 16L;
        public const long long_4 = 32L;
        public const long long_5 = 64L;
        public const long long_6 = 128L;
        public const long long_7 = 256L;
        public const long long_8 = 512L;
        public const long long_9 = 131072L;

        public GClass31()
        {
        }

        public static Dictionary<string,GClass31.GClass32> smethod_0(int int_7)
        {
            GClass31.GStruct1 gstruct1;
            GClass31.GStruct2 gstruct2;

            Dictionary<string,GClass31.GClass32> dictionary = new Dictionary<string,GClass31.GClass32>();
            gstruct1 = new GClass31.GStruct1();
            gstruct2 = new GClass31.GStruct2();
            int i = Marshal.SizeOf(gstruct2);
            GClass31.GetSystemInfo(ref gstruct1);
            uint ui1 = gstruct1.uint_3;
            for (uint ui2 = 16777216; ui2 < ui1; ui2 = checked((uint)checked(gstruct2.int_0 + gstruct2.int_3)))
            {
                gstruct2.int_3 = 0;
                GClass31.VirtualQueryEx(int_7, checked((int)ui2), ref gstruct2, i);
                if ((gstruct2.int_3 > 0) & (gstruct2.int_0 >= 39813120))
                {
                    GClass31.GClass32 gclass32 = new GClass31.GClass32();
                    gclass32.int_0 = gstruct2.int_0;
                    gclass32.int_1 = gstruct2.int_3;
                    dictionary.Add(Conversions.ToString(gclass32.int_0), gclass32);
                }
                if (!((gstruct2.int_3 <= 17780736) & (gstruct2.int_3 > 16777216)))
                    Thread.Sleep(1);
            }
            return dictionary;
        }

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern long CloseHandle(int int_7);

        [PreserveSig]
        [DllImport("User32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetProcessHeap();

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern void GetSystemInfo([MarshalAs(UnmanagedType.Struct)] ref GClass31.GStruct1 gstruct1_0);

        [PreserveSig]
        [DllImport("User32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(int int_7, ref int int_8);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int OpenProcess(int int_7, int int_8, int int_9);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int ReadProcessMemory(int int_7, int int_8, byte[] byte_0, int int_9, ref int int_10);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int VirtualProtectEx(int int_7, ref object object_0, int int_8, int int_9, ref int int_10);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int VirtualQueryEx(int int_7, int int_8, [MarshalAs(UnmanagedType.Struct)] ref GClass31.GStruct2 gstruct2_0, int int_9);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int WriteProcessMemory(int int_7, int int_8, ref int int_9, int int_10, ref int int_11);

        [PreserveSig]
        [DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool WriteProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_7, ref int int_8);

        [PreserveSig]
        [DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool WriteProcessMemory_2(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, out int int_7);

    } // class GClass31

}

