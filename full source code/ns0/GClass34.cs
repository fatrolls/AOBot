using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ns0
{

    public sealed class GClass34
    {

        public enum GEnum7
        {
            const_0 = 0,
            const_1 = 2035711
        }

        [CompilerGenerated]
        internal sealed class Class18
        {

            public GClass34 gclass34_0;
            public int int_0;
            public string string_0;

            public Class18()
            {
            }

            [CompilerGenerated]
            public bool method_0(byte byte_0, int int_1)
            {
                if ((string_0[int_1] != 63) && (string_0[int_1] == 120))
                {
                    if (byte_0 == gclass34_0.byte_0[checked(int_0 + int_1)])
                    {
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }

        } // class Class18

        [CompilerGenerated]
        internal sealed class Class19
        {

            public GClass34 gclass34_0;
            public int int_0;
            public string string_0;

            public Class19()
            {
            }

            [CompilerGenerated]
            public bool method_0(GClass34.GClass35 gclass35_0)
            {
                return Enumerable.Any<byte>(Enumerable.Where<byte>(gclass35_0.method_0(), new Func<byte,int,bool>(method_1)));
            }

            [CompilerGenerated]
            public bool method_1(byte byte_0, int int_1)
            {
                if ((string_0[int_1] != 63) && (string_0[int_1] == 120))
                {
                    if (byte_0 == gclass34_0.byte_0[checked(int_0 + int_1)])
                    {
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }

        } // class Class19

        public sealed class GClass35
        {

            [CompilerGenerated]
            private byte[] byte_0;

            public GClass35()
            {
            }

            public byte[] method_0()
            {
                return byte_0;
            }

            public void method_1(byte[] byte_1)
            {
                byte_0 = byte_1;
            }

        } // class GClass35

        private byte[] byte_0;
        public HashSet<GClass34.GClass35> hashSet_0;
        private int int_0;
        private IntPtr intptr_0;
        private Process process_0;

        public GClass34()
        {
            hashSet_0 = new HashSet<GClass34.GClass35>();
            process_0 = null;
            intptr_0 = IntPtr.Zero;
            int_0 = 0;
            byte_0 = null;
        }

        public GClass34(Process process_1, IntPtr intptr_1, int int_1)
        {
            hashSet_0 = new HashSet<GClass34.GClass35>();
            process_0 = process_1;
            intptr_0 = intptr_1;
            int_0 = int_1;
        }

        private bool method_0()
        {
            // decompiler error
        }

        private bool method_1(int int_1, IEnumerable<byte> ienumerable_0, string string_0)
        {
            GClass34.Class18 class18 = new GClass34.Class18();
            class18.gclass34_0 = this;
            class18.int_0 = int_1;
            class18.string_0 = string_0;
            return Enumerable.Any<byte>(Enumerable.Where<byte>(ienumerable_0, new Func<byte,int,bool>(class18, class18.method_0))) == 0;
        }

        public int method_10()
        {
            return int_0;
        }

        public void method_11(int int_1)
        {
            int_0 = int_1;
        }

        private bool method_2(int int_1, string string_0)
        {
            GClass34.Class19 class19 = new GClass34.Class19();
            class19.gclass34_0 = this;
            class19.string_0 = string_0;
            class19.int_0 = int_1;
            return Enumerable.All<GClass34.GClass35>(hashSet_0, new Func<GClass34.GClass35,bool>(class19, class19.method_0)) == 0;
        }

        public IntPtr method_3(byte[] byte_1, string string_0, int int_1)
        {
            // decompiler error
        }

        public IntPtr method_4(List<byte[]> list_0, string string_0, int int_1)
        {
            // decompiler error
        }

        public void method_5()
        {
            byte_0 = null;
        }

        public Process method_6()
        {
            Process process;

            return process_0;
        }

        public void method_7(Process process_1)
        {
            process_0 = process_1;
        }

        public IntPtr method_8()
        {
            return intptr_0;
        }

        public void method_9(IntPtr intptr_1)
        {
            intptr_0 = intptr_1;
        }

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int CloseHandle(int int_1);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr OpenProcess(GClass34.GEnum7 genum7_0, bool bool_0, int int_1);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool ReadProcessMemory(int int_1, int int_2, [Out] byte[] byte_1, int int_3, ref int int_4);

    } // class GClass34

}

