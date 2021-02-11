using System;
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
    public sealed class BotForm : MetroForm
    {

        [CompilerGenerated]
        internal sealed class Class6
        {

            public PanelExTitle panelExTitle_0;

            public Class6()
            {
            }

            [CompilerGenerated]
            public bool method_0(GClass6.GClass13 gclass13_0)
            {
                return Operators.CompareString(gclass13_0.method_2().TitlePanel.Text, panelExTitle_0.Text, false) == 0;
            }

            [CompilerGenerated]
            public bool method_1(GClass6.GClass13 gclass13_0)
            {
                return gclass13_0.method_2().Expanded & (Operators.CompareString(gclass13_0.method_2().TitlePanel.Text, panelExTitle_0.Text, false) != 0);
            }

            [CompilerGenerated]
            public bool method_2(GClass6.GClass13 gclass13_0)
            {
                return Operators.CompareString(gclass13_0.method_0(), panelExTitle_0.Name, false) == 0;
            }

        } // class Class6

        [AccessedThroughProperty("Bar1")]
        private Bar bar_0;
        [AccessedThroughProperty("selectClientButton")]
        private ButtonItem buttonItem_0;
        [AccessedThroughProperty("PartyModeButton")]
        private ButtonItem buttonItem_1;
        private IContainer icontainer_0;
        [AccessedThroughProperty("botListPanel")]
        private PanelEx panelEx_0;

        public static GClass6 gclass6_0;
        public static PanelEx panelEx_1;
        public static PanelExTitle panelExTitle_0;
        public static SlidePanel slidePanel_0;
        public static SlidePanel slidePanel_1;
        public static SlidePanel slidePanel_2;

        public BotForm()
        {
            Load += new EventHandler(BotForm_Load);
            InitializeComponent();
        }

        private void BotForm_Load(object sender, EventArgs e)
        {
            Color color;

            BotForm.panelEx_1 = vmethod_0();
            MetroColorGeneratorParameters metroColorGeneratorParameters = Class1.Class2_0.method_7().vmethod_18().MetroColorParameters;
            BotForm.panelEx_1.Style.BorderColor.Color = metroColorGeneratorParameters.BaseColor;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;

            vmethod_1(new PanelEx());
            vmethod_3(new Bar());
            vmethod_5(new ButtonItem());
            vmethod_7(new ButtonItem());
            vmethod_2().BeginInit();
            SuspendLayout();
            vmethod_0().AutoScroll = true;
            vmethod_0().CanvasColor = SystemColors.Control;
            vmethod_0().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_0().Dock = DockStyle.Left;
            Point point = new Point(0, 18);
            vmethod_0().Location = point;
            vmethod_0().Name = "botListPanel";
            Size size = new Size(222, 380);
            vmethod_0().Size = size;
            vmethod_0().Style.Alignment = StringAlignment.Center;
            vmethod_0().Style.BackColor1.Color = Color.Black;
            vmethod_0().Style.Border = eBorderType.SingleLine;
            vmethod_0().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_0().Style.BorderSide = eBorderSide.Right | eBorderSide.Top;
            vmethod_0().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_0().Style.GradientAngle = 90;
            vmethod_0().TabIndex = 5;
            vmethod_2().AccessibleDescription = "Bar1 (Bar1)";
            vmethod_2().AccessibleName = "Bar1";
            vmethod_2().AccessibleRole = AccessibleRole.ToolBar;
            vmethod_2().AntiAlias = true;
            vmethod_2().BackColor = Color.Black;
            vmethod_2().BarType = eBarType.DockWindow;
            vmethod_2().CanCustomize = false;
            vmethod_2().ColorScheme.BarDockedBorder = Color.FromArgb(0, 0, 192);
            vmethod_2().ColorScheme.BarFloatingBorder = Color.FromArgb(0, 0, 255);
            vmethod_2().ColorScheme.MenuBorder = Color.FromArgb(0, 0, 255);
            vmethod_2().Dock = DockStyle.Top;
            vmethod_2().FadeEffect = true;
            vmethod_2().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BaseItem[] baseItemArr = new BaseItem[] {
                                                      vmethod_4(), 
                                                      vmethod_6() };
            vmethod_2().Items.AddRange(baseItemArr);
            point = new Point(0, 0);
            vmethod_2().Location = point;
            vmethod_2().Name = "Bar1";
            vmethod_2().SingleLineColor = SystemColors.ActiveCaption;
            size = new Size(707, 18);
            vmethod_2().Size = size;
            vmethod_2().Stretch = true;
            vmethod_2().Style = eDotNetBarStyle.Metro;
            vmethod_2().TabIndex = 6;
            vmethod_2().TabStop = false;
            vmethod_2().Text = "Bar1";
            vmethod_4().Name = "selectClientButton";
            vmethod_4().Symbol = "\uF007 SELECT ACCOUNT";
            vmethod_4().SymbolSize = 9.0F;
            vmethod_4().Text = "SELECT ACCOUNT";
            vmethod_6().Name = "PartyModeButton";
            vmethod_6().Symbol = "\uF0E8 PARTY MODE";
            vmethod_6().SymbolSize = 9.0F;
            vmethod_6().Text = "ButtonItem1";
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(707, 398);
            ClientSize = size;
            Controls.Add(vmethod_0());
            Controls.Add(vmethod_2());
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BotForm";
            Text = "Bot";
            vmethod_2().EndInit();
            ResumeLayout(false);
        }

        private void method_0(object sender, EventArgs e)
        {
            GClass6.GClass13 gclass13 = Enumerable.FirstOrDefault<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(null, BotForm.smethod_2));
            if (!BotForm.slidePanel_0.IsOpen)
            {
                if (gclass13 != null)
                {
                    gclass13.method_4().Visible = false;
                    gclass13.method_4().IsOpen = false;
                }
                if (BotForm.slidePanel_1.IsOpen)
                {
                    BotForm.slidePanel_1.Visible = false;
                    BotForm.slidePanel_1.IsOpen = false;
                }
                BotForm.slidePanel_0.Visible = true;
                BotForm.slidePanel_0.IsOpen = true;
                BotForm.slidePanel_0.BringToFront();
                BotForm.slidePanel_0.SlideSide = eSlideSide.Right;
            }
        }

        private void method_1(object sender, EventArgs e)
        {
            GClass6.GClass13 gclass13 = Enumerable.FirstOrDefault<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(null, BotForm.smethod_4));
            if (!BotForm.slidePanel_1.IsOpen)
            {
                if (gclass13 != null)
                {
                    gclass13.method_4().Visible = false;
                    gclass13.method_4().IsOpen = false;
                }
                if (BotForm.slidePanel_0.IsOpen)
                {
                    BotForm.slidePanel_0.Visible = false;
                    BotForm.slidePanel_0.IsOpen = false;
                }
                BotForm.slidePanel_1.Visible = true;
                BotForm.slidePanel_1.IsOpen = true;
                BotForm.slidePanel_1.BringToFront();
                BotForm.slidePanel_1.SlideSide = eSlideSide.Right;
            }
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

        internal virtual PanelEx vmethod_0()
        {
            PanelEx panelEx;

            return panelEx_0;
        }

        internal virtual void vmethod_1(PanelEx panelEx_2)
        {
            panelEx_0 = panelEx_2;
        }

        internal virtual Bar vmethod_2()
        {
            Bar bar;

            return bar_0;
        }

        internal virtual void vmethod_3(Bar bar_1)
        {
            bar_0 = bar_1;
        }

        internal virtual ButtonItem vmethod_4()
        {
            ButtonItem buttonItem;

            return buttonItem_0;
        }

        internal virtual void vmethod_5(ButtonItem buttonItem_2)
        {
            EventHandler eventHandler = new EventHandler(method_0);
            if (buttonItem_0 != null)
                buttonItem_0.Click -= eventHandler;
            buttonItem_0 = buttonItem_2;
            if (buttonItem_0 != null)
                buttonItem_0.Click += eventHandler;
        }

        internal virtual ButtonItem vmethod_6()
        {
            ButtonItem buttonItem;

            return buttonItem_1;
        }

        internal virtual void vmethod_7(ButtonItem buttonItem_2)
        {
            EventHandler eventHandler = new EventHandler(method_1);
            if (buttonItem_1 != null)
                buttonItem_1.Click -= eventHandler;
            buttonItem_1 = buttonItem_2;
            if (buttonItem_1 != null)
                buttonItem_1.Click += eventHandler;
        }

        public static void smethod_0(object sender, EventArgs e)
        {
            BotForm.Class6 class6 = new BotForm.Class6();
            class6.panelExTitle_0 = (PanelExTitle)sender;
            GClass6.GClass13 gclass13_3 = Enumerable.FirstOrDefault<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(class6, class6.method_0));
            GClass6.GClass13 gclass13_2 = Enumerable.FirstOrDefault<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(class6, class6.method_1));
            if ((gclass13_2 != null) && (Operators.CompareString(gclass13_3.method_2().TitlePanel.Text, gclass13_2.method_2().TitlePanel.Text, false) != 0))
                BotForm.smethod_1(gclass13_2);
            GClass6.GClass13 gclass13_1 = Enumerable.FirstOrDefault<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(class6, class6.method_2));
            if (gclass13_1.method_4().IsOpen)
                return;
            if ((BotForm.slidePanel_0.IsOpen | BotForm.slidePanel_1.IsOpen))
            {
                if (BotForm.slidePanel_0.IsOpen)
                {
                    BotForm.slidePanel_0.Visible = false;
                    BotForm.slidePanel_0.IsOpen = false;
                    gclass13_1.method_4().Visible = true;
                    gclass13_1.method_4().IsOpen = true;
                }
                if (BotForm.slidePanel_1.IsOpen)
                {
                    BotForm.slidePanel_1.Visible = false;
                    BotForm.slidePanel_1.IsOpen = false;
                    gclass13_1.method_4().Visible = true;
                    gclass13_1.method_4().IsOpen = true;
                }
            }
            else
            {
                GClass6.GClass13 gclass13_4 = Enumerable.FirstOrDefault<GClass6.GClass13>(GClass6.list_2, new Func<GClass6.GClass13,bool>(null, BotForm.smethod_3));
                if (gclass13_4 != null)
                {
                    gclass13_4.method_4().Visible = false;
                    gclass13_4.method_4().IsOpen = false;
                    gclass13_1.method_4().Visible = true;
                    gclass13_1.method_4().IsOpen = true;
                }
                else
                {
                    gclass13_1.method_4().Visible = true;
                    gclass13_1.method_4().IsOpen = true;
                }
            }
        }

        public static void smethod_1(GClass6.GClass13 gclass13_0)
        {
            gclass13_0.method_2().Expanded = false;
        }

        [CompilerGenerated]
        private static bool smethod_2(GClass6.GClass13 gclass13_0)
        {
            return gclass13_0.method_4().IsOpen;
        }

        [CompilerGenerated]
        private static bool smethod_3(GClass6.GClass13 gclass13_0)
        {
            return gclass13_0.method_4().IsOpen;
        }

        [CompilerGenerated]
        private static bool smethod_4(GClass6.GClass13 gclass13_0)
        {
            return gclass13_0.method_4().IsOpen;
        }

    } // class BotForm

}

