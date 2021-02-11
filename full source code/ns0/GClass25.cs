using System.Runtime.CompilerServices;
using System.Speech.Synthesis;
using System.Threading;

namespace ns0
{

    public sealed class GClass25
    {

        [CompilerGenerated]
        internal sealed class Class11
        {

            public GClass25 gclass25_0;
            public string string_0;

            public Class11()
            {
            }

            [CompilerGenerated]
            public void method_0()
            {
                gclass25_0.method_0(string_0);
            }

        } // class Class11

        public GClass25()
        {
        }

        public void method_0(string string_0)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Rate = 1;
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Speak(string_0);
        }

        public static void smethod_0(string string_0)
        {
            GClass25.Class11 class11 = new GClass25.Class11();
            class11.string_0 = string_0;
            class11.gclass25_0 = new GClass25();
            Thread thread = new Thread(new ThreadStart(class11.method_0));
            thread.IsBackground = true;
            thread.Start();
        }

    } // class GClass25

}

