using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ultimate_Bot_Reloaded.PartyFunctions;

namespace ns0
{

    [DesignerGenerated]
    public sealed class Bot : MetroForm
    {

        public enum GEnum0
        {
            const_0 = 0,
            const_1 = 2035711
        }

        [CompilerGenerated]
        internal sealed class Class5
        {

            public GClass28.GClass29 gclass29_0;

            public Class5()
            {
            }

            [CompilerGenerated]
            public bool method_0(GClass28.GClass29 gclass29_1)
            {
                return Operators.CompareString(gclass29_1.method_4(), gclass29_0.method_4(), false) == 0;
            }

            [CompilerGenerated]
            public bool method_1(GClass28.GClass29 gclass29_1)
            {
                return Operators.CompareString(gclass29_1.method_0(), gclass29_0.method_4(), false) == 0;
            }

            [CompilerGenerated]
            public bool method_2(GClass28.GClass29 gclass29_1)
            {
                return Operators.CompareString(gclass29_1.method_4(), gclass29_0.method_0(), false) == 0;
            }

        } // class Class5

        private readonly GClass22 gclass22_0;

        public Automoveform automoveform_0;
        [AccessedThroughProperty("Bar1")]
        private Bar bar_0;
        public bool bool_0;
        private bool bool_1;
        public bool bool_2;
        [AccessedThroughProperty("mnuOptions")]
        private ButtonItem buttonItem_0;
        [AccessedThroughProperty("btnHotspot")]
        private ButtonItem buttonItem_1;
        [AccessedThroughProperty("btnClose")]
        private ButtonItem buttonItem_2;
        [AccessedThroughProperty("botSettings")]
        private ButtonItem buttonItem_3;
        [AccessedThroughProperty("btnReload")]
        private ButtonItem buttonItem_4;
        [AccessedThroughProperty("btnQuest")]
        private ButtonItem buttonItem_5;
        private DateTime dateTime_0;
        public debugger debugger_0;
        [AccessedThroughProperty("DockSite4")]
        private DockSite dockSite_0;
        [AccessedThroughProperty("DockSite1")]
        private DockSite dockSite_1;
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
        [AccessedThroughProperty("DotNetBarManager1")]
        private DotNetBarManager dotNetBarManager_0;
        public double[] double_0;
        public double[] double_1;
        public GClass14 gclass14_0;
        public GClass26 gclass26_0;
        public GClass28.GClass30 gclass30_0;
        public GClass4 gclass4_0;
        private IContainer icontainer_0;
        public int[,] int_0;
        public int[] int_1;
        public int[] int_2;
        public int[] int_3;
        public int[] int_4;
        public int[] int_5;
        public int int_6;
        [AccessedThroughProperty("botName")]
        private LabelItem labelItem_0;
        [AccessedThroughProperty("dbugger")]
        private LabelX labelX_0;
        public LabelX labelX_1;
        public LabelX labelX_2;
        public LabelX labelX_3;
        public LabelX labelX_4;
        public LabelX labelX_5;
        public LabelX labelX_6;
        public LabelX labelX_7;
        public long long_0;
        public long long_1;
        public MapTeleport mapTeleport_0;
        [AccessedThroughProperty("PanelEx1")]
        private PanelEx panelEx_0;
        [AccessedThroughProperty("PanelEx9")]
        private PanelEx panelEx_1;
        [AccessedThroughProperty("PanelEx8")]
        private PanelEx panelEx_2;
        [AccessedThroughProperty("PanelEx7")]
        private PanelEx panelEx_3;
        [AccessedThroughProperty("PanelEx6")]
        private PanelEx panelEx_4;
        [AccessedThroughProperty("PanelEx5")]
        private PanelEx panelEx_5;
        [AccessedThroughProperty("PanelEx4")]
        private PanelEx panelEx_6;
        [AccessedThroughProperty("PanelEx3")]
        private PanelEx panelEx_7;
        [AccessedThroughProperty("PanelEx2")]
        private PanelEx panelEx_8;
        public PartyCode partyCode_0;
        public Process process_0;
        [AccessedThroughProperty("MP8")]
        private ProgressBarX progressBarX_0;
        [AccessedThroughProperty("HP8")]
        private ProgressBarX progressBarX_1;
        [AccessedThroughProperty("MP3")]
        private ProgressBarX progressBarX_10;
        [AccessedThroughProperty("HP3")]
        private ProgressBarX progressBarX_11;
        [AccessedThroughProperty("MP2")]
        private ProgressBarX progressBarX_12;
        [AccessedThroughProperty("HP2")]
        private ProgressBarX progressBarX_13;
        [AccessedThroughProperty("MP1")]
        private ProgressBarX progressBarX_14;
        [AccessedThroughProperty("HP1")]
        private ProgressBarX progressBarX_15;
        [AccessedThroughProperty("MP0")]
        private ProgressBarX progressBarX_16;
        [AccessedThroughProperty("HP0")]
        private ProgressBarX progressBarX_17;
        private ProgressBarX[] progressBarX_18;
        private ProgressBarX[] progressBarX_19;
        [AccessedThroughProperty("MP7")]
        private ProgressBarX progressBarX_2;
        [AccessedThroughProperty("HP7")]
        private ProgressBarX progressBarX_3;
        [AccessedThroughProperty("MP6")]
        private ProgressBarX progressBarX_4;
        [AccessedThroughProperty("HP6")]
        private ProgressBarX progressBarX_5;
        [AccessedThroughProperty("MP5")]
        private ProgressBarX progressBarX_6;
        [AccessedThroughProperty("HP5")]
        private ProgressBarX progressBarX_7;
        [AccessedThroughProperty("MP4")]
        private ProgressBarX progressBarX_8;
        [AccessedThroughProperty("HP4")]
        private ProgressBarX progressBarX_9;
        public string string_0;
        public string string_1;
        public string string_2;
        public string string_3;
        public string string_4;
        public string string_5;
        public string string_6;
        public string string_7;
        public string string_8;
        [AccessedThroughProperty("startSwitch")]
        private SwitchButtonItem switchButtonItem_0;
        private Thread thread_0;
        [AccessedThroughProperty("LifeManaBars")]
        private Timer timer_0;
        [AccessedThroughProperty("UpdateLabels")]
        private Timer timer_1;
        [AccessedThroughProperty("Coordinates")]
        private Timer timer_2;
        [AccessedThroughProperty("ElapsedTime")]
        private Timer timer_3;
        [AccessedThroughProperty("PartyModeCheck")]
        private Timer timer_4;
        [AccessedThroughProperty("AutoMoveTeleport")]
        private Timer timer_5;
        private TimeSpan timeSpan_0;

        public Bot()
        {
            Disposed += new EventHandler(Bot_Disposed);
            Load += new EventHandler(Bot_Load);
            bool_0 = false;
            gclass26_0 = new GClass26();
            int_0 = new int[101, 2];
            int_1 = new int[9];
            progressBarX_18 = new ProgressBarX[9];
            progressBarX_19 = new ProgressBarX[9];
            int_2 = new int[9];
            int_3 = new int[9];
            int_4 = new int[9];
            int_5 = new int[9];
            double_0 = new double[9];
            double_1 = new double[9];
            gclass22_0 = new GClass22();
            bool_1 = true;
            gclass30_0 = new GClass28.GClass30();
            partyCode_0 = PartyCode.None;
            InitializeComponent();
        }

        private void Bot_Disposed(object sender, EventArgs e)
        {
            IEnumerator<GClass28.GClass29> ienumerator;

            Bot.Class5 class5 = new Bot.Class5();
            bool_0 = false;
            bool_1 = false;
            class5.gclass29_0 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_22));
            if (class5.gclass29_0.method_2() == PartyCode.Follower)
            {
                IEnumerable<GClass28.GClass29> ienumerable1 = Enumerable.Where<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(class5, class5.method_0));
                if (ienumerable1 == null)
                {
                    GClass28.GClass29 gclass29_1 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(class5, class5.method_1));
                    gclass29_1.method_5(2.ToString());
                    gclass29_1.method_3(PartyCode.None);
                }
            }
            if (class5.gclass29_0.method_2() == PartyCode.Leader)
            {
                IEnumerable<GClass28.GClass29> ienumerable = Enumerable.Where<GClass28.GClass29>((PartyCode)GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(class5, class5.method_2));
                try
                {
                    ienumerator = ienumerable.GetEnumerator();
                    while (ienumerator.MoveNext())
                    {
                        GClass28.GClass29 gclass29_2 = ienumerator.get_Current();
                        gclass29_2.method_3(PartyCode.None);
                        gclass29_2.method_5(2.ToString());
                    }
                }
                finally
                {
                    if (ienumerator != null)
                        ienumerator.Dispose();
                }
            }
            GClass28.hashSet_0.Remove(class5.gclass29_0);
            Bot.CloseHandle(checked((int)long_0));
        }

        private void Bot_Load(object sender, EventArgs e)
        {
            gclass14_0 = new GClass14();
            gclass14_0.gclass26_0 = gclass26_0;
            gclass14_0.method_0(string_0);
            gclass14_0.method_1(string_0);
            method_2();
            method_3();
            method_1();
            method_7();
            method_0();
            GClass28.GClass29 gclass29 = new GClass28.GClass29();
            gclass29.method_1(string_0);
            GClass28.hashSet_0.Add(gclass29);
            gclass4_0 = new GClass4(this, gclass22_0, gclass26_0, long_1, gclass14_0);
            automoveform_0 = new Automoveform(this, gclass22_0, gclass26_0, gclass4_0);
            mapTeleport_0 = new MapTeleport(this, gclass22_0, gclass26_0, gclass4_0);
            int i = 0;
            goto label_3;
        label_1:
            int_1[i] = 0;
        label_2:
            i = checked(i + 1);
            if (i <= 8)
                goto label_3;
            while (true)
            {
                progressBarX_18[i].Text = "MERCENARY UNAVAILABLE";
                progressBarX_18[i].Value = 0;
                int_1[i] = 1;
                goto label_2;
            label_3:
                int_2[i] = checked((int)gclass22_0.method_3(checked((int)checked(gclass26_0.long_1 + (long)checked(i * GClass24.int_0))), 4));
                if (!((int_2[i] == 0) | (int_2[i] == 14)))
                    goto label_1;
            }
            vmethod_86().Enabled = true;
            vmethod_64().Enabled = true;
            vmethod_92().Enabled = true;
            vmethod_94().Enabled = true;
            vmethod_88().Enabled = true;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;

            icontainer_0 = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Bot));
            vmethod_1(new DotNetBarManager(icontainer_0));
            vmethod_3(new DockSite());
            vmethod_5(new DockSite());
            vmethod_7(new DockSite());
            vmethod_17(new DockSite());
            vmethod_11(new DockSite());
            vmethod_13(new DockSite());
            vmethod_15(new DockSite());
            vmethod_9(new DockSite());
            vmethod_19(new Bar());
            vmethod_21(new SwitchButtonItem());
            vmethod_23(new ButtonItem());
            vmethod_99(new ButtonItem());
            vmethod_101(new ButtonItem());
            vmethod_25(new ButtonItem());
            vmethod_103(new ButtonItem());
            vmethod_27(new LabelItem());
            vmethod_67(new ButtonItem());
            vmethod_63(new ProgressBarX());
            vmethod_61(new ProgressBarX());
            vmethod_57(new ProgressBarX());
            vmethod_59(new ProgressBarX());
            vmethod_49(new ProgressBarX());
            vmethod_51(new ProgressBarX());
            vmethod_53(new ProgressBarX());
            vmethod_55(new ProgressBarX());
            vmethod_33(new ProgressBarX());
            vmethod_35(new ProgressBarX());
            vmethod_37(new ProgressBarX());
            vmethod_39(new ProgressBarX());
            vmethod_41(new ProgressBarX());
            vmethod_43(new ProgressBarX());
            vmethod_45(new ProgressBarX());
            vmethod_47(new ProgressBarX());
            vmethod_29(new ProgressBarX());
            vmethod_31(new ProgressBarX());
            vmethod_65(new Timer(icontainer_0));
            vmethod_69(new PanelEx());
            vmethod_85(new PanelEx());
            vmethod_83(new PanelEx());
            vmethod_81(new PanelEx());
            vmethod_79(new PanelEx());
            vmethod_77(new PanelEx());
            vmethod_75(new PanelEx());
            vmethod_73(new PanelEx());
            vmethod_71(new PanelEx());
            vmethod_87(new Timer(icontainer_0));
            vmethod_89(new Timer(icontainer_0));
            vmethod_91(new Timer(icontainer_0));
            vmethod_93(new Timer(icontainer_0));
            vmethod_95(new Timer(icontainer_0));
            vmethod_97(new LabelX());
            vmethod_18().BeginInit();
            SuspendLayout();
            vmethod_0().AutoDispatchShortcuts.Add(eShortcut.F1);
            vmethod_0().AutoDispatchShortcuts.Add(eShortcut.CtrlC);
            vmethod_0().AutoDispatchShortcuts.Add(eShortcut.CtrlA);
            vmethod_0().AutoDispatchShortcuts.Add(eShortcut.CtrlV);
            vmethod_0().AutoDispatchShortcuts.Add(eShortcut.CtrlX);
            vmethod_0().AutoDispatchShortcuts.Add(eShortcut.CtrlZ);
            vmethod_0().AutoDispatchShortcuts.Add(eShortcut.CtrlY);
            vmethod_0().AutoDispatchShortcuts.Add(eShortcut.Del);
            vmethod_0().AutoDispatchShortcuts.Add(eShortcut.Ins);
            vmethod_0().BottomDockSite = vmethod_2();
            vmethod_0().EnableFullSizeDock = false;
            vmethod_0().LeftDockSite = vmethod_4();
            vmethod_0().ParentForm = this;
            vmethod_0().RightDockSite = vmethod_6();
            vmethod_0().Style = eDotNetBarStyle.Office2003;
            vmethod_0().ToolbarBottomDockSite = vmethod_16();
            vmethod_0().ToolbarLeftDockSite = vmethod_10();
            vmethod_0().ToolbarRightDockSite = vmethod_12();
            vmethod_0().ToolbarTopDockSite = vmethod_14();
            vmethod_0().TopDockSite = vmethod_8();
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
            componentResourceManager.ApplyResources(vmethod_18(), "Bar1");
            vmethod_18().AccessibleRole = AccessibleRole.ToolBar;
            vmethod_18().AntiAlias = true;
            BaseItem[] baseItemArr = new BaseItem[] {
                                                      vmethod_20(), 
                                                      vmethod_22(), 
                                                      vmethod_24(), 
                                                      vmethod_102(), 
                                                      vmethod_26(), 
                                                      vmethod_66() };
            vmethod_18().Items.AddRange(baseItemArr);
            vmethod_18().Name = "Bar1";
            vmethod_18().Stretch = true;
            vmethod_18().Style = eDotNetBarStyle.Metro;
            vmethod_18().TabStop = false;
            vmethod_20().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_20().ButtonHeight = 18;
            vmethod_20().ButtonWidth = 70;
            vmethod_20().Margin.Left = 5;
            vmethod_20().Margin.Right = 5;
            vmethod_20().Name = "startSwitch";
            vmethod_20().OffBackColor = Color.FromArgb(45, 45, 48);
            componentResourceManager.ApplyResources(vmethod_20(), "startSwitch");
            vmethod_20().OffTextColor = Color.White;
            vmethod_20().OnTextColor = Color.White;
            vmethod_20().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_20().SwitchFont = new Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_20().SwitchWidth = 6;
            vmethod_20().TextColor = Color.White;
            vmethod_20().Value = true;
            vmethod_22().AutoExpandOnClick = true;
            vmethod_22().Name = "mnuOptions";
            vmethod_22().PopupAnimation = ePopupAnimation.Slide;
            baseItemArr = new BaseItem[] {
                                           vmethod_98(), 
                                           vmethod_100() };
            vmethod_22().SubItems.AddRange(baseItemArr);
            componentResourceManager.ApplyResources(vmethod_22(), "mnuOptions");
            vmethod_98().Name = "botSettings";
            vmethod_98().PopupAnimation = ePopupAnimation.Slide;
            componentResourceManager.ApplyResources(vmethod_98(), "botSettings");
            vmethod_100().Name = "btnReload";
            componentResourceManager.ApplyResources(vmethod_100(), "btnReload");
            vmethod_24().Name = "btnHotspot";
            componentResourceManager.ApplyResources(vmethod_24(), "btnHotspot");
            vmethod_102().Name = "btnQuest";
            componentResourceManager.ApplyResources(vmethod_102(), "btnQuest");
            vmethod_102().Visible = false;
            vmethod_26().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_26().ForeColor = Color.White;
            vmethod_26().ItemAlignment = eItemAlignment.Far;
            vmethod_26().Name = "botName";
            vmethod_26().PaddingLeft = 5;
            vmethod_26().PaddingRight = 6;
            vmethod_26().TextAlignment = StringAlignment.Center;
            vmethod_66().Name = "btnClose";
            vmethod_66().Symbol = "";
            vmethod_66().SymbolSize = 10.0F;
            vmethod_62().BackColor = Color.Black;
            vmethod_62().BackgroundStyle.BackColor = Color.Black;
            vmethod_62().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_62().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_62().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_62().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_62().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_62().BackgroundStyle.TextColor = Color.White;
            vmethod_62().ChunkColor = Color.DarkRed;
            vmethod_62().ChunkColor2 = Color.DarkRed;
            componentResourceManager.ApplyResources(vmethod_62(), "HP0");
            vmethod_62().ForeColor = Color.White;
            vmethod_62().Name = "HP0";
            vmethod_62().Style = eDotNetBarStyle.Office2000;
            vmethod_62().TextVisible = true;
            vmethod_62().Value = 100;
            vmethod_60().BackColor = Color.Black;
            vmethod_60().BackgroundStyle.BackColor = Color.Black;
            vmethod_60().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_60().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_60().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_60().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_60().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_60().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_60().BackgroundStyle.BorderRightWidth = 1;
            vmethod_60().BackgroundStyle.BorderTopWidth = 1;
            vmethod_60().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_60().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_60().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_60().BackgroundStyle.TextColor = Color.White;
            vmethod_60().ChunkColor = Color.FromArgb(41, 128, 185);
            vmethod_60().ChunkColor2 = Color.FromArgb(41, 128, 185);
            componentResourceManager.ApplyResources(vmethod_60(), "MP0");
            vmethod_60().ForeColor = Color.White;
            vmethod_60().Name = "MP0";
            vmethod_60().Style = eDotNetBarStyle.Office2000;
            vmethod_60().TextVisible = true;
            vmethod_60().Value = 100;
            vmethod_56().BackColor = Color.Black;
            vmethod_56().BackgroundStyle.BackColor = Color.Black;
            vmethod_56().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_56().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_56().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_56().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_56().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_56().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_56().BackgroundStyle.BorderRightWidth = 1;
            vmethod_56().BackgroundStyle.BorderTopWidth = 1;
            vmethod_56().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_56().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_56().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_56().BackgroundStyle.TextColor = Color.White;
            vmethod_56().ChunkColor = Color.FromArgb(41, 128, 185);
            vmethod_56().ChunkColor2 = Color.FromArgb(41, 128, 185);
            componentResourceManager.ApplyResources(vmethod_56(), "MP1");
            vmethod_56().ForeColor = Color.White;
            vmethod_56().Name = "MP1";
            vmethod_56().Style = eDotNetBarStyle.Office2000;
            vmethod_56().TextVisible = true;
            vmethod_56().Value = 100;
            vmethod_58().BackColor = Color.Black;
            vmethod_58().BackgroundStyle.BackColor = Color.Black;
            vmethod_58().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_58().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_58().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_58().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_58().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_58().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_58().BackgroundStyle.BorderRightWidth = 1;
            vmethod_58().BackgroundStyle.BorderTopWidth = 1;
            vmethod_58().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_58().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_58().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_58().BackgroundStyle.TextColor = Color.White;
            vmethod_58().ChunkColor = Color.DarkRed;
            vmethod_58().ChunkColor2 = Color.DarkRed;
            componentResourceManager.ApplyResources(vmethod_58(), "HP1");
            vmethod_58().ForeColor = Color.White;
            vmethod_58().Name = "HP1";
            vmethod_58().Style = eDotNetBarStyle.Office2000;
            vmethod_58().TextVisible = true;
            vmethod_58().Value = 100;
            vmethod_48().BackColor = Color.Black;
            vmethod_48().BackgroundStyle.BackColor = Color.Black;
            vmethod_48().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_48().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_48().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_48().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_48().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_48().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_48().BackgroundStyle.BorderRightWidth = 1;
            vmethod_48().BackgroundStyle.BorderTopWidth = 1;
            vmethod_48().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_48().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_48().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_48().BackgroundStyle.TextColor = Color.White;
            vmethod_48().ChunkColor = Color.FromArgb(41, 128, 185);
            vmethod_48().ChunkColor2 = Color.FromArgb(41, 128, 185);
            componentResourceManager.ApplyResources(vmethod_48(), "MP3");
            vmethod_48().ForeColor = Color.White;
            vmethod_48().Name = "MP3";
            vmethod_48().Style = eDotNetBarStyle.Office2000;
            vmethod_48().TextVisible = true;
            vmethod_48().Value = 100;
            vmethod_50().BackColor = Color.Black;
            vmethod_50().BackgroundStyle.BackColor = Color.Black;
            vmethod_50().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_50().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_50().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_50().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_50().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_50().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_50().BackgroundStyle.BorderRightWidth = 1;
            vmethod_50().BackgroundStyle.BorderTopWidth = 1;
            vmethod_50().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_50().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_50().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_50().BackgroundStyle.TextColor = Color.White;
            vmethod_50().ChunkColor = Color.DarkRed;
            vmethod_50().ChunkColor2 = Color.DarkRed;
            componentResourceManager.ApplyResources(vmethod_50(), "HP3");
            vmethod_50().ForeColor = Color.White;
            vmethod_50().Name = "HP3";
            vmethod_50().Style = eDotNetBarStyle.Office2000;
            vmethod_50().TextVisible = true;
            vmethod_50().Value = 100;
            vmethod_52().BackColor = Color.Black;
            vmethod_52().BackgroundStyle.BackColor = Color.Black;
            vmethod_52().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_52().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_52().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_52().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_52().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_52().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_52().BackgroundStyle.BorderRightWidth = 1;
            vmethod_52().BackgroundStyle.BorderTopWidth = 1;
            vmethod_52().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_52().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_52().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_52().BackgroundStyle.TextColor = Color.White;
            vmethod_52().ChunkColor = Color.FromArgb(41, 128, 185);
            vmethod_52().ChunkColor2 = Color.FromArgb(41, 128, 185);
            componentResourceManager.ApplyResources(vmethod_52(), "MP2");
            vmethod_52().ForeColor = Color.White;
            vmethod_52().Name = "MP2";
            vmethod_52().Style = eDotNetBarStyle.Office2000;
            vmethod_52().TextVisible = true;
            vmethod_52().Value = 100;
            vmethod_54().BackColor = Color.Black;
            vmethod_54().BackgroundStyle.BackColor = Color.Black;
            vmethod_54().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_54().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_54().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_54().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_54().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_54().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_54().BackgroundStyle.BorderRightWidth = 1;
            vmethod_54().BackgroundStyle.BorderTopWidth = 1;
            vmethod_54().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_54().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_54().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_54().BackgroundStyle.TextColor = Color.White;
            vmethod_54().ChunkColor = Color.DarkRed;
            vmethod_54().ChunkColor2 = Color.DarkRed;
            componentResourceManager.ApplyResources(vmethod_54(), "HP2");
            vmethod_54().ForeColor = Color.White;
            vmethod_54().Name = "HP2";
            vmethod_54().Style = eDotNetBarStyle.Office2000;
            vmethod_54().TextVisible = true;
            vmethod_54().Value = 100;
            vmethod_32().BackColor = Color.Black;
            vmethod_32().BackgroundStyle.BackColor = Color.Black;
            vmethod_32().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_32().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_32().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_32().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_32().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_32().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_32().BackgroundStyle.BorderRightWidth = 1;
            vmethod_32().BackgroundStyle.BorderTopWidth = 1;
            vmethod_32().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_32().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_32().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_32().BackgroundStyle.TextColor = Color.White;
            vmethod_32().ChunkColor = Color.FromArgb(41, 128, 185);
            vmethod_32().ChunkColor2 = Color.FromArgb(41, 128, 185);
            componentResourceManager.ApplyResources(vmethod_32(), "MP7");
            vmethod_32().ForeColor = Color.White;
            vmethod_32().Name = "MP7";
            vmethod_32().Style = eDotNetBarStyle.Office2000;
            vmethod_32().TextVisible = true;
            vmethod_32().Value = 100;
            vmethod_34().BackColor = Color.Black;
            vmethod_34().BackgroundStyle.BackColor = Color.Black;
            vmethod_34().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_34().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_34().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_34().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_34().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_34().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_34().BackgroundStyle.BorderRightWidth = 1;
            vmethod_34().BackgroundStyle.BorderTopWidth = 1;
            vmethod_34().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_34().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_34().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_34().BackgroundStyle.TextColor = Color.White;
            vmethod_34().ChunkColor = Color.DarkRed;
            vmethod_34().ChunkColor2 = Color.DarkRed;
            componentResourceManager.ApplyResources(vmethod_34(), "HP7");
            vmethod_34().ForeColor = Color.White;
            vmethod_34().Name = "HP7";
            vmethod_34().Style = eDotNetBarStyle.Office2000;
            vmethod_34().TextVisible = true;
            vmethod_34().Value = 100;
            vmethod_36().BackColor = Color.Black;
            vmethod_36().BackgroundStyle.BackColor = Color.Black;
            vmethod_36().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_36().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_36().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_36().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_36().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_36().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_36().BackgroundStyle.BorderRightWidth = 1;
            vmethod_36().BackgroundStyle.BorderTopWidth = 1;
            vmethod_36().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_36().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_36().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_36().BackgroundStyle.TextColor = Color.White;
            vmethod_36().ChunkColor = Color.FromArgb(41, 128, 185);
            vmethod_36().ChunkColor2 = Color.FromArgb(41, 128, 185);
            componentResourceManager.ApplyResources(vmethod_36(), "MP6");
            vmethod_36().ForeColor = Color.White;
            vmethod_36().Name = "MP6";
            vmethod_36().Style = eDotNetBarStyle.Office2000;
            vmethod_36().TextVisible = true;
            vmethod_36().Value = 100;
            vmethod_38().BackColor = Color.Black;
            vmethod_38().BackgroundStyle.BackColor = Color.Black;
            vmethod_38().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_38().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_38().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_38().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_38().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_38().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_38().BackgroundStyle.BorderRightWidth = 1;
            vmethod_38().BackgroundStyle.BorderTopWidth = 1;
            vmethod_38().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_38().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_38().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_38().BackgroundStyle.TextColor = Color.White;
            vmethod_38().ChunkColor = Color.DarkRed;
            vmethod_38().ChunkColor2 = Color.DarkRed;
            componentResourceManager.ApplyResources(vmethod_38(), "HP6");
            vmethod_38().ForeColor = Color.White;
            vmethod_38().Name = "HP6";
            vmethod_38().Style = eDotNetBarStyle.Office2000;
            vmethod_38().TextVisible = true;
            vmethod_38().Value = 100;
            vmethod_40().BackColor = Color.Black;
            vmethod_40().BackgroundStyle.BackColor = Color.Black;
            vmethod_40().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_40().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_40().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_40().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_40().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_40().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_40().BackgroundStyle.BorderRightWidth = 1;
            vmethod_40().BackgroundStyle.BorderTopWidth = 1;
            vmethod_40().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_40().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_40().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_40().BackgroundStyle.TextColor = Color.White;
            vmethod_40().ChunkColor = Color.FromArgb(41, 128, 185);
            vmethod_40().ChunkColor2 = Color.FromArgb(41, 128, 185);
            componentResourceManager.ApplyResources(vmethod_40(), "MP5");
            vmethod_40().ForeColor = Color.White;
            vmethod_40().Name = "MP5";
            vmethod_40().Style = eDotNetBarStyle.Office2000;
            vmethod_40().TextVisible = true;
            vmethod_40().Value = 100;
            vmethod_42().BackColor = Color.Black;
            vmethod_42().BackgroundStyle.BackColor = Color.Black;
            vmethod_42().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_42().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_42().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_42().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_42().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_42().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_42().BackgroundStyle.BorderRightWidth = 1;
            vmethod_42().BackgroundStyle.BorderTopWidth = 1;
            vmethod_42().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_42().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_42().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_42().BackgroundStyle.TextColor = Color.White;
            vmethod_42().ChunkColor = Color.DarkRed;
            vmethod_42().ChunkColor2 = Color.DarkRed;
            componentResourceManager.ApplyResources(vmethod_42(), "HP5");
            vmethod_42().ForeColor = Color.White;
            vmethod_42().Name = "HP5";
            vmethod_42().Style = eDotNetBarStyle.Office2000;
            vmethod_42().TextVisible = true;
            vmethod_42().Value = 100;
            vmethod_44().BackColor = Color.Black;
            vmethod_44().BackgroundStyle.BackColor = Color.Black;
            vmethod_44().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_44().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_44().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_44().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_44().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_44().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_44().BackgroundStyle.BorderRightWidth = 1;
            vmethod_44().BackgroundStyle.BorderTopWidth = 1;
            vmethod_44().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_44().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_44().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_44().BackgroundStyle.TextColor = Color.White;
            vmethod_44().ChunkColor = Color.FromArgb(41, 128, 185);
            vmethod_44().ChunkColor2 = Color.FromArgb(41, 128, 185);
            componentResourceManager.ApplyResources(vmethod_44(), "MP4");
            vmethod_44().ForeColor = Color.White;
            vmethod_44().Name = "MP4";
            vmethod_44().Style = eDotNetBarStyle.Office2000;
            vmethod_44().TextVisible = true;
            vmethod_44().Value = 100;
            vmethod_46().BackColor = Color.Black;
            vmethod_46().BackgroundStyle.BackColor = Color.Black;
            vmethod_46().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_46().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_46().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_46().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_46().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_46().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_46().BackgroundStyle.BorderRightWidth = 1;
            vmethod_46().BackgroundStyle.BorderTopWidth = 1;
            vmethod_46().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_46().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_46().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_46().BackgroundStyle.TextColor = Color.White;
            vmethod_46().ChunkColor = Color.DarkRed;
            vmethod_46().ChunkColor2 = Color.DarkRed;
            componentResourceManager.ApplyResources(vmethod_46(), "HP4");
            vmethod_46().ForeColor = Color.White;
            vmethod_46().Name = "HP4";
            vmethod_46().Style = eDotNetBarStyle.Office2000;
            vmethod_46().TextVisible = true;
            vmethod_46().Value = 100;
            vmethod_28().BackColor = Color.Black;
            vmethod_28().BackgroundStyle.BackColor = Color.Black;
            vmethod_28().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_28().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_28().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_28().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_28().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_28().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_28().BackgroundStyle.BorderRightWidth = 1;
            vmethod_28().BackgroundStyle.BorderTopWidth = 1;
            vmethod_28().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_28().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_28().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_28().BackgroundStyle.TextColor = Color.White;
            vmethod_28().ChunkColor = Color.FromArgb(41, 128, 185);
            vmethod_28().ChunkColor2 = Color.FromArgb(41, 128, 185);
            componentResourceManager.ApplyResources(vmethod_28(), "MP8");
            vmethod_28().ForeColor = Color.White;
            vmethod_28().Name = "MP8";
            vmethod_28().Style = eDotNetBarStyle.Office2000;
            vmethod_28().TextVisible = true;
            vmethod_28().Value = 100;
            vmethod_30().BackColor = Color.Black;
            vmethod_30().BackgroundStyle.BackColor = Color.Black;
            vmethod_30().BackgroundStyle.BackColor2 = Color.Black;
            vmethod_30().BackgroundStyle.BorderBottomColorSchemePart = eColorSchemePart.BarCaptionBackground;
            vmethod_30().BackgroundStyle.BorderBottomWidth = 1;
            vmethod_30().BackgroundStyle.BorderColorSchemePart = eColorSchemePart.BarCaptionText;
            vmethod_30().BackgroundStyle.BorderLeftWidth = 1;
            vmethod_30().BackgroundStyle.BorderLightGradientAngle = 0;
            vmethod_30().BackgroundStyle.BorderRightWidth = 1;
            vmethod_30().BackgroundStyle.BorderTopWidth = 1;
            vmethod_30().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_30().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_30().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_30().BackgroundStyle.TextColor = Color.White;
            vmethod_30().ChunkColor = Color.DarkRed;
            vmethod_30().ChunkColor2 = Color.DarkRed;
            componentResourceManager.ApplyResources(vmethod_30(), "HP8");
            vmethod_30().ForeColor = Color.White;
            vmethod_30().Name = "HP8";
            vmethod_30().Style = eDotNetBarStyle.Office2000;
            vmethod_30().TextVisible = true;
            vmethod_30().Value = 100;
            vmethod_68().CanvasColor = SystemColors.Control;
            vmethod_68().ColorSchemeStyle = eDotNetBarStyle.Metro;
            componentResourceManager.ApplyResources(vmethod_68(), "PanelEx1");
            vmethod_68().Name = "PanelEx1";
            vmethod_68().Style.Alignment = StringAlignment.Center;
            vmethod_68().Style.BackColor1.Color = Color.Black;
            vmethod_68().Style.Border = eBorderType.SingleLine;
            vmethod_68().Style.BorderColor.Color = Color.Black;
            vmethod_68().Style.ForeColor.Color = Color.White;
            vmethod_68().Style.GradientAngle = 90;
            vmethod_68().StyleMouseDown.ForeColor.Color = Color.White;
            vmethod_84().CanvasColor = SystemColors.Control;
            vmethod_84().ColorSchemeStyle = eDotNetBarStyle.Metro;
            componentResourceManager.ApplyResources(vmethod_84(), "PanelEx2");
            vmethod_84().Name = "PanelEx2";
            vmethod_84().Style.Alignment = StringAlignment.Center;
            vmethod_84().Style.BackColor1.Color = Color.Black;
            vmethod_84().Style.Border = eBorderType.SingleLine;
            vmethod_84().Style.BorderColor.Color = Color.Black;
            vmethod_84().Style.ForeColor.Color = Color.White;
            vmethod_84().Style.GradientAngle = 90;
            vmethod_84().StyleMouseDown.ForeColor.Color = Color.White;
            vmethod_82().CanvasColor = SystemColors.Control;
            vmethod_82().ColorSchemeStyle = eDotNetBarStyle.Metro;
            componentResourceManager.ApplyResources(vmethod_82(), "PanelEx3");
            vmethod_82().Name = "PanelEx3";
            vmethod_82().Style.Alignment = StringAlignment.Center;
            vmethod_82().Style.BackColor1.Color = Color.Black;
            vmethod_82().Style.Border = eBorderType.SingleLine;
            vmethod_82().Style.BorderColor.Color = Color.Black;
            vmethod_82().Style.ForeColor.Color = Color.White;
            vmethod_82().Style.GradientAngle = 90;
            vmethod_82().StyleMouseDown.ForeColor.Color = Color.White;
            vmethod_80().CanvasColor = SystemColors.Control;
            vmethod_80().ColorSchemeStyle = eDotNetBarStyle.Metro;
            componentResourceManager.ApplyResources(vmethod_80(), "PanelEx4");
            vmethod_80().Name = "PanelEx4";
            vmethod_80().Style.Alignment = StringAlignment.Center;
            vmethod_80().Style.BackColor1.Color = Color.Black;
            vmethod_80().Style.Border = eBorderType.SingleLine;
            vmethod_80().Style.BorderColor.Color = Color.Black;
            vmethod_80().Style.ForeColor.Color = Color.White;
            vmethod_80().Style.GradientAngle = 90;
            vmethod_80().StyleMouseDown.ForeColor.Color = Color.White;
            vmethod_78().CanvasColor = SystemColors.Control;
            vmethod_78().ColorSchemeStyle = eDotNetBarStyle.Metro;
            componentResourceManager.ApplyResources(vmethod_78(), "PanelEx5");
            vmethod_78().Name = "PanelEx5";
            vmethod_78().Style.Alignment = StringAlignment.Center;
            vmethod_78().Style.BackColor1.Color = Color.Black;
            vmethod_78().Style.Border = eBorderType.SingleLine;
            vmethod_78().Style.BorderColor.Color = Color.Black;
            vmethod_78().Style.ForeColor.Color = Color.White;
            vmethod_78().Style.GradientAngle = 90;
            vmethod_78().StyleMouseDown.ForeColor.Color = Color.White;
            vmethod_76().CanvasColor = SystemColors.Control;
            vmethod_76().ColorSchemeStyle = eDotNetBarStyle.Metro;
            componentResourceManager.ApplyResources(vmethod_76(), "PanelEx6");
            vmethod_76().Name = "PanelEx6";
            vmethod_76().Style.Alignment = StringAlignment.Center;
            vmethod_76().Style.BackColor1.Color = Color.Black;
            vmethod_76().Style.Border = eBorderType.SingleLine;
            vmethod_76().Style.BorderColor.Color = Color.Black;
            vmethod_76().Style.ForeColor.Color = Color.White;
            vmethod_76().Style.GradientAngle = 90;
            vmethod_76().StyleMouseDown.ForeColor.Color = Color.White;
            vmethod_74().CanvasColor = SystemColors.Control;
            vmethod_74().ColorSchemeStyle = eDotNetBarStyle.Metro;
            componentResourceManager.ApplyResources(vmethod_74(), "PanelEx7");
            vmethod_74().Name = "PanelEx7";
            vmethod_74().Style.Alignment = StringAlignment.Center;
            vmethod_74().Style.BackColor1.Color = Color.Black;
            vmethod_74().Style.Border = eBorderType.SingleLine;
            vmethod_74().Style.BorderColor.Color = Color.Black;
            vmethod_74().Style.ForeColor.Color = Color.White;
            vmethod_74().Style.GradientAngle = 90;
            vmethod_74().StyleMouseDown.ForeColor.Color = Color.White;
            vmethod_72().CanvasColor = SystemColors.Control;
            vmethod_72().ColorSchemeStyle = eDotNetBarStyle.Metro;
            componentResourceManager.ApplyResources(vmethod_72(), "PanelEx8");
            vmethod_72().Name = "PanelEx8";
            vmethod_72().Style.Alignment = StringAlignment.Center;
            vmethod_72().Style.BackColor1.Color = Color.Black;
            vmethod_72().Style.Border = eBorderType.SingleLine;
            vmethod_72().Style.BorderColor.Color = Color.Black;
            vmethod_72().Style.ForeColor.Color = Color.White;
            vmethod_72().Style.GradientAngle = 90;
            vmethod_72().StyleMouseDown.ForeColor.Color = Color.White;
            vmethod_70().CanvasColor = SystemColors.Control;
            vmethod_70().ColorSchemeStyle = eDotNetBarStyle.Metro;
            componentResourceManager.ApplyResources(vmethod_70(), "PanelEx9");
            vmethod_70().Name = "PanelEx9";
            vmethod_70().Style.Alignment = StringAlignment.Center;
            vmethod_70().Style.BackColor1.Color = Color.Black;
            vmethod_70().Style.Border = eBorderType.SingleLine;
            vmethod_70().Style.BorderColor.Color = Color.Black;
            vmethod_70().Style.ForeColor.Color = Color.White;
            vmethod_70().Style.GradientAngle = 90;
            vmethod_70().StyleMouseDown.ForeColor.Color = Color.White;
            vmethod_88().Interval = 1000;
            vmethod_90().Interval = 900;
            vmethod_96().BackColor = Color.Black;
            vmethod_96().BackgroundStyle.CornerType = eCornerType.Square;
            componentResourceManager.ApplyResources(vmethod_96(), "dbugger");
            vmethod_96().ForeColor = Color.White;
            vmethod_96().Name = "dbugger";
            componentResourceManager.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(vmethod_96());
            Controls.Add(vmethod_28());
            Controls.Add(vmethod_30());
            Controls.Add(vmethod_32());
            Controls.Add(vmethod_34());
            Controls.Add(vmethod_36());
            Controls.Add(vmethod_38());
            Controls.Add(vmethod_40());
            Controls.Add(vmethod_42());
            Controls.Add(vmethod_44());
            Controls.Add(vmethod_46());
            Controls.Add(vmethod_48());
            Controls.Add(vmethod_50());
            Controls.Add(vmethod_52());
            Controls.Add(vmethod_54());
            Controls.Add(vmethod_56());
            Controls.Add(vmethod_58());
            Controls.Add(vmethod_60());
            Controls.Add(vmethod_62());
            Controls.Add(vmethod_18());
            Controls.Add(vmethod_6());
            Controls.Add(vmethod_4());
            Controls.Add(vmethod_8());
            Controls.Add(vmethod_2());
            Controls.Add(vmethod_10());
            Controls.Add(vmethod_12());
            Controls.Add(vmethod_14());
            Controls.Add(vmethod_16());
            Controls.Add(vmethod_70());
            Controls.Add(vmethod_72());
            Controls.Add(vmethod_74());
            Controls.Add(vmethod_76());
            Controls.Add(vmethod_78());
            Controls.Add(vmethod_80());
            Controls.Add(vmethod_82());
            Controls.Add(vmethod_84());
            Controls.Add(vmethod_68());
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bot";
            vmethod_18().EndInit();
            ResumeLayout(false);
        }

        private void method_0()
        {
            int i = 0;
            do
            {
                int_2[i] = checked((int)gclass22_0.method_3(checked((int)checked(gclass26_0.long_1 + (long)checked(i * GClass24.int_0))), 4));
                int_4[i] = checked((int)gclass22_0.method_3(checked((int)checked(gclass26_0.long_1 + (long)checked(i * GClass24.int_0))), 4));
                int_3[i] = checked((int)gclass22_0.method_3(checked((int)checked(checked(gclass26_0.long_1 + 4L) + (long)checked(i * GClass24.int_0))), 4));
                int_5[i] = checked((int)gclass22_0.method_3(checked((int)checked(checked(gclass26_0.long_1 + 4L) + (long)checked(i * GClass24.int_0))), 4));
                i = checked(i + 1);
            } while (i <= 8);
        }

        private void method_1()
        {
        }

        private void method_10(object sender, EventArgs e)
        {
            // decompiler error
        }

        private void method_11(object sender, EventArgs e)
        {
            DateTime dateTime = DateAndTime.Now;
            timeSpan_0 = dateTime.Subtract(dateTime_0);
            string_4 = String.Format("ELAPSED TIME: {0:00}:{1:00}:{2:00}", timeSpan_0.Hours, timeSpan_0.Minutes, timeSpan_0.Seconds);
        }

        private void method_12(object sender, EventArgs e)
        {
            GClass28.GClass29 gclass29 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_30));
            if (gclass29 != null)
            {
                method_14();
                switch (gclass29.method_2())
                {
                    case PartyCode.Leader:
                        method_15();
                        method_16(0.ToString());
                        partyCode_0 = PartyCode.Leader;
                        bool_2 = true;
                        break;

                    case PartyCode.Follower:
                        method_13();
                        method_16(1.ToString());
                        partyCode_0 = PartyCode.Follower;
                        bool_2 = true;
                        break;
                }
            }
        }

        private void method_13()
        {
            GClass28.GClass29 gclass29 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_31));
            gclass30_0.method_1(gclass29.method_6());
            gclass30_0.method_3(gclass29.method_8());
            gclass30_0.method_7(checked((int)gclass29.method_12()));
            gclass30_0.method_9(checked((int)gclass29.method_14()));
            gclass30_0.method_11(Conversions.ToInteger(gclass29.method_16()));
        }

        private void method_14()
        {
            GClass28.GClass29 gclass29 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_33));
            gclass29.method_7(checked((int)gclass22_0.method_3(checked((int)gclass26_0.long_61), 2)));
            gclass29.method_13(gclass22_0.method_3(checked((int)gclass26_0.long_46), 2));
            gclass29.method_15(gclass22_0.method_3(checked((int)gclass26_0.long_21), 2));
            gclass29.method_17(Conversions.ToString(gclass22_0.method_3(checked((int)checked(gclass26_0.long_21 + 2L)), 2)));
        }

        private void method_15()
        {
            IEnumerable<GClass28.GClass29> ienumerable = Enumerable.Where<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_34));
            if (Enumerable.Count<GClass28.GClass29>(ienumerable) == Enumerable.Count<GClass28.GClass29>(ienumerable, new Func<GClass28.GClass29,bool>(null, Bot.smethod_0)))
                gclass30_0.method_3(GEnum6.const_0);
            else
                gclass30_0.method_3(GEnum6.const_1);
        }

        private void method_16(string string_9)
        {
            string[] sArr = Strings.Split(labelX_6.Text, ": ", -1, CompareMethod.Binary);
            labelX_6.Text = sArr[0] + ": " + string_9;
        }

        private void method_17(object sender, EventArgs e)
        {
            if (!automoveform_0.Visible & (gclass22_0.method_3(checked((int)gclass26_0.long_57), 1) == 1L) & (gclass22_0.method_3(checked((int)gclass26_0.long_60), 2) == 0L))
                automoveform_0.Show();
            gclass26_0.long_55 = (long)gclass22_0.method_1(GClass24.int_56, 4);
            if (gclass22_0.method_2(GClass24.int_56, 4))
            {
                if (!mapTeleport_0.Visible)
                {
                    mapTeleport_0.vmethod_0().Enabled = true;
                    mapTeleport_0.Show();
                }
            }
            else if (mapTeleport_0.Visible)
            {
                mapTeleport_0.vmethod_0().Enabled = true;
                mapTeleport_0.Hide();
            }
        }

        private void method_18(object sender, EventArgs e)
        {
            GClass6.GClass13 gclass13 = Enumerable.FirstOrDefault<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(method_35));
            gclass13.method_16().BringToFront();
            gclass13.method_16().Visible = true;
            gclass13.method_16().IsOpen = true;
        }

        private void method_19(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                int_4[i] = checked((int)gclass22_0.method_3(checked((int)checked(gclass26_0.long_1 + (long)checked(i * GClass24.int_0))), 4));
                int_5[i] = checked((int)gclass22_0.method_3(checked((int)checked(checked(gclass26_0.long_1 + 4L) + (long)checked(i * GClass24.int_0))), 4));
                i = checked(i + 1);
            } while (i <= 8);
        }

        private void method_2()
        {
            List<GClass1.GClass2>.Enumerator enumerator;

            List<GClass1.GClass2> list = GClass1.list_0.FindAll(new Predicate<GClass1.GClass2>(method_23));
            try
            {
                enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    GClass1.GClass2 gclass2 = enumerator.get_Current();
                    process_0 = gclass2.method_0();
                    gclass22_0.int_0 = (int)GClass22.OpenProcess(GClass22.GEnum3.const_1, true, process_0.Id);
                    gclass2.method_3((long)gclass22_0.int_0);
                    long_1 = gclass2.method_4();
                    gclass26_0.method_0(gclass22_0);
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }

        private void method_20(object sender, EventArgs e)
        {
            List<GClass6.GClass13>.Enumerator enumerator;

            List<GClass6.GClass13> list = GClass6.list_2.FindAll(new Predicate<GClass6.GClass13>(method_36));
            try
            {
                enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    GClass6.GClass13 gclass13 = enumerator.get_Current();
                    gclass13.method_10().BringToFront();
                    gclass13.method_10().Visible = true;
                    gclass13.method_10().IsOpen = true;
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }

        private void method_21(object sender, EventArgs e)
        {
            GClass6.GClass13 gclass13 = Enumerable.FirstOrDefault<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(method_37));
            gclass13.method_14().BringToFront();
            gclass13.method_14().Visible = true;
            gclass13.method_14().IsOpen = true;
        }

        [CompilerGenerated]
        private bool method_22(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_23(GClass1.GClass2 gclass2_0)
        {
            return Operators.CompareString(gclass2_0.method_6(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private void method_24()
        {
            gclass4_0.method_3();
        }

        [CompilerGenerated]
        private void method_25()
        {
            gclass4_0.method_5();
        }

        [CompilerGenerated]
        private bool method_26(GClass6.GClass13 gclass13_0)
        {
            return Operators.CompareString(gclass13_0.method_0(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_27(GClass6.GClass13 gclass13_0)
        {
            return Operators.CompareString(gclass13_0.method_0(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_28(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_29(GClass6.GClass13 gclass13_0)
        {
            return Operators.CompareString(gclass13_0.method_0(), string_0, false) == 0;
        }

        private void method_3()
        {
            progressBarX_18[0] = vmethod_62();
            progressBarX_18[1] = vmethod_58();
            progressBarX_18[2] = vmethod_54();
            progressBarX_18[3] = vmethod_50();
            progressBarX_18[4] = vmethod_46();
            progressBarX_18[5] = vmethod_42();
            progressBarX_18[6] = vmethod_38();
            progressBarX_18[7] = vmethod_34();
            progressBarX_18[8] = vmethod_30();
            progressBarX_19[0] = vmethod_60();
            progressBarX_19[1] = vmethod_56();
            progressBarX_19[2] = vmethod_52();
            progressBarX_19[3] = vmethod_48();
            progressBarX_19[4] = vmethod_44();
            progressBarX_19[5] = vmethod_40();
            progressBarX_19[6] = vmethod_36();
            progressBarX_19[7] = vmethod_32();
            progressBarX_19[8] = vmethod_28();
        }

        [CompilerGenerated]
        private bool method_30(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_31(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_32)).method_4(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_32(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_33(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_34(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_4(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_35(GClass6.GClass13 gclass13_0)
        {
            return Operators.CompareString(gclass13_0.method_0(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_36(GClass6.GClass13 gclass13_0)
        {
            return Operators.CompareString(gclass13_0.method_0(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_37(GClass6.GClass13 gclass13_0)
        {
            return Operators.CompareString(gclass13_0.method_0(), string_0, false) == 0;
        }

        private void method_4(object sender, EventArgs e)
        {
            // decompiler error
        }

        private void method_5()
        {
            while (bool_1)
            {
                if (gclass22_0.method_3(checked((int)gclass26_0.long_10), 1) == 0L)
                {
                    int i = 0;
                    goto label_2;
                label_1:
                    if (double_1[i] > 1.0)
                        int_5[i] = checked((int)gclass22_0.method_3(checked((int)checked(checked(gclass26_0.long_1 + 4L) + (long)checked(i * GClass24.int_0))), 4));
                    i = checked(i + 1);
                    if (i <= 8)
                        goto label_2;
                    while (true)
                    {
                        int_4[i] = checked((int)gclass22_0.method_3(checked((int)checked(gclass26_0.long_1 + (long)checked(i * GClass24.int_0))), 4));
                        goto label_1;
                    label_2:
                        if (double_0[i] <= 1.0)
                            goto label_1;
                    }
                }
                Thread.Sleep(500);
            }
        }

        private void method_6(object sender, EventArgs e)
        {
            SwitchButtonItem switchButtonItem = (SwitchButtonItem)sender;
            if (!switchButtonItem.Value)
            {
                if ((thread_0 != null) && thread_0.IsAlive)
                {
                    ErrorForm errorForm = new ErrorForm();
                    errorForm.vmethod_2().Text = "Please wait bot is currently cleaning up previous bot thread.";
                    switchButtonItem_0.Value = false;
                    errorForm.Show();
                    return;
                }
                bool_0 = true;
                thread_0 = new Thread(new ThreadStart(method_24));
                thread_0.IsBackground = true;
                thread_0.Start();
                Thread thread = new Thread(new ThreadStart(method_25));
                thread.IsBackground = true;
                thread.Start();
                dateTime_0 = DateAndTime.Now;
                vmethod_90().Enabled = true;
            }
            else
            {
                if (gclass4_0 != null)
                    gclass4_0.method_39(GEnum6.const_1);
                bool_0 = false;
                vmethod_90().Enabled = false;
            }
        }

        public void method_7()
        {
            List<GClass6.GClass13>.Enumerator enumerator;

            List<GClass6.GClass13> list = GClass6.list_2.FindAll(new Predicate<GClass6.GClass13>(method_26));
            try
            {
                enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    GClass6.GClass13 gclass13 = enumerator.get_Current();
                    labelX_1 = gclass13.method_28();
                    string_2 = labelX_1.Text;
                    labelX_2 = gclass13.method_20();
                    string_3 = labelX_2.Text;
                    labelX_3 = gclass13.method_24();
                    string_4 = labelX_3.Text;
                    labelX_4 = gclass13.method_22();
                    string_5 = labelX_4.Text;
                    labelX_5 = gclass13.method_26();
                    string_6 = labelX_5.Text;
                    labelX_6 = gclass13.method_30();
                    string_7 = labelX_6.Text;
                    labelX_7 = gclass13.method_32();
                    string_8 = labelX_7.Text;
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }

        private void method_8(object sender, EventArgs e)
        {
            List<GClass6.GClass13>.Enumerator enumerator;
            List<GClass6.GClass13>.Enumerator enumerator1;

            List<GClass6.GClass13> list1 = GClass6.list_2.FindAll(new Predicate<GClass6.GClass13>(method_27));
            try
            {
                enumerator = list1.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    GClass6.GClass13 gclass13_1 = enumerator.get_Current();
                    gclass13_1.method_6().Dispose();
                    gclass13_1.method_4().Dispose();
                    gclass13_1.method_2().Dispose();
                    gclass13_1.method_10().Dispose();
                }
            }
            finally
            {
                enumerator.Dispose();
            }
            GClass28.GClass29 gclass29 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_28));
            if (gclass29 != null)
                GClass28.hashSet_0.Remove(gclass29);
            List<GClass6.GClass13> list = GClass6.list_2.FindAll(new Predicate<GClass6.GClass13>(method_29));
            try
            {
                enumerator1 = list.GetEnumerator();
                while (enumerator1.MoveNext())
                {
                    GClass6.GClass13 gclass13_2 = enumerator1.get_Current();
                    GClass6.list_2.Remove(gclass13_2);
                }
            }
            finally
            {
                enumerator1.Dispose();
            }
        }

        private void method_9(object sender, EventArgs e)
        {
            labelX_1.Text = string_2;
            labelX_2.Text = string_3;
            labelX_3.Text = string_4;
            labelX_5.Text = string_6;
            labelX_4.Text = string_5;
            vmethod_96().Text = "DEBUG: " + string_1;
            int i = checked((int)gclass22_0.method_3(checked((int)gclass26_0.long_42), 1));
            if (i != 0)
                i = checked(i - 5);
            labelX_7.Text = "CRAFT: +" + Conversions.ToString(i);
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

        internal virtual DotNetBarManager vmethod_0()
        {
            DotNetBarManager dotNetBarManager;

            return dotNetBarManager_0;
        }

        internal virtual void vmethod_1(DotNetBarManager dotNetBarManager_1)
        {
            dotNetBarManager_0 = dotNetBarManager_1;
        }

        internal virtual DockSite vmethod_10()
        {
            DockSite dockSite;

            return dockSite_4;
        }

        internal virtual ButtonItem vmethod_100()
        {
            ButtonItem buttonItem;

            return buttonItem_4;
        }

        internal virtual void vmethod_101(ButtonItem buttonItem_6)
        {
            EventHandler eventHandler = new EventHandler(method_19);
            if (buttonItem_4 != null)
                buttonItem_4.Click -= eventHandler;
            buttonItem_4 = buttonItem_6;
            if (buttonItem_4 != null)
                buttonItem_4.Click += eventHandler;
        }

        internal virtual ButtonItem vmethod_102()
        {
            ButtonItem buttonItem;

            return buttonItem_5;
        }

        internal virtual void vmethod_103(ButtonItem buttonItem_6)
        {
            EventHandler eventHandler = new EventHandler(method_21);
            if (buttonItem_5 != null)
                buttonItem_5.Click -= eventHandler;
            buttonItem_5 = buttonItem_6;
            if (buttonItem_5 != null)
                buttonItem_5.Click += eventHandler;
        }

        internal virtual void vmethod_11(DockSite dockSite_8)
        {
            dockSite_4 = dockSite_8;
        }

        internal virtual DockSite vmethod_12()
        {
            DockSite dockSite;

            return dockSite_5;
        }

        internal virtual void vmethod_13(DockSite dockSite_8)
        {
            dockSite_5 = dockSite_8;
        }

        internal virtual DockSite vmethod_14()
        {
            DockSite dockSite;

            return dockSite_6;
        }

        internal virtual void vmethod_15(DockSite dockSite_8)
        {
            dockSite_6 = dockSite_8;
        }

        internal virtual DockSite vmethod_16()
        {
            DockSite dockSite;

            return dockSite_7;
        }

        internal virtual void vmethod_17(DockSite dockSite_8)
        {
            dockSite_7 = dockSite_8;
        }

        internal virtual Bar vmethod_18()
        {
            Bar bar;

            return bar_0;
        }

        internal virtual void vmethod_19(Bar bar_1)
        {
            bar_0 = bar_1;
        }

        internal virtual DockSite vmethod_2()
        {
            DockSite dockSite;

            return dockSite_0;
        }

        internal virtual SwitchButtonItem vmethod_20()
        {
            SwitchButtonItem switchButtonItem;

            return switchButtonItem_0;
        }

        internal virtual void vmethod_21(SwitchButtonItem switchButtonItem_1)
        {
            EventHandler eventHandler = new EventHandler(method_6);
            if (switchButtonItem_0 != null)
                switchButtonItem_0.ValueChanged -= eventHandler;
            switchButtonItem_0 = switchButtonItem_1;
            if (switchButtonItem_0 != null)
                switchButtonItem_0.ValueChanged += eventHandler;
        }

        internal virtual ButtonItem vmethod_22()
        {
            ButtonItem buttonItem;

            return buttonItem_0;
        }

        internal virtual void vmethod_23(ButtonItem buttonItem_6)
        {
            buttonItem_0 = buttonItem_6;
        }

        internal virtual ButtonItem vmethod_24()
        {
            ButtonItem buttonItem;

            return buttonItem_1;
        }

        internal virtual void vmethod_25(ButtonItem buttonItem_6)
        {
            EventHandler eventHandler = new EventHandler(method_18);
            if (buttonItem_1 != null)
                buttonItem_1.Click -= eventHandler;
            buttonItem_1 = buttonItem_6;
            if (buttonItem_1 != null)
                buttonItem_1.Click += eventHandler;
        }

        internal virtual LabelItem vmethod_26()
        {
            LabelItem labelItem;

            return labelItem_0;
        }

        internal virtual void vmethod_27(LabelItem labelItem_1)
        {
            labelItem_0 = labelItem_1;
        }

        internal virtual ProgressBarX vmethod_28()
        {
            ProgressBarX progressBarX;

            return progressBarX_0;
        }

        internal virtual void vmethod_29(ProgressBarX progressBarX_20)
        {
            progressBarX_0 = progressBarX_20;
        }

        internal virtual void vmethod_3(DockSite dockSite_8)
        {
            dockSite_0 = dockSite_8;
        }

        internal virtual ProgressBarX vmethod_30()
        {
            ProgressBarX progressBarX;

            return progressBarX_1;
        }

        internal virtual void vmethod_31(ProgressBarX progressBarX_20)
        {
            progressBarX_1 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_32()
        {
            ProgressBarX progressBarX;

            return progressBarX_2;
        }

        internal virtual void vmethod_33(ProgressBarX progressBarX_20)
        {
            progressBarX_2 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_34()
        {
            ProgressBarX progressBarX;

            return progressBarX_3;
        }

        internal virtual void vmethod_35(ProgressBarX progressBarX_20)
        {
            progressBarX_3 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_36()
        {
            ProgressBarX progressBarX;

            return progressBarX_4;
        }

        internal virtual void vmethod_37(ProgressBarX progressBarX_20)
        {
            progressBarX_4 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_38()
        {
            ProgressBarX progressBarX;

            return progressBarX_5;
        }

        internal virtual void vmethod_39(ProgressBarX progressBarX_20)
        {
            progressBarX_5 = progressBarX_20;
        }

        internal virtual DockSite vmethod_4()
        {
            DockSite dockSite;

            return dockSite_1;
        }

        internal virtual ProgressBarX vmethod_40()
        {
            ProgressBarX progressBarX;

            return progressBarX_6;
        }

        internal virtual void vmethod_41(ProgressBarX progressBarX_20)
        {
            progressBarX_6 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_42()
        {
            ProgressBarX progressBarX;

            return progressBarX_7;
        }

        internal virtual void vmethod_43(ProgressBarX progressBarX_20)
        {
            progressBarX_7 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_44()
        {
            ProgressBarX progressBarX;

            return progressBarX_8;
        }

        internal virtual void vmethod_45(ProgressBarX progressBarX_20)
        {
            progressBarX_8 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_46()
        {
            ProgressBarX progressBarX;

            return progressBarX_9;
        }

        internal virtual void vmethod_47(ProgressBarX progressBarX_20)
        {
            progressBarX_9 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_48()
        {
            ProgressBarX progressBarX;

            return progressBarX_10;
        }

        internal virtual void vmethod_49(ProgressBarX progressBarX_20)
        {
            progressBarX_10 = progressBarX_20;
        }

        internal virtual void vmethod_5(DockSite dockSite_8)
        {
            dockSite_1 = dockSite_8;
        }

        internal virtual ProgressBarX vmethod_50()
        {
            ProgressBarX progressBarX;

            return progressBarX_11;
        }

        internal virtual void vmethod_51(ProgressBarX progressBarX_20)
        {
            progressBarX_11 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_52()
        {
            ProgressBarX progressBarX;

            return progressBarX_12;
        }

        internal virtual void vmethod_53(ProgressBarX progressBarX_20)
        {
            progressBarX_12 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_54()
        {
            ProgressBarX progressBarX;

            return progressBarX_13;
        }

        internal virtual void vmethod_55(ProgressBarX progressBarX_20)
        {
            progressBarX_13 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_56()
        {
            ProgressBarX progressBarX;

            return progressBarX_14;
        }

        internal virtual void vmethod_57(ProgressBarX progressBarX_20)
        {
            progressBarX_14 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_58()
        {
            ProgressBarX progressBarX;

            return progressBarX_15;
        }

        internal virtual void vmethod_59(ProgressBarX progressBarX_20)
        {
            progressBarX_15 = progressBarX_20;
        }

        internal virtual DockSite vmethod_6()
        {
            DockSite dockSite;

            return dockSite_2;
        }

        internal virtual ProgressBarX vmethod_60()
        {
            ProgressBarX progressBarX;

            return progressBarX_16;
        }

        internal virtual void vmethod_61(ProgressBarX progressBarX_20)
        {
            progressBarX_16 = progressBarX_20;
        }

        internal virtual ProgressBarX vmethod_62()
        {
            ProgressBarX progressBarX;

            return progressBarX_17;
        }

        internal virtual void vmethod_63(ProgressBarX progressBarX_20)
        {
            progressBarX_17 = progressBarX_20;
        }

        internal virtual Timer vmethod_64()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual void vmethod_65(Timer timer_6)
        {
            EventHandler eventHandler = new EventHandler(method_4);
            if (timer_0 != null)
                timer_0.Tick -= eventHandler;
            timer_0 = timer_6;
            if (timer_0 != null)
                timer_0.Tick += eventHandler;
        }

        internal virtual ButtonItem vmethod_66()
        {
            ButtonItem buttonItem;

            return buttonItem_2;
        }

        internal virtual void vmethod_67(ButtonItem buttonItem_6)
        {
            EventHandler eventHandler = new EventHandler(method_8);
            if (buttonItem_2 != null)
                buttonItem_2.Click -= eventHandler;
            buttonItem_2 = buttonItem_6;
            if (buttonItem_2 != null)
                buttonItem_2.Click += eventHandler;
        }

        internal virtual PanelEx vmethod_68()
        {
            PanelEx panelEx;

            return panelEx_0;
        }

        internal virtual void vmethod_69(PanelEx panelEx_9)
        {
            panelEx_0 = panelEx_9;
        }

        internal virtual void vmethod_7(DockSite dockSite_8)
        {
            dockSite_2 = dockSite_8;
        }

        internal virtual PanelEx vmethod_70()
        {
            PanelEx panelEx;

            return panelEx_1;
        }

        internal virtual void vmethod_71(PanelEx panelEx_9)
        {
            panelEx_1 = panelEx_9;
        }

        internal virtual PanelEx vmethod_72()
        {
            PanelEx panelEx;

            return panelEx_2;
        }

        internal virtual void vmethod_73(PanelEx panelEx_9)
        {
            panelEx_2 = panelEx_9;
        }

        internal virtual PanelEx vmethod_74()
        {
            PanelEx panelEx;

            return panelEx_3;
        }

        internal virtual void vmethod_75(PanelEx panelEx_9)
        {
            panelEx_3 = panelEx_9;
        }

        internal virtual PanelEx vmethod_76()
        {
            PanelEx panelEx;

            return panelEx_4;
        }

        internal virtual void vmethod_77(PanelEx panelEx_9)
        {
            panelEx_4 = panelEx_9;
        }

        internal virtual PanelEx vmethod_78()
        {
            PanelEx panelEx;

            return panelEx_5;
        }

        internal virtual void vmethod_79(PanelEx panelEx_9)
        {
            panelEx_5 = panelEx_9;
        }

        internal virtual DockSite vmethod_8()
        {
            DockSite dockSite;

            return dockSite_3;
        }

        internal virtual PanelEx vmethod_80()
        {
            PanelEx panelEx;

            return panelEx_6;
        }

        internal virtual void vmethod_81(PanelEx panelEx_9)
        {
            panelEx_6 = panelEx_9;
        }

        internal virtual PanelEx vmethod_82()
        {
            PanelEx panelEx;

            return panelEx_7;
        }

        internal virtual void vmethod_83(PanelEx panelEx_9)
        {
            panelEx_7 = panelEx_9;
        }

        internal virtual PanelEx vmethod_84()
        {
            PanelEx panelEx;

            return panelEx_8;
        }

        internal virtual void vmethod_85(PanelEx panelEx_9)
        {
            panelEx_8 = panelEx_9;
        }

        internal virtual Timer vmethod_86()
        {
            Timer timer;

            return timer_1;
        }

        internal virtual void vmethod_87(Timer timer_6)
        {
            EventHandler eventHandler = new EventHandler(method_9);
            if (timer_1 != null)
                timer_1.Tick -= eventHandler;
            timer_1 = timer_6;
            if (timer_1 != null)
                timer_1.Tick += eventHandler;
        }

        internal virtual Timer vmethod_88()
        {
            Timer timer;

            return timer_2;
        }

        internal virtual void vmethod_89(Timer timer_6)
        {
            EventHandler eventHandler = new EventHandler(method_10);
            if (timer_2 != null)
                timer_2.Tick -= eventHandler;
            timer_2 = timer_6;
            if (timer_2 != null)
                timer_2.Tick += eventHandler;
        }

        internal virtual void vmethod_9(DockSite dockSite_8)
        {
            dockSite_3 = dockSite_8;
        }

        internal virtual Timer vmethod_90()
        {
            Timer timer;

            return timer_3;
        }

        internal virtual void vmethod_91(Timer timer_6)
        {
            EventHandler eventHandler = new EventHandler(method_11);
            if (timer_3 != null)
                timer_3.Tick -= eventHandler;
            timer_3 = timer_6;
            if (timer_3 != null)
                timer_3.Tick += eventHandler;
        }

        internal virtual Timer vmethod_92()
        {
            Timer timer;

            return timer_4;
        }

        internal virtual void vmethod_93(Timer timer_6)
        {
            EventHandler eventHandler = new EventHandler(method_12);
            if (timer_4 != null)
                timer_4.Tick -= eventHandler;
            timer_4 = timer_6;
            if (timer_4 != null)
                timer_4.Tick += eventHandler;
        }

        internal virtual Timer vmethod_94()
        {
            Timer timer;

            return timer_5;
        }

        internal virtual void vmethod_95(Timer timer_6)
        {
            EventHandler eventHandler = new EventHandler(method_17);
            if (timer_5 != null)
                timer_5.Tick -= eventHandler;
            timer_5 = timer_6;
            if (timer_5 != null)
                timer_5.Tick += eventHandler;
        }

        internal virtual LabelX vmethod_96()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual void vmethod_97(LabelX labelX_8)
        {
            labelX_0 = labelX_8;
        }

        internal virtual ButtonItem vmethod_98()
        {
            ButtonItem buttonItem;

            return buttonItem_3;
        }

        internal virtual void vmethod_99(ButtonItem buttonItem_6)
        {
            EventHandler eventHandler = new EventHandler(method_20);
            if (buttonItem_3 != null)
                buttonItem_3.Click -= eventHandler;
            buttonItem_3 = buttonItem_6;
            if (buttonItem_3 != null)
                buttonItem_3.Click += eventHandler;
        }

        [CompilerGenerated]
        private static bool smethod_0(GClass28.GClass29 gclass29_0)
        {
            return gclass29_0.method_8() == GEnum6.const_0;
        }

        [PreserveSig]
        [DllImport("kernel32", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int CloseHandle(int int_7);

        [PreserveSig]
        [DllImport("d3d9hook.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetCoordinates(int int_7);

        [PreserveSig]
        [DllImport("user32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [PreserveSig]
        [DllImport("user32.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

        [PreserveSig]
        [DllImport("d3d9hook.dll", CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int SetAttack(int int_7, int int_8);

    } // class Bot

}

