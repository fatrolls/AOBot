using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class ErrorForm : MetroForm
    {

        [AccessedThroughProperty("ButtonX1")]
        private ButtonX buttonX_0;
        private IContainer icontainer_0;
        [AccessedThroughProperty("ErrorMessages")]
        private LabelX labelX_0;

        public ErrorForm()
        {
            Load += new EventHandler(ErrorForm_Load);
            InitializeComponent();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Point point2;

            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ErrorForm));
            vmethod_1(new ButtonX());
            vmethod_3(new LabelX());
            SuspendLayout();
            vmethod_0().AccessibleRole = AccessibleRole.PushButton;
            vmethod_0().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_0().Font = new Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Point point1 = new Point(98, 83);
            vmethod_0().Location = point1;
            vmethod_0().Name = "ButtonX1";
            Size size = new Size(119, 31);
            vmethod_0().Size = size;
            vmethod_0().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_0().TabIndex = 0;
            vmethod_0().Text = "OK";
            vmethod_2().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_2().Font = new Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            point1 = new Point(14, 13);
            vmethod_2().Location = point1;
            vmethod_2().Name = "ErrorMessages";
            size = new Size(286, 64);
            vmethod_2().Size = size;
            vmethod_2().Style = eDotNetBarStyle.Metro;
            vmethod_2().TabIndex = 1;
            vmethod_2().TextAlignment = StringAlignment.Center;
            vmethod_2().WordWrap = true;
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(314, 123);
            ClientSize = size;
            Controls.Add(vmethod_2());
            Controls.Add(vmethod_0());
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ErrorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Error";
            ResumeLayout(false);
        }

        private void method_0(object sender, EventArgs e)
        {
            base.Dispose();
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
            EventHandler eventHandler = new EventHandler(method_0);
            if (buttonX_0 != null)
                buttonX_0.Click -= eventHandler;
            buttonX_0 = buttonX_1;
            if (buttonX_0 != null)
                buttonX_0.Click += eventHandler;
        }

        internal virtual LabelX vmethod_2()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual void vmethod_3(LabelX labelX_1)
        {
            labelX_0 = labelX_1;
        }

    } // class ErrorForm

}

