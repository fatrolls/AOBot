using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ns0
{

    [GeneratedCode("MyTemplate", "11.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class Form0 : WindowsFormsApplicationBase
    {

        [DebuggerStepThrough]
        public Form0() : base(AuthenticationMode.Windows)
        {
            IsSingleInstance = false;
            EnableVisualStyles = true;
            SaveMySettingsOnExit = true;
            ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            MainForm = Class1.Class2_0.method_7();
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [STAThread]
        [DebuggerHidden]
        public static void Main(string[] args)
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            }
            finally
            {
            }
            Class1.Form0_0.Run(args);
        }

    } // class Form0

}

