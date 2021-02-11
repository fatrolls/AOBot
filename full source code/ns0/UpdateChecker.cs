using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class UpdateChecker : MetroForm
    {

        [AccessedThroughProperty("updateCheckProgress")]
        private CircularProgress circularProgress_0;
        private GClass44 gclass44_0;
        private IContainer icontainer_0;
        [AccessedThroughProperty("LabelX1")]
        private LabelX labelX_0;
        [AccessedThroughProperty("lblInform")]
        private LabelX labelX_1;
        [AccessedThroughProperty("ProgressTimer")]
        private Timer timer_0;

        public UpdateChecker()
        {
            Load += new EventHandler(UpdateChecker_Load);
            Shown += new EventHandler(UpdateChecker_Shown);
            InitializeComponent();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Padding padding2;
            Point point2;

            icontainer_0 = new Container();
            vmethod_1(new LabelX());
            vmethod_3(new CircularProgress());
            vmethod_5(new Timer(icontainer_0));
            vmethod_7(new LabelX());
            SuspendLayout();
            vmethod_0().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_0().Font = new Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Point point1 = new Point(13, 14);
            vmethod_0().Location = point1;
            Padding padding1 = new Padding(4, 5, 4, 5);
            vmethod_0().Margin = padding1;
            vmethod_0().Name = "LabelX1";
            Size size = new Size(365, 34);
            vmethod_0().Size = size;
            vmethod_0().TabIndex = 0;
            vmethod_0().Text = "CHECKING FOR UPDATE";
            vmethod_0().TextAlignment = StringAlignment.Center;
            vmethod_2().BackgroundStyle.CornerType = eCornerType.Square;
            point1 = new Point(12, 62);
            vmethod_2().Location = point1;
            vmethod_2().Name = "updateCheckProgress";
            vmethod_2().ProgressBarType = eCircularProgressType.Dot;
            vmethod_2().ProgressColor = Color.FromArgb(255, 128, 0);
            size = new Size(366, 87);
            vmethod_2().Size = size;
            vmethod_2().Style = eDotNetBarStyle.OfficeXP;
            vmethod_2().TabIndex = 1;
            vmethod_2().Value = 100;
            vmethod_4().Interval = 20;
            vmethod_6().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_6().Font = new Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point1 = new Point(13, 81);
            vmethod_6().Location = point1;
            padding1 = new Padding(4, 5, 4, 5);
            vmethod_6().Margin = padding1;
            vmethod_6().Name = "lblInform";
            size = new Size(365, 34);
            vmethod_6().Size = size;
            vmethod_6().TabIndex = 2;
            vmethod_6().TextAlignment = StringAlignment.Center;
            vmethod_6().Visible = false;
            SizeF sizeF = new SizeF(9.0F, 21.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(391, 196);
            ClientSize = size;
            Controls.Add(vmethod_6());
            Controls.Add(vmethod_2());
            Controls.Add(vmethod_0());
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            padding1 = new Padding(4, 5, 4, 5);
            Margin = padding1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateChecker";
            ShowIcon = false;
            Text = "UpdateChecker";
            ResumeLayout(false);
        }

        private void method_0(object sender, EventArgs e)
        {
            if (vmethod_2().Value == 100)
                vmethod_2().Value = 1;
            CircularProgress circularProgress = vmethod_2();
            circularProgress.Value = checked(circularProgress.Value + 1);
        }

        private void UpdateChecker_Load(object sender, EventArgs e)
        {
        }

        private void UpdateChecker_Shown(object sender, EventArgs e)
        {
            vmethod_4().Enabled = true;
            NetTcpBinding netTcpBinding = new NetTcpBinding();
            netTcpBinding.Security.Mode = SecurityMode.None;
            EndpointAddress endpointAddress = new EndpointAddress(new Uri("net.tcp://192.3.13.100:8740/UpdateService"), new AddressHeader[0]);
            gclass44_0 = new GClass44(netTcpBinding, endpointAddress);
            gclass44_0.get_ChannelFactory().Open();
            object obj = gclass44_0.CheckUpdate("200");
            if (obj != null)
            {
                vmethod_2().Visible = false;
                vmethod_4().Enabled = false;
                vmethod_6().Visible = true;
                vmethod_6().Text = Conversions.ToString(Interaction.IIf(Conversions.ToBoolean(obj), "Update Availible", "No Update Found"));
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

        internal virtual LabelX vmethod_0()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual void vmethod_1(LabelX labelX_2)
        {
            labelX_0 = labelX_2;
        }

        internal virtual CircularProgress vmethod_2()
        {
            CircularProgress circularProgress;

            return circularProgress_0;
        }

        internal virtual void vmethod_3(CircularProgress circularProgress_1)
        {
            circularProgress_0 = circularProgress_1;
        }

        internal virtual Timer vmethod_4()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual void vmethod_5(Timer timer_1)
        {
            EventHandler eventHandler = new EventHandler(method_0);
            if (timer_0 != null)
                timer_0.Tick -= eventHandler;
            timer_0 = timer_1;
            if (timer_0 != null)
                timer_0.Tick += eventHandler;
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

    } // class UpdateChecker

}

