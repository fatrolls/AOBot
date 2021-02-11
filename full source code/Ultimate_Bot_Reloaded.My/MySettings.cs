using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace Ultimate_Bot_Reloaded.My
{

    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal sealed class MySettings : ApplicationSettingsBase
    {

        private static bool addedHandler;
        private static object addedHandlerLockObject;
        private static MySettings defaultInstance;

        public static MySettings Default
        {
            get
            {
                if (!MySettings.addedHandler)
                {
                    object obj = MySettings.addedHandlerLockObject;
                    ObjectFlowControl.CheckForSyncLockOnValueType(obj);
                    bool flag = false;
                    try
                    {
                        Monitor.Enter(obj, ref flag);
                        if (!MySettings.addedHandler)
                        {
                            Class1.Form0_0.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
                            MySettings.addedHandler = true;
                        }
                    }
                    finally
                    {
                        if (flag)
                            Monitor.Exit(obj);
                    }
                }
                return MySettings.defaultInstance;
            }
        }

        static MySettings()
        {
            MySettings.defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());
            MySettings.addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new Object());
        }

        public MySettings()
        {
        }

        [DebuggerNonUserCode]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (Class1.Form0_0.SaveMySettingsOnExit)
                Class15.Settings.Save();
        }

    } // class MySettings

}

