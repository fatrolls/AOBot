using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns0
{

    public sealed class GClass1
    {

        public sealed class GClass2
        {

            [CompilerGenerated]
            private long long_0;
            [CompilerGenerated]
            private long long_1;
            [CompilerGenerated]
            private Process process_0;
            [CompilerGenerated]
            private string string_0;

            public GClass2()
            {
            }

            public Process method_0()
            {
                Process process;

                return process_0;
            }

            public void method_1(Process process_1)
            {
                process_0 = process_1;
            }

            public long method_2()
            {
                return long_0;
            }

            public void method_3(long long_2)
            {
                long_0 = long_2;
            }

            public long method_4()
            {
                return long_1;
            }

            public void method_5(long long_2)
            {
                long_1 = long_2;
            }

            public string method_6()
            {
                return string_0;
            }

            public void method_7(string string_1)
            {
                string_0 = string_1;
            }

        } // class GClass2

        public static List<GClass1.GClass2> list_0;

        static GClass1()
        {
            GClass1.list_0 = new List<GClass1.GClass2>();
        }

        public GClass1()
        {
        }

    } // class GClass1

}

