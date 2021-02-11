using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [GeneratedCode("MyTemplate", "11.0.0.0")]
    [HideModuleName]
    [StandardModule]
    internal sealed class Class1
    {

        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class Class2
        {

            public Bot bot_0;
            public BotForm botForm_0;
            public BotSettings botSettings_0;
            public debugger debugger_0;
            public ErrorForm errorForm_0;
            public Hotspotform hotspotform_0;
            public Login login_0;
            public Main main_0;
            public PartyForm partyForm_0;
            public QuestForm questForm_0;
            public SelectClient selectClient_0;
            public UpdateChecker updateChecker_0;

            [ThreadStatic]
            private static Hashtable hashtable_0;

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Class2()
            {
            }

            public Bot method_0()
            {
                bot_0 = Class1.Class2.smethod_0<Bot>(bot_0);
                return bot_0;
            }

            public BotForm method_1()
            {
                botForm_0 = Class1.Class2.smethod_0<BotForm>(botForm_0);
                return botForm_0;
            }

            public SelectClient method_10()
            {
                selectClient_0 = Class1.Class2.smethod_0<SelectClient>(selectClient_0);
                return selectClient_0;
            }

            public UpdateChecker method_11()
            {
                updateChecker_0 = Class1.Class2.smethod_0<UpdateChecker>(updateChecker_0);
                return updateChecker_0;
            }

            public void method_12(Bot bot_1)
            {
                if (bot_1 == bot_0)
                    return;
                if (bot_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<Bot>(ref bot_0);
            }

            public void method_13(BotForm botForm_1)
            {
                if (botForm_1 == botForm_0)
                    return;
                if (botForm_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<BotForm>(ref botForm_0);
            }

            public void method_14(BotSettings botSettings_1)
            {
                if (botSettings_1 == botSettings_0)
                    return;
                if (botSettings_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<BotSettings>(ref botSettings_0);
            }

            public void method_15(debugger debugger_1)
            {
                if (debugger_1 == debugger_0)
                    return;
                if (debugger_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<debugger>(ref debugger_0);
            }

            public void method_16(ErrorForm errorForm_1)
            {
                if (errorForm_1 == errorForm_0)
                    return;
                if (errorForm_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<ErrorForm>(ref errorForm_0);
            }

            public void method_17(Hotspotform hotspotform_1)
            {
                if (hotspotform_1 == hotspotform_0)
                    return;
                if (hotspotform_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<Hotspotform>(ref hotspotform_0);
            }

            public void method_18(Login login_1)
            {
                if (login_1 == login_0)
                    return;
                if (login_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<Login>(ref login_0);
            }

            public void method_19(Main main_1)
            {
                if (main_1 == main_0)
                    return;
                if (main_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<Main>(ref main_0);
            }

            public BotSettings method_2()
            {
                botSettings_0 = Class1.Class2.smethod_0<BotSettings>(botSettings_0);
                return botSettings_0;
            }

            public void method_20(PartyForm partyForm_1)
            {
                if (partyForm_1 == partyForm_0)
                    return;
                if (partyForm_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<PartyForm>(ref partyForm_0);
            }

            public void method_21(QuestForm questForm_1)
            {
                if (questForm_1 == questForm_0)
                    return;
                if (questForm_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<QuestForm>(ref questForm_0);
            }

            public void method_22(SelectClient selectClient_1)
            {
                if (selectClient_1 == selectClient_0)
                    return;
                if (selectClient_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<SelectClient>(ref selectClient_0);
            }

            public void method_23(UpdateChecker updateChecker_1)
            {
                if (updateChecker_1 == updateChecker_0)
                    return;
                if (updateChecker_1 != null)
                    throw new ArgumentException("Property can only be set to Nothing");
                this.method_24<UpdateChecker>(ref updateChecker_0);
            }

            [DebuggerHidden]
            private void method_24<T>(ref T gparam_0)
                where T : Form
            {
                // decompiler error
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal Type method_25()
            {
                return typeof(Class1.Class2);
            }

            public debugger method_3()
            {
                debugger_0 = Class1.Class2.smethod_0<debugger>(debugger_0);
                return debugger_0;
            }

            public ErrorForm method_4()
            {
                errorForm_0 = Class1.Class2.smethod_0<ErrorForm>(errorForm_0);
                return errorForm_0;
            }

            public Hotspotform method_5()
            {
                hotspotform_0 = Class1.Class2.smethod_0<Hotspotform>(hotspotform_0);
                return hotspotform_0;
            }

            public Login method_6()
            {
                login_0 = Class1.Class2.smethod_0<Login>(login_0);
                return login_0;
            }

            public Main method_7()
            {
                main_0 = Class1.Class2.smethod_0<Main>(main_0);
                return main_0;
            }

            public PartyForm method_8()
            {
                partyForm_0 = Class1.Class2.smethod_0<PartyForm>(partyForm_0);
                return partyForm_0;
            }

            public QuestForm method_9()
            {
                questForm_0 = Class1.Class2.smethod_0<QuestForm>(questForm_0);
                return questForm_0;
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }

            [DebuggerHidden]
            private static T smethod_0<T>(T gparam_0)
                where T : Form, new()
            {
                // decompiler error
            }

        } // class Class2

        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class Class3
        {

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Class3()
            {
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            internal Type method_0()
            {
                return typeof(Class1.Class3);
            }

            [DebuggerHidden]
            private void method_1<T>(ref T gparam_0)
            {
                // decompiler error
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }

            [DebuggerHidden]
            private static T smethod_0<T>(T gparam_0)
                where T : new()
            {
                if (gparam_0 == null)
                    return Activator.CreateInstance<T>();
                return gparam_0;
            }

        } // class Class3

        [EditorBrowsable(EditorBrowsableState.Never)]
        [ComVisible(false)]
        internal sealed class Class4<T>
            where T : new()
        {

            [CompilerGenerated]
            [ThreadStatic]
            private static T gparam_0;

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Class4()
            {
            }

            [DebuggerHidden]
            internal T method_0()
            {
                if (gparam_0 == null)
                    gparam_0 = Activator.CreateInstance<T>();
                return gparam_0;
            }

        } // class Class4

        private static readonly Class1.Class4<Class0> class4_0;
        private static readonly Class1.Class4<Form0> class4_1;
        private static readonly Class1.Class4<User> class4_2;
        private static readonly Class1.Class4<Class1.Class3> class4_4;

        private static Class1.Class4<Class1.Class2> class4_3;

        [HelpKeyword("My.Computer")]
        internal static Class0 Class0_0
        {
            get
            {
                return Class1.class4_0.method_0();
            }
        }

        [HelpKeyword("My.Forms")]
        internal static Class1.Class2 Class2_0
        {
            get
            {
                return Class1.class4_3.method_0();
            }
        }

        [HelpKeyword("My.WebServices")]
        internal static Class1.Class3 Class3_0
        {
            get
            {
                return Class1.class4_4.method_0();
            }
        }

        [HelpKeyword("My.Application")]
        internal static Form0 Form0_0
        {
            get
            {
                return Class1.class4_1.method_0();
            }
        }

        [HelpKeyword("My.User")]
        internal static User User_0
        {
            get
            {
                User user;

                return Class1.class4_2.method_0();
            }
        }

        static Class1()
        {
            Class1.class4_0 = new Class1.Class4<Class0>();
            Class1.class4_1 = new Class1.Class4<Form0>();
            Class1.class4_2 = new Class1.Class4<User>();
            Class1.class4_3 = new Class1.Class4<Class1.Class2>();
            Class1.class4_4 = new Class1.Class4<Class1.Class3>();
        }

    } // class Class1

}

