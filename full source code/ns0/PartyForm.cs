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
using Microsoft.VisualBasic.CompilerServices;
using Ultimate_Bot_Reloaded.PartyFunctions;

namespace ns0
{

    [DesignerGenerated]
    public sealed class PartyForm : MetroForm
    {

        [CompilerGenerated]
        internal sealed class Class16
        {

            public ListViewItem listViewItem_0;
            public ListViewItem listViewItem_1;

            public Class16(PartyForm.Class16 class16_0)
            {
                if (class16_0 != null)
                {
                    listViewItem_0 = class16_0.listViewItem_0;
                    listViewItem_1 = class16_0.listViewItem_1;
                }
            }

            [CompilerGenerated]
            public bool method_0(GClass28.GClass29 gclass29_0)
            {
                return Operators.CompareString(gclass29_0.method_0(), listViewItem_1.Text, false) == 0;
            }

            [CompilerGenerated]
            public bool method_1(GClass28.GClass29 gclass29_0)
            {
                return Operators.CompareString(gclass29_0.method_4(), listViewItem_0.Text, false) == 0;
            }

            [CompilerGenerated]
            public bool method_2(GClass28.GClass29 gclass29_0)
            {
                return (Operators.CompareString(gclass29_0.method_0(), listViewItem_1.Text, false) == 0) & (gclass29_0.method_2() == PartyCode.Leader);
            }

            [CompilerGenerated]
            public bool method_3(GClass28.GClass29 gclass29_0)
            {
                return Operators.CompareString(gclass29_0.method_4(), listViewItem_1.Text, false) == 0;
            }

            [CompilerGenerated]
            public bool method_4(GClass28.GClass29 gclass29_0)
            {
                return (Operators.CompareString(gclass29_0.method_0(), listViewItem_1.Text, false) == 0) & (gclass29_0.method_4() != null);
            }

            [CompilerGenerated]
            public bool method_5(GClass28.GClass29 gclass29_0)
            {
                return (Operators.CompareString(gclass29_0.method_0(), listViewItem_1.Text, false) == 0) & (gclass29_0.method_2() == PartyCode.Leader);
            }

        } // class Class16

        [CompilerGenerated]
        internal sealed class Class17
        {

            public GClass28.GClass29 gclass29_0;

            public Class17()
            {
            }

            [CompilerGenerated]
            public bool method_0(GClass28.GClass29 gclass29_1)
            {
                return Operators.CompareString(gclass29_1.method_4(), gclass29_0.method_0(), false) == 0;
            }

            [CompilerGenerated]
            public bool method_1(GClass28.GClass29 gclass29_1)
            {
                return Operators.CompareString(gclass29_1.method_4(), gclass29_0.method_4(), false) == 0;
            }

            [CompilerGenerated]
            public bool method_2(GClass28.GClass29 gclass29_1)
            {
                return Operators.CompareString(gclass29_1.method_0(), gclass29_0.method_4(), false) == 0;
            }

        } // class Class17

        [AccessedThroughProperty("Bar1")]
        private Bar bar_0;
        [AccessedThroughProperty("btnClose")]
        private ButtonItem buttonItem_0;
        [AccessedThroughProperty("saveButton")]
        private ButtonX buttonX_0;
        [AccessedThroughProperty("btnDisbandParty")]
        private ButtonX buttonX_1;
        [AccessedThroughProperty("headName")]
        private ColumnHeader columnHeader_0;
        [AccessedThroughProperty("headLeader")]
        private ColumnHeader columnHeader_1;
        [AccessedThroughProperty("headVariable")]
        private ColumnHeader columnHeader_2;
        [AccessedThroughProperty("cmbLeader")]
        private ComboBoxEx comboBoxEx_0;
        [AccessedThroughProperty("cmbFollower")]
        private ComboBoxEx comboBoxEx_1;
        private IContainer icontainer_0;
        [AccessedThroughProperty("LabelX1")]
        private LabelX labelX_0;
        [AccessedThroughProperty("LabelX2")]
        private LabelX labelX_1;
        [AccessedThroughProperty("partyList")]
        private ListViewEx listViewEx_0;
        [AccessedThroughProperty("partyUpdate")]
        private Timer timer_0;

        public PartyForm()
        {
            Load += new EventHandler(PartyForm_Load);
            InitializeComponent();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;

            icontainer_0 = new Container();
            vmethod_1(new ListViewEx());
            vmethod_17(new ColumnHeader());
            vmethod_19(new ColumnHeader());
            vmethod_21(new ColumnHeader());
            vmethod_3(new LabelX());
            vmethod_5(new ComboBoxEx());
            vmethod_7(new ComboBoxEx());
            vmethod_9(new LabelX());
            vmethod_11(new ButtonX());
            vmethod_13(new ButtonX());
            vmethod_15(new Timer(icontainer_0));
            vmethod_23(new Bar());
            vmethod_25(new ButtonItem());
            vmethod_22().BeginInit();
            SuspendLayout();
            vmethod_0().BackColor = Color.Black;
            vmethod_0().Border.Class = "CrumbBarBackgroundKey";
            vmethod_0().Border.CornerType = eCornerType.Square;
            ColumnHeader[] columnHeaderArr = new ColumnHeader[] {
                                                                  vmethod_16(), 
                                                                  vmethod_18(), 
                                                                  vmethod_20() };
            vmethod_0().Columns.AddRange(columnHeaderArr);
            vmethod_0().ForeColor = Color.White;
            vmethod_0().FullRowSelect = true;
            vmethod_0().HideSelection = false;
            Point point = new Point(27, 81);
            vmethod_0().Location = point;
            vmethod_0().MultiSelect = false;
            vmethod_0().Name = "partyList";
            Size size = new Size(430, 258);
            vmethod_0().Size = size;
            vmethod_0().TabIndex = 0;
            vmethod_0().UseCompatibleStateImageBehavior = false;
            vmethod_0().View = View.Details;
            vmethod_16().Text = "Name";
            vmethod_16().Width = 134;
            vmethod_18().Text = "Leader";
            vmethod_18().Width = 134;
            vmethod_20().Text = "Variable";
            vmethod_20().Width = 161;
            vmethod_2().BackColor = Color.Black;
            vmethod_2().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_2().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_2().ForeColor = Color.White;
            point = new Point(28, 33);
            vmethod_2().Location = point;
            vmethod_2().Name = "LabelX1";
            size = new Size(40, 14);
            vmethod_2().Size = size;
            vmethod_2().TabIndex = 1;
            vmethod_2().Text = "Leader";
            vmethod_4().DisplayMember = "Text";
            vmethod_4().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_4().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_4().ForeColor = Color.White;
            vmethod_4().FormattingEnabled = true;
            vmethod_4().ItemHeight = 16;
            point = new Point(27, 51);
            vmethod_4().Location = point;
            vmethod_4().Name = "cmbLeader";
            size = new Size(170, 22);
            vmethod_4().Size = size;
            vmethod_4().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_4().TabIndex = 2;
            vmethod_6().DisplayMember = "Text";
            vmethod_6().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_6().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_6().ForeColor = Color.White;
            vmethod_6().FormattingEnabled = true;
            vmethod_6().ItemHeight = 16;
            point = new Point(203, 51);
            vmethod_6().Location = point;
            vmethod_6().Name = "cmbFollower";
            size = new Size(152, 22);
            vmethod_6().Size = size;
            vmethod_6().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_6().TabIndex = 4;
            vmethod_8().BackColor = Color.Black;
            vmethod_8().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_8().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_8().ForeColor = Color.White;
            point = new Point(203, 33);
            vmethod_8().Location = point;
            vmethod_8().Name = "LabelX2";
            size = new Size(52, 14);
            vmethod_8().Size = size;
            vmethod_8().TabIndex = 3;
            vmethod_8().Text = "Follower";
            vmethod_10().AccessibleRole = AccessibleRole.PushButton;
            vmethod_10().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_10().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(361, 51);
            vmethod_10().Location = point;
            vmethod_10().Name = "saveButton";
            vmethod_10().RightToLeft = RightToLeft.No;
            size = new Size(96, 22);
            vmethod_10().Size = size;
            vmethod_10().Style = eDotNetBarStyle.Metro;
            vmethod_10().TabIndex = 37;
            vmethod_10().Text = "ADD TO PARTY";
            vmethod_12().AccessibleRole = AccessibleRole.PushButton;
            vmethod_12().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_12().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(354, 345);
            vmethod_12().Location = point;
            vmethod_12().Name = "btnDisbandParty";
            vmethod_12().RightToLeft = RightToLeft.No;
            size = new Size(103, 22);
            vmethod_12().Size = size;
            vmethod_12().Style = eDotNetBarStyle.Metro;
            vmethod_12().TabIndex = 38;
            vmethod_12().Text = "DISBAND PARTY";
            vmethod_14().Enabled = true;
            vmethod_22().AntiAlias = true;
            vmethod_22().Dock = DockStyle.Top;
            vmethod_22().Font = new Font("Segoe UI", 9.0F);
            BaseItem[] baseItemArr = new BaseItem[] { vmethod_24() };
            vmethod_22().Items.AddRange(baseItemArr);
            point = new Point(0, 0);
            vmethod_22().Location = point;
            vmethod_22().Name = "Bar1";
            size = new Size(484, 20);
            vmethod_22().Size = size;
            vmethod_22().Stretch = true;
            vmethod_22().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_22().TabIndex = 39;
            vmethod_22().TabStop = false;
            vmethod_22().Text = "Bar1";
            vmethod_24().ItemAlignment = eItemAlignment.Far;
            vmethod_24().Name = "btnClose";
            vmethod_24().Symbol = "";
            vmethod_24().SymbolSize = 10.0F;
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(484, 392);
            ClientSize = size;
            Controls.Add(vmethod_22());
            Controls.Add(vmethod_12());
            Controls.Add(vmethod_10());
            Controls.Add(vmethod_6());
            Controls.Add(vmethod_8());
            Controls.Add(vmethod_4());
            Controls.Add(vmethod_2());
            Controls.Add(vmethod_0());
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PartyForm";
            Text = "PartyForm";
            vmethod_22().EndInit();
            ResumeLayout(false);
        }

        private void method_0(object sender, EventArgs e)
        {
            if (((vmethod_4().SelectedItem == null) & (vmethod_6().SelectedItem == null)))
                return;
            if (Operators.CompareString(vmethod_6().SelectedItem.ToString(), vmethod_4().SelectedItem.ToString(), false) == 0)
                return;
            IEnumerable<GClass28.GClass29> ienumerable = Enumerable.Where<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_4));
            if (Enumerable.Count<GClass28.GClass29>(ienumerable) == 3)
                return;
            GClass28.GClass29 gclass29_2 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_5));
            if (((gclass29_2.method_2() == PartyCode.Leader) & (Enumerable.Count<GClass28.GClass29>(ienumerable) == 3)))
                return;
            gclass29_2 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_6));
            if (gclass29_2.method_2() == PartyCode.Leader)
                return;
            GClass28.GClass29 gclass29_1 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_7));
            if (gclass29_1.method_2() != PartyCode.Follower)
            {
                gclass29_1.method_5(Conversions.ToString(vmethod_4().SelectedItem));
                gclass29_1.method_3(PartyCode.Follower);
            }
            GClass28.GClass29 gclass29_3 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_8));
            if (gclass29_3.method_2() != PartyCode.Leader)
                gclass29_3.method_3(PartyCode.Leader);
        }

        private void method_1(object sender, EventArgs e)
        {
            // decompiler error
        }

        private void method_2(object sender, EventArgs e)
        {
            IEnumerator<GClass28.GClass29> ienumerator;
            IEnumerator<GClass28.GClass29> ienumerator1;

            if (vmethod_0().SelectedItems.Count > 0)
            {
                PartyForm.Class17 class17 = new PartyForm.Class17();
                class17.gclass29_0 = Enumerable.FirstOrDefault<GClass28.GClass29>((PartyCode)GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(method_9));
                if (class17.gclass29_0 != null)
                {
                    if (class17.gclass29_0.method_2() == PartyCode.Leader)
                    {
                        IEnumerable<GClass28.GClass29> ienumerable1 = Enumerable.Where<GClass28.GClass29>((PartyCode)GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(class17, class17.method_0));
                        try
                        {
                            ienumerator1 = ienumerable1.GetEnumerator();
                            while (ienumerator1.MoveNext())
                            {
                                GClass28.GClass29 gclass29_1 = ienumerator1.get_Current();
                                gclass29_1.method_3(PartyCode.None);
                                gclass29_1.method_5(Conversions.ToString(2));
                            }
                        }
                        finally
                        {
                            if (ienumerator1 != null)
                                ienumerator1.Dispose();
                        }
                        class17.gclass29_0.method_3(PartyCode.None);
                        class17.gclass29_0.method_5(Conversions.ToString(2));
                    }
                    if (class17.gclass29_0.method_2() == PartyCode.Follower)
                    {
                        IEnumerable<GClass28.GClass29> ienumerable = Enumerable.Where<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(class17, class17.method_1));
                        GClass28.GClass29 gclass29_2 = Enumerable.FirstOrDefault<GClass28.GClass29>(GClass28.hashSet_0, new Func<GClass28.GClass29,bool>(class17, class17.method_2));
                        gclass29_2.method_3(PartyCode.None);
                        gclass29_2.method_5(Conversions.ToString(2));
                        try
                        {
                            ienumerator = ienumerable.GetEnumerator();
                            while (ienumerator.MoveNext())
                            {
                                GClass28.GClass29 gclass29_3 = ienumerator.get_Current();
                                gclass29_3.method_3(PartyCode.None);
                                gclass29_3.method_5(Conversions.ToString(2));
                            }
                        }
                        finally
                        {
                            if (ienumerator != null)
                                ienumerator.Dispose();
                        }
                        class17.gclass29_0.method_3(PartyCode.None);
                        class17.gclass29_0.method_5(Conversions.ToString(2));
                    }
                }
            }
        }

        private void method_3(object sender, EventArgs e)
        {
            BotForm.slidePanel_1.Visible = false;
            BotForm.slidePanel_1.IsOpen = false;
        }

        [CompilerGenerated]
        private bool method_4(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_4(), vmethod_4().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_5(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), vmethod_4().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_6(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), vmethod_6().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_7(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), vmethod_6().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_8(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), vmethod_4().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_9(GClass28.GClass29 gclass29_0)
        {
            return Operators.CompareString(gclass29_0.method_0(), vmethod_0().SelectedItems[0].Text, false) == 0;
        }

        private void PartyForm_Load(object sender, EventArgs e)
        {
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

        internal virtual ListViewEx vmethod_0()
        {
            ListViewEx listViewEx;

            return listViewEx_0;
        }

        internal virtual void vmethod_1(ListViewEx listViewEx_1)
        {
            listViewEx_0 = listViewEx_1;
        }

        internal virtual ButtonX vmethod_10()
        {
            ButtonX buttonX;

            return buttonX_0;
        }

        internal virtual void vmethod_11(ButtonX buttonX_2)
        {
            EventHandler eventHandler = new EventHandler(method_0);
            if (buttonX_0 != null)
                buttonX_0.Click -= eventHandler;
            buttonX_0 = buttonX_2;
            if (buttonX_0 != null)
                buttonX_0.Click += eventHandler;
        }

        internal virtual ButtonX vmethod_12()
        {
            ButtonX buttonX;

            return buttonX_1;
        }

        internal virtual void vmethod_13(ButtonX buttonX_2)
        {
            EventHandler eventHandler = new EventHandler(method_2);
            if (buttonX_1 != null)
                buttonX_1.Click -= eventHandler;
            buttonX_1 = buttonX_2;
            if (buttonX_1 != null)
                buttonX_1.Click += eventHandler;
        }

        internal virtual Timer vmethod_14()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual void vmethod_15(Timer timer_1)
        {
            EventHandler eventHandler = new EventHandler(method_1);
            if (timer_0 != null)
                timer_0.Tick -= eventHandler;
            timer_0 = timer_1;
            if (timer_0 != null)
                timer_0.Tick += eventHandler;
        }

        internal virtual ColumnHeader vmethod_16()
        {
            ColumnHeader columnHeader;

            return columnHeader_0;
        }

        internal virtual void vmethod_17(ColumnHeader columnHeader_3)
        {
            columnHeader_0 = columnHeader_3;
        }

        internal virtual ColumnHeader vmethod_18()
        {
            ColumnHeader columnHeader;

            return columnHeader_1;
        }

        internal virtual void vmethod_19(ColumnHeader columnHeader_3)
        {
            columnHeader_1 = columnHeader_3;
        }

        internal virtual LabelX vmethod_2()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual ColumnHeader vmethod_20()
        {
            ColumnHeader columnHeader;

            return columnHeader_2;
        }

        internal virtual void vmethod_21(ColumnHeader columnHeader_3)
        {
            columnHeader_2 = columnHeader_3;
        }

        internal virtual Bar vmethod_22()
        {
            Bar bar;

            return bar_0;
        }

        internal virtual void vmethod_23(Bar bar_1)
        {
            bar_0 = bar_1;
        }

        internal virtual ButtonItem vmethod_24()
        {
            ButtonItem buttonItem;

            return buttonItem_0;
        }

        internal virtual void vmethod_25(ButtonItem buttonItem_1)
        {
            EventHandler eventHandler = new EventHandler(method_3);
            if (buttonItem_0 != null)
                buttonItem_0.Click -= eventHandler;
            buttonItem_0 = buttonItem_1;
            if (buttonItem_0 != null)
                buttonItem_0.Click += eventHandler;
        }

        internal virtual void vmethod_3(LabelX labelX_2)
        {
            labelX_0 = labelX_2;
        }

        internal virtual ComboBoxEx vmethod_4()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_0;
        }

        internal virtual void vmethod_5(ComboBoxEx comboBoxEx_2)
        {
            comboBoxEx_0 = comboBoxEx_2;
        }

        internal virtual ComboBoxEx vmethod_6()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_1;
        }

        internal virtual void vmethod_7(ComboBoxEx comboBoxEx_2)
        {
            comboBoxEx_1 = comboBoxEx_2;
        }

        internal virtual LabelX vmethod_8()
        {
            LabelX labelX;

            return labelX_1;
        }

        internal virtual void vmethod_9(LabelX labelX_2)
        {
            labelX_1 = labelX_2;
        }

    } // class PartyForm

}

