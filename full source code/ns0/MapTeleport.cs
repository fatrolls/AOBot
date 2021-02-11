using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class MapTeleport : MetroForm
    {

        private Bot bot_0;
        [AccessedThroughProperty("teleportButton")]
        private ButtonX buttonX_0;
        public GClass0 gclass0_0;
        private GClass22 gclass22_0;
        private GClass26 gclass26_0;
        private GClass4 gclass4_0;
        private IContainer icontainer_0;
        [AccessedThroughProperty("LabelX1")]
        private LabelX labelX_0;
        [AccessedThroughProperty("LabelX2")]
        private LabelX labelX_1;
        [AccessedThroughProperty("LabelX3")]
        private LabelX labelX_2;
        [AccessedThroughProperty("LabelX4")]
        private LabelX labelX_3;
        [AccessedThroughProperty("lblLocation")]
        private LabelX labelX_4;
        [AccessedThroughProperty("lblX")]
        private LabelX labelX_5;
        [AccessedThroughProperty("lblY")]
        private LabelX labelX_6;
        [AccessedThroughProperty("MapTeleportTimer")]
        private Timer timer_0;

        public MapTeleport(Bot bot_1, GClass22 gclass22_1, GClass26 gclass26_1, GClass4 gclass4_1)
        {
            Load += new EventHandler(MapTeleport_Load);
            InitializeComponent();
            bot_0 = bot_1;
            gclass22_0 = gclass22_1;
            gclass26_0 = gclass26_1;
            gclass4_0 = gclass4_1;
            bot_0.bool_0 = true;
            gclass0_0 = new GClass0(bot_0, gclass26_0, gclass22_0, gclass4_0);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;

            icontainer_0 = new Container();
            vmethod_1(new ButtonX());
            vmethod_3(new LabelX());
            vmethod_5(new LabelX());
            vmethod_7(new LabelX());
            vmethod_9(new Timer(icontainer_0));
            vmethod_11(new LabelX());
            vmethod_13(new LabelX());
            vmethod_15(new LabelX());
            vmethod_17(new LabelX());
            SuspendLayout();
            vmethod_0().AccessibleRole = AccessibleRole.PushButton;
            vmethod_0().BackColor = Color.FromArgb(45, 137, 239);
            vmethod_0().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_0().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Point point = new Point(313, 123);
            vmethod_0().Location = point;
            vmethod_0().Name = "teleportButton";
            vmethod_0().RightToLeft = RightToLeft.No;
            Size size = new Size(90, 22);
            vmethod_0().Size = size;
            vmethod_0().Style = eDotNetBarStyle.Metro;
            vmethod_0().TabIndex = 40;
            vmethod_0().Text = "TELEPORT";
            vmethod_2().AutoSize = true;
            vmethod_2().BackColor = Color.Black;
            vmethod_2().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_2().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_2().ForeColor = Color.White;
            point = new Point(58, 23);
            vmethod_2().Location = point;
            vmethod_2().Name = "LabelX1";
            size = new Size(345, 17);
            vmethod_2().Size = size;
            vmethod_2().TabIndex = 39;
            vmethod_2().Text = "MAP DETECTED CLICK LOCATION ON MAP THEN CLICK TELEPORT";
            vmethod_4().AutoSize = true;
            vmethod_4().BackColor = Color.Black;
            vmethod_4().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_4().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_4().ForeColor = Color.White;
            point = new Point(186, 65);
            vmethod_4().Location = point;
            vmethod_4().Name = "LabelX2";
            size = new Size(13, 17);
            vmethod_4().Size = size;
            vmethod_4().TabIndex = 42;
            vmethod_4().Text = "X:";
            vmethod_6().AutoSize = true;
            vmethod_6().BackColor = Color.Black;
            vmethod_6().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_6().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_6().ForeColor = Color.White;
            point = new Point(187, 88);
            vmethod_6().Location = point;
            vmethod_6().Name = "LabelX3";
            size = new Size(12, 17);
            vmethod_6().Size = size;
            vmethod_6().TabIndex = 43;
            vmethod_6().Text = "Y:";
            vmethod_10().AutoSize = true;
            vmethod_10().BackColor = Color.Black;
            vmethod_10().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_10().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_10().ForeColor = Color.White;
            point = new Point(101, 42);
            vmethod_10().Location = point;
            vmethod_10().Name = "LabelX4";
            size = new Size(97, 17);
            vmethod_10().Size = size;
            vmethod_10().TabIndex = 44;
            vmethod_10().Text = "LOCATION NAME:";
            vmethod_12().AutoSize = true;
            vmethod_12().BackColor = Color.Black;
            vmethod_12().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_12().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_12().ForeColor = Color.White;
            point = new Point(204, 42);
            vmethod_12().Location = point;
            vmethod_12().Name = "lblLocation";
            size = new Size(0, 0);
            vmethod_12().Size = size;
            vmethod_12().TabIndex = 45;
            vmethod_14().AutoSize = true;
            vmethod_14().BackColor = Color.Black;
            vmethod_14().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_14().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_14().ForeColor = Color.White;
            point = new Point(204, 65);
            vmethod_14().Location = point;
            vmethod_14().Name = "lblX";
            size = new Size(0, 0);
            vmethod_14().Size = size;
            vmethod_14().TabIndex = 46;
            vmethod_16().AutoSize = true;
            vmethod_16().BackColor = Color.Black;
            vmethod_16().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_16().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_16().ForeColor = Color.White;
            point = new Point(204, 88);
            vmethod_16().Location = point;
            vmethod_16().Name = "lblY";
            size = new Size(0, 0);
            vmethod_16().Size = size;
            vmethod_16().TabIndex = 47;
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(474, 178);
            ClientSize = size;
            ControlBox = false;
            Controls.Add(vmethod_16());
            Controls.Add(vmethod_14());
            Controls.Add(vmethod_12());
            Controls.Add(vmethod_10());
            Controls.Add(vmethod_6());
            Controls.Add(vmethod_4());
            Controls.Add(vmethod_0());
            Controls.Add(vmethod_2());
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MapTeleport";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Map Teleport";
            ResumeLayout(false);
            PerformLayout();
        }

        private void MapTeleport_Load(object sender, EventArgs e)
        {
            TopMost = true;
            vmethod_8().Enabled = true;
        }

        private void method_0(object sender, EventArgs e)
        {
            if (Visible)
            {
                bot_0.gclass26_0.long_55 = (long)gclass22_0.method_1(GClass24.int_56, 4);
                if (gclass22_0.method_3(checked((int)checked(bot_0.gclass26_0.long_55 - 4L)), 4) != 0L)
                {
                    long l = gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_55), 2);
                    if (l == 0L)
                        vmethod_12().Text = "Northeast Asia";
                    else if (l == 170L)
                        vmethod_12().Text = "Southeast Asia India";
                    else if (l == 173L)
                        vmethod_12().Text = "Northern Europe";
                    else if (l == 171L)
                        vmethod_12().Text = "Southern Europe";
                    else if (l == 178L)
                        vmethod_12().Text = "Africa";
                    else if (l == 172L)
                        vmethod_12().Text = "Southwest Asia";
                    else if (l == 174L)
                        vmethod_12().Text = "North America";
                    else if (l == 175L)
                        vmethod_12().Text = "Central Asia";
                    else if (l == 179L)
                        vmethod_12().Text = "Australia";
                    else if (l == 3000L)
                        vmethod_12().Text = "Atlantis Outskirts";
                    else if (l == 3001L)
                        vmethod_12().Text = "West Atlantis";
                    else if (l == 2300L)
                        vmethod_12().Text = "Titan Island";
                }
                bot_0.gclass26_0.long_54 = (long)gclass22_0.method_1(GClass24.int_55, 4);
                if (gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_54), 1) != 0L)
                {
                    if (Operators.CompareString(gclass22_0.method_5(checked((int)bot_0.gclass26_0.long_54), 25), "", false) != 0)
                    {
                        string s = gclass22_0.method_5(checked((int)bot_0.gclass26_0.long_54), 50);
                        s = Strings.Replace(s, "X : ", "", 1, -1, CompareMethod.Binary);
                        s = Strings.Replace(s, "Y : ", "", 1, -1, CompareMethod.Binary);
                        s = Strings.Replace(s, " ", "", 1, -1, CompareMethod.Binary);
                        string[] sArr = Strings.Split(s, ",", -1, CompareMethod.Binary);
                        if (Information.UBound(sArr, 1) == 1)
                        {
                            vmethod_14().Text = sArr[0];
                            vmethod_16().Text = sArr[1];
                        }
                    }
                    else
                    {
                        vmethod_0().Enabled = false;
                    }
                }
            }
        }

        private void method_1(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(method_2));
            thread.IsBackground = true;
            thread.Start();
        }

        [CompilerGenerated]
        private void method_2()
        {
            gclass0_0.method_3(checked((int)gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_55), 2)), Conversions.ToInteger(vmethod_14().Text), Conversions.ToInteger(vmethod_16().Text));
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

        internal virtual void vmethod_1(ButtonX buttonX_1)
        {
            EventHandler eventHandler = new EventHandler(method_1);
            if (buttonX_0 != null)
                buttonX_0.Click -= eventHandler;
            buttonX_0 = buttonX_1;
            if (buttonX_0 != null)
                buttonX_0.Click += eventHandler;
        }

        internal virtual LabelX vmethod_10()
        {
            LabelX labelX;

            return labelX_3;
        }

        internal virtual void vmethod_11(LabelX labelX_7)
        {
            labelX_3 = labelX_7;
        }

        internal virtual LabelX vmethod_12()
        {
            LabelX labelX;

            return labelX_4;
        }

        internal virtual void vmethod_13(LabelX labelX_7)
        {
            labelX_4 = labelX_7;
        }

        internal virtual LabelX vmethod_14()
        {
            LabelX labelX;

            return labelX_5;
        }

        internal virtual void vmethod_15(LabelX labelX_7)
        {
            labelX_5 = labelX_7;
        }

        internal virtual LabelX vmethod_16()
        {
            LabelX labelX;

            return labelX_6;
        }

        internal virtual void vmethod_17(LabelX labelX_7)
        {
            labelX_6 = labelX_7;
        }

        internal virtual LabelX vmethod_2()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual void vmethod_3(LabelX labelX_7)
        {
            labelX_0 = labelX_7;
        }

        internal virtual LabelX vmethod_4()
        {
            LabelX labelX;

            return labelX_1;
        }

        internal virtual void vmethod_5(LabelX labelX_7)
        {
            labelX_1 = labelX_7;
        }

        internal virtual LabelX vmethod_6()
        {
            LabelX labelX;

            return labelX_2;
        }

        internal virtual void vmethod_7(LabelX labelX_7)
        {
            labelX_2 = labelX_7;
        }

        internal virtual Timer vmethod_8()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual void vmethod_9(Timer timer_1)
        {
            EventHandler eventHandler = new EventHandler(method_0);
            if (timer_0 != null)
                timer_0.Tick -= eventHandler;
            timer_0 = timer_1;
            if (timer_0 != null)
                timer_0.Tick += eventHandler;
        }

    } // class MapTeleport

}

