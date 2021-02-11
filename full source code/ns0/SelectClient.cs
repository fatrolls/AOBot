using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using DevComponents.Editors;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class SelectClient : MetroForm
    {

        public enum GEnum8
        {
            const_0 = 0,
            const_1 = 2035711
        }

        [CompilerGenerated]
        internal sealed class Class23
        {

            public string string_0;

            public Class23(SelectClient.Class23 class23_0)
            {
                if (class23_0 != null)
                    string_0 = class23_0.string_0;
            }

            [CompilerGenerated]
            public bool method_0(GClass1.GClass2 gclass2_0)
            {
                return Operators.CompareString(gclass2_0.method_6(), string_0, false) == 0;
            }

        } // class Class23

        [CompilerGenerated]
        internal sealed class Class24
        {

            public string string_0;

            public Class24()
            {
            }

            [CompilerGenerated]
            public bool method_0(GClass1.GClass2 gclass2_0)
            {
                return Operators.CompareString(gclass2_0.method_6(), string_0, false) == 0;
            }

        } // class Class24

        [CompilerGenerated]
        internal sealed class Class25
        {

            public object object_0;

            public Class25(SelectClient.Class25 class25_0)
            {
                if (class25_0 != null)
                    object_0 = RuntimeHelpers.GetObjectValue(class25_0.object_0);
            }

            [CompilerGenerated]
            public bool method_0(GClass1.GClass2 gclass2_0)
            {
                return Operators.CompareString(gclass2_0.method_6(), object_0.ToString(), false) == 0;
            }

        } // class Class25

        public const int int_0 = 16;
        public const int int_1 = 2;
        private const int int_2 = 4096;
        private const int int_3 = 32768;
        public const int int_4 = 4;
        public const int int_5 = 2;
        public const int int_6 = 8;
        public const int int_7 = 32;

        [AccessedThroughProperty("selectClientButton")]
        private ButtonX buttonX_0;
        [AccessedThroughProperty("refreshAccountList")]
        private ButtonX buttonX_1;
        [AccessedThroughProperty("clientSelected")]
        private ComboBoxEx comboBoxEx_0;
        private ComboItem comboItem_0;
        private GClass22 gclass22_0;
        private GClass6 gclass6_0;
        private IContainer icontainer_0;
        [AccessedThroughProperty("LabelX4")]
        private LabelX labelX_0;
        [AccessedThroughProperty("LabelX1")]
        private LabelX labelX_1;
        [AccessedThroughProperty("CheckAccounts")]
        private Timer timer_0;

        public SelectClient()
        {
            Load += new EventHandler(SelectClient_Load);
            gclass6_0 = new GClass6();
            gclass22_0 = new GClass22();
            InitializeComponent();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;

            icontainer_0 = new Container();
            vmethod_1(new LabelX());
            vmethod_3(new ComboBoxEx());
            vmethod_5(new ButtonX());
            vmethod_7(new LabelX());
            vmethod_9(new ButtonX());
            vmethod_11(new Timer(icontainer_0));
            SuspendLayout();
            vmethod_0().BackColor = Color.Transparent;
            vmethod_0().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_0().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_0().ForeColor = Color.White;
            Point point = new Point(106, 86);
            vmethod_0().Location = point;
            vmethod_0().Name = "LabelX4";
            Size size = new Size(143, 17);
            vmethod_0().Size = size;
            vmethod_0().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_0().TabIndex = 36;
            vmethod_0().Text = "SELECT ACCOUNT";
            vmethod_2().DisplayMember = "Text";
            vmethod_2().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_2().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_2().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_2().FormattingEnabled = true;
            vmethod_2().ItemHeight = 16;
            point = new Point(106, 103);
            vmethod_2().Location = point;
            vmethod_2().Name = "clientSelected";
            size = new Size(231, 22);
            vmethod_2().Size = size;
            vmethod_2().Style = eDotNetBarStyle.Metro;
            vmethod_2().TabIndex = 35;
            vmethod_2().WatermarkColor = Color.Black;
            vmethod_4().AccessibleRole = AccessibleRole.PushButton;
            vmethod_4().BackColor = Color.FromArgb(255, 128, 0);
            vmethod_4().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_4().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(247, 140);
            vmethod_4().Location = point;
            vmethod_4().Name = "selectClientButton";
            vmethod_4().RightToLeft = RightToLeft.No;
            size = new Size(90, 25);
            vmethod_4().Size = size;
            vmethod_4().Style = eDotNetBarStyle.Metro;
            vmethod_4().TabIndex = 34;
            vmethod_4().Text = "SELECT";
            vmethod_6().BackColor = Color.Black;
            vmethod_6().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_6().Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_6().ForeColor = Color.White;
            point = new Point(45, 2);
            vmethod_6().Location = point;
            vmethod_6().Name = "LabelX1";
            size = new Size(392, 66);
            vmethod_6().Size = size;
            vmethod_6().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_6().TabIndex = 37;
            vmethod_6().Text = "Select a character from the drop down list. Press the reload button to refresh the list of characters.";
            vmethod_6().TextLineAlignment = StringAlignment.Near;
            vmethod_6().WordWrap = true;
            vmethod_8().AccessibleRole = AccessibleRole.PushButton;
            vmethod_8().AutoSize = true;
            vmethod_8().ColorTable = eButtonColor.Orange;
            vmethod_8().FocusCuesEnabled = false;
            point = new Point(343, 102);
            vmethod_8().Location = point;
            vmethod_8().Name = "refreshAccountList";
            vmethod_8().Shape = new EllipticalShapeDescriptor();
            size = new Size(25, 24);
            vmethod_8().Size = size;
            vmethod_8().Style = eDotNetBarStyle.Metro;
            vmethod_8().Symbol = "\uF01E";
            vmethod_8().SymbolSize = 12.0F;
            vmethod_8().TabIndex = 38;
            vmethod_10().Interval = 1000;
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(484, 392);
            ClientSize = size;
            Controls.Add(vmethod_8());
            Controls.Add(vmethod_6());
            Controls.Add(vmethod_0());
            Controls.Add(vmethod_2());
            Controls.Add(vmethod_4());
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectClient";
            Text = "SelectClient";
            ResumeLayout(false);
            PerformLayout();
        }

        public void method_0()
        {
            List<GClass1.GClass2>.Enumerator enumerator;

            gclass22_0.method_0();
            List<GClass1.GClass2> list = GClass1.list_0;
            try
            {
                enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    SelectClient.Class23 class23 = new SelectClient.Class23(class23);
                    GClass1.GClass2 gclass2 = enumerator.get_Current();
                    gclass22_0.int_0 = (int)GClass22.OpenProcess(GClass22.GEnum3.const_1, true, gclass2.method_0().Id);
                    gclass22_0.long_0 = (long)gclass2.method_0().Id;
                    long l = (long)gclass22_0.method_1(GClass24.int_2, 4);
                    class23.string_0 = gclass22_0.method_5(checked((int)l), 24);
                    if (Operators.CompareString(class23.string_0, "NOPERSONNAME", false) == 0)
                        continue;
                    List<GClass1.GClass2> list1 = GClass1.list_0.FindAll(new Predicate<GClass1.GClass2>(class23, class23.method_0));
                    if (list1.get_Count() == 0)
                    {
                        gclass2.method_5((long)gclass2.method_0().MainWindowHandle);
                        comboItem_0 = new ComboItem();
                        comboItem_0.Text = class23.string_0;
                        GClass6.smethod_0(comboItem_0);
                        vmethod_2().Items.Add(comboItem_0);
                        gclass2.method_7(class23.string_0);
                        vmethod_2().SelectedIndex = 0;
                    }
                    SelectClient.CloseHandle(gclass22_0.int_0);
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }

        private void method_1(object sender, EventArgs e)
        {
            Class1.Class2_0.method_1().Refresh();
            if (vmethod_2().SelectedItem == null)
                return;
            List<GClass6.GClass13> list = new List<GClass6.GClass13>();
            list = GClass6.list_2.FindAll(new Predicate<GClass6.GClass13>(method_4));
            if (list.get_Count() == 0)
            {
                string s = vmethod_2().SelectedItem.ToString();
                SelectClient.smethod_0(s);
                gclass6_0.method_5(s);
            }
            else
            {
                ErrorForm errorForm = new ErrorForm();
                errorForm.vmethod_2().Text = "You have already have a bot loaded with this account.";
                errorForm.Show();
            }
        }

        private void method_2(object sender, EventArgs e)
        {
            method_0();
        }

        private void method_3(object sender, EventArgs e)
        {
            SelectClient.Class25 class25;
            GClass1.GClass2 gclass2;
            IEnumerator ienumerator;

            if (vmethod_2().Items.Count > 0)
            {
                try
                {
                    ienumerator = vmethod_2().Items.GetEnumerator();
                    while (ienumerator.MoveNext())
                    {
                        class25 = new SelectClient.Class25(class25);
                        class25.object_0 = RuntimeHelpers.GetObjectValue(ienumerator.Current);
                        gclass2 = Enumerable.FirstOrDefault<GClass1.GClass2>(GClass1.list_0, new Func<GClass1.GClass2,bool>(class25, class25.method_0));
                        gclass22_0.int_0 = (int)GClass22.OpenProcess(GClass22.GEnum3.const_1, true, gclass2.method_0().Id);
                        gclass22_0.long_0 = (long)gclass2.method_0().Id;
                        long l = (long)gclass22_0.method_1(GClass24.int_2, 4);
                        string s = gclass22_0.method_5(checked((int)l), 24);
                        if (Operators.CompareString(s, gclass2.method_6(), false) != 0)
                            goto label_1;
                    }
                    return;
                label_1:
                    GClass1.list_0.Remove(gclass2);
                    vmethod_2().Items.Remove(RuntimeHelpers.GetObjectValue(class25.object_0));
                }
                finally
                {
                    if (ienumerator is IDisposable)
                        (ienumerator as IDisposable).Dispose();
                }
            }
        }

        [CompilerGenerated]
        private bool method_4(GClass6.GClass13 gclass13_0)
        {
            return Operators.CompareString(gclass13_0.method_0(), vmethod_2().SelectedItem.ToString(), false) == 0;
        }

        private void SelectClient_Load(object sender, EventArgs e)
        {
            vmethod_10().Enabled = true;
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

        internal virtual LabelX vmethod_0()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual void vmethod_1(LabelX labelX_2)
        {
            labelX_0 = labelX_2;
        }

        internal virtual Timer vmethod_10()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual void vmethod_11(Timer timer_1)
        {
            EventHandler eventHandler = new EventHandler(method_3);
            if (timer_0 != null)
                timer_0.Tick -= eventHandler;
            timer_0 = timer_1;
            if (timer_0 != null)
                timer_0.Tick += eventHandler;
        }

        internal virtual ComboBoxEx vmethod_2()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_0;
        }

        internal virtual void vmethod_3(ComboBoxEx comboBoxEx_1)
        {
            comboBoxEx_0 = comboBoxEx_1;
        }

        internal virtual ButtonX vmethod_4()
        {
            ButtonX buttonX;

            return buttonX_0;
        }

        internal virtual void vmethod_5(ButtonX buttonX_2)
        {
            EventHandler eventHandler = new EventHandler(method_1);
            if (buttonX_0 != null)
                buttonX_0.Click -= eventHandler;
            buttonX_0 = buttonX_2;
            if (buttonX_0 != null)
                buttonX_0.Click += eventHandler;
        }

        internal virtual LabelX vmethod_6()
        {
            LabelX labelX;

            return labelX_1;
        }

        internal virtual void vmethod_7(LabelX labelX_2)
        {
            labelX_1 = labelX_2;
        }

        internal virtual ButtonX vmethod_8()
        {
            ButtonX buttonX;

            return buttonX_1;
        }

        internal virtual void vmethod_9(ButtonX buttonX_2)
        {
            EventHandler eventHandler = new EventHandler(method_2);
            if (buttonX_1 != null)
                buttonX_1.Click -= eventHandler;
            buttonX_1 = buttonX_2;
            if (buttonX_1 != null)
                buttonX_1.Click += eventHandler;
        }

        private static void smethod_0(string string_0)
        {
            List<GClass1.GClass2>.Enumerator enumerator;

            SelectClient.Class24 class24 = new SelectClient.Class24();
            class24.string_0 = string_0;
            List<GClass1.GClass2> list = GClass1.list_0.FindAll(new Predicate<GClass1.GClass2>(class24, class24.method_0));
            try
            {
                enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    GClass1.GClass2 gclass2 = enumerator.get_Current();
                    Process process = Process.GetProcessById(gclass2.method_0().Id);
                    ProcessModuleCollection processModuleCollection = process.Modules;
                    for (int i = checked(processModuleCollection.Count - 1); i >= 0; i = checked(i + -1))
                    {
                        if (processModuleCollection[i].FileName.EndsWith("d3d9hook.dll"))
                            goto label_1;
                    }
                    SelectClient.smethod_1((long)gclass2.method_0().Id);
                }
                return;
            label_1:;
            }
            finally
            {
                enumerator.Dispose();
            }
        }

        private static void smethod_1(long long_0)
        {
            int i4;

            string s1 = Application.StartupPath + "\\d3d9hook.dll";
            string s2 = "Kernel32.dll";
            int i2 = SelectClient.GetModuleHandleA(ref s2);
            int i3 = (int)SelectClient.OpenProcess(SelectClient.GEnum8.const_1, true, checked((int)long_0));
            int i1 = SelectClient.VirtualAllocEx(i3, 0, checked(s1.Length + 1), 4096, 4);
            int i5 = 0;
            SelectClient.WriteProcessMemory(i3, i1, ref s1, checked(s1.Length + 1), ref i5);
            s2 = "LoadLibraryA";
            SelectClient.CreateRemoteThread(i3, 0, 0, SelectClient.GetProcAddress(i2, ref s2), i1, 0, ref i4);
            i5 = 0;
            SelectClient.VirtualFreeEx(i3, i1, ref i5, 32768);
            SelectClient.CloseHandle(i3);
        }

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int CloseHandle(int int_8);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int CreateRemoteThread(int int_8, int int_9, int int_10, int int_11, int int_12, int int_13, ref int int_14);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetProcAddress(int int_8, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr OpenProcess(SelectClient.GEnum8 genum8_0, bool bool_0, int int_8);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int VirtualAllocEx(int int_8, int int_9, int int_10, int int_11, int int_12);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int VirtualFreeEx(int int_8, int int_9, ref int int_10, int int_11);

        [PreserveSig]
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int WriteProcessMemory(int int_8, int int_9, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_10, ref int int_11);

    } // class SelectClient

}

