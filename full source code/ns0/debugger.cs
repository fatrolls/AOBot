using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class debugger : MetroForm
    {

        private IContainer icontainer_0;
        [AccessedThroughProperty("debugText")]
        private RichTextBoxEx richTextBoxEx_0;

        public debugger()
        {
            Load += new EventHandler(debugger_Load);
            InitializeComponent();
        }

        private void debugger_Load(object sender, EventArgs e)
        {
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Point point2;

            vmethod_1(new RichTextBoxEx());
            SuspendLayout();
            vmethod_0().BackgroundStyle.Class = "RichTextBoxBorder";
            vmethod_0().BackgroundStyle.CornerType = eCornerType.Square;
            Point point1 = new Point(6, 8);
            vmethod_0().Location = point1;
            vmethod_0().Name = "debugText";
            vmethod_0().Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\r\n{\\colortbl ;\\red255\\green255\\blue255;}\r\n\\viewkind4\\uc1\\pard\\cf1\\f0\\fs17\\par\r\n}\r\n";
            Size size = new Size(481, 298);
            vmethod_0().Size = size;
            vmethod_0().TabIndex = 0;
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(492, 314);
            ClientSize = size;
            Controls.Add(vmethod_0());
            DoubleBuffered = true;
            Name = "debugger";
            Text = "Ultimate Bot Debugger";
            ResumeLayout(false);
        }

        public void method_0(string string_0, string string_1, bool bool_0)
        {
            if (bool_0)
            {
                RichTextBoxEx richTextBoxEx = vmethod_0();
                richTextBoxEx.Text = richTextBoxEx.Text + "[" + string_0 + "] " + string_1 + "\r\n";
            }
            else
            {
                vmethod_0().Text = "";
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

        internal virtual RichTextBoxEx vmethod_0()
        {
            RichTextBoxEx richTextBoxEx;

            return richTextBoxEx_0;
        }

        internal virtual void vmethod_1(RichTextBoxEx richTextBoxEx_1)
        {
            richTextBoxEx_0 = richTextBoxEx_1;
        }

    } // class debugger

}

