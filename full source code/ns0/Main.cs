using System;
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
using DevComponents.DotNetBar.Metro.ColorTables;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class Main : MetroForm
    {

        [CompilerGenerated]
        internal sealed class Class13
        {

            public ButtonItem buttonItem_0;

            public Class13()
            {
            }

            [CompilerGenerated]
            public bool method_0(GClass6.GClass12 gclass12_0)
            {
                return Operators.CompareString(gclass12_0.method_0(), buttonItem_0.Name, false) == 0;
            }

        } // class Class13

        public BotSettings botSettings_0;
        [AccessedThroughProperty("ColorPickerButton1")]
        private ColorPickerButton colorPickerButton_0;
        [AccessedThroughProperty("DockSite4")]
        private DockSite dockSite_0;
        [AccessedThroughProperty("DockSite1")]
        private DockSite dockSite_1;
        [AccessedThroughProperty("DockSite11")]
        private DockSite dockSite_10;
        [AccessedThroughProperty("DockSite12")]
        private DockSite dockSite_11;
        [AccessedThroughProperty("DockSite13")]
        private DockSite dockSite_12;
        [AccessedThroughProperty("DockSite14")]
        private DockSite dockSite_13;
        [AccessedThroughProperty("DockSite15")]
        private DockSite dockSite_14;
        [AccessedThroughProperty("DockSite16")]
        private DockSite dockSite_15;
        [AccessedThroughProperty("DockSite2")]
        private DockSite dockSite_2;
        [AccessedThroughProperty("DockSite3")]
        private DockSite dockSite_3;
        [AccessedThroughProperty("DockSite5")]
        private DockSite dockSite_4;
        [AccessedThroughProperty("DockSite6")]
        private DockSite dockSite_5;
        [AccessedThroughProperty("DockSite7")]
        private DockSite dockSite_6;
        [AccessedThroughProperty("DockSite8")]
        private DockSite dockSite_7;
        [AccessedThroughProperty("DockSite10")]
        private DockSite dockSite_8;
        [AccessedThroughProperty("DockSite9")]
        private DockSite dockSite_9;
        [AccessedThroughProperty("DotNetBarManager")]
        private DotNetBarManager dotNetBarManager_1;
        private IContainer icontainer_0;
        public List<GClass6.GClass12> list_0;
        [AccessedThroughProperty("loginPanel")]
        private SlidePanel slidePanel_0;
        [AccessedThroughProperty("StyleManager1")]
        private StyleManager styleManager_0;

        [AccessedThroughProperty("DotNetBarManager1")]
        private static DotNetBarManager dotNetBarManager_0;
        public static GClass6 gclass6_0;

        public Main()
        {
            Disposed += new EventHandler(Main_Disposed);
            Load += new EventHandler(Main_Load);
            list_0 = new List<GClass6.GClass12>();
            InitializeComponent();
        }

        static Main()
        {
            Main.gclass6_0 = new GClass6();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;
            MetroColorGeneratorParameters metroColorGeneratorParameters2;

            icontainer_0 = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
            vmethod_19(new StyleManager(icontainer_0));
            vmethod_3(new DockSite());
            vmethod_5(new DockSite());
            vmethod_7(new DockSite());
            vmethod_17(new DockSite());
            vmethod_11(new DockSite());
            vmethod_13(new DockSite());
            vmethod_15(new DockSite());
            vmethod_9(new DockSite());
            vmethod_21(new DotNetBarManager(icontainer_0));
            vmethod_37(new DockSite());
            vmethod_31(new DockSite());
            vmethod_33(new DockSite());
            vmethod_35(new DockSite());
            vmethod_23(new DockSite());
            vmethod_25(new DockSite());
            vmethod_29(new DockSite());
            vmethod_27(new DockSite());
            vmethod_39(new ColorPickerButton());
            SuspendLayout();
            vmethod_18().ManagerColorTint = Color.FromArgb(255, 128, 0);
            vmethod_18().ManagerStyle = eStyle.Metro;
            MetroColorGeneratorParameters metroColorGeneratorParameters1 = new MetroColorGeneratorParameters(Color.Black, Color.FromArgb(255, 128, 0));
            vmethod_18().MetroColorParameters = metroColorGeneratorParameters1;
            vmethod_2().AccessibleRole = AccessibleRole.Window;
            vmethod_2().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_2(), "DockSite4");
            vmethod_2().DocumentDockContainer = new DocumentDockContainer();
            vmethod_2().ForeColor = Color.White;
            vmethod_2().Name = "DockSite4";
            vmethod_2().TabStop = false;
            vmethod_4().AccessibleRole = AccessibleRole.Window;
            vmethod_4().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_4(), "DockSite1");
            vmethod_4().DocumentDockContainer = new DocumentDockContainer();
            vmethod_4().ForeColor = Color.White;
            vmethod_4().Name = "DockSite1";
            vmethod_4().TabStop = false;
            vmethod_6().AccessibleRole = AccessibleRole.Window;
            vmethod_6().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_6(), "DockSite2");
            vmethod_6().DocumentDockContainer = new DocumentDockContainer();
            vmethod_6().ForeColor = Color.White;
            vmethod_6().Name = "DockSite2";
            vmethod_6().TabStop = false;
            vmethod_16().AccessibleRole = AccessibleRole.Window;
            vmethod_16().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_16(), "DockSite8");
            vmethod_16().ForeColor = Color.White;
            vmethod_16().Name = "DockSite8";
            vmethod_16().TabStop = false;
            vmethod_10().AccessibleRole = AccessibleRole.Window;
            vmethod_10().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_10(), "DockSite5");
            vmethod_10().ForeColor = Color.White;
            vmethod_10().Name = "DockSite5";
            vmethod_10().TabStop = false;
            vmethod_12().AccessibleRole = AccessibleRole.Window;
            vmethod_12().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_12(), "DockSite6");
            vmethod_12().ForeColor = Color.White;
            vmethod_12().Name = "DockSite6";
            vmethod_12().TabStop = false;
            vmethod_14().AccessibleRole = AccessibleRole.Window;
            vmethod_14().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_14(), "DockSite7");
            vmethod_14().ForeColor = Color.White;
            vmethod_14().Name = "DockSite7";
            vmethod_14().TabStop = false;
            vmethod_8().AccessibleRole = AccessibleRole.Window;
            vmethod_8().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_8(), "DockSite3");
            vmethod_8().DocumentDockContainer = new DocumentDockContainer();
            vmethod_8().ForeColor = Color.White;
            vmethod_8().Name = "DockSite3";
            vmethod_8().TabStop = false;
            vmethod_20().AutoDispatchShortcuts.Add(eShortcut.F1);
            vmethod_20().AutoDispatchShortcuts.Add(eShortcut.CtrlC);
            vmethod_20().AutoDispatchShortcuts.Add(eShortcut.CtrlA);
            vmethod_20().AutoDispatchShortcuts.Add(eShortcut.CtrlV);
            vmethod_20().AutoDispatchShortcuts.Add(eShortcut.CtrlX);
            vmethod_20().AutoDispatchShortcuts.Add(eShortcut.CtrlZ);
            vmethod_20().AutoDispatchShortcuts.Add(eShortcut.CtrlY);
            vmethod_20().AutoDispatchShortcuts.Add(eShortcut.Del);
            vmethod_20().AutoDispatchShortcuts.Add(eShortcut.Ins);
            vmethod_20().BottomDockSite = null;
            vmethod_20().ColorScheme.BarDockedBorder = Color.FromArgb(45, 45, 48);
            vmethod_20().ColorScheme.BarFloatingBorder = Color.FromArgb(45, 45, 48);
            vmethod_20().ColorScheme.ItemDesignTimeBorder = SystemColors.Highlight;
            vmethod_20().EnableFullSizeDock = false;
            vmethod_20().LeftDockSite = null;
            vmethod_20().ParentForm = this;
            vmethod_20().RightDockSite = null;
            vmethod_20().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_20().ToolbarBottomDockSite = vmethod_36();
            vmethod_20().ToolbarLeftDockSite = vmethod_30();
            vmethod_20().ToolbarRightDockSite = vmethod_32();
            vmethod_20().ToolbarTopDockSite = vmethod_34();
            vmethod_20().TopDockSite = null;
            vmethod_20().UseGlobalColorScheme = true;
            vmethod_36().AccessibleRole = AccessibleRole.Window;
            vmethod_36().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_36(), "DockSite16");
            vmethod_36().ForeColor = Color.White;
            vmethod_36().Name = "DockSite16";
            vmethod_36().TabStop = false;
            vmethod_30().AccessibleRole = AccessibleRole.Window;
            vmethod_30().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_30(), "DockSite13");
            vmethod_30().ForeColor = Color.White;
            vmethod_30().Name = "DockSite13";
            vmethod_30().TabStop = false;
            vmethod_32().AccessibleRole = AccessibleRole.Window;
            vmethod_32().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_32(), "DockSite14");
            vmethod_32().ForeColor = Color.White;
            vmethod_32().Name = "DockSite14";
            vmethod_32().TabStop = false;
            vmethod_34().AccessibleRole = AccessibleRole.Window;
            vmethod_34().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_34(), "DockSite15");
            vmethod_34().ForeColor = Color.White;
            vmethod_34().Name = "DockSite15";
            vmethod_34().TabStop = false;
            vmethod_22().AccessibleRole = AccessibleRole.Window;
            vmethod_22().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_22(), "DockSite10");
            vmethod_22().DocumentDockContainer = new DocumentDockContainer();
            vmethod_22().ForeColor = Color.White;
            vmethod_22().Name = "DockSite10";
            vmethod_22().TabStop = false;
            vmethod_24().AccessibleRole = AccessibleRole.Window;
            vmethod_24().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_24(), "DockSite9");
            vmethod_24().DocumentDockContainer = new DocumentDockContainer();
            vmethod_24().ForeColor = Color.White;
            vmethod_24().Name = "DockSite9";
            vmethod_24().TabStop = false;
            vmethod_28().AccessibleRole = AccessibleRole.Window;
            vmethod_28().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_28(), "DockSite12");
            vmethod_28().DocumentDockContainer = new DocumentDockContainer();
            vmethod_28().ForeColor = Color.White;
            vmethod_28().Name = "DockSite12";
            vmethod_28().TabStop = false;
            vmethod_26().AccessibleRole = AccessibleRole.Window;
            vmethod_26().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_26(), "DockSite11");
            vmethod_26().DocumentDockContainer = new DocumentDockContainer();
            vmethod_26().ForeColor = Color.White;
            vmethod_26().Name = "DockSite11";
            vmethod_26().TabStop = false;
            vmethod_38().AccessibleRole = AccessibleRole.PushButton;
            vmethod_38().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_38().Image = (Image)componentResourceManager.GetObject("ColorPickerButton1.Image");
            componentResourceManager.ApplyResources(vmethod_38(), "ColorPickerButton1");
            vmethod_38().Name = "ColorPickerButton1";
            Rectangle rectangle = new Rectangle(2, 2, 12, 12);
            vmethod_38().SelectedColorImageRectangle = rectangle;
            vmethod_38().Style = eDotNetBarStyle.StyleManagerControlled;
            componentResourceManager.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CaptionFont = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Controls.Add(vmethod_38());
            Controls.Add(vmethod_22());
            Controls.Add(vmethod_24());
            Controls.Add(vmethod_6());
            Controls.Add(vmethod_4());
            Controls.Add(vmethod_8());
            Controls.Add(vmethod_2());
            Controls.Add(vmethod_10());
            Controls.Add(vmethod_12());
            Controls.Add(vmethod_14());
            Controls.Add(vmethod_16());
            Controls.Add(vmethod_26());
            Controls.Add(vmethod_28());
            Controls.Add(vmethod_30());
            Controls.Add(vmethod_32());
            Controls.Add(vmethod_34());
            Controls.Add(vmethod_36());
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            SettingsButtonText = "SETTINGS";
            TitleText = "ULTIMATE BOT";
            ResumeLayout(false);
        }

        private void Main_Disposed(object sender, EventArgs e)
        {
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Main.gclass6_0.method_0();
            Main.gclass6_0.method_2();
            Main.gclass6_0.method_1();
            GClass14.smethod_5();
            GClass14.smethod_4();
        }

        public void method_0(object sender, EventArgs e)
        {
            Color color;
            IEnumerator<GClass6.GClass13> ienumerator;
            MetroColorGeneratorParameters metroColorGeneratorParameters2;

            ColorPickerDropDown colorPickerDropDown = (ColorPickerDropDown)sender;
            MetroColorGeneratorParameters metroColorGeneratorParameters1 = new MetroColorGeneratorParameters(Color.Black, colorPickerDropDown.SelectedColor);
            vmethod_18().MetroColorParameters = metroColorGeneratorParameters1;
            vmethod_18().ManagerColorTint = colorPickerDropDown.SelectedColor;
            GClass6.GClass12 gclass12_1 = Enumerable.FirstOrDefault<GClass6.GClass12>(GClass6.list_1, new Func<GClass6.GClass12,bool>(null, Main.smethod_5));
            if (gclass12_1 != null)
            {
                Login login = (Login)gclass12_1.method_8();
                login.vmethod_66().BackgroundStyle.BackColor = colorPickerDropDown.SelectedColor;
                login.vmethod_40().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
            }
            GClass6.GClass12 gclass12_2 = Enumerable.FirstOrDefault<GClass6.GClass12>(GClass6.list_1, new Func<GClass6.GClass12,bool>(null, Main.smethod_6));
            if (gclass12_2 != null)
            {
                BotForm botForm = (BotForm)gclass12_2.method_8();
                botForm.vmethod_0().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
            }
            IEnumerable<GClass6.GClass13> ienumerable = Enumerable.Where<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(null, Main.smethod_7));
            try
            {
                ienumerator = ienumerable.GetEnumerator();
                while (ienumerator.MoveNext())
                {
                    GClass6.GClass13 gclass13 = ienumerator.get_Current();
                    gclass13.method_6().vmethod_26().BackColor = colorPickerDropDown.SelectedColor;
                    gclass13.method_2().TitleStyle.BackColor1.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_2().TitleStyle.BackColor2.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_2().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_2().TitleStyle.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_314().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_448().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_424().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_354().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_550().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_542().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_518().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_498().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_488().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_576().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_612().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_632().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_642().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_660().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_678().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_698().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_688().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_680().Border.BorderLeftColor = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_680().Border.BorderRightColor = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_690().Border.BorderLeftColor = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_690().Border.BorderRightColor = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_638().Border.BorderLeftColor = colorPickerDropDown.SelectedColor;
                    gclass13.method_8().vmethod_638().Border.BorderRightColor = colorPickerDropDown.SelectedColor;
                    gclass13.method_18().vmethod_16().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                    gclass13.method_18().vmethod_4().Style.BorderColor.Color = colorPickerDropDown.SelectedColor;
                }
            }
            finally
            {
                if (ienumerator != null)
                    ienumerator.Dispose();
            }
            Refresh();
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

        internal virtual SlidePanel vmethod_0()
        {
            SlidePanel slidePanel;

            return slidePanel_0;
        }

        internal virtual void vmethod_1(SlidePanel slidePanel_1)
        {
            slidePanel_0 = slidePanel_1;
        }

        internal virtual DockSite vmethod_10()
        {
            DockSite dockSite;

            return dockSite_4;
        }

        internal virtual void vmethod_11(DockSite dockSite_16)
        {
            dockSite_4 = dockSite_16;
        }

        internal virtual DockSite vmethod_12()
        {
            DockSite dockSite;

            return dockSite_5;
        }

        internal virtual void vmethod_13(DockSite dockSite_16)
        {
            dockSite_5 = dockSite_16;
        }

        internal virtual DockSite vmethod_14()
        {
            DockSite dockSite;

            return dockSite_6;
        }

        internal virtual void vmethod_15(DockSite dockSite_16)
        {
            dockSite_6 = dockSite_16;
        }

        internal virtual DockSite vmethod_16()
        {
            DockSite dockSite;

            return dockSite_7;
        }

        internal virtual void vmethod_17(DockSite dockSite_16)
        {
            dockSite_7 = dockSite_16;
        }

        internal virtual StyleManager vmethod_18()
        {
            StyleManager styleManager;

            return styleManager_0;
        }

        internal virtual void vmethod_19(StyleManager styleManager_1)
        {
            styleManager_0 = styleManager_1;
        }

        internal virtual DockSite vmethod_2()
        {
            DockSite dockSite;

            return dockSite_0;
        }

        internal virtual DotNetBarManager vmethod_20()
        {
            DotNetBarManager dotNetBarManager;

            return dotNetBarManager_1;
        }

        internal virtual void vmethod_21(DotNetBarManager dotNetBarManager_2)
        {
            dotNetBarManager_1 = dotNetBarManager_2;
        }

        internal virtual DockSite vmethod_22()
        {
            DockSite dockSite;

            return dockSite_8;
        }

        internal virtual void vmethod_23(DockSite dockSite_16)
        {
            dockSite_8 = dockSite_16;
        }

        internal virtual DockSite vmethod_24()
        {
            DockSite dockSite;

            return dockSite_9;
        }

        internal virtual void vmethod_25(DockSite dockSite_16)
        {
            dockSite_9 = dockSite_16;
        }

        internal virtual DockSite vmethod_26()
        {
            DockSite dockSite;

            return dockSite_10;
        }

        internal virtual void vmethod_27(DockSite dockSite_16)
        {
            dockSite_10 = dockSite_16;
        }

        internal virtual DockSite vmethod_28()
        {
            DockSite dockSite;

            return dockSite_11;
        }

        internal virtual void vmethod_29(DockSite dockSite_16)
        {
            dockSite_11 = dockSite_16;
        }

        internal virtual void vmethod_3(DockSite dockSite_16)
        {
            dockSite_0 = dockSite_16;
        }

        internal virtual DockSite vmethod_30()
        {
            DockSite dockSite;

            return dockSite_12;
        }

        internal virtual void vmethod_31(DockSite dockSite_16)
        {
            dockSite_12 = dockSite_16;
        }

        internal virtual DockSite vmethod_32()
        {
            DockSite dockSite;

            return dockSite_13;
        }

        internal virtual void vmethod_33(DockSite dockSite_16)
        {
            dockSite_13 = dockSite_16;
        }

        internal virtual DockSite vmethod_34()
        {
            DockSite dockSite;

            return dockSite_14;
        }

        internal virtual void vmethod_35(DockSite dockSite_16)
        {
            dockSite_14 = dockSite_16;
        }

        internal virtual DockSite vmethod_36()
        {
            DockSite dockSite;

            return dockSite_15;
        }

        internal virtual void vmethod_37(DockSite dockSite_16)
        {
            dockSite_15 = dockSite_16;
        }

        internal virtual ColorPickerButton vmethod_38()
        {
            ColorPickerButton colorPickerButton;

            return colorPickerButton_0;
        }

        internal virtual void vmethod_39(ColorPickerButton colorPickerButton_1)
        {
            colorPickerButton_0 = colorPickerButton_1;
        }

        internal virtual DockSite vmethod_4()
        {
            DockSite dockSite;

            return dockSite_1;
        }

        internal virtual void vmethod_5(DockSite dockSite_16)
        {
            dockSite_1 = dockSite_16;
        }

        internal virtual DockSite vmethod_6()
        {
            DockSite dockSite;

            return dockSite_2;
        }

        internal virtual void vmethod_7(DockSite dockSite_16)
        {
            dockSite_2 = dockSite_16;
        }

        internal virtual DockSite vmethod_8()
        {
            DockSite dockSite;

            return dockSite_3;
        }

        internal virtual void vmethod_9(DockSite dockSite_16)
        {
            dockSite_3 = dockSite_16;
        }

        internal static DotNetBarManager smethod_0()
        {
            DotNetBarManager dotNetBarManager;

            return Main.dotNetBarManager_0;
        }

        internal static void smethod_1(DotNetBarManager dotNetBarManager_2)
        {
            Main.dotNetBarManager_0 = dotNetBarManager_2;
        }

        public static void smethod_2(object sender, EventArgs e)
        {
            Main.Class13 class13 = new Main.Class13();
            class13.buttonItem_0 = (ButtonItem)sender;
            if (Operators.CompareString(class13.buttonItem_0.Name, "buttonGrinder", false) == 0)
            {
                GClass6.GClass12 gclass12_3 = Enumerable.FirstOrDefault<GClass6.GClass12>(GClass6.list_1, new Func<GClass6.GClass12,bool>(null, Main.smethod_3));
                gclass12_3.method_4().method_0();
            }
            GClass6.GClass12 gclass12_1 = Enumerable.FirstOrDefault<GClass6.GClass12>(GClass6.list_1, new Func<GClass6.GClass12,bool>(null, Main.smethod_4));
            GClass6.GClass12 gclass12_2 = Enumerable.FirstOrDefault<GClass6.GClass12>(GClass6.list_1, new Func<GClass6.GClass12,bool>(class13, class13.method_0));
            gclass12_1.method_2().IsOpen = false;
            gclass12_1.method_2().Visible = false;
            gclass12_2.method_2().Visible = true;
            gclass12_2.method_2().IsOpen = true;
            gclass12_2.method_2().BringToFront();
            gclass12_2.method_2().SlideSide = eSlideSide.Left;
        }

        [CompilerGenerated]
        private static bool smethod_3(GClass6.GClass12 gclass12_0)
        {
            return Operators.CompareString(gclass12_0.method_6().Name, "panelSelectClient", false) == 0;
        }

        [CompilerGenerated]
        private static bool smethod_4(GClass6.GClass12 gclass12_0)
        {
            return gclass12_0.method_2().Visible;
        }

        [CompilerGenerated]
        private static bool smethod_5(GClass6.GClass12 gclass12_0)
        {
            return Operators.CompareString(gclass12_0.method_2().Name, "panelLogin", false) == 0;
        }

        [CompilerGenerated]
        private static bool smethod_6(GClass6.GClass12 gclass12_0)
        {
            return Operators.CompareString(gclass12_0.method_2().Name, "panelGrinder", false) == 0;
        }

        [CompilerGenerated]
        private static bool smethod_7(GClass6.GClass13 gclass13_0)
        {
            return Operators.CompareString(gclass13_0.method_6().Name, null, false) != 0;
        }

    } // class Main

}

