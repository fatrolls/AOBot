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
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class Hotspotform : MetroForm
    {

        public enum GEnum5
        {
            const_0 = 0,
            const_1 = 2035711
        }

        [CompilerGenerated]
        internal sealed class Class12
        {

            public GClass14.GClass19 gclass19_0;
            public Hotspotform hotspotform_0;

            public Class12()
            {
            }

            [CompilerGenerated]
            public void method_0()
            {
                hotspotform_0.gclass0_0.method_2(checked((int)gclass19_0.method_2()), checked((int)gclass19_0.method_4()), Conversions.ToInteger(gclass19_0.method_6()));
            }

        } // class Class12

        public Bot bot_0;
        [AccessedThroughProperty("cancelSettingsButton")]
        private ButtonX buttonX_0;
        [AccessedThroughProperty("ButtonX1")]
        private ButtonX buttonX_1;
        [AccessedThroughProperty("selectClientButton")]
        private ButtonX buttonX_2;
        [AccessedThroughProperty("saveLocations")]
        private ButtonX buttonX_3;
        [AccessedThroughProperty("lstLocations")]
        private ComboBoxEx comboBoxEx_0;
        private GClass0 gclass0_0;
        private GClass14 gclass14_0;
        private GClass22 gclass22_0;
        private IContainer icontainer_0;
        [AccessedThroughProperty("LabelX54")]
        private LabelX labelX_0;
        [AccessedThroughProperty("LabelX12")]
        private LabelX labelX_1;
        [AccessedThroughProperty("lblLocationY")]
        private LabelX labelX_2;
        [AccessedThroughProperty("lblLocationX")]
        private LabelX labelX_3;
        [AccessedThroughProperty("LabelX22")]
        private LabelX labelX_4;
        [AccessedThroughProperty("LabelX23")]
        private LabelX labelX_5;
        [AccessedThroughProperty("LabelX1")]
        private LabelX labelX_6;
        [AccessedThroughProperty("LabelX2")]
        private LabelX labelX_7;
        public long long_0;
        [AccessedThroughProperty("hotspotPanel")]
        private PanelEx panelEx_0;
        [AccessedThroughProperty("locationPanel")]
        private PanelEx panelEx_1;
        public Process process_0;
        public SlidePanel slidePanel_0;
        public string string_0;
        private string string_1;
        private string string_2;
        [AccessedThroughProperty("txtLocation")]
        private TextBoxX textBoxX_0;
        [AccessedThroughProperty("LocationTimer")]
        private Timer timer_0;

        public Hotspotform()
        {
            Load += new EventHandler(Hotspotform_Load);
            gclass22_0 = new GClass22();
            InitializeComponent();
        }

        private void Hotspotform_Load(object sender, EventArgs e)
        {
            List<GClass1.GClass2>.Enumerator enumerator;

            string_1 = Application.StartupPath + "\\" + string_0 + "\\hotSpotTeleport.ini";
            List<GClass1.GClass2> list = GClass1.list_0.FindAll(new Predicate<GClass1.GClass2>(method_6));
            try
            {
                enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    GClass1.GClass2 gclass2 = enumerator.get_Current();
                    process_0 = gclass2.method_0();
                    long_0 = (long)GClass22.OpenProcess(GClass22.GEnum3.const_1, true, process_0.Id);
                    gclass22_0.int_0 = checked((int)long_0);
                }
            }
            finally
            {
                enumerator.Dispose();
            }
            gclass14_0 = bot_0.gclass14_0;
            method_0();
            gclass0_0 = new GClass0(bot_0, bot_0.gclass26_0, gclass22_0, bot_0.gclass4_0);
            vmethod_2().Enabled = true;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;

            icontainer_0 = new Container();
            vmethod_1(new ButtonX());
            vmethod_3(new Timer(icontainer_0));
            vmethod_5(new PanelEx());
            vmethod_7(new ButtonX());
            vmethod_9(new ButtonX());
            vmethod_11(new ComboBoxEx());
            vmethod_13(new LabelX());
            vmethod_15(new LabelX());
            vmethod_17(new PanelEx());
            vmethod_19(new ButtonX());
            vmethod_21(new TextBoxX());
            vmethod_23(new LabelX());
            vmethod_25(new LabelX());
            vmethod_27(new LabelX());
            vmethod_29(new LabelX());
            vmethod_31(new LabelX());
            vmethod_33(new LabelX());
            vmethod_4().SuspendLayout();
            vmethod_16().SuspendLayout();
            SuspendLayout();
            vmethod_0().AccessibleRole = AccessibleRole.PushButton;
            vmethod_0().BackColor = Color.FromArgb(45, 137, 239);
            vmethod_0().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_0().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Point point = new Point(376, 340);
            vmethod_0().Location = point;
            vmethod_0().Name = "cancelSettingsButton";
            vmethod_0().RightToLeft = RightToLeft.No;
            Size size = new Size(90, 22);
            vmethod_0().Size = size;
            vmethod_0().Style = eDotNetBarStyle.Metro;
            vmethod_0().TabIndex = 36;
            vmethod_0().Text = "CANCEL";
            vmethod_4().CanvasColor = SystemColors.Control;
            vmethod_4().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_4().Controls.Add(vmethod_6());
            vmethod_4().Controls.Add(vmethod_8());
            vmethod_4().Controls.Add(vmethod_10());
            vmethod_4().Controls.Add(vmethod_12());
            vmethod_4().Controls.Add(vmethod_14());
            point = new Point(12, 17);
            vmethod_4().Location = point;
            vmethod_4().Name = "hotspotPanel";
            size = new Size(454, 114);
            vmethod_4().Size = size;
            vmethod_4().Style.Alignment = StringAlignment.Center;
            vmethod_4().Style.BackColor1.Color = Color.Black;
            vmethod_4().Style.Border = eBorderType.SingleLine;
            vmethod_4().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_4().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_4().Style.GradientAngle = 90;
            vmethod_4().TabIndex = 41;
            vmethod_6().AccessibleRole = AccessibleRole.PushButton;
            vmethod_6().BackColor = Color.FromArgb(45, 137, 239);
            vmethod_6().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_6().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(256, 77);
            vmethod_6().Location = point;
            vmethod_6().Name = "ButtonX1";
            vmethod_6().RightToLeft = RightToLeft.No;
            size = new Size(90, 25);
            vmethod_6().Size = size;
            vmethod_6().Style = eDotNetBarStyle.Metro;
            vmethod_6().TabIndex = 45;
            vmethod_6().Text = "TELEPORT";
            vmethod_8().AccessibleRole = AccessibleRole.PushButton;
            vmethod_8().BackColor = Color.FromArgb(45, 137, 239);
            vmethod_8().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_8().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(352, 77);
            vmethod_8().Location = point;
            vmethod_8().Name = "selectClientButton";
            vmethod_8().RightToLeft = RightToLeft.No;
            size = new Size(90, 25);
            vmethod_8().Size = size;
            vmethod_8().Style = eDotNetBarStyle.Metro;
            vmethod_8().TabIndex = 44;
            vmethod_8().Text = "DELETE";
            vmethod_10().DisplayMember = "Text";
            vmethod_10().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_10().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_10().ForeColor = Color.White;
            vmethod_10().FormattingEnabled = true;
            vmethod_10().ItemHeight = 16;
            point = new Point(11, 44);
            vmethod_10().Location = point;
            vmethod_10().Name = "lstLocations";
            size = new Size(431, 22);
            vmethod_10().Size = size;
            vmethod_10().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_10().TabIndex = 43;
            vmethod_12().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_12().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_12().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_12().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_12().BackgroundStyle.MarginLeft = 1;
            vmethod_12().BackgroundStyle.MarginRight = 1;
            vmethod_12().BackgroundStyle.MarginTop = 1;
            vmethod_12().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_12().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_12().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_12().BackgroundStyle.TextShadowOffset = point;
            vmethod_12().Dock = DockStyle.Top;
            vmethod_12().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_12().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_12().Location = point;
            vmethod_12().Name = "LabelX54";
            vmethod_12().PaddingLeft = 10;
            size = new Size(454, 19);
            vmethod_12().Size = size;
            vmethod_12().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_12().TabIndex = 42;
            vmethod_12().Text = "HOT SPOT TELEPORT";
            vmethod_12().TextLineAlignment = StringAlignment.Near;
            vmethod_14().BackColor = Color.Black;
            vmethod_14().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_14().ForeColor = Color.White;
            point = new Point(11, 25);
            vmethod_14().Location = point;
            vmethod_14().Name = "LabelX12";
            size = new Size(81, 15);
            vmethod_14().Size = size;
            vmethod_14().TabIndex = 40;
            vmethod_14().Text = "LOCATION";
            vmethod_16().CanvasColor = SystemColors.Control;
            vmethod_16().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_16().Controls.Add(vmethod_18());
            vmethod_16().Controls.Add(vmethod_20());
            vmethod_16().Controls.Add(vmethod_22());
            vmethod_16().Controls.Add(vmethod_24());
            vmethod_16().Controls.Add(vmethod_26());
            vmethod_16().Controls.Add(vmethod_28());
            vmethod_16().Controls.Add(vmethod_30());
            vmethod_16().Controls.Add(vmethod_32());
            point = new Point(12, 147);
            vmethod_16().Location = point;
            vmethod_16().Name = "locationPanel";
            size = new Size(454, 152);
            vmethod_16().Size = size;
            vmethod_16().Style.Alignment = StringAlignment.Center;
            vmethod_16().Style.BackColor1.Color = Color.Black;
            vmethod_16().Style.Border = eBorderType.SingleLine;
            vmethod_16().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_16().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_16().Style.GradientAngle = 90;
            vmethod_16().TabIndex = 42;
            vmethod_18().AccessibleRole = AccessibleRole.PushButton;
            vmethod_18().BackColor = Color.FromArgb(45, 137, 239);
            vmethod_18().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_18().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(329, 115);
            vmethod_18().Location = point;
            vmethod_18().Name = "saveLocations";
            vmethod_18().RightToLeft = RightToLeft.No;
            size = new Size(113, 25);
            vmethod_18().Size = size;
            vmethod_18().Style = eDotNetBarStyle.Metro;
            vmethod_18().TabIndex = 68;
            vmethod_18().Text = "SAVE LOCATION";
            vmethod_20().BackColor = Color.Black;
            vmethod_20().Border.Class = "TextBoxBorder";
            vmethod_20().Border.CornerType = eCornerType.Square;
            vmethod_20().ForeColor = Color.White;
            point = new Point(11, 43);
            vmethod_20().Location = point;
            vmethod_20().Name = "txtLocation";
            size = new Size(431, 22);
            vmethod_20().Size = size;
            vmethod_20().TabIndex = 67;
            vmethod_22().AutoSize = true;
            vmethod_22().BackColor = Color.Black;
            vmethod_22().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_22().ForeColor = Color.White;
            point = new Point(28, 87);
            vmethod_22().Location = point;
            vmethod_22().Name = "lblLocationY";
            size = new Size(33, 17);
            vmethod_22().Size = size;
            vmethod_22().TabIndex = 66;
            vmethod_22().Text = "NONE";
            vmethod_24().AutoSize = true;
            vmethod_24().BackColor = Color.Black;
            vmethod_24().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_24().ForeColor = Color.White;
            point = new Point(28, 71);
            vmethod_24().Location = point;
            vmethod_24().Name = "lblLocationX";
            size = new Size(33, 17);
            vmethod_24().Size = size;
            vmethod_24().TabIndex = 65;
            vmethod_24().Text = "NONE";
            vmethod_26().AutoSize = true;
            vmethod_26().BackColor = Color.Black;
            vmethod_26().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_26().ForeColor = Color.White;
            point = new Point(11, 87);
            vmethod_26().Location = point;
            vmethod_26().Name = "LabelX22";
            size = new Size(11, 17);
            vmethod_26().Size = size;
            vmethod_26().TabIndex = 64;
            vmethod_26().Text = "Y:";
            vmethod_28().AutoSize = true;
            vmethod_28().BackColor = Color.Black;
            vmethod_28().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_28().ForeColor = Color.White;
            point = new Point(11, 71);
            vmethod_28().Location = point;
            vmethod_28().Name = "LabelX23";
            size = new Size(11, 17);
            vmethod_28().Size = size;
            vmethod_28().TabIndex = 63;
            vmethod_28().Text = "X:";
            vmethod_30().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_30().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_30().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_30().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_30().BackgroundStyle.MarginLeft = 1;
            vmethod_30().BackgroundStyle.MarginRight = 1;
            vmethod_30().BackgroundStyle.MarginTop = 1;
            vmethod_30().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_30().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_30().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_30().BackgroundStyle.TextShadowOffset = point;
            vmethod_30().Dock = DockStyle.Top;
            vmethod_30().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_30().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_30().Location = point;
            vmethod_30().Name = "LabelX1";
            vmethod_30().PaddingLeft = 10;
            size = new Size(454, 19);
            vmethod_30().Size = size;
            vmethod_30().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_30().TabIndex = 42;
            vmethod_30().Text = "SAVE LOCATION";
            vmethod_30().TextLineAlignment = StringAlignment.Near;
            vmethod_32().BackColor = Color.Black;
            vmethod_32().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_32().ForeColor = Color.White;
            point = new Point(11, 25);
            vmethod_32().Location = point;
            vmethod_32().Name = "LabelX2";
            size = new Size(81, 15);
            vmethod_32().Size = size;
            vmethod_32().TabIndex = 40;
            vmethod_32().Text = "LOCATION";
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(478, 374);
            ClientSize = size;
            Controls.Add(vmethod_16());
            Controls.Add(vmethod_4());
            Controls.Add(vmethod_0());
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hotspotform";
            Text = "Hotspot Teleport";
            vmethod_4().ResumeLayout(false);
            vmethod_16().ResumeLayout(false);
            vmethod_16().PerformLayout();
            ResumeLayout(false);
        }

        public void method_0()
        {
            List<GClass14.GClass19>.Enumerator enumerator;

            try
            {
                enumerator = gclass14_0.list_4.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    GClass14.GClass19 gclass19 = enumerator.get_Current();
                    vmethod_10().Items.Add(gclass19.method_0());
                }
            }
            finally
            {
                enumerator.Dispose();
            }
            if (vmethod_10().Items.Count > -1)
                vmethod_10().SelectedIndex = 0;
        }

        private void method_1(object sender, EventArgs e)
        {
            slidePanel_0.IsOpen = false;
        }

        private void method_2(object sender, EventArgs e)
        {
            if (Operators.CompareString(string_2, gclass22_0.method_5(checked((int)bot_0.gclass26_0.long_30), 100), false) != 0)
            {
                vmethod_20().Text = gclass22_0.method_5(checked((int)bot_0.gclass26_0.long_30), 100);
                vmethod_24().Text = Conversions.ToString(gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_21), 2));
                vmethod_22().Text = Conversions.ToString(gclass22_0.method_3(checked((int)checked(bot_0.gclass26_0.long_21 + 2L)), 2));
            }
            string_2 = gclass22_0.method_5(checked((int)bot_0.gclass26_0.long_30), 100);
        }

        private void method_3(object sender, EventArgs e)
        {
            string s = GClass5.smethod_2(string_1, vmethod_20().Text);
            GClass14.GClass19 gclass19_1 = Enumerable.FirstOrDefault<GClass14.GClass19>(gclass14_0.list_4, new Func<GClass14.GClass19,bool>(method_7));
            if ((gclass19_1 == null) && (Operators.CompareString(s, "", false) == 0))
            {
                GClass14.GClass19 gclass19_2 = new GClass14.GClass19();
                long l = gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_46), 2);
                gclass19_2.method_1(vmethod_20().Text);
                gclass19_2.method_3(l);
                gclass19_2.method_5(Conversions.ToLong(vmethod_24().Text));
                gclass19_2.method_7(vmethod_22().Text);
                gclass14_0.list_4.Add(gclass19_2);
                GClass5.smethod_4(string_1, vmethod_20().Text, "Id", Conversions.ToString(l));
                GClass5.smethod_4(string_1, vmethod_20().Text, "X", vmethod_24().Text);
                GClass5.smethod_4(string_1, vmethod_20().Text, "Y", vmethod_22().Text + "\r\n");
                vmethod_10().Items.Add(vmethod_20().Text);
            }
        }

        private void method_4(object sender, EventArgs e)
        {
            Hotspotform.Class12 class12 = new Hotspotform.Class12();
            class12.hotspotform_0 = this;
            bot_0.bool_0 = true;
            class12.gclass19_0 = Enumerable.FirstOrDefault<GClass14.GClass19>(gclass14_0.list_4, new Func<GClass14.GClass19,bool>(method_8));
            if (class12.gclass19_0 != null)
            {
                Thread thread = new Thread(new ThreadStart(class12.method_0));
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void method_5(object sender, EventArgs e)
        {
            GClass14.GClass19 gclass19 = Enumerable.FirstOrDefault<GClass14.GClass19>(gclass14_0.list_4, new Func<GClass14.GClass19,bool>(method_9));
            if (gclass19 != null)
            {
                gclass14_0.list_4.Remove(gclass19);
                GClass5.smethod_6(string_1, Conversions.ToString(vmethod_10().SelectedItem));
                vmethod_10().Items.Remove(RuntimeHelpers.GetObjectValue(vmethod_10().SelectedItem));
                if (vmethod_10().Items.Count > 0)
                    vmethod_10().SelectedIndex = 0;
            }
        }

        [CompilerGenerated]
        private bool method_6(GClass1.GClass2 gclass2_0)
        {
            return Operators.CompareString(gclass2_0.method_6(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_7(GClass14.GClass19 gclass19_0)
        {
            return Operators.CompareString(gclass19_0.method_0(), vmethod_20().Text, false) == 0;
        }

        [CompilerGenerated]
        private bool method_8(GClass14.GClass19 gclass19_0)
        {
            return Operators.CompareString(gclass19_0.method_0(), vmethod_10().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_9(GClass14.GClass19 gclass19_0)
        {
            return Operators.ConditionalCompareObjectEqual(gclass19_0.method_0(), vmethod_10().SelectedItem, false);
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

        internal virtual ButtonX vmethod_0()
        {
            ButtonX buttonX;

            return buttonX_0;
        }

        internal virtual void vmethod_1(ButtonX buttonX_4)
        {
            EventHandler eventHandler = new EventHandler(method_1);
            if (buttonX_0 != null)
                buttonX_0.Click -= eventHandler;
            buttonX_0 = buttonX_4;
            if (buttonX_0 != null)
                buttonX_0.Click += eventHandler;
        }

        internal virtual ComboBoxEx vmethod_10()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_0;
        }

        internal virtual void vmethod_11(ComboBoxEx comboBoxEx_1)
        {
            comboBoxEx_0 = comboBoxEx_1;
        }

        internal virtual LabelX vmethod_12()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual void vmethod_13(LabelX labelX_8)
        {
            labelX_0 = labelX_8;
        }

        internal virtual LabelX vmethod_14()
        {
            LabelX labelX;

            return labelX_1;
        }

        internal virtual void vmethod_15(LabelX labelX_8)
        {
            labelX_1 = labelX_8;
        }

        internal virtual PanelEx vmethod_16()
        {
            PanelEx panelEx;

            return panelEx_1;
        }

        internal virtual void vmethod_17(PanelEx panelEx_2)
        {
            panelEx_1 = panelEx_2;
        }

        internal virtual ButtonX vmethod_18()
        {
            ButtonX buttonX;

            return buttonX_3;
        }

        internal virtual void vmethod_19(ButtonX buttonX_4)
        {
            EventHandler eventHandler = new EventHandler(method_3);
            if (buttonX_3 != null)
                buttonX_3.Click -= eventHandler;
            buttonX_3 = buttonX_4;
            if (buttonX_3 != null)
                buttonX_3.Click += eventHandler;
        }

        internal virtual Timer vmethod_2()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual TextBoxX vmethod_20()
        {
            TextBoxX textBoxX;

            return textBoxX_0;
        }

        internal virtual void vmethod_21(TextBoxX textBoxX_1)
        {
            textBoxX_0 = textBoxX_1;
        }

        internal virtual LabelX vmethod_22()
        {
            LabelX labelX;

            return labelX_2;
        }

        internal virtual void vmethod_23(LabelX labelX_8)
        {
            labelX_2 = labelX_8;
        }

        internal virtual LabelX vmethod_24()
        {
            LabelX labelX;

            return labelX_3;
        }

        internal virtual void vmethod_25(LabelX labelX_8)
        {
            labelX_3 = labelX_8;
        }

        internal virtual LabelX vmethod_26()
        {
            LabelX labelX;

            return labelX_4;
        }

        internal virtual void vmethod_27(LabelX labelX_8)
        {
            labelX_4 = labelX_8;
        }

        internal virtual LabelX vmethod_28()
        {
            LabelX labelX;

            return labelX_5;
        }

        internal virtual void vmethod_29(LabelX labelX_8)
        {
            labelX_5 = labelX_8;
        }

        internal virtual void vmethod_3(Timer timer_1)
        {
            EventHandler eventHandler = new EventHandler(method_2);
            if (timer_0 != null)
                timer_0.Tick -= eventHandler;
            timer_0 = timer_1;
            if (timer_0 != null)
                timer_0.Tick += eventHandler;
        }

        internal virtual LabelX vmethod_30()
        {
            LabelX labelX;

            return labelX_6;
        }

        internal virtual void vmethod_31(LabelX labelX_8)
        {
            labelX_6 = labelX_8;
        }

        internal virtual LabelX vmethod_32()
        {
            LabelX labelX;

            return labelX_7;
        }

        internal virtual void vmethod_33(LabelX labelX_8)
        {
            labelX_7 = labelX_8;
        }

        internal virtual PanelEx vmethod_4()
        {
            PanelEx panelEx;

            return panelEx_0;
        }

        internal virtual void vmethod_5(PanelEx panelEx_2)
        {
            panelEx_0 = panelEx_2;
        }

        internal virtual ButtonX vmethod_6()
        {
            ButtonX buttonX;

            return buttonX_1;
        }

        internal virtual void vmethod_7(ButtonX buttonX_4)
        {
            EventHandler eventHandler = new EventHandler(method_4);
            if (buttonX_1 != null)
                buttonX_1.Click -= eventHandler;
            buttonX_1 = buttonX_4;
            if (buttonX_1 != null)
                buttonX_1.Click += eventHandler;
        }

        internal virtual ButtonX vmethod_8()
        {
            ButtonX buttonX;

            return buttonX_2;
        }

        internal virtual void vmethod_9(ButtonX buttonX_4)
        {
            EventHandler eventHandler = new EventHandler(method_5);
            if (buttonX_2 != null)
                buttonX_2.Click -= eventHandler;
            buttonX_2 = buttonX_4;
            if (buttonX_2 != null)
                buttonX_2.Click += eventHandler;
        }

    } // class Hotspotform

}

