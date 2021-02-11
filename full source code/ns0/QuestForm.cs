using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class QuestForm : MetroForm
    {

        public delegate void GDelegate6(bool state, object control);
        public delegate void GDelegate7(string labelText, object control);

        [CompilerGenerated]
        internal sealed class Class20
        {

            public byte[] byte_0;
            public QuestForm questForm_0;
            public string string_0;

            public Class20()
            {
            }

            [CompilerGenerated]
            public void method_0()
            {
                questForm_0.method_2(questForm_0.process_0, byte_0, string_0);
            }

        } // class Class20

        [CompilerGenerated]
        internal sealed class Class21
        {

            [CompilerGenerated]
            internal sealed class Class22
            {

                public int int_0;

                public Class22(QuestForm.Class21.Class22 class22_0)
                {
                    if (class22_0 != null)
                        int_0 = class22_0.int_0;
                }

                [CompilerGenerated]
                public bool method_0(GClass38.GClass42 gclass42_0, int int_1)
                {
                    return (gclass42_0.method_4() != 0) & (int_1 == int_0);
                }

            } // class Class22

            public long long_0;

            public Class21()
            {
            }

            [CompilerGenerated]
            public bool method_0(GClass38.GClass39 gclass39_0)
            {
                return Enumerable.Any<GClass38.GClass41>(gclass39_0.method_2(), new Func<GClass38.GClass41,bool>(method_1));
            }

            [CompilerGenerated]
            public bool method_1(GClass38.GClass41 gclass41_0)
            {
                return (long)BitConverter.ToInt32(gclass41_0.method_0(), 0) == long_0;
            }

            [CompilerGenerated]
            public bool method_2(GClass38.GClass41 gclass41_0)
            {
                return (long)BitConverter.ToInt32(gclass41_0.method_0(), 0) == long_0;
            }

        } // class Class21

        public sealed class GClass36
        {

            [CompilerGenerated]
            private long long_0;
            [CompilerGenerated]
            private long long_1;
            [CompilerGenerated]
            private long long_2;

            public GClass36()
            {
            }

            public long method_0()
            {
                return long_0;
            }

            public void method_1(long long_3)
            {
                long_0 = long_3;
            }

            public long method_2()
            {
                return long_1;
            }

            public void method_3(long long_3)
            {
                long_1 = long_3;
            }

            public long method_4()
            {
                return long_2;
            }

            public void method_5(long long_3)
            {
                long_2 = long_3;
            }

        } // class GClass36

        public sealed class GClass37
        {

            [CompilerGenerated]
            private static int int_0;
            [CompilerGenerated]
            private static IntPtr intptr_0;
            [CompilerGenerated]
            private static Process process_0;

            public GClass37()
            {
            }

            public static Process smethod_0()
            {
                Process process;

                return QuestForm.GClass37.process_0;
            }

            public static void smethod_1(Process process_1)
            {
                QuestForm.GClass37.process_0 = process_1;
            }

            public static IntPtr smethod_2()
            {
                return QuestForm.GClass37.intptr_0;
            }

            public static void smethod_3(IntPtr intptr_1)
            {
                QuestForm.GClass37.intptr_0 = intptr_1;
            }

            public static int smethod_4()
            {
                return QuestForm.GClass37.int_0;
            }

            public static void smethod_5(int int_1)
            {
                QuestForm.GClass37.int_0 = int_1;
            }

        } // class GClass37

        private readonly GClass22 gclass22_0;

        [AccessedThroughProperty("Bar1")]
        private Bar bar_0;
        public Bot bot_0;
        [AccessedThroughProperty("btnSearch")]
        private ButtonItem buttonItem_0;
        [AccessedThroughProperty("btnClose")]
        private ButtonItem buttonItem_1;
        [AccessedThroughProperty("cmbQuests")]
        private ComboBoxItem comboBoxItem_0;
        private IContainer icontainer_0;
        [AccessedThroughProperty("lblSelectQuest")]
        private LabelItem labelItem_0;
        [AccessedThroughProperty("questScanStatus")]
        private LabelItem labelItem_1;
        [AccessedThroughProperty("conditionOne")]
        private LabelX labelX_0;
        [AccessedThroughProperty("conditionTwo")]
        private LabelX labelX_1;
        [AccessedThroughProperty("conditionThree")]
        private LabelX labelX_2;
        [AccessedThroughProperty("conditionFour")]
        private LabelX labelX_3;
        [AccessedThroughProperty("questTitle")]
        private LabelX labelX_4;
        public LabelX[] labelX_5;
        private List<GClass38.GClass39> list_0;
        public List<QuestForm.GClass36> list_1;
        public List<byte[]> list_2;
        public long long_0;
        [AccessedThroughProperty("statusBar")]
        private MetroStatusBar metroStatusBar_0;
        public Process process_0;
        public SlidePanel slidePanel_0;
        public string string_0;
        [AccessedThroughProperty("QuestRefresh")]
        private Timer timer_0;
        [AccessedThroughProperty("questUpdate")]
        private Timer timer_1;

        public static QuestForm.GClass37 gclass37_0;

        public QuestForm()
        {
            Load += new EventHandler(QuestForm_Load);
            gclass22_0 = new GClass22();
            labelX_5 = new LabelX[4];
            vmethod_27(new Timer());
            InitializeComponent();
        }

        static QuestForm()
        {
            QuestForm.gclass37_0 = new QuestForm.GClass37();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Point point2;

            icontainer_0 = new Container();
            vmethod_1(new Bar());
            vmethod_3(new LabelItem());
            vmethod_5(new ComboBoxItem());
            vmethod_7(new ButtonItem());
            vmethod_13(new ButtonItem());
            vmethod_9(new MetroStatusBar());
            vmethod_11(new LabelItem());
            vmethod_15(new LabelX());
            vmethod_17(new LabelX());
            vmethod_19(new LabelX());
            vmethod_21(new LabelX());
            vmethod_23(new LabelX());
            vmethod_25(new Timer(icontainer_0));
            vmethod_0().BeginInit();
            SuspendLayout();
            vmethod_0().AntiAlias = true;
            vmethod_0().Dock = DockStyle.Top;
            vmethod_0().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BaseItem[] baseItemArr = new BaseItem[] {
                                                      vmethod_2(), 
                                                      vmethod_4(), 
                                                      vmethod_6(), 
                                                      vmethod_12() };
            vmethod_0().Items.AddRange(baseItemArr);
            Point point1 = new Point(0, 0);
            vmethod_0().Location = point1;
            vmethod_0().Name = "Bar1";
            Size size = new Size(478, 27);
            vmethod_0().Size = size;
            vmethod_0().Stretch = true;
            vmethod_0().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_0().TabIndex = 0;
            vmethod_0().TabStop = false;
            vmethod_0().Text = "Bar1";
            vmethod_2().Name = "lblSelectQuest";
            vmethod_2().PaddingLeft = 5;
            vmethod_2().Text = "SELECT QUEST";
            vmethod_4().ComboWidth = 110;
            vmethod_4().DropDownHeight = 106;
            vmethod_4().ItemHeight = 16;
            vmethod_4().Name = "cmbQuests";
            vmethod_6().ColorTable = eButtonColor.Blue;
            vmethod_6().Name = "btnSearch";
            vmethod_6().Text = "SEARCH QUEST";
            vmethod_12().ItemAlignment = eItemAlignment.Far;
            vmethod_12().Name = "btnClose";
            vmethod_12().Symbol = "";
            vmethod_12().SymbolSize = 10.0F;
            vmethod_8().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_8().ContainerControlProcessDialogKey = true;
            vmethod_8().Dock = DockStyle.Bottom;
            vmethod_8().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            baseItemArr = new BaseItem[] { vmethod_10() };
            vmethod_8().Items.AddRange(baseItemArr);
            point1 = new Point(0, 348);
            vmethod_8().Location = point1;
            vmethod_8().Name = "statusBar";
            size = new Size(478, 26);
            vmethod_8().Size = size;
            vmethod_8().TabIndex = 1;
            vmethod_8().Text = "MetroStatusBar1";
            vmethod_10().Name = "questScanStatus";
            vmethod_10().PaddingTop = -4;
            vmethod_10().TextLineAlignment = StringAlignment.Near;
            vmethod_14().AutoSize = true;
            vmethod_14().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_14().Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            point1 = new Point(22, 84);
            vmethod_14().Location = point1;
            vmethod_14().Name = "conditionOne";
            size = new Size(0, 0);
            vmethod_14().Size = size;
            vmethod_14().TabIndex = 2;
            vmethod_16().AutoSize = true;
            vmethod_16().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_16().Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            point1 = new Point(22, 107);
            vmethod_16().Location = point1;
            vmethod_16().Name = "conditionTwo";
            size = new Size(0, 0);
            vmethod_16().Size = size;
            vmethod_16().TabIndex = 3;
            vmethod_18().AutoSize = true;
            vmethod_18().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_18().Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            point1 = new Point(22, 130);
            vmethod_18().Location = point1;
            vmethod_18().Name = "conditionThree";
            size = new Size(0, 0);
            vmethod_18().Size = size;
            vmethod_18().TabIndex = 4;
            vmethod_20().AutoSize = true;
            vmethod_20().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_20().Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            point1 = new Point(22, 153);
            vmethod_20().Location = point1;
            vmethod_20().Name = "conditionFour";
            size = new Size(0, 0);
            vmethod_20().Size = size;
            vmethod_20().TabIndex = 5;
            vmethod_22().AutoSize = true;
            vmethod_22().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_22().Font = new Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            point1 = new Point(22, 52);
            vmethod_22().Location = point1;
            vmethod_22().Name = "questTitle";
            size = new Size(0, 0);
            vmethod_22().Size = size;
            vmethod_22().TabIndex = 6;
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(478, 374);
            ClientSize = size;
            Controls.Add(vmethod_22());
            Controls.Add(vmethod_20());
            Controls.Add(vmethod_18());
            Controls.Add(vmethod_16());
            Controls.Add(vmethod_14());
            Controls.Add(vmethod_8());
            Controls.Add(vmethod_0());
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuestForm";
            Text = "QuestForm";
            vmethod_0().EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void method_0()
        {
            // decompiler error
        }

        public void method_1(object sender, EventArgs e)
        {
            SlidePanel slidePanel = (SlidePanel)sender;
            if (slidePanel.IsOpen)
            {
                if (QuestForm.GClass37.smethod_2() == IntPtr.Zero)
                {
                    QuestForm.Class20 class20 = new QuestForm.Class20();
                    class20.questForm_0 = this;
                    vmethod_10().Text = "Searching Region";
                    byte[] bArr = new byte[] { 0, 48, 15, 1, 0, 48, 15, 1 };
                    class20.byte_0 = bArr;
                    class20.string_0 = "xxxxxxxx";
                    Thread thread = new Thread(new ThreadStart(class20.method_0));
                    thread.IsBackground = true;
                    thread.Start();
                }
                else
                {
                    vmethod_10().Text = "Region Found";
                    vmethod_8().RecalcLayout();
                }
            }
        }

        private void method_10(object sender, EventArgs e)
        {
            if (long_0 == 0L)
            {
                vmethod_24().Enabled = false;
            }
            else
            {
                byte[] bArr = gclass22_0.method_4(long_0, (long)process_0.Id, 56);
                Enumerable.Where<byte>(bArr, new Func<byte,bool>(null, QuestForm.smethod_2));
                method_6(bArr);
            }
        }

        [CompilerGenerated]
        private bool method_11(GClass1.GClass2 gclass2_0)
        {
            return Operators.CompareString(gclass2_0.method_6(), bot_0.string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_12(GClass6.GClass13 gclass13_0)
        {
            return Operators.CompareString(gclass13_0.method_0(), bot_0.string_0, false) == 0;
        }

        [CompilerGenerated]
        private void method_13()
        {
            method_5();
        }

        private void method_2(Process process_1, byte[] byte_0, string string_1)
        {
            IEnumerator<KeyValuePair<string,GClass31.GClass32>> ienumerator;

            Dictionary<string,GClass31.GClass32> dictionary = GClass31.smethod_0((int)process_1.Handle);
            IEnumerable<KeyValuePair<string,GClass31.GClass32>> ienumerable = Enumerable.Where<IEnumerable<T>>(dictionary, new Func<KeyValuePair<string,GClass31.GClass32>,bool>(null, QuestForm.smethod_0));
            try
            {
                ienumerator = ienumerable.GetEnumerator();
                while (ienumerator.MoveNext())
                {
                    KeyValuePair<string,GClass31.GClass32> keyValuePair = ienumerator.get_Current();
                    GClass34 gclass34 = new GClass34();
                    gclass34.method_7(process_1);
                    gclass34.method_9((IntPtr)keyValuePair.get_Value().int_0);
                    gclass34.method_11(keyValuePair.get_Value().int_1);
                    byte[] bArr = byte_0;
                    if ((keyValuePair.get_Value().int_1 <= 17780736) & (keyValuePair.get_Value().int_1 > 16777216))
                    {
                        gclass34.method_11(80535);
                        long l = (long)gclass34.method_3(bArr, string_1, checked((int)bArr.Length));
                        if (l != 0L)
                        {
                            QuestForm.GClass37.smethod_1(process_1);
                            QuestForm.GClass37.smethod_3((IntPtr)keyValuePair.get_Value().int_0);
                            QuestForm.GClass37.smethod_5(keyValuePair.get_Value().int_1);
                            vmethod_10().Text = "Quest Found";
                            vmethod_8().RecalcLayout();
                        }
                    }
                }
            }
            finally
            {
                if (ienumerator != null)
                    ienumerator.Dispose();
            }
        }

        private void method_3(object sender, EventArgs e)
        {
            GClass6.GClass13 gclass13 = Enumerable.FirstOrDefault<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(method_12));
            gclass13.method_14().BringToFront();
            gclass13.method_14().Visible = false;
            gclass13.method_14().IsOpen = false;
        }

        private void method_4(object sender, EventArgs e)
        {
            List<GClass38.GClass41>.Enumerator enumerator;
            IEnumerator<GClass38.GClass39> ienumerator;

            list_0 = new List<GClass38.GClass39>();
            if (vmethod_4().SelectedItem != null)
            {
                list_0 = GClass38.smethod_0(vmethod_4().SelectedItem.ToString());
                IEnumerable<GClass38.GClass39> ienumerable = Enumerable.Where<GClass38.GClass39>(list_0, new Func<GClass38.GClass39,bool>(null, QuestForm.smethod_1));
                list_2 = new List<byte[]>();
                try
                {
                    ienumerator = ienumerable.GetEnumerator();
                    while (ienumerator.MoveNext())
                    {
                        GClass38.GClass39 gclass39 = ienumerator.get_Current();
                        try
                        {
                            enumerator = gclass39.method_2().GetEnumerator();
                            while (enumerator.MoveNext())
                            {
                                GClass38.GClass41 gclass41 = enumerator.get_Current();
                                list_2.Add(gclass41.method_0());
                            }
                        }
                        finally
                        {
                            enumerator.Dispose();
                        }
                    }
                }
                finally
                {
                    if (ienumerator != null)
                        ienumerator.Dispose();
                }
                Thread thread = new Thread(new ThreadStart(method_13));
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                vmethod_22().Text = "Please select a quest";
            }
        }

        private void method_5()
        {
            List<byte[]>.Enumerator enumerator;

            GClass34 gclass34 = new GClass34();
            gclass34.method_7(QuestForm.GClass37.smethod_0());
            gclass34.method_9(QuestForm.GClass37.smethod_2());
            gclass34.method_11(160000);
            GClass34.GClass35 gclass35 = new GClass34.GClass35();
            try
            {
                enumerator = list_2.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    byte[] bArr1 = enumerator.get_Current();
                    gclass35.method_1(bArr1);
                    gclass34.hashSet_0.Add(gclass35);
                }
            }
            finally
            {
                enumerator.Dispose();
            }
            long l = (long)gclass34.method_4(list_2, "xxxx", 4);
            if (l != 0L)
            {
                byte[] bArr2 = gclass22_0.method_4(checked(l - 8L), (long)process_0.Id, 56);
                long_0 = checked(l - 8L);
                method_6(bArr2);
                vmethod_26().Enabled = true;
            }
            else
            {
                method_8("Quest not found", vmethod_22());
            }
        }

        public void method_6(byte[] byte_0)
        {
            QuestForm.Class21 class21 = new QuestForm.Class21();
            list_1 = new List<QuestForm.GClass36>();
            class21.long_0 = (long)BitConverter.ToInt32(byte_0, 4);
            if (class21.long_0 != 0L)
            {
                GClass38.GClass39 gclass39 = Enumerable.FirstOrDefault<GClass38.GClass39>(list_0, new Func<GClass38.GClass39,bool>(class21, class21.method_0));
                GClass38.GClass41 gclass41 = Enumerable.FirstOrDefault<GClass38.GClass41>(gclass39.method_2(), new Func<GClass38.GClass41,bool>(class21, class21.method_2));
                if (gclass39 != null)
                    method_8(gclass39.method_0(), vmethod_22());
                int i3 = checked(BitConverter.ToInt16(byte_0, 10) - 1);
                for (int i1 = 0; i1 <= i3; i1 = checked(i1 + 1))
                {
                    QuestForm.Class21.Class22 class22 = new QuestForm.Class21.Class22(class22);
                    class22.int_0 = i1;
                    GClass38.GClass42 gclass42 = Enumerable.First<GClass38.GClass42>(Enumerable.Where<GClass38.GClass42>(gclass41.method_4(), new Func<GClass38.GClass42,int,bool>(class22, class22.method_0)));
                    QuestForm.GClass36 gclass36 = new QuestForm.GClass36();
                    gclass36.method_1((long)BitConverter.ToInt16(byte_0, checked(12 + checked(i1 * 8))));
                    gclass36.method_3((long)BitConverter.ToInt16(byte_0, checked(checked(12 + checked(i1 * 8)) + 2)));
                    gclass36.method_5((long)BitConverter.ToInt16(byte_0, checked(checked(12 + checked(i1 * 8)) + 4)));
                    list_1.Add(gclass36);
                    method_8(method_9(gclass36, gclass42.method_2()), labelX_5[i1]);
                }
            }
            else
            {
                method_8("Quest Ended", vmethod_22());
                int i2 = 0;
                do
                {
                    method_8("", labelX_5[i2]);
                    i2 = checked(i2 + 1);
                } while (i2 <= 3);
            }
        }

        public void method_7(bool bool_0, object object_0)
        {
            object[] objArr2;

            if (Conversions.ToBoolean(NewLateBinding.LateGet(object_0, null, "InvokeRequired", new object[0], null, null, null)))
            {
                object[] objArr1 = new object[] {
                                                  new QuestForm.GDelegate6(method_7), 
                                                  bool_0, 
                                                  RuntimeHelpers.GetObjectValue(object_0) };
                objArr2 = objArr1;
                bool[] flagArr = new bool[] { false, true, true };
                NewLateBinding.LateCall(object_0, null, "Invoke", objArr2, null, null, flagArr, true);
                if (flagArr[1])
                    bool_0 = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArr2[1]), typeof(bool));
                if (!flagArr[2])
                    return;
                object_0 = RuntimeHelpers.GetObjectValue(objArr2[2]);
                return;
            }
            objArr2 = new object[] { bool_0 };
            NewLateBinding.LateSet(object_0, null, "enabled", objArr2, null, null);
        }

        public void method_8(string string_1, object object_0)
        {
            object[] objArr2;

            if (Conversions.ToBoolean(NewLateBinding.LateGet(object_0, null, "InvokeRequired", new object[0], null, null, null)))
            {
                object[] objArr1 = new object[] {
                                                  new QuestForm.GDelegate7(method_8), 
                                                  string_1, 
                                                  RuntimeHelpers.GetObjectValue(object_0) };
                objArr2 = objArr1;
                bool[] flagArr = new bool[] { false, true, true };
                NewLateBinding.LateCall(object_0, null, "Invoke", objArr2, null, null, flagArr, true);
                if (flagArr[1])
                    string_1 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArr2[1]), typeof(string));
                if (!flagArr[2])
                    return;
                object_0 = RuntimeHelpers.GetObjectValue(objArr2[2]);
                return;
            }
            objArr2 = new object[] { string_1 };
            NewLateBinding.LateSet(object_0, null, "Text", objArr2, null, null);
        }

        public string method_9(QuestForm.GClass36 gclass36_0, int int_0)
        {
            long l = gclass36_0.method_0();
            if (l == 17L)
                return String.Format("Kill Monsters ({0}/{1})", gclass36_0.method_4(), int_0);
            if (l == 110L)
                return "Speak to NPC";
            if (l == 28L)
                return "Obtain Items";
            return "Unknown, please report to developers.";
        }

        private void QuestForm_Load(object sender, EventArgs e)
        {
            GClass1.GClass2 gclass2 = Enumerable.FirstOrDefault<GClass1.GClass2>(GClass1.list_0, new Func<GClass1.GClass2,bool>(method_11));
            process_0 = bot_0.process_0;
            gclass22_0.int_0 = checked((int)gclass2.method_2());
            labelX_5[0] = vmethod_14();
            labelX_5[1] = vmethod_16();
            labelX_5[2] = vmethod_18();
            labelX_5[3] = vmethod_20();
            vmethod_26().Interval = 100.0;
        }

        private Timer vmethod_26()
        {
            Timer timer;

            return timer_1;
        }

        private void vmethod_27(Timer timer_2)
        {
            ElapsedEventHandler elapsedEventHandler = new ElapsedEventHandler(method_10);
            if (timer_1 != null)
                timer_1.Elapsed -= elapsedEventHandler;
            timer_1 = timer_2;
            if (timer_1 != null)
                timer_1.Elapsed += elapsedEventHandler;
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (icontainer_0 != null))
                    icontainer_0.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        internal virtual Bar vmethod_0()
        {
            Bar bar;

            return bar_0;
        }

        internal virtual void vmethod_1(Bar bar_1)
        {
            bar_0 = bar_1;
        }

        internal virtual LabelItem vmethod_10()
        {
            LabelItem labelItem;

            return labelItem_1;
        }

        internal virtual void vmethod_11(LabelItem labelItem_2)
        {
            labelItem_1 = labelItem_2;
        }

        internal virtual ButtonItem vmethod_12()
        {
            ButtonItem buttonItem;

            return buttonItem_1;
        }

        internal virtual void vmethod_13(ButtonItem buttonItem_2)
        {
            EventHandler eventHandler = new EventHandler(method_3);
            if (buttonItem_1 != null)
                buttonItem_1.Click -= eventHandler;
            buttonItem_1 = buttonItem_2;
            if (buttonItem_1 != null)
                buttonItem_1.Click += eventHandler;
        }

        internal virtual LabelX vmethod_14()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual void vmethod_15(LabelX labelX_6)
        {
            labelX_0 = labelX_6;
        }

        internal virtual LabelX vmethod_16()
        {
            LabelX labelX;

            return labelX_1;
        }

        internal virtual void vmethod_17(LabelX labelX_6)
        {
            labelX_1 = labelX_6;
        }

        internal virtual LabelX vmethod_18()
        {
            LabelX labelX;

            return labelX_2;
        }

        internal virtual void vmethod_19(LabelX labelX_6)
        {
            labelX_2 = labelX_6;
        }

        internal virtual LabelItem vmethod_2()
        {
            LabelItem labelItem;

            return labelItem_0;
        }

        internal virtual LabelX vmethod_20()
        {
            LabelX labelX;

            return labelX_3;
        }

        internal virtual void vmethod_21(LabelX labelX_6)
        {
            labelX_3 = labelX_6;
        }

        internal virtual LabelX vmethod_22()
        {
            LabelX labelX;

            return labelX_4;
        }

        internal virtual void vmethod_23(LabelX labelX_6)
        {
            labelX_4 = labelX_6;
        }

        internal virtual Timer vmethod_24()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual void vmethod_25(Timer timer_2)
        {
            timer_0 = timer_2;
        }

        internal virtual void vmethod_3(LabelItem labelItem_2)
        {
            labelItem_0 = labelItem_2;
        }

        internal virtual ComboBoxItem vmethod_4()
        {
            ComboBoxItem comboBoxItem;

            return comboBoxItem_0;
        }

        internal virtual void vmethod_5(ComboBoxItem comboBoxItem_1)
        {
            comboBoxItem_0 = comboBoxItem_1;
        }

        internal virtual ButtonItem vmethod_6()
        {
            ButtonItem buttonItem;

            return buttonItem_0;
        }

        internal virtual void vmethod_7(ButtonItem buttonItem_2)
        {
            EventHandler eventHandler = new EventHandler(method_4);
            if (buttonItem_0 != null)
                buttonItem_0.Click -= eventHandler;
            buttonItem_0 = buttonItem_2;
            if (buttonItem_0 != null)
                buttonItem_0.Click += eventHandler;
        }

        internal virtual MetroStatusBar vmethod_8()
        {
            MetroStatusBar metroStatusBar;

            return metroStatusBar_0;
        }

        internal virtual void vmethod_9(MetroStatusBar metroStatusBar_1)
        {
            metroStatusBar_0 = metroStatusBar_1;
        }

        [CompilerGenerated]
        private static bool smethod_0(KeyValuePair<string,GClass31.GClass32> keyValuePair_0)
        {
            return (keyValuePair_0.get_Value().int_1 <= 17780736) & (keyValuePair_0.get_Value().int_1 > 16777216);
        }

        [CompilerGenerated]
        private static bool smethod_1(GClass38.GClass39 gclass39_0)
        {
            return gclass39_0.method_0() != null;
        }

        [CompilerGenerated]
        private static bool smethod_2(byte byte_0)
        {
            return byte_0 != 0;
        }

    } // class QuestForm

}

