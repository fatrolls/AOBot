using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ultimate_Bot_Reloaded.PartyFunctions;

namespace ns0
{

    public sealed class GClass4
    {

        public delegate void GDelegate0();

        public struct GStruct0
        {

            public int int_0;
            public int int_1;
            public int int_2;
            public int int_3;

        }

        private const int int_6 = 513;
        private const int int_7 = 514;
        private const long long_1 = 512L;
        private const long long_2 = 517L;
        private const long long_3 = 516L;

        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private Bot bot_0;
        private DateTime dateTime_0;
        private GClass0 gclass0_0;
        private GClass14 gclass14_0;
        private GClass22 gclass22_0;
        private GClass23 gclass23_0;
        private GClass26 gclass26_0;
        private GEnum2 genum2_0;
        private GClass4.GStruct0 gstruct0_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int[] int_3;
        private int[,] int_4;
        private int[,] int_5;
        public long long_0;
        private TimeSpan timeSpan_0;

        public GClass4(Bot bot_1, GClass22 gclass22_1, GClass26 gclass26_1, long long_4, GClass14 gclass14_1)
        {
            bool_0 = false;
            int_0 = 0;
            genum2_0 = GEnum2.const_0;
            int_3 = new int[2];
            int_4 = new int[9, 3];
            int_5 = new int[9, 3];
            bool_1 = true;
            bool_2 = false;
            bot_0 = bot_1;
            gclass14_0 = gclass14_1;
            gclass22_0 = gclass22_1;
            gclass26_0 = gclass26_1;
            long_0 = long_4;
            gclass0_0 = new GClass0(bot_0, gclass26_0, gclass22_0, this);
            gclass23_0 = new GClass23(gclass22_0, gclass26_0, long_0, gclass14_0);
        }

        public void method_0(int int_8, int int_9)
        {
            int i = GClass4.smethod_0(int_8, int_9);
            GClass4.SendMessage((IntPtr)long_0, 516, (IntPtr)0, (IntPtr)i);
            GClass4.SendMessage((IntPtr)long_0, 517, (IntPtr)0, (IntPtr)i);
        }

        public void method_1(int int_8, int int_9)
        {
            int i = GClass4.smethod_0(int_8, int_9);
            GClass4.SendMessage((IntPtr)long_0, 513, (IntPtr)0, (IntPtr)i);
            GClass4.SendMessage((IntPtr)long_0, 514, (IntPtr)0, (IntPtr)i);
        }

        public int method_10()
        {
            Thread.Sleep(200);
            return checked((int)gclass22_0.method_3(checked((int)gclass26_0.long_15), 1));
        }

        public bool method_11()
        {
            if (gclass14_0.bool_13)
            {
                if (gclass14_0.bool_15)
                    method_15();
                else
                    method_14();
            }
            else if (gclass14_0.bool_10)
            {
                if (gclass14_0.bool_12)
                    method_13();
                else
                    method_12();
            }
            return true;
        }

        public object method_12()
        {
            if (gclass14_0.bool_14)
            {
                if (method_19(gclass14_0.int_10, gclass14_0.int_11))
                {
                    Random random1 = new Random();
                    GClass14.GClass17 gclass17_1 = gclass14_0.list_2.get_Item(random1.Next(0, checked(gclass14_0.list_2.get_Count() - 1)));
                    gclass0_0.method_2(checked((int)gclass17_1.method_2()), checked((int)gclass17_1.method_4()), Conversions.ToInteger(gclass17_1.method_6()));
                    dateTime_0 = DateTime.Now;
                    int_0 = 0;
                }
            }
            else if (method_19(gclass14_0.int_10, gclass14_0.int_11))
            {
                Random random2 = new Random();
                GClass14.GClass17 gclass17_2 = gclass14_0.list_2.get_Item(random2.Next(0, checked(gclass14_0.list_2.get_Count() - 1)));
                gclass0_0.method_4(checked((int)gclass17_2.method_2()), checked((int)gclass17_2.method_4()), Conversions.ToInteger(gclass17_2.method_6()));
                dateTime_0 = DateTime.Now;
                int_0 = 0;
            }
            return 1;
        }

        public object method_13()
        {
            GClass14.GClass17 gclass17_1, gclass17_2;

            if (gclass14_0.bool_11)
            {
                if (int_0 >= gclass14_0.int_12)
                {
                    while (true)
                    {
                        Random random1 = new Random();
                        gclass17_1 = gclass14_0.list_2.get_Item(random1.Next(0, checked(gclass14_0.list_2.get_Count() - 1)));
                        if (Operators.CompareString(gclass17_1.method_0(), gclass22_0.method_5(checked((int)bot_0.gclass26_0.long_30), 100), false) == 0)
                            break;
                    }
                    gclass0_0.method_2(checked((int)gclass17_1.method_2()), checked((int)gclass17_1.method_4()), Conversions.ToInteger(gclass17_1.method_6()));
                    dateTime_0 = DateTime.Now;
                    int_0 = 0;
                }
            }
            else if (int_0 >= gclass14_0.int_12)
            {
                while (true)
                {
                    Random random2 = new Random();
                    gclass17_2 = gclass14_0.list_2.get_Item(random2.Next(0, checked(gclass14_0.list_2.get_Count() - 1)));
                    if (Operators.CompareString(gclass17_2.method_0(), gclass22_0.method_5(checked((int)bot_0.gclass26_0.long_30), 100), false) == 0)
                        break;
                }
                gclass0_0.method_4(checked((int)gclass17_2.method_2()), checked((int)gclass17_2.method_4()), Conversions.ToInteger(gclass17_2.method_6()));
                dateTime_0 = DateTime.Now;
                int_0 = 0;
            }
            return 1;
        }

        public object method_14()
        {
            if (gclass14_0.bool_14)
            {
                if (method_19(gclass14_0.int_13, gclass14_0.int_14))
                {
                    Random random1 = new Random();
                    GClass14.GClass18 gclass18_1 = gclass14_0.list_3.get_Item(random1.Next(0, checked(gclass14_0.list_3.get_Count() - 1)));
                    gclass0_0.method_2(checked((int)gclass18_1.method_2()), checked((int)gclass18_1.method_4()), Conversions.ToInteger(gclass18_1.method_6()));
                    dateTime_0 = DateTime.Now;
                    while (!(method_19(gclass14_0.int_15, gclass14_0.int_16) | !bot_0.bool_0))
                    {
                        bot_0.string_1 = "14";
                        Thread.Sleep(1000);
                    }
                    gclass0_0.method_2(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
                    dateTime_0 = DateTime.Now;
                    int_0 = 0;
                }
            }
            else if (method_19(gclass14_0.int_13, gclass14_0.int_14))
            {
                Random random2 = new Random();
                GClass14.GClass18 gclass18_2 = gclass14_0.list_3.get_Item(random2.Next(0, checked(gclass14_0.list_3.get_Count() - 1)));
                gclass0_0.method_4(checked((int)gclass18_2.method_2()), checked((int)gclass18_2.method_4()), Conversions.ToInteger(gclass18_2.method_6()));
                dateTime_0 = DateTime.Now;
                while (!(method_19(gclass14_0.int_15, gclass14_0.int_16) | !bot_0.bool_0))
                {
                    bot_0.string_1 = "15";
                    Thread.Sleep(1000);
                }
                gclass0_0.method_4(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
                dateTime_0 = DateTime.Now;
                int_0 = 0;
            }
            return 1;
        }

        public object method_15()
        {
            if (gclass14_0.bool_14)
            {
                if (int_0 >= gclass14_0.int_17)
                {
                    Random random1 = new Random();
                    GClass14.GClass18 gclass18_1 = gclass14_0.list_3.get_Item(random1.Next(0, checked(gclass14_0.list_3.get_Count() - 1)));
                    gclass0_0.method_2(checked((int)gclass18_1.method_2()), checked((int)gclass18_1.method_4()), Conversions.ToInteger(gclass18_1.method_6()));
                    dateTime_0 = DateTime.Now;
                    while (!(method_19(gclass14_0.int_15, gclass14_0.int_16) | !bot_0.bool_0))
                    {
                        bot_0.string_1 = "16";
                        Thread.Sleep(1000);
                    }
                    gclass0_0.method_2(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
                    dateTime_0 = DateTime.Now;
                    int_0 = 0;
                }
            }
            else if (int_0 > gclass14_0.int_17)
            {
                Random random2 = new Random();
                GClass14.GClass18 gclass18_2 = gclass14_0.list_3.get_Item(random2.Next(0, checked(gclass14_0.list_3.get_Count() - 1)));
                gclass0_0.method_4(checked((int)gclass18_2.method_2()), checked((int)gclass18_2.method_4()), Conversions.ToInteger(gclass18_2.method_6()));
                dateTime_0 = DateTime.Now;
                while (!(method_19(gclass14_0.int_15, gclass14_0.int_16) | !bot_0.bool_0))
                {
                    bot_0.string_1 = "17";
                    Thread.Sleep(1000);
                }
                gclass0_0.method_4(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
                dateTime_0 = DateTime.Now;
                int_0 = 0;
            }
            return 1;
        }

        public object method_16(int int_8, int int_9)
        {
            gclass26_0.long_18 = (long)gclass22_0.method_1(GClass24.int_18, 4);
            Thread.Sleep(100);
            gclass22_0.method_6(checked((int)gclass26_0.long_18), 0, 1L);
            Thread.Sleep(100);
            GClass4.SetAttack(bot_0.process_0.Id, 1);
            Thread.Sleep(50);
            method_1(0, 0);
            method_2(int_8, int_9);
            gclass22_0.method_6(checked((int)gclass26_0.long_5), int_8, 2L);
            gclass22_0.method_6(checked((int)checked(gclass26_0.long_5 + 4L)), int_9, 2L);
            Thread.Sleep(150);
            method_1(int_8, int_9);
            Thread.Sleep(50);
            GClass4.SetAttack(bot_0.process_0.Id, 0);
            Thread.Sleep(200);
            GClass4.SendMessage((IntPtr)long_0, 6, (IntPtr)0, (IntPtr)0);
            GClass4.SendMessage((IntPtr)long_0, 6, (IntPtr)1, (IntPtr)0);
            GClass4.SendMessage((IntPtr)long_0, 6, (IntPtr)2, (IntPtr)0);
            gclass22_0.method_6(checked((int)gclass26_0.long_18), 1, 1L);
            Thread.Sleep(100);
            return 1;
        }

        public void method_17(int int_8, int int_9)
        {
            gclass22_0.method_6(gclass22_0.method_1(GClass24.int_18, 4), 0, 1L);
            Thread.Sleep(100);
            method_1(int_8, int_9);
            Thread.Sleep(100);
            gclass22_0.method_6(gclass22_0.method_1(GClass24.int_18, 4), 1, 1L);
        }

        public void method_18()
        {
            GClass4.SetAttack(bot_0.process_0.Id, 1);
            Thread.Sleep(200);
            GClass4.SendMessage((IntPtr)long_0, 256, (IntPtr)83, (IntPtr)0);
            GClass4.SendMessage((IntPtr)long_0, 257, (IntPtr)83, (IntPtr)65539);
            GClass4.SetAttack(bot_0.process_0.Id, 0);
            Thread.Sleep(200);
            GClass4.SendMessage((IntPtr)long_0, 6, (IntPtr)0, (IntPtr)0);
            GClass4.SendMessage((IntPtr)long_0, 6, (IntPtr)1, (IntPtr)0);
            GClass4.SendMessage((IntPtr)long_0, 6, (IntPtr)2, (IntPtr)0);
        }

        public bool method_19(int int_8, int int_9)
        {
            DateTime dateTime = DateAndTime.Now;
            timeSpan_0 = dateTime.Subtract(dateTime_0);
            if ((timeSpan_0.TotalHours >= (double)int_8) && (timeSpan_0.TotalMinutes >= (double)int_9))
                return true;
            return false;
        }

        public void method_2(int int_8, int int_9)
        {
            int i = GClass4.smethod_0(int_8, int_9);
            GClass4.SendMessage((IntPtr)long_0, 512, (IntPtr)0, (IntPtr)i);
        }

        public bool method_20()
        {
            gclass26_0.long_18 = (long)gclass22_0.method_1(GClass24.int_18, 4);
            if (gclass22_0.method_3(checked((int)gclass26_0.long_18), 1) == 1L)
            {
                Thread.Sleep(20);
                gclass22_0.method_7(gclass22_0.method_1(GClass24.int_6, 4), (float)gclass14_0.int_9);
                Thread.Sleep(200);
                gclass22_0.method_7(gclass22_0.method_1(GClass24.int_7, 4), (float)gclass14_0.int_9);
                Thread.Sleep(200);
                gclass22_0.method_7(gclass22_0.method_1(GClass24.int_8, 4), 1.55F);
                Thread.Sleep(200);
                gclass22_0.method_6(checked((int)gclass26_0.long_18), 0, 1L);
            }
            return true;
        }

        public int[,] method_21(ref int[,] int_8)
        {
            int i6, i7;

            int[,] iArr1 = new int[51, 2];
            int i1 = 0;
            int i2 = checked(Information.UBound(iArr1, 1) - 1);
            for (int i3 = 0; i3 <= i2; i3 = checked(i3 + 1))
            {
                int i4 = checked(Information.UBound(int_8, 1) - 1);
                for (int i5 = 0; i5 <= i4; i5 = checked(i5 + 1))
                {
                    if (int_8[i5, 1] > i6)
                    {
                        i7 = i5;
                        i6 = int_8[i5, 1];
                    }
                }
                if (int_8[i7, 1] != 0)
                    i1 = checked(i1 + 1);
                iArr1[i3, 0] = int_8[i7, 0];
                iArr1[i3, 1] = int_8[i7, 1];
                int_8[i7, 0] = 0;
                int_8[i7, 1] = 0;
                i7 = i6 = 0;
            }
            int[,] iArr = new int[checked(i1 + 1), 2];
            int i8 = checked(i1 - 1);
            for (int i9 = 0; i9 <= i8; i9 = checked(i9 + 1))
            {
                iArr[i9, 0] = iArr1[i9, 0];
                iArr[i9, 1] = iArr1[i9, 1];
            }
            return iArr;
        }

        public void method_22()
        {
            int i1, i2;

            bool flag = false;
            goto label_4;
        label_1:
            if ((gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L) & bot_0.bool_0)
            {
                while (true)
                {
                    int[,] iArr = method_21(ref bot_0.int_0);
                    int i3 = checked(Information.UBound(iArr, 1) - 1);
                    for (i1 = 0; i1 <= i3; i1 = checked(i1 + 1))
                    {
                        method_2(iArr[i1, 0], iArr[i1, 1]);
                        gclass22_0.method_6(checked((int)gclass26_0.long_5), iArr[i1, 0], 2L);
                        gclass22_0.method_6(checked((int)checked(gclass26_0.long_5 + 4L)), iArr[i1, 1], 2L);
                        if (gclass22_0.method_3(checked((int)gclass26_0.long_11), 1) == 1L)
                            goto label_5;
                        Thread.Sleep(200);
                        if (gclass22_0.method_3(gclass22_0.method_1(GClass24.int_13, 4), 1) == 4L)
                            goto label_3;
                    }
                    int i4 = checked(Information.UBound(iArr, 1) - 1);
                    for (i2 = 0; i2 <= i4; i2 = checked(i2 + 1))
                    {
                        method_2(iArr[i2, 0], iArr[i2, 1]);
                        gclass22_0.method_6(checked((int)gclass26_0.long_5), iArr[i2, 0], 2L);
                        gclass22_0.method_6(checked((int)checked(gclass26_0.long_5 + 4L)), iArr[i2, 1], 2L);
                        Thread.Sleep(100);
                        if (gclass22_0.method_3(checked((int)gclass26_0.long_11), 1) == 1L)
                            break;
                        if (gclass22_0.method_3(checked((int)gclass26_0.long_13), 1) == 5L)
                            goto label_2;
                    }
                    method_25();
                    goto label_1;
                label_2:
                    method_2(iArr[i2, 0], checked(iArr[i2, 1] - 10));
                    if ((long)GClass4.GetForegroundWindow() == long_0)
                    {
                        method_17(iArr[i2, 0], checked(iArr[i2, 1] - 10));
                        goto label_1;
                    }
                    method_16(iArr[i2, 0], iArr[i2, 1]);
                    goto label_1;
                label_3:
                    if ((long)GClass4.GetForegroundWindow() == long_0)
                        method_17(iArr[i1, 0], iArr[i1, 1]);
                    else
                        method_16(iArr[i1, 0], iArr[i1, 1]);
                    if (!flag)
                        goto label_1;
                    flag = false;
                    Thread.Sleep(500);
                label_4:
                    gclass26_0.long_11 = (long)gclass22_0.method_1(GClass24.int_11, 4);
                    gclass26_0.long_27 = (long)gclass22_0.method_1(GClass24.int_27, 4);
                    gclass22_0.method_7(gclass22_0.method_1(GClass24.int_6, 4), 40.0F);
                    gclass22_0.method_7(gclass22_0.method_1(GClass24.int_7, 4), 50.0F);
                    gclass22_0.method_7(gclass22_0.method_1(GClass24.int_8, 4), 1.55F);
                    Thread.Sleep(400);
                    if (!((gclass22_0.method_3(checked((int)gclass26_0.long_11), 1) == 0L) & (gclass22_0.method_3(checked((int)gclass26_0.long_14), 1) == 0L)))
                        goto label_1;
                }
                return;
            label_5:
                return;
            }
        }

        public void method_23()
        {
            gclass26_0.long_11 = (long)gclass22_0.method_1(GClass24.int_11, 4);
            gclass26_0.long_27 = (long)gclass22_0.method_1(GClass24.int_27, 4);
            if (gclass14_0.bool_17 & !bool_0 & (gclass22_0.method_3(checked((int)gclass26_0.long_14), 1) == 0L) & (method_10() > 0))
            {
                method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_27), 2) + 197L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_27 + 4L)), 2) + 98L)));
            }
            else if (gclass14_0.bool_17 & bool_0 & (gclass22_0.method_3(checked((int)gclass26_0.long_14), 1) == 1L))
            {
                method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_27), 2) + 197L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_27 + 4L)), 2) + 98L)));
            }
            else if (!gclass14_0.bool_17 & gclass23_0.method_0(GClass23.GEnum4.const_0))
            {
                Thread.Sleep(1000);
                if (gclass22_0.method_3(checked((int)gclass26_0.long_11), 1) == 0L)
                    method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_27), 2) + 197L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_27 + 4L)), 2) + 98L)));
            }
            method_25();
        }

        public void method_24()
        {
            gclass26_0.long_12 = (long)gclass22_0.method_1(GClass24.int_12, 4);
            gclass26_0.long_20 = (long)gclass22_0.method_1(GClass24.int_20, 4);
            if (gclass14_0.bool_17 & !bool_0 & (gclass22_0.method_3(checked((int)gclass26_0.long_14), 1) == 0L) & (method_10() > 0))
                method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_20), 2) + 189L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_20 + 4L)), 2) + 39L)));
            else if (gclass14_0.bool_17 & bool_0 & (gclass22_0.method_3(checked((int)gclass26_0.long_14), 1) == 1L))
                method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_20), 2) + 189L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_20 + 4L)), 2) + 39L)));
            else if (!gclass14_0.bool_17 & gclass23_0.method_0(GClass23.GEnum4.const_1))
                method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_20), 2) + 189L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_20 + 4L)), 2) + 39L)));
            Thread.Sleep(100);
            if ((gclass22_0.method_3(checked((int)gclass26_0.long_12), 1) == 1L) & (gclass22_0.method_3(checked((int)gclass26_0.long_14), 1) == 0L))
            {
                gclass22_0.method_6(checked((int)gclass26_0.long_16), 0, 1L);
                if (gclass14_0.bool_4)
                    method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_20), 2) + 196L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_20 + 4L)), 2) + 80L)));
                else
                    method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_20), 2) + 25L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_20 + 4L)), 2) + 37L)));
            }
            Thread.Sleep(1000);
            gclass26_0.long_10 = (long)gclass22_0.method_1(GClass24.int_10, 4);
        }

        public void method_25()
        {
            Thread.Sleep(400);
            if (((gclass22_0.method_3(checked((int)gclass26_0.long_11), 1) == 0L) & (gclass22_0.method_3(checked((int)gclass26_0.long_14), 1) == 0L)))
            {
                gclass22_0.method_6(checked((int)gclass26_0.long_16), 0, 1L);
                gclass26_0.long_27 = (long)gclass22_0.method_1(GClass24.int_27, 4);
                if (gclass14_0.bool_4)
                    method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_27), 2) + 197L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_27 + 4L)), 2) + 197L)));
                else
                    method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_27), 2) + 154L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_27 + 4L)), 2) + 197L)));
            }
        }

        public bool method_26()
        {
            goto label_2;
        label_1:
            bot_0.string_1 = "18";
            if (gclass22_0.method_3(checked((int)gclass26_0.long_18), 1) == 0L)
                gclass22_0.method_6(checked((int)gclass26_0.long_18), 1, 1L);
            if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) == 1L)
            {
                if (gclass14_0.bool_18)
                {
                    method_22();
                    goto label_2;
                }
                method_23();
                goto label_2;
            }
            if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 2L)
                goto label_2;
            method_24();
            while (true)
            {
                Thread.Sleep(1000);
                if (!((gclass22_0.method_3(gclass22_0.method_1(GClass24.int_10, 4), 1) != 0L) & bot_0.bool_0))
                {
                    Thread.Sleep(500);
                    if ((gclass22_0.method_3(gclass22_0.method_1(GClass24.int_10, 4), 1) != 0L) & bot_0.bool_0) goto label_3;
                }
            label_2:
                if (!((gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) == 0L) | !bot_0.bool_0))
                    goto label_1;
            }
        label_3:
            return true;
        }

        public bool method_27()
        {
            int i7, i8, i9;

            bool flag1 = false;
            int i1 = 2000, i2 = 100;
            int[] iArr = new int[] {  };
            gclass26_0.long_10 = (long)gclass22_0.method_1(GClass24.int_10, 4);
            while (!(flag1 | !bot_0.bool_0))
            {
                bot_0.string_1 = "19";
                if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) == 0L)
                {
                    int i3 = bot_0.int_6;
                    for (int i4 = 0; i4 <= i3; i4 = checked(i4 + 1))
                    {
                        if (!((bot_0.int_0[i4, 0] == 0) & (bot_0.int_0[i4, 1] == 0)))
                        {
                            int i5 = checked(checked((int)iArr.Length) - 1);
                            for (int i6 = 0; i6 <= i5; i6 = checked(i6 + 1))
                            {
                                if (iArr[i6] == i4)
                                    i4 = checked(i4 + 1);
                            }
                            if (bot_0.int_0[i4, 0] < int_1)
                                i7 = checked(int_1 - bot_0.int_0[i4, 0]);
                            else
                                i7 = checked(bot_0.int_0[i4, 0] - int_1);
                            if (bot_0.int_0[i4, 1] < int_2)
                                i8 = checked(int_2 - bot_0.int_0[i4, 1]);
                            else
                                i8 = checked(bot_0.int_0[i4, 1] - int_2);
                            if (i8 > i7)
                                i9 = checked(i8 + i7);
                            else
                                i9 = checked(i7 + i8);
                            if (i1 > i9)
                            {
                                i1 = i9;
                                i2 = i4;
                            }
                        }
                    }
                    gclass22_0.method_6(checked((int)gclass26_0.long_5), bot_0.int_0[i2, 0], 2L);
                    gclass22_0.method_6(checked((int)checked(gclass26_0.long_5 + 4L)), bot_0.int_0[i2, 1], 2L);
                    method_2(bot_0.int_0[i2, 0], bot_0.int_0[i2, 1]);
                    Thread.Sleep(300);
                    if (gclass22_0.method_3(checked((int)gclass26_0.long_4), 1) == 16L)
                    {
                        iArr = (int[])Utils.CopyArray((Array)iArr, new int[checked(checked((int)iArr.Length) + 1)]);
                        iArr[checked(checked((int)iArr.Length) - 1)] = i2;
                    }
                    else if (gclass22_0.method_3(checked((int)gclass26_0.long_4), 1) == 2L)
                    {
                        method_1(bot_0.int_0[i2, 0], bot_0.int_0[i2, 1]);
                        bool flag2 = true, flag3 = false;
                        while (!(!flag2 | flag3 | !bot_0.bool_0))
                        {
                            bot_0.string_1 = "20";
                            if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L)
                            {
                                flag3 = true;
                                Thread.Sleep(1000);
                            }
                            if (gclass22_0.method_3(checked((int)gclass26_0.long_34), 1) == 0L)
                            {
                                flag2 = false;
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else if (checked((int)iArr.Length) >= 15)
                    {
                        Array.Clear(bot_0.int_0, 0, bot_0.int_0.Length);
                        iArr = new int[0];
                    }
                    else
                    {
                        iArr = (int[])Utils.CopyArray((Array)iArr, new int[checked(checked((int)iArr.Length) + 1)]);
                        iArr[checked(checked((int)iArr.Length) - 1)] = i2;
                    }
                    i2 = 100;
                    i1 = 2000;
                }
                else
                {
                    flag1 = true;
                }
            }
            return true;
        }

        public bool method_28()
        {
            while (!(((gclass22_0.method_3(checked(gclass22_0.method_1(GClass24.int_25, 4) - 516), 2) == 0L) & (gclass22_0.method_3(gclass22_0.method_1(GClass24.int_19, 4), 2) == 0L) & (gclass22_0.method_3(gclass22_0.method_1(GClass24.int_33, 4), 2) == 0L) & (gclass22_0.method_3(gclass22_0.method_1(GClass24.int_40, 4), 2) == 0L)) | !bot_0.bool_0))
            {
                gclass26_0.long_28 = (long)gclass22_0.method_1(GClass24.int_28, 4);
                gclass26_0.long_33 = (long)gclass22_0.method_1(GClass24.int_33, 4);
                gclass26_0.long_25 = (long)gclass22_0.method_1(GClass24.int_25, 4);
                gclass26_0.long_19 = (long)gclass22_0.method_1(GClass24.int_19, 4);
                gclass26_0.long_39 = (long)gclass22_0.method_1(GClass24.int_40, 4);
                bot_0.string_1 = "21";
                if (gclass22_0.method_3(checked(gclass22_0.method_1(GClass24.int_25, 4) - 516), 2) != 0L)
                {
                    gclass26_0.long_25 = (long)gclass22_0.method_1(GClass24.int_25, 4);
                    Thread.Sleep(200);
                    method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_25), 2) + 506L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_25 + 4L)), 2) + 325L)));
                    Thread.Sleep(500);
                }
                if (gclass22_0.method_3(gclass22_0.method_1(GClass24.int_19, 4), 2) != 0L)
                {
                    gclass26_0.long_19 = (long)gclass22_0.method_1(GClass24.int_19, 4);
                    Thread.Sleep(200);
                    method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_19), 2) + 455L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_19 + 4L)), 2) + 446L)));
                    Thread.Sleep(500);
                }
                if (gclass22_0.method_3(gclass22_0.method_1(GClass24.int_33, 4), 2) != 0L)
                {
                    gclass26_0.long_28 = (long)gclass22_0.method_1(GClass24.int_28, 4);
                    Thread.Sleep(200);
                    method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_28), 2) + 10L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_28 + 4L)), 2) + 13L)));
                    Thread.Sleep(100);
                    method_1(checked((int)checked(checked(gclass22_0.method_3(checked((int)gclass26_0.long_28), 2) + gclass22_0.method_3(checked(gclass22_0.method_1(GClass24.int_28, 4) + 8), 2)) - 15L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_28 + 4L)), 2) + 13L)));
                    Thread.Sleep(500);
                }
                if (gclass22_0.method_3(gclass22_0.method_1(GClass24.int_40, 4), 2) != 0L)
                {
                    gclass26_0.long_39 = (long)gclass22_0.method_1(GClass24.int_40, 4);
                    Thread.Sleep(500);
                    method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_39), 2) + 242L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_39 + 4L)), 2) + 228L)));
                    Thread.Sleep(500);
                }
            }
            return true;
        }

        public object method_29()
        {
            if (method_35())
            {
            }
            while (!(((bot_0.int_2[0] != 0) & (bot_0.int_2[0] != 14)) | !bot_0.bool_0))
            {
                if (bot_0.bool_2 & (bot_0.partyCode_0 == PartyCode.Follower))
                    gclass23_0.method_1(0);
                bot_0.string_1 = "25";
                Thread.Sleep(500);
            }
            while (!((gclass22_0.method_3(checked((int)gclass26_0.long_31), 1) == 0L) | !bot_0.bool_0))
            {
                bot_0.string_1 = "26";
                Thread.Sleep(500);
            }
            if (!method_30())
                return 1;
            if (!method_31())
                return 1;
            if (!method_32())
                return 1;
            if (!method_33())
                return 1;
            return 1;
        }

        public void method_3()
        {
            Thread thread = new Thread(new ThreadStart(method_48));
            thread.IsBackground = true;
            thread.Start();
            GClass4.GetWindowRect(checked((int)long_0), ref gstruct0_0);
            int_1 = checked((int)Math.Round((double)checked(gstruct0_0.int_2 - gstruct0_0.int_0) / 2.0));
            int_2 = checked((int)Math.Round((double)checked(gstruct0_0.int_3 - gstruct0_0.int_1) / 2.0));
            gclass26_0.long_18 = (long)gclass22_0.method_1(GClass24.int_18, 4);
            Operators.ConditionalCompareObjectEqual(method_29(), 1, false);
            if (bot_0.bool_2 & (bot_0.partyCode_0 == PartyCode.Follower))
            {
                while (!((bot_0.gclass30_0.method_2() == GEnum6.const_0) | !bot_0.bool_0))
                {
                    if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) == 0L)
                    {
                        bot_0.string_1 = "8";
                        Thread.Sleep(1000);
                    }
                }
                if ((int)gclass22_0.method_3(checked((int)gclass26_0.long_46), 2) != bot_0.gclass30_0.method_6())
                {
                    if (gclass14_0.bool_3)
                        gclass0_0.method_2(bot_0.gclass30_0.method_6(), bot_0.gclass30_0.method_8(), bot_0.gclass30_0.method_10());
                    else
                        gclass0_0.method_4(bot_0.gclass30_0.method_6(), bot_0.gclass30_0.method_8(), bot_0.gclass30_0.method_10());
                }
                gclass22_0.method_6(checked((int)gclass26_0.long_60), bot_0.gclass30_0.method_0(), 4L);
            }
            else if (gclass14_0.bool_17 & (gclass14_0.int_18 >= method_10()))
            {
                method_9();
            }
            else if (Operators.ConditionalCompareObjectEqual(method_37(), 1, false))
            {
                if (gclass14_0.bool_3)
                    gclass0_0.method_2(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
                else
                    gclass0_0.method_4(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
            }
            method_39(GEnum6.const_0);
            dateTime_0 = DateTime.Now;
            while (bot_0.bool_0)
            {
                bot_0.string_1 = "9";
                bool_2 = true;
                method_47("STATUS: RUNNING");
                method_6();
                bool_2 = false;
            }
            method_47("STATUS: IDLE");
        }

        public bool method_30()
        {
            int i1 = 8;
            while (!((i1 == 0) | !bot_0.bool_0))
            {
                bot_0.string_1 = "27";
                i1 = 9;
                int i2 = 0;
                goto label_2;
            label_1:
                i2 = checked(i2 + 1);
                if (i2 <= 8)
                    goto label_2;
                while (true)
                {
                    i1 = checked(i1 - 1);
                    goto label_1;
                label_2:
                    if (!((bot_0.int_2[i2] != 0) | (bot_0.int_4[i2] == 0) | (bot_0.int_2[i2] == 14) | (bot_0.int_1[i2] == 1)))
                        goto label_1;
                }
                if ((i1 > 0) && !method_34())
                    goto label_4;
                Thread.Sleep(100);
                if (!method_36(Conversions.ToString(gclass14_0.int_0)))
                    return true;
                if (((double)gclass14_0.int_0 == Conversions.ToDouble("2149")) | ((double)gclass14_0.int_0 == Conversions.ToDouble("2153")))
                {
                    if (!(gclass14_0.bool_0 & (gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) != 0L) & (i1 > 0)))
                        goto label_3;
                    method_0(checked((int)checked(checked(gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) + 40L) + (long)checked(int_3[1] * 46))), checked((int)checked(checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_3 + 4L)), 2) + 67L) + (long)checked(int_3[0] * 46))));
                    method_44();
                }
                else
                {
                    if (gclass14_0.bool_0 & (gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) != 0L) & (i1 > 0))
                    {
                        Thread.Sleep(200);
                        gclass26_0.long_3 = (long)gclass22_0.method_1(GClass24.int_3, 4);
                        gclass26_0.long_58 = (long)gclass22_0.method_1(GClass24.int_59, 4);
                        if (gclass22_0.method_3(checked((int)gclass26_0.long_58), 1) == 0L)
                        {
                            method_0(checked((int)checked(checked(gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) + 40L) + (long)checked(int_3[1] * 46))), checked((int)checked(checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_3 + 4L)), 2) + 67L) + (long)checked(int_3[0] * 46))));
                            Thread.Sleep(1000);
                            continue;
                        }
                        if (gclass22_0.method_3(checked((int)gclass26_0.long_58), 1) != 0L)
                        {
                            gclass26_0.long_24 = (long)gclass22_0.method_1(GClass24.int_24, 4);
                            method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_24), 2) + 266L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_24 + 4L)), 2) + 76L)));
                            Thread.Sleep(800);
                            method_44();
                        }
                    }
                label_3:;
                }
            }
            return true;
        label_4:
            return true;
        }

        public bool method_31()
        {
            int i1 = 8;
            if (gclass14_0.bool_1)
            {
                while (!((i1 == 0) | !bot_0.bool_0))
                {
                    bot_0.string_1 = "28";
                    i1 = 9;
                    int i2 = 0;
                    while ((i2 <= 8) && !((bot_0.double_0[i2] < gclass14_0.double_0) & (bot_0.int_1[i2] == 0)))
                    {
                        i2 = checked(i2 + 1);
                    }
                    if (!method_34())
                        goto label_4;
                    Thread.Sleep(100);
                    if (!method_36(Conversions.ToString(gclass14_0.int_1)))
                        goto label_5;
                    gclass26_0.long_3 = (long)gclass22_0.method_1(GClass24.int_3, 4);
                    int i3 = 0;
                    goto label_3;
                label_1:
                    i1 = checked(i1 - 1);
                label_2:
                    i3 = checked(i3 + 1);
                    if (i3 <= 8)
                        goto label_3;
                    while (true)
                    {
                        gclass26_0.long_16 = (long)gclass22_0.method_1(GClass24.int_16, 4);
                        gclass22_0.method_6(checked((int)gclass26_0.long_16), i3, 1L);
                        gclass26_0.long_23 = (long)gclass22_0.method_1(GClass24.int_23, 4);
                        int_4[i3, 0] = bot_0.int_2[i3];
                        int_4[i3, 2] = checked((int)gclass22_0.method_3(checked((int)checked(gclass26_0.long_23 + (long)checked(checked(int_3[0] * 480) + checked(int_3[1] * 48)))), 2));
                        if (bot_0.int_2[i3] == 0)
                            goto label_2;
                        if (Operators.CompareString(gclass14_0.string_1, "Food", false) == 0)
                        {
                            while (!((method_38() > 10) | (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L) | !bot_0.bool_0))
                            {
                                bot_0.string_1 = "29";
                                Thread.Sleep(500);
                            }
                            Thread.Sleep(100);
                            if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L)
                                goto label_6;
                            Thread.Sleep(300);
                            method_0(checked((int)checked(checked(gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) + 40L) + (long)checked(int_3[1] * 46))), checked((int)checked(checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_3 + 4L)), 2) + 67L) + (long)checked(int_3[0] * 46))));
                            Thread.Sleep(200);
                        }
                        else
                        {
                            Thread.Sleep(300);
                            method_0(checked((int)checked(checked(gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) + 40L) + (long)checked(int_3[1] * 46))), checked((int)checked(checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_3 + 4L)), 2) + 67L) + (long)checked(int_3[0] * 46))));
                            Thread.Sleep(200);
                        }
                        Thread.Sleep(500);
                        if ((int_4[i3, 0] == bot_0.int_2[i3]) & ((long)int_4[i3, 2] != gclass22_0.method_3(checked((int)checked(gclass26_0.long_23 + (long)checked(checked(int_3[0] * 480) + checked(int_3[1] * 48)))), 2)))
                        {
                            int[,] iArr = int_4;
                            int i5 = i3;
                            iArr[i5, 1] = checked(iArr[i5, 1] + 1);
                            int_4[i3, 2] = checked((int)gclass22_0.method_3(checked((int)checked(gclass26_0.long_23 + (long)checked(checked(int_3[0] * 480) + checked(int_3[1] * 48)))), 2));
                        }
                        else
                        {
                            int_4[i3, 0] = 0;
                            int_4[i3, 1] = 0;
                            int_4[i3, 2] = 0;
                        }
                        if (int_4[i3, 1] == 4)
                        {
                            bot_0.int_4[i3] = bot_0.int_2[i3];
                            int_4[i3, 0] = 0;
                            int_4[i3, 1] = 0;
                            int_4[i3, 2] = 0;
                        }
                        method_43();
                        goto label_2;
                    label_3:
                        if (!((bot_0.double_0[i3] < gclass14_0.double_0) & (bot_0.int_2[i3] != 14) & (bot_0.int_1[i3] == 0)))
                            goto label_1;
                    }
                }
                int i6 = 0;
                do
                {
                    int_4[i6, 0] = 0;
                    int_4[i6, 1] = 0;
                    int_4[i6, 2] = 0;
                    i6 = checked(i6 + 1);
                } while (i6 <= 8);
                return true;
            label_4:
                return true;
            label_5:
                return true;
            label_6:
                int i4 = 0;
                do
                {
                    int_4[i4, 0] = 0;
                    int_4[i4, 1] = 0;
                    int_4[i4, 2] = 0;
                    i4 = checked(i4 + 1);
                } while (i4 <= 8);
                return true;
            }
            return true;
        }

        public bool method_32()
        {
            int i1 = 8;
            if (gclass14_0.bool_2)
            {
                while (!((i1 == 0) | !bot_0.bool_0))
                {
                    bot_0.string_1 = "30";
                    i1 = 9;
                    int i2 = 0;
                    while ((i2 <= 8) && !((bot_0.double_1[i2] < gclass14_0.double_1) & (bot_0.int_1[i2] == 0)))
                    {
                        i2 = checked(i2 + 1);
                    }
                    if (!method_34())
                        goto label_4;
                    Thread.Sleep(100);
                    if (!method_36(Conversions.ToString(gclass14_0.int_2)))
                        goto label_5;
                    int i3 = 0;
                    goto label_3;
                label_1:
                    i1 = checked(i1 - 1);
                label_2:
                    i3 = checked(i3 + 1);
                    if (i3 <= 8)
                        goto label_3;
                    while (true)
                    {
                        gclass26_0.long_16 = (long)gclass22_0.method_1(GClass24.int_16, 4);
                        gclass22_0.method_6(checked((int)gclass26_0.long_16), i3, 1L);
                        gclass26_0.long_23 = (long)gclass22_0.method_1(GClass24.int_23, 4);
                        int_5[i3, 0] = bot_0.int_3[i3];
                        int_5[i3, 2] = checked((int)gclass22_0.method_3(checked((int)checked(gclass26_0.long_23 + (long)checked(checked(int_3[0] * 480) + checked(int_3[1] * 48)))), 2));
                        if (bot_0.int_3[i3] == 0)
                            goto label_2;
                        if (Operators.CompareString(gclass14_0.string_2, "Food", false) == 0)
                        {
                            while (!((method_38() > 10) | (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L) | !bot_0.bool_0))
                            {
                                bot_0.string_1 = "31";
                                Thread.Sleep(500);
                            }
                            if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L)
                                goto label_6;
                            Thread.Sleep(300);
                            method_0(checked((int)checked(checked(gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) + 40L) + (long)checked(int_3[1] * 46))), checked((int)checked(checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_3 + 4L)), 2) + 67L) + (long)checked(int_3[0] * 46))));
                            Thread.Sleep(200);
                        }
                        else
                        {
                            Thread.Sleep(300);
                            method_0(checked((int)checked(checked(gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) + 40L) + (long)checked(int_3[1] * 46))), checked((int)checked(checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_3 + 4L)), 2) + 67L) + (long)checked(int_3[0] * 46))));
                            Thread.Sleep(200);
                        }
                        Thread.Sleep(500);
                        if ((int_5[i3, 0] == bot_0.int_3[i3]) & ((long)int_5[i3, 2] != gclass22_0.method_3(checked((int)checked(gclass26_0.long_23 + (long)checked(checked(int_3[0] * 480) + checked(int_3[1] * 48)))), 2)))
                        {
                            int[,] iArr = int_5;
                            int i5 = i3;
                            iArr[i5, 1] = checked(iArr[i5, 1] + 1);
                        }
                        else
                        {
                            int_5[i3, 0] = 0;
                            int_5[i3, 1] = 0;
                            int_5[i3, 2] = 0;
                        }
                        if (int_5[i3, 1] == 4)
                        {
                            bot_0.int_5[i3] = bot_0.int_3[i3];
                            int_5[i3, 0] = 0;
                            int_5[i3, 1] = 0;
                            int_5[i3, 2] = 0;
                        }
                        method_43();
                        goto label_2;
                    label_3:
                        if (!((bot_0.double_1[i3] < gclass14_0.double_1) & (bot_0.int_3[i3] != 14) & (bot_0.int_1[i3] == 0)))
                            goto label_1;
                    }
                }
                int i6 = 0;
                do
                {
                    int_5[i6, 0] = 0;
                    int_5[i6, 1] = 0;
                    int_5[i6, 2] = 0;
                    i6 = checked(i6 + 1);
                } while (i6 <= 8);
                return true;
            label_4:
                return true;
            label_5:
                return true;
            label_6:
                int i4 = 0;
                do
                {
                    int_5[i4, 0] = 0;
                    int_5[i4, 1] = 0;
                    int_5[i4, 2] = 0;
                    i4 = checked(i4 + 1);
                } while (i4 <= 8);
                return true;
            }
            return true;
        }

        public bool method_33()
        {
            Thread.Sleep(500);
            gclass26_0.long_3 = (long)gclass22_0.method_1(GClass24.int_3, 4);
            Thread.Sleep(200);
            if (gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) != 0L)
            {
                method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_3), 2) + 487L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_3 + 4L)), 2) + 12L)));
                Thread.Sleep(1000);
            }
            gclass26_0.long_3 = (long)gclass22_0.method_1(GClass24.int_3, 4);
            return true;
        }

        public bool method_34()
        {
            while (!((gclass22_0.method_3(gclass22_0.method_1(GClass24.int_3, 4), 2) != 0L) | !bot_0.bool_0))
            {
                bot_0.string_1 = "32";
                if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L)
                    goto label_1;
                if (gclass22_0.method_3(gclass22_0.method_1(GClass24.int_3, 4), 2) == 0L)
                {
                    method_0(355, 689);
                    Thread.Sleep(100);
                }
                Thread.Sleep(500);
            }
            gclass26_0.long_3 = (long)gclass22_0.method_1(GClass24.int_3, 4);
            return true;
        label_1:
            genum2_0 = GEnum2.const_2;
            return false;
        }

        public bool method_35()
        {
            for (int i = 0; (i <= 8) && (bot_0.double_0[i] >= 0.8); i = checked(i + 1))
            {
                if (bot_0.double_1[i] < 0.8)
                    return false;
                if (i == 8)
                    goto label_1;
            }
            return false;
        label_1:
            return true;
        }

        public bool method_36(string string_0)
        {
            bool flag = false;
            gclass26_0.long_22 = (long)gclass22_0.method_1(GClass24.int_22, 4);
            Thread.Sleep(200);
            if ((double)gclass22_0.method_3(checked((int)checked(gclass26_0.long_22 + (long)checked(checked(int_3[0] * 480) + checked(int_3[1] * 48)))), 2) == Conversions.ToDouble(string_0))
            {
                flag = true;
            }
            else
            {
                int i1 = 0;
                goto label_3;
            label_1:
                int i2 = checked(i2 + 1);
                if (i2 > 9)
                    goto label_2;
                while (true)
                {
                    if ((double)gclass22_0.method_3(checked((int)checked(gclass26_0.long_22 + (long)checked(checked(i1 * 480) + checked(i2 * 48)))), 2) != Conversions.ToDouble(string_0))
                        goto label_1;
                    int_3[0] = i1;
                    int_3[1] = i2;
                    flag = true;
                label_2:
                    if (!flag)
                    {
                        i1 = checked(i1 + 1);
                        if (i1 <= 8)
                        {
                        label_3:
                            i2 = 0;
                        }
                    }
                }
            }
            if (!flag)
            {
                GClass25.smethod_0(bot_0.string_0 + " is out of potions");
                method_42();
                return false;
            }
            return true;
        }

        public object method_37()
        {
            gclass26_0.long_46 = (long)gclass22_0.method_1(GClass24.int_47, 4);
            if (GClass0.smethod_0(checked((int)gclass22_0.method_3(checked((int)gclass26_0.long_46), 2))))
                return 1;
            return 0;
        }

        public int method_38()
        {
            string[] sArr;

            string s = gclass22_0.method_5(checked((int)gclass26_0.long_35), 50);
            if (s.Contains(":"))
                sArr = Strings.Split(gclass22_0.method_5(checked((int)gclass26_0.long_35), 50), ":", -1, CompareMethod.Binary);
            else
                sArr = Strings.Split(gclass22_0.method_5(checked((int)gclass26_0.long_35), 50), " ", -1, CompareMethod.Binary);
            sArr[1] = sArr[1].Replace("%", "");
            sArr[1] = sArr[1].Replace(" ", "");
            return Conversions.ToInteger(sArr[1]);
        }

        public object method_39(GEnum6 genum6_0)
        {
            GClass28.GClass29 gclass29 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_50));
            if (gclass29 != null)
                gclass29.method_9(genum6_0);
            return 1;
        }

        public void method_4()
        {
            if ((int)gclass22_0.method_3(checked((int)gclass26_0.long_44), 4) != gclass14_0.int_8)
                gclass22_0.method_6(checked((int)gclass26_0.long_44), gclass14_0.int_8, 4L);
        }

        public object method_40(GEnum6 genum6_0)
        {
            GClass28.GClass29 gclass29 = Enumerable.FirstOrDefault<GClass28.GClass29>((GEnum6)GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_51));
            if (gclass29 != null)
                gclass29.method_11(genum6_0);
            return 1;
        }

        public int method_41()
        {
            string[] sArr = Strings.Split(bot_0.string_2, ": ", -1, CompareMethod.Binary);
            sArr[1] = Conversions.ToString(checked(Conversions.ToInteger(sArr[1]) + 1));
            return Conversions.ToInteger(sArr[1]);
        }

        public void method_42()
        {
            if (bot_0.vmethod_20().InvokeRequired)
            {
                bot_0.vmethod_20().Invoke(new GClass4.GDelegate0(method_42));
                return;
            }
            bot_0.bool_0 = false;
            bot_0.vmethod_20().Value = true;
        }

        public void method_43()
        {
            string[] sArr = Strings.Split(bot_0.string_6, ": ", -1, CompareMethod.Binary);
            sArr[1] = Conversions.ToString(checked(Conversions.ToInteger(sArr[1]) + 1));
            bot_0.string_6 = sArr[0] + ": " + sArr[1];
        }

        public void method_44()
        {
            string[] sArr = Strings.Split(bot_0.string_5, ": ", -1, CompareMethod.Binary);
            sArr[1] = Conversions.ToString(checked(Conversions.ToInteger(sArr[1]) + 1));
            bot_0.string_5 = sArr[0] + ": " + sArr[1];
        }

        public void method_45()
        {
            string[] sArr = Strings.Split(bot_0.string_2, ": ", -1, CompareMethod.Binary);
            sArr[1] = Conversions.ToString(checked(Conversions.ToInteger(sArr[1]) + 1));
            bot_0.string_2 = sArr[0] + ": " + sArr[1];
            int_0 = checked(int_0 + 1);
        }

        public void method_46(string string_0)
        {
            bot_0.string_2 = string_0;
        }

        public void method_47(string string_0)
        {
            bot_0.string_3 = string_0;
        }

        [CompilerGenerated]
        private void method_48()
        {
            method_5();
        }

        [CompilerGenerated]
        private bool method_49(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_4(), bot_0.string_0, false) == 0;
        }

        public void method_5()
        {
            while (bot_0.bool_0)
            {
                gclass26_0.long_56 = (long)gclass22_0.method_1(GClass24.int_57, 4);
                gclass26_0.long_18 = (long)gclass22_0.method_1(GClass24.int_18, 4);
                gclass26_0.long_10 = (long)gclass22_0.method_1(GClass24.int_10, 4);
                gclass26_0.long_59 = (long)gclass22_0.method_1(GClass24.int_60, 4);
                if (gclass22_0.method_3(checked((int)gclass26_0.long_18), 1) == 1L)
                {
                    if (gclass14_0.bool_9 && (gclass22_0.method_3(checked((int)gclass26_0.long_56), 2) != 0L))
                    {
                        method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_56), 2) + 116L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_56 + 4L)), 2) + 393L)));
                        Thread.Sleep(1000);
                    }
                    if (gclass14_0.bool_8 && (gclass22_0.method_3(checked((int)gclass26_0.long_59), 2) != 0L))
                    {
                        method_1(checked((int)checked(gclass22_0.method_3(checked((int)gclass26_0.long_59), 2) + 64L)), checked((int)checked(gclass22_0.method_3(checked((int)checked(gclass26_0.long_59 + 4L)), 2) + 158L)));
                        Thread.Sleep(1000);
                    }
                }
                Thread.Sleep(5000);
            }
        }

        [CompilerGenerated]
        private bool method_50(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), bot_0.string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_51(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), bot_0.string_0, false) == 0;
        }

        public void method_6()
        {
            switch (genum2_0)
            {
                case GEnum2.const_0:
                    if (bot_0.bool_2 & (bot_0.partyCode_0 == PartyCode.Leader))
                    {
                        while (!((bot_0.gclass30_0.method_2() == GEnum6.const_0) | !bot_0.bool_0))
                        {
                            if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L)
                                goto label_1;
                            bot_0.string_1 = "11";
                            Thread.Sleep(200);
                        }
                        goto label_2;
                    label_1:
                        genum2_0 = GEnum2.const_2;
                    }
                label_2:
                    if (bot_0.bool_2 & (bot_0.partyCode_0 == PartyCode.Follower))
                    {
                        genum2_0 = GEnum2.const_2;
                        return;
                    }
                    if (!method_20())
                        return;
                    genum2_0 = GEnum2.const_1;
                    break;

                case GEnum2.const_1:
                    if (bot_0.bool_2 & (bot_0.partyCode_0 == PartyCode.Follower))
                    {
                        genum2_0 = GEnum2.const_2;
                        return;
                    }
                    if (!method_27())
                        return;
                    genum2_0 = GEnum2.const_2;
                    break;

                case GEnum2.const_2:
                    if (bot_0.bool_2 & (bot_0.partyCode_0 == PartyCode.Follower))
                    {
                        while (!Operators.ConditionalCompareObjectEqual(method_37(), 1, false) && !((gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L) | !bot_0.bool_0))
                        {
                            bot_0.string_1 = "12";
                            Thread.Sleep(500);
                        }
                        goto label_3;
                        genum2_0 = GEnum2.const_3;
                        gclass23_0.method_1(0);
                        return;
                    }
                label_3:
                    method_39(GEnum6.const_2);
                    if (!method_26())
                        return;
                    genum2_0 = GEnum2.const_3;
                    method_45();
                    break;

                case GEnum2.const_3:
                    method_8();
                    if (!method_28())
                        return;
                    genum2_0 = GEnum2.const_4;
                    break;

                case GEnum2.const_4:
                    method_8();
                    if (Operators.ConditionalCompareObjectEqual(method_29(), 1, false))
                    {
                        bool_1 = true;
                        genum2_0 = GEnum2.const_5;
                    }
                    break;

                case GEnum2.const_5:
                    while (gclass22_0.method_3(checked((int)gclass26_0.long_31), 1) == 1L)
                    {
                        Thread.Sleep(300);
                    }
                    if (Operators.ConditionalCompareObjectEqual(method_37(), 1, false))
                    {
                        method_39(GEnum6.const_3);
                        if (bot_0.bool_2 & (bot_0.partyCode_0 == PartyCode.Follower))
                        {
                            method_29();
                            while (!((bot_0.gclass30_0.method_2() == GEnum6.const_0) | !bot_0.bool_0))
                            {
                                bot_0.string_1 = "13";
                                gclass23_0.method_1(0);
                                Thread.Sleep(500);
                            }
                            if (gclass14_0.bool_3)
                                gclass0_0.method_2(bot_0.gclass30_0.method_6(), bot_0.gclass30_0.method_8(), bot_0.gclass30_0.method_10());
                            else
                                gclass0_0.method_4(bot_0.gclass30_0.method_6(), bot_0.gclass30_0.method_8(), bot_0.gclass30_0.method_10());
                            gclass23_0.method_1(bot_0.gclass30_0.method_0());
                        }
                        else
                        {
                            if (gclass14_0.bool_17 & (gclass14_0.int_18 >= method_10()))
                                method_9();
                            while (!(method_7() | !bot_0.bool_0))
                            {
                                Thread.Sleep(200);
                            }
                            if (gclass14_0.bool_3)
                                gclass0_0.method_2(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
                            else
                                gclass0_0.method_4(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
                        }
                    }
                    else
                    {
                        if (bot_0.bool_2 & (bot_0.partyCode_0 == PartyCode.Follower))
                        {
                            method_39(GEnum6.const_0);
                            while (!((bot_0.gclass30_0.method_2() == GEnum6.const_0) | !bot_0.bool_0))
                            {
                                gclass23_0.method_1(0);
                                if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) != 0L)
                                    goto label_4;
                                Thread.Sleep(500);
                            }
                            goto label_5;
                        label_4:
                            genum2_0 = GEnum2.const_2;
                        label_5:
                            if ((int)gclass22_0.method_3(checked((int)gclass26_0.long_60), 4) != bot_0.gclass30_0.method_0())
                                gclass22_0.method_6(checked((int)gclass26_0.long_60), bot_0.gclass30_0.method_0(), 4L);
                        }
                        if (!bot_0.bool_2 && gclass14_0.bool_17)
                        {
                            method_9();
                            method_11();
                        }
                        genum2_0 = GEnum2.const_0;
                        method_39(GEnum6.const_0);
                    }
                    break;
            }
        }

        public bool method_7()
        {
            IEnumerable<GClass28.GClass29> ienumerable = Enumerable.Where<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_49));
            if (Enumerable.Count<GClass28.GClass29>(ienumerable) == Enumerable.Count<GClass28.GClass29>(ienumerable, new Func<GClass28.GClass29,bool>(null, GClass4.smethod_1)))
                return true;
            return false;
        }

        public void method_8()
        {
            if ((bot_0.bool_2 & (bot_0.partyCode_0 == PartyCode.Follower)))
            {
                if (bot_0.gclass30_0.method_2() == GEnum6.const_3)
                    gclass22_0.method_6(checked((int)gclass26_0.long_60), 0, 4L);
                else if ((int)gclass22_0.method_3(checked((int)gclass26_0.long_60), 4) != bot_0.gclass30_0.method_0())
                    gclass22_0.method_6(checked((int)gclass26_0.long_60), bot_0.gclass30_0.method_0(), 4L);
            }
        }

        public bool method_9()
        {
            if ((gclass14_0.int_18 >= method_10()) & !bool_0)
            {
                Random random = new Random();
                GClass14.GClass15 gclass15 = gclass14_0.list_0.get_Item(random.Next(0, checked(gclass14_0.list_0.get_Count() - 1)));
                bool_0 = true;
                gclass22_0.method_6(checked((int)gclass26_0.long_14), 0, 1L);
                if (gclass14_0.bool_16)
                    gclass0_0.method_2(checked((int)gclass15.method_2()), checked((int)gclass15.method_4()), Conversions.ToInteger(gclass15.method_6()));
                else
                    gclass0_0.method_4(checked((int)gclass15.method_2()), checked((int)gclass15.method_4()), Conversions.ToInteger(gclass15.method_6()));
            }
            if ((gclass14_0.int_19 <= method_10()) & bool_0)
            {
                if (gclass14_0.bool_16)
                    gclass0_0.method_2(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
                else
                    gclass0_0.method_4(gclass14_0.int_4, gclass14_0.int_5, gclass14_0.int_6);
                bool_0 = false;
            }
            return true;
        }

        private static int smethod_0(int int_8, int int_9)
        {
            return (checked(int_9 - 1) << 16) | checked(int_8 + 65535);
        }

        [CompilerGenerated]
        private static bool smethod_1(GClass28.GClass29 gclass29_0)
        {
            return gclass29_0.method_8() != GEnum6.const_2;
        }

        [PreserveSig]
        [DllImport("user32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [PreserveSig]
        [DllImport("user32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern long GetWindowRect(int int_8, ref GClass4.GStruct0 gstruct0_1);

        [PreserveSig]
        [DllImport("user32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

        [PreserveSig]
        [DllImport("d3d9hook.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SetAttack(int int_8, int int_9);

    } // class GClass4

}

