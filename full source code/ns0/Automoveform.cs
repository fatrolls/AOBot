using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class Automoveform : MetroForm
    {

        private Bot bot_0;
        [AccessedThroughProperty("saveButton")]
        private ButtonX buttonX_0;
        [AccessedThroughProperty("ButtonX1")]
        private ButtonX buttonX_1;
        public GClass0 gclass0_0;
        private GClass22 gclass22_0;
        private GClass26 gclass26_0;
        private GClass4 gclass4_0;
        private IContainer icontainer_0;
        [AccessedThroughProperty("LabelX1")]
        private LabelX labelX_0;
        [AccessedThroughProperty("checkAutomove")]
        private Timer timer_0;

        public Automoveform(Bot bot_1, GClass22 gclass22_1, GClass26 gclass26_1, GClass4 gclass4_1)
        {
            Load += new EventHandler(Automoveform_Load);
            InitializeComponent();
            bot_0 = bot_1;
            gclass22_0 = gclass22_1;
            gclass26_0 = gclass26_1;
            gclass4_0 = gclass4_1;
            bot_0.bool_0 = true;
            gclass0_0 = new GClass0(bot_0, gclass26_0, gclass22_0, gclass4_0);
            vmethod_6().Enabled = true;
        }

        private void Automoveform_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;

            icontainer_0 = new Container();
            vmethod_1(new LabelX());
            vmethod_3(new ButtonX());
            vmethod_5(new ButtonX());
            vmethod_7(new Timer(icontainer_0));
            SuspendLayout();
            vmethod_0().AutoSize = true;
            vmethod_0().BackColor = Color.Black;
            vmethod_0().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_0().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_0().ForeColor = Color.White;
            Point point = new Point(82, 31);
            vmethod_0().Location = point;
            vmethod_0().Name = "LabelX1";
            Size size = new Size(301, 17);
            vmethod_0().Size = size;
            vmethod_0().TabIndex = 0;
            vmethod_0().Text = "AUTO-MOVE DETECTED WOULD YOU LIKE TO TELEPORT ";
            vmethod_2().AccessibleRole = AccessibleRole.PushButton;
            vmethod_2().BackColor = Color.FromArgb(45, 137, 239);
            vmethod_2().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_2().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(132, 71);
            vmethod_2().Location = point;
            vmethod_2().Name = "saveButton";
            vmethod_2().RightToLeft = RightToLeft.No;
            size = new Size(90, 22);
            vmethod_2().Size = size;
            vmethod_2().Style = eDotNetBarStyle.Metro;
            vmethod_2().TabIndex = 37;
            vmethod_2().Text = "TELEPORT";
            vmethod_4().AccessibleRole = AccessibleRole.PushButton;
            vmethod_4().BackColor = Color.FromArgb(45, 137, 239);
            vmethod_4().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_4().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(243, 71);
            vmethod_4().Location = point;
            vmethod_4().Name = "ButtonX1";
            vmethod_4().RightToLeft = RightToLeft.No;
            size = new Size(90, 22);
            vmethod_4().Size = size;
            vmethod_4().Style = eDotNetBarStyle.Metro;
            vmethod_4().TabIndex = 38;
            vmethod_4().Text = "CANCEL";
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(465, 138);
            ClientSize = size;
            ControlBox = false;
            Controls.Add(vmethod_4());
            Controls.Add(vmethod_2());
            Controls.Add(vmethod_0());
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Automoveform";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Auto-Move Teleport";
            ResumeLayout(false);
            PerformLayout();
        }

        private void method_0(object sender, EventArgs e)
        {
            if (Visible && (gclass22_0.method_3(checked((int)gclass26_0.long_57), 1) == 0L))
                Hide();
        }

        private void method_1(object sender, EventArgs e)
        {
            if (gclass22_0.method_3(checked((int)gclass26_0.long_57), 1) == 1L)
            {
                Thread thread = new Thread(new ThreadStart(method_3));
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void method_2(object sender, EventArgs e)
        {
            Hide();
        }

        [CompilerGenerated]
        private void method_3()
        {
            gclass0_0.method_3(checked((int)gclass22_0.method_3(checked((int)gclass26_0.long_50), 2)), checked((int)gclass22_0.method_3(checked((int)gclass26_0.long_51), 2)), checked((int)gclass22_0.method_3(checked((int)gclass26_0.long_52), 2)));
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

        internal virtual void vmethod_1(LabelX labelX_1)
        {
            labelX_0 = labelX_1;
        }

        internal virtual ButtonX vmethod_2()
        {
            ButtonX buttonX;

            return buttonX_0;
        }

        internal virtual void vmethod_3(ButtonX buttonX_2)
        {
            EventHandler eventHandler = new EventHandler(method_1);
            if (buttonX_0 != null)
                buttonX_0.Click -= eventHandler;
            buttonX_0 = buttonX_2;
            if (buttonX_0 != null)
                buttonX_0.Click += eventHandler;
        }

        internal virtual ButtonX vmethod_4()
        {
            ButtonX buttonX;

            return buttonX_1;
        }

        internal virtual void vmethod_5(ButtonX buttonX_2)
        {
            EventHandler eventHandler = new EventHandler(method_2);
            if (buttonX_1 != null)
                buttonX_1.Click -= eventHandler;
            buttonX_1 = buttonX_2;
            if (buttonX_1 != null)
                buttonX_1.Click += eventHandler;
        }

        internal virtual Timer vmethod_6()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual void vmethod_7(Timer timer_1)
        {
            EventHandler eventHandler = new EventHandler(method_0);
            if (timer_0 != null)
                timer_0.Tick -= eventHandler;
            timer_0 = timer_1;
            if (timer_0 != null)
                timer_0.Tick += eventHandler;
        }

    } // class Automoveform

}

