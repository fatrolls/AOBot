using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [HideModuleName]
    [StandardModule]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    internal sealed class Class14
    {

        private static CultureInfo cultureInfo_0;
        private static ResourceManager resourceManager_0;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return Class14.cultureInfo_0;
            }
            set
            {
                Class14.cultureInfo_0 = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (Object.ReferenceEquals(Class14.resourceManager_0, null))
                {
                    ResourceManager resourceManager = new ResourceManager("Ultimate_Bot_Reloaded.Resources", typeof(Class14).Assembly);
                    Class14.resourceManager_0 = resourceManager;
                }
                return Class14.resourceManager_0;
            }
        }

    } // class Class14

}

