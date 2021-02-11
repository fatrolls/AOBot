using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    public sealed class GClass23
    {

        public enum GEnum4
        {
            const_0,
            const_1
        }

        private GClass14 gclass14_0;
        private GClass22 gclass22_0;
        private GClass26 gclass26_0;
        private long long_0;

        public GClass23(GClass22 gclass22_1, GClass26 gclass26_1, long long_1, GClass14 gclass14_1)
        {
            gclass22_0 = gclass22_1;
            gclass26_0 = gclass26_1;
            long_0 = long_1;
            gclass14_0 = gclass14_1;
        }

        public bool method_0(GClass23.GEnum4 genum4_0)
        {
            bool flag;

            if (genum4_0 == GClass23.GEnum4.const_0)
            {
                if (((int)gclass22_0.method_3(checked((int)gclass26_0.long_15), 1) >= gclass14_0.int_7) & (gclass22_0.method_3(checked((int)gclass26_0.long_14), 1) == 0L) & (Operators.CompareString(gclass22_0.method_5(gclass22_0.method_1(GClass24.int_36, 4), 7), "", false) != 0))
                    return true;
                return false;
            }
            if (genum4_0 == GClass23.GEnum4.const_1)
            {
                if (((int)gclass22_0.method_3(checked((int)gclass26_0.long_15), 1) >= gclass14_0.int_7) & (gclass22_0.method_3(checked((int)gclass26_0.long_14), 1) == 0L) & (Operators.CompareString(gclass22_0.method_5(gclass22_0.method_1(GClass24.int_37, 4), 7), "", false) != 0))
                    return true;
                return false;
            }
            return flag;
        }

        public void method_1(int int_0)
        {
            if ((int)gclass22_0.method_3(checked((int)gclass26_0.long_60), 4) != int_0)
                gclass22_0.method_6(checked((int)gclass26_0.long_60), int_0, 4L);
        }

    } // class GClass23

}

