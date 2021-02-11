using Microsoft.VisualBasic;

namespace ns0
{

    public sealed class GClass5
    {

        public GClass5()
        {
        }

        public static string smethod_0(string string_0, string string_1, string string_2, string string_3)
        {
            string s = Strings.Space(1024);
            int i = GClass5.GetPrivateProfileStringW(ref string_1, ref string_2, ref string_3, ref s, s.Length, ref string_0);
            if (i > 0)
                return s.Substring(0, i);
            return "";
        }

        public static string smethod_1(string string_0, string string_1, string string_2)
        {
            return GClass5.smethod_0(string_0, string_1, string_2, "");
        }

        public static string smethod_2(string string_0, string string_1)
        {
            return GClass5.smethod_0(string_0, string_1, null, "");
        }

        public static string smethod_3(string string_0)
        {
            return GClass5.smethod_0(string_0, null, null, "");
        }

        public static void smethod_4(string string_0, string string_1, string string_2, string string_3)
        {
            GClass5.WritePrivateProfileStringW(ref string_1, ref string_2, ref string_3, ref string_0);
        }

        public static void smethod_5(string string_0, string string_1, string string_2)
        {
            string s = null;
            GClass5.WritePrivateProfileStringW(ref string_1, ref string_2, ref s, ref string_0);
        }

        public static void smethod_6(string string_0, string string_1)
        {
            string s1 = null;
            string s2 = null;
            GClass5.WritePrivateProfileStringW(ref string_1, ref s1, ref s2, ref string_0);
        }

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int GetPrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_4);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int WritePrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3);

    } // class GClass5

}

