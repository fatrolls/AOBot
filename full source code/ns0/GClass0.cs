using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{

    public sealed class GClass0
    {

        [CompilerGenerated]
        internal sealed class Class8
        {

            public int int_0;

            public Class8()
            {
            }

            [CompilerGenerated]
            public bool method_0(GClass14.GClass21 gclass21_0)
            {
                return gclass21_0.method_2() == int_0;
            }

        } // class Class8

        private const int int_0 = 513;
        private const int int_1 = 514;

        private Bot bot_0;
        private GClass22 gclass22_0;
        private GClass26 gclass26_0;
        private GClass4 gclass4_0;

        public GClass0(Bot bot_1, GClass26 gclass26_1, GClass22 gclass22_1, GClass4 gclass4_1)
        {
            bot_0 = bot_1;
            gclass26_0 = gclass26_1;
            gclass22_0 = gclass22_1;
            gclass4_0 = gclass4_1;
        }

        private int method_0(int int_2, int int_3)
        {
            return (checked(int_3 - 1) << 16) | checked(int_2 + 65535);
        }

        public void method_1(int int_2, int int_3)
        {
            int i = method_0(int_2, int_3);
            GClass0.SendMessage((IntPtr)gclass4_0.long_0, 513, (IntPtr)0, (IntPtr)i);
            GClass0.SendMessage((IntPtr)gclass4_0.long_0, 514, (IntPtr)0, (IntPtr)i);
        }

        public bool method_2(int int_2, int int_3, int int_4)
        {
            bool flag;

            int i = 0;
            while (!((gclass4_0.method_38() > 20) | !bot_0.bool_0))
            {
                bot_0.string_1 = "1";
                Thread.Sleep(1000);
            }
            while (!(flag | !bot_0.bool_0))
            {
                bot_0.string_1 = "2";
                while (!((i == 3) | !bot_0.bool_0))
                {
                    bot_0.string_1 = "3";
                    gclass26_0.long_32 = (long)gclass22_0.method_1(GClass24.int_32, 4);
                    Thread.Sleep(300);
                    if (i == 0)
                    {
                        Thread.Sleep(500);
                        method_1(54, 11);
                        Thread.Sleep(500);
                        method_1(63, 57);
                        i = 1;
                    }
                    if ((gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) != 0L) & (i == 1))
                    {
                        Thread.Sleep(300);
                        method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) + 321L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_32 + 4L)), 2) - 12L)));
                        Thread.Sleep(1000);
                        gclass26_0.long_49 = (long)gclass22_0.method_1(GClass24.int_50, 4);
                        Thread.Sleep(100);
                        gclass26_0.long_47 = (long)gclass22_0.method_1(GClass24.int_48, 4);
                        Thread.Sleep(100);
                        gclass26_0.long_48 = (long)gclass22_0.method_1(GClass24.int_49, 4);
                        while (((int)gclass22_0.method_3(checked((int)gclass26_0.long_49), 2) != int_2) | ((int)gclass22_0.method_3(checked((int)gclass26_0.long_47), 2) != int_3) | ((int)gclass22_0.method_3(checked((int)gclass26_0.long_48), 2) != int_4))
                        {
                            Thread.Sleep(200);
                            gclass22_0.method_6(checked((int)gclass26_0.long_49), int_2, 2L);
                            Thread.Sleep(200);
                            gclass22_0.method_6(checked((int)gclass26_0.long_47), int_3, 2L);
                            Thread.Sleep(200);
                            gclass22_0.method_6(checked((int)gclass26_0.long_48), int_4, 2L);
                        }
                        Thread.Sleep(300);
                        gclass26_0.long_45 = (long)gclass22_0.method_1(GClass24.int_46, 4);
                        gclass22_0.method_6(checked((int)gclass26_0.long_45), 1, 1L);
                        Thread.Sleep(400);
                        method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) + 275L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_32 + 4L)), 2) + 48L)));
                        Thread.Sleep(500);
                        i = 2;
                    }
                    if ((gclass22_0.method_3(checked((int)gclass26_0.long_31), 1) == 0L) & (gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) != 0L) & (i == 2))
                    {
                        Thread.Sleep(500);
                        method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) + 371L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_32 + 4L)), 2) - 58L)));
                        i = 3;
                    }
                }
                if (i == 3)
                    flag = true;
            }
            return true;
        }

        public bool method_3(int int_2, int int_3, int int_4)
        {
            bool flag;

            int i = 0;
            while (gclass4_0.method_38() <= 20)
            {
                bot_0.string_1 = "4";
                Thread.Sleep(1000);
            }
            while (!flag)
            {
                bot_0.string_1 = "5";
                while (i != 3)
                {
                    bot_0.string_1 = "6";
                    gclass26_0.long_32 = (long)gclass22_0.method_1(GClass24.int_32, 4);
                    Thread.Sleep(300);
                    if (i == 0)
                    {
                        Thread.Sleep(500);
                        method_1(54, 11);
                        Thread.Sleep(500);
                        method_1(63, 57);
                        i = 1;
                    }
                    if ((gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) != 0L) & (i == 1))
                    {
                        Thread.Sleep(300);
                        method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) + 321L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_32 + 4L)), 2) - 12L)));
                        Thread.Sleep(1000);
                        gclass26_0.long_49 = (long)gclass22_0.method_1(GClass24.int_50, 4);
                        gclass26_0.long_47 = (long)gclass22_0.method_1(GClass24.int_48, 4);
                        gclass26_0.long_48 = (long)gclass22_0.method_1(GClass24.int_49, 4);
                        while (((int)gclass22_0.method_3(checked((int)gclass26_0.long_49), 2) != int_2) | ((int)gclass22_0.method_3(checked((int)gclass26_0.long_47), 2) != int_3) | ((int)gclass22_0.method_3(checked((int)gclass26_0.long_48), 2) != int_4))
                        {
                            Thread.Sleep(200);
                            gclass22_0.method_6(checked((int)gclass26_0.long_49), int_2, 2L);
                            Thread.Sleep(200);
                            gclass22_0.method_6(checked((int)gclass26_0.long_47), int_3, 2L);
                            Thread.Sleep(200);
                            gclass22_0.method_6(checked((int)gclass26_0.long_48), int_4, 2L);
                        }
                        Thread.Sleep(300);
                        gclass26_0.long_45 = (long)gclass22_0.method_1(GClass24.int_46, 4);
                        gclass22_0.method_6(checked((int)gclass26_0.long_45), 1, 1L);
                        Thread.Sleep(400);
                        method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) + 275L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_32 + 4L)), 2) + 48L)));
                        Thread.Sleep(500);
                        i = 2;
                    }
                    if ((gclass22_0.method_3(checked((int)gclass26_0.long_31), 1) == 0L) & (gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) != 0L) & (i == 2))
                    {
                        Thread.Sleep(500);
                        method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_32), 2) + 371L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_32 + 4L)), 2) - 58L)));
                        i = 3;
                    }
                }
                if (i == 3)
                    flag = true;
            }
            return true;
        }

        public bool method_4(int int_2, int int_3, int int_4)
        {
            bool flag = false;
            gclass22_0.method_6(checked((int)gclass26_0.long_50), int_2, 2L);
            Thread.Sleep(1000);
            gclass22_0.method_6(checked((int)gclass26_0.long_51), int_3, 2L);
            Thread.Sleep(1000);
            gclass22_0.method_6(checked((int)gclass26_0.long_52), int_4, 2L);
            Thread.Sleep(1000);
            gclass22_0.method_6(checked((int)gclass26_0.long_57), 1, 1L);
            int i1 = checked(int_3 + 7);
            int i2 = checked(int_3 - 7);
            int i3 = checked(int_4 + 7);
            int i4 = checked(int_4 - 7);
            while (!(flag | !bot_0.bool_0))
            {
                bot_0.string_1 = "7";
                int i5 = checked((int)gclass22_0.method_3(checked((int)gclass26_0.long_21), 2));
                int i6 = checked((int)gclass22_0.method_3(checked((int)checked(gclass26_0.long_21 + 2L)), 2));
                Thread.Sleep(1000);
                if (((int)gclass22_0.method_3(checked((int)gclass26_0.long_46), 2) == int_2) && ((i5 <= i1) & (i5 >= i2)) && ((i6 <= i3) & (i6 >= i4)))
                    flag = true;
            }
            return true;
        }

        public static bool smethod_0(int int_2)
        {
            GClass0.Class8 class8 = new GClass0.Class8();
            class8.int_0 = int_2;
            GClass14.GClass21 gclass21 = Enumerable.FirstOrDefault<GClass14.GClass21>(GClass14.smethod_2(), new Func<GClass14.GClass21,bool>(class8, class8.method_0));
            if (gclass21 != null)
                return true;
            return false;
        }

        [PreserveSig]
        [DllImport("user32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

    } // class GClass0

}

