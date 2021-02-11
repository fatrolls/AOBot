using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;
using DevComponents.Editors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class Login : MetroForm
    {

        public delegate void GDelegate1(string message);
        public delegate void GDelegate2();
        public delegate void GDelegate3();
        public delegate void GDelegate4(bool value);
        public delegate void GDelegate5(string messags);

        [AccessedThroughProperty("loginbtn")]
        private ButtonX buttonX_0;
        [AccessedThroughProperty("chkCredental")]
        private CheckBoxX checkBoxX_0;
        [AccessedThroughProperty("chkCredentals")]
        private CheckBoxX checkBoxX_1;
        [AccessedThroughProperty("cmbRegion")]
        private ComboBoxEx comboBoxEx_0;
        [AccessedThroughProperty("INT")]
        private ComboItem comboItem_0;
        [AccessedThroughProperty("ComboItem2")]
        private ComboItem comboItem_1;
        [AccessedThroughProperty("ComboItem99")]
        private ComboItem comboItem_10;
        [AccessedThroughProperty("ComboItem100")]
        private ComboItem comboItem_11;
        [AccessedThroughProperty("ComboItem101")]
        private ComboItem comboItem_12;
        [AccessedThroughProperty("ComboItem102")]
        private ComboItem comboItem_13;
        [AccessedThroughProperty("ComboItem103")]
        private ComboItem comboItem_14;
        [AccessedThroughProperty("ComboItem104")]
        private ComboItem comboItem_15;
        [AccessedThroughProperty("ComboItem16")]
        private ComboItem comboItem_16;
        [AccessedThroughProperty("ComboItem18")]
        private ComboItem comboItem_17;
        [AccessedThroughProperty("ComboItem17")]
        private ComboItem comboItem_18;
        [AccessedThroughProperty("ComboItem19")]
        private ComboItem comboItem_19;
        [AccessedThroughProperty("ComboItem3")]
        private ComboItem comboItem_2;
        [AccessedThroughProperty("ComboItem1")]
        private ComboItem comboItem_20;
        [AccessedThroughProperty("ComboItem92")]
        private ComboItem comboItem_3;
        [AccessedThroughProperty("ComboItem93")]
        private ComboItem comboItem_4;
        [AccessedThroughProperty("ComboItem94")]
        private ComboItem comboItem_5;
        [AccessedThroughProperty("ComboItem95")]
        private ComboItem comboItem_6;
        [AccessedThroughProperty("ComboItem96")]
        private ComboItem comboItem_7;
        [AccessedThroughProperty("ComboItem97")]
        private ComboItem comboItem_8;
        [AccessedThroughProperty("ComboItem98")]
        private ComboItem comboItem_9;
        private GClass43 gclass43_0;
        private GClass44 gclass44_0;
        private IContainer icontainer_0;
        private int int_0;
        [AccessedThroughProperty("LabelX4")]
        private LabelX labelX_0;
        [AccessedThroughProperty("LabelX5")]
        private LabelX labelX_1;
        [AccessedThroughProperty("LabelX6")]
        private LabelX labelX_2;
        [AccessedThroughProperty("LabelX1")]
        private LabelX labelX_3;
        [AccessedThroughProperty("PanelEx1")]
        private PanelEx panelEx_0;
        [AccessedThroughProperty("loginProgress")]
        private ProgressBarX progressBarX_0;
        public string string_0;
        [AccessedThroughProperty("txtPassword")]
        private TextBoxX textBoxX_0;
        [AccessedThroughProperty("txtUsernam")]
        private TextBoxX textBoxX_1;
        [AccessedThroughProperty("PingTimer")]
        private Timer timer_0;
        [AccessedThroughProperty("WebBrowser1")]
        private WebBrowser webBrowser_0;

        public static Socket socket_0;
        public static string string_1;

        public Login()
        {
            Disposed += new EventHandler(Login_Disposed);
            Load += new EventHandler(Login_Load);
            Shown += new EventHandler(Login_Shown);
            int_0 = 2;
            InitializeComponent();
        }

        static Login()
        {
            Login.string_1 = Application.StartupPath + "\\settings.ini";
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;

            icontainer_0 = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Login));
            vmethod_9(new CheckBoxX());
            vmethod_1(new ComboItem());
            vmethod_3(new ComboItem());
            vmethod_5(new ComboItem());
            vmethod_7(new ProgressBarX());
            vmethod_11(new ComboItem());
            vmethod_13(new ComboItem());
            vmethod_15(new ComboItem());
            vmethod_17(new ComboItem());
            vmethod_19(new ComboItem());
            vmethod_21(new ComboItem());
            vmethod_23(new ComboItem());
            vmethod_25(new ComboItem());
            vmethod_27(new ComboItem());
            vmethod_29(new ComboItem());
            vmethod_31(new ComboItem());
            vmethod_33(new ComboItem());
            vmethod_35(new ComboItem());
            vmethod_37(new Timer(icontainer_0));
            vmethod_39(new WebBrowser());
            vmethod_41(new PanelEx());
            vmethod_43(new CheckBoxX());
            vmethod_45(new ComboBoxEx());
            vmethod_47(new ComboItem());
            vmethod_49(new ComboItem());
            vmethod_51(new ComboItem());
            vmethod_53(new ComboItem());
            vmethod_55(new TextBoxX());
            vmethod_57(new TextBoxX());
            vmethod_59(new LabelX());
            vmethod_61(new LabelX());
            vmethod_63(new LabelX());
            vmethod_65(new ButtonX());
            vmethod_67(new LabelX());
            vmethod_69(new ComboItem());
            vmethod_40().SuspendLayout();
            SuspendLayout();
            vmethod_8().BackgroundStyle.CornerType = eCornerType.Square;
            componentResourceManager.ApplyResources(vmethod_8(), "chkCredental");
            vmethod_8().Name = "chkCredental";
            vmethod_8().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_0().BackColor = Color.Black;
            componentResourceManager.ApplyResources(vmethod_0(), "INT");
            componentResourceManager.ApplyResources(vmethod_2(), "ComboItem2");
            componentResourceManager.ApplyResources(vmethod_4(), "ComboItem3");
            vmethod_6().BackColor = Color.Black;
            vmethod_6().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_6().BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
            vmethod_6().BackgroundStyle.TextColor = Color.FromArgb(255, 255, 255);
            vmethod_6().ForeColor = Color.White;
            componentResourceManager.ApplyResources(vmethod_6(), "loginProgress");
            vmethod_6().Name = "loginProgress";
            vmethod_6().Style = eDotNetBarStyle.Metro;
            vmethod_6().TextVisible = true;
            componentResourceManager.ApplyResources(vmethod_10(), "ComboItem92");
            componentResourceManager.ApplyResources(vmethod_12(), "ComboItem93");
            componentResourceManager.ApplyResources(vmethod_14(), "ComboItem94");
            componentResourceManager.ApplyResources(vmethod_16(), "ComboItem95");
            componentResourceManager.ApplyResources(vmethod_18(), "ComboItem96");
            componentResourceManager.ApplyResources(vmethod_20(), "ComboItem97");
            componentResourceManager.ApplyResources(vmethod_22(), "ComboItem98");
            componentResourceManager.ApplyResources(vmethod_24(), "ComboItem99");
            componentResourceManager.ApplyResources(vmethod_26(), "ComboItem100");
            componentResourceManager.ApplyResources(vmethod_28(), "ComboItem101");
            componentResourceManager.ApplyResources(vmethod_30(), "ComboItem102");
            componentResourceManager.ApplyResources(vmethod_32(), "ComboItem103");
            componentResourceManager.ApplyResources(vmethod_34(), "ComboItem104");
            vmethod_36().Interval = 30000;
            componentResourceManager.ApplyResources(vmethod_38(), "WebBrowser1");
            vmethod_38().Name = "WebBrowser1";
            vmethod_38().ScrollBarsEnabled = false;
            vmethod_38().Url = new Uri("http://www.aodeve.net/BotContent/", UriKind.Absolute);
            vmethod_38().WebBrowserShortcutsEnabled = false;
            vmethod_40().CanvasColor = SystemColors.Control;
            vmethod_40().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_40().Controls.Add(vmethod_42());
            vmethod_40().Controls.Add(vmethod_44());
            vmethod_40().Controls.Add(vmethod_54());
            vmethod_40().Controls.Add(vmethod_56());
            vmethod_40().Controls.Add(vmethod_58());
            vmethod_40().Controls.Add(vmethod_60());
            vmethod_40().Controls.Add(vmethod_62());
            vmethod_40().Controls.Add(vmethod_64());
            vmethod_40().Controls.Add(vmethod_66());
            componentResourceManager.ApplyResources(vmethod_40(), "PanelEx1");
            vmethod_40().Name = "PanelEx1";
            vmethod_40().Style.Alignment = StringAlignment.Center;
            vmethod_40().Style.BackColor1.Color = Color.Black;
            vmethod_40().Style.Border = eBorderType.SingleLine;
            vmethod_40().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_40().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_40().Style.GradientAngle = 90;
            vmethod_42().BackgroundStyle.CornerType = eCornerType.Square;
            componentResourceManager.ApplyResources(vmethod_42(), "chkCredentals");
            vmethod_42().ForeColor = Color.White;
            vmethod_42().Name = "chkCredentals";
            vmethod_42().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_44().DisplayMember = "Text";
            vmethod_44().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_44().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_44().ForeColor = Color.White;
            vmethod_44().FormattingEnabled = true;
            componentResourceManager.ApplyResources(vmethod_44(), "cmbRegion");
            object[] objArr = new object[] {
                                             vmethod_46(), 
                                             vmethod_48(), 
                                             vmethod_50(), 
                                             vmethod_52(), 
                                             vmethod_68() };
            vmethod_44().Items.AddRange(objArr);
            vmethod_44().Name = "cmbRegion";
            vmethod_44().Style = eDotNetBarStyle.StyleManagerControlled;
            componentResourceManager.ApplyResources(vmethod_46(), "ComboItem16");
            componentResourceManager.ApplyResources(vmethod_48(), "ComboItem18");
            componentResourceManager.ApplyResources(vmethod_50(), "ComboItem17");
            componentResourceManager.ApplyResources(vmethod_52(), "ComboItem19");
            vmethod_54().BackColor = Color.Black;
            vmethod_54().Border.Class = "TextBoxBorder";
            vmethod_54().Border.CornerType = eCornerType.Square;
            vmethod_54().ForeColor = Color.White;
            componentResourceManager.ApplyResources(vmethod_54(), "txtPassword");
            vmethod_54().Name = "txtPassword";
            vmethod_56().BackColor = Color.Black;
            vmethod_56().Border.Class = "TextBoxBorder";
            vmethod_56().Border.CornerType = eCornerType.Square;
            vmethod_56().ForeColor = Color.White;
            componentResourceManager.ApplyResources(vmethod_56(), "txtUsernam");
            vmethod_56().Name = "txtUsernam";
            vmethod_58().BackColor = Color.Transparent;
            vmethod_58().BackgroundStyle.CornerType = eCornerType.Square;
            componentResourceManager.ApplyResources(vmethod_58(), "LabelX4");
            vmethod_58().ForeColor = Color.White;
            vmethod_58().Name = "LabelX4";
            vmethod_60().BackColor = Color.Transparent;
            vmethod_60().BackgroundStyle.CornerType = eCornerType.Square;
            componentResourceManager.ApplyResources(vmethod_60(), "LabelX5");
            vmethod_60().ForeColor = Color.White;
            vmethod_60().Name = "LabelX5";
            vmethod_62().BackColor = Color.Transparent;
            vmethod_62().BackgroundStyle.CornerType = eCornerType.Square;
            componentResourceManager.ApplyResources(vmethod_62(), "LabelX6");
            vmethod_62().ForeColor = Color.White;
            vmethod_62().Name = "LabelX6";
            vmethod_64().AccessibleRole = AccessibleRole.PushButton;
            vmethod_64().BackColor = Color.FromArgb(255, 128, 0);
            vmethod_64().ColorTable = eButtonColor.OrangeWithBackground;
            componentResourceManager.ApplyResources(vmethod_64(), "loginbtn");
            vmethod_64().Name = "loginbtn";
            vmethod_64().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_66().BackgroundStyle.BackColor = Color.FromArgb(255, 128, 0);
            vmethod_66().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_66().BackgroundStyle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_66().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_66().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Far;
            componentResourceManager.ApplyResources(vmethod_66(), "LabelX1");
            vmethod_66().ForeColor = Color.White;
            vmethod_66().Name = "LabelX1";
            vmethod_66().PaddingLeft = 10;
            vmethod_66().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_66().TextLineAlignment = StringAlignment.Near;
            vmethod_66().TextOrientation = eOrientation.Vertical;
            componentResourceManager.ApplyResources(vmethod_68(), "ComboItem1");
            componentResourceManager.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(vmethod_40());
            Controls.Add(vmethod_38());
            Controls.Add(vmethod_6());
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            vmethod_40().ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Login_Disposed(object sender, EventArgs e)
        {
            // decompiler error
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Assembly.GetExecutingAssembly().GetName().Version;
            method_12();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
        }

        private bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
        {
            return true;
        }

        private void method_1(string string_2)
        {
            if (vmethod_6().InvokeRequired)
            {
                object[] objArr = new object[] { string_2 };
                vmethod_6().Invoke(new Login.GDelegate1(method_1), objArr);
                return;
            }
            vmethod_6().Text = string_2;
        }

        public long method_10(string string_2)
        {
            // decompiler error
        }

        private void method_11(string string_2)
        {
            if (vmethod_64().InvokeRequired)
            {
                object[] objArr = new object[] { string_2 };
                vmethod_64().Invoke(new Login.GDelegate5(method_11), objArr);
                return;
            }
            ErrorForm errorForm = new ErrorForm();
            errorForm.vmethod_2().Text = string_2;
            errorForm.Show();
        }

        private void method_12()
        {
            try
            {
                if (!File.Exists(Login.string_1))
                {
                    GClass5.smethod_4(Login.string_1, "Credentials", "Username", "");
                    GClass5.smethod_4(Login.string_1, "Credentials", "Password", "");
                    GClass5.smethod_4(Login.string_1, "Credentials", "Region", "INTERNATIONAL");
                    GClass5.smethod_4(Login.string_1, "Credentials", "Save Credentials", "False");
                }
                vmethod_56().Text = GClass5.smethod_1(Login.string_1, "Credentials", "Username");
                vmethod_54().Text = GClass5.smethod_1(Login.string_1, "Credentials", "Password");
                vmethod_44().Text = GClass5.smethod_1(Login.string_1, "Credentials", "Region");
                vmethod_42().Checked = Conversions.ToBoolean(GClass5.smethod_1(Login.string_1, "Credentials", "Save Credentials"));
            }
            catch (Exception e)
            {
                ProjectData.SetProjectError(e);
                Interaction.MsgBox(e.Message, MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void method_13(object sender, EventArgs e)
        {
            // decompiler error
        }

        private void method_14(object sender, EventArgs e)
        {
            buttonX_0.Enabled = false;
            if (gclass43_0 == null) goto label_1;
            if (gclass43_0.get_State() == 0) goto label_1;
        label_1:
            string s = vmethod_44().SelectedItem.ToString();
            if (Operators.CompareString(s, "INTERNATIONAL", false) != 0) goto label_2;
            string_0 = "INT";
            goto label_3;
        label_2:
            if (Operators.CompareString(s, "EUROPE", false) == 0)
                string_0 = "EU";
            else if (Operators.CompareString(s, "RUSSIA", false) == 0)
                string_0 = "RU";
            else if (Operators.CompareString(s, "INDONESIA", false) == 0)
                string_0 = "IND";
            else if (Operators.CompareString(s, "JAPAN", false) == 0)
                string_0 = "JAO";
        label_3:
            if (vmethod_42().Checked)
            {
                GClass5.smethod_4(Login.string_1, "Credentials", "Username", vmethod_56().Text);
                GClass5.smethod_4(Login.string_1, "Credentials", "Password", vmethod_54().Text);
                GClass5.smethod_4(Login.string_1, "Credentials", "Region", vmethod_44().SelectedItem.ToString());
                GClass5.smethod_4(Login.string_1, "Credentials", "Save Credentials", Conversions.ToString(vmethod_42().Checked));
            }
            Thread thread = new Thread(new ThreadStart(method_2));
            thread.IsBackground = true;
            thread.Start();
            vmethod_36().Enabled = true;
        }

        private void method_2()
        {
            // decompiler error
        }

        private void method_3()
        {
            try
            {
                NetTcpBinding netTcpBinding = new NetTcpBinding();
                netTcpBinding.Security.Mode = SecurityMode.Message;
                netTcpBinding.Security.Message.ClientCredentialType = MessageCredentialType.UserName;
                X509Certificate2 x509Certificate2 = new X509Certificate2();
                x509Certificate2.Import(Convert.FromBase64String("AwAAAAEAAAAUAAAAQcgWJnd4oqrpvstQNdObF5sN38ogAAAAAQAAAPIBAAAwggHuMIIBW6ADAgECAhAYm0VuskvylUnqOsIYxRrrMAkGBSsOAwIdBQAwFDESMBAGA1UEAxMJQm90U2VydmVyMB4XDTE0MDYyODA0MDAwMFoXDTIwMDYyODA0MDAwMFowFDESMBAGA1UEAxMJQm90U2VydmVyMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCLsrZicF+Z8CyvBnVDvExNEtOXnsbI5dxl+jOjkEY9n7B6MwJjijbBRnx5uwaes5B/xTjhyjvrH/jvpa9rKIp209ZCxtsua1dBk4/1RnhcjNyYdWiDOlHq1p3BEB/gRyG1EMpOwxxIKAGuWdOy1ZmgcHtbU3kwuZW0MwIbPAMSOQIDAQABo0kwRzBFBgNVHQEEPjA8gBDwQLz3wk71DLoe2Z6rSArFoRYwFDESMBAGA1UEAxMJQm90U2VydmVyghAYm0VuskvylUnqOsIYxRrrMAkGBSsOAwIdBQADgYEAPwUTuTBKNbNbjhL8H0nlEcOLPKfaI+hwhAInm0Q+MRnxGMxmEREHF3U4MOQ4uDHWP0gJZCCEeF7+XAQJp93+RACFUar+q+8h+RAa8hcekRtnV527kxe2a9yC5EkI3HVdwJU6b9eL7JL4IwWV+87V6ZTyyV/y9nhkRcAJAweO2tY="));
                EndpointAddress endpointAddress = new EndpointAddress(new Uri("net.tcp://192.3.13.100:8740/BotServices"), EndpointIdentity.CreateX509CertificateIdentity(x509Certificate2), new AddressHeader[0]);
                gclass43_0 = new GClass43(netTcpBinding, endpointAddress);
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(method_0);
                gclass43_0.get_ClientCredentials().ServiceCertificate.Authentication.CertificateValidationMode = (X509CertificateValidationMode)0;
                gclass43_0.get_ClientCredentials().UserName.UserName = vmethod_56().Text;
                gclass43_0.get_ClientCredentials().UserName.Password = vmethod_54().Text;
                gclass43_0.get_ChannelFactory().Open();
                gclass43_0.UserConnection(string_0);
            }
            catch (Exception e)
            {
                ProjectData.SetProjectError(e);
                method_8(true);
                method_1(e.InnerException.Message);
                throw new FaultException();
            }
        }

        private void method_4()
        {
            // decompiler error
        }

        public int[] method_5(string string_2)
        {
            method_7();
            return gclass43_0.GetAddress(string_2);
        }

        public void method_6()
        {
            List<GClass6.GClass10>.Enumerator enumerator;

            if (InvokeRequired)
            {
                base.Invoke(new Login.GDelegate2(method_6));
                return;
            }
            ButtonItem buttonItem = null;
            List<GClass6.GClass10> list = GClass6.list_0;
            try
            {
                enumerator = list.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    GClass6.GClass10 gclass10 = enumerator.get_Current();
                    if (gclass10.method_2().Visible)
                    {
                        gclass10.method_2().Visible = false;
                    }
                    else
                    {
                        if (Operators.CompareString(gclass10.method_2().Name, "buttonGrinder", false) == 0)
                            buttonItem = gclass10.method_2();
                        gclass10.method_2().Visible = true;
                        gclass10.method_0().RecalcLayout();
                    }
                }
            }
            finally
            {
                enumerator.Dispose();
            }
            buttonItem.RaiseClick();
        }

        public void method_7()
        {
            if (vmethod_6().InvokeRequired)
            {
                vmethod_6().Invoke(new Login.GDelegate3(method_7));
                return;
            }
            vmethod_6().Value = checked(vmethod_6().Value + int_0);
            vmethod_6().Text = Conversions.ToString(vmethod_6().Value) + "%";
        }

        public void method_8(bool bool_0)
        {
            if (vmethod_64().InvokeRequired)
            {
                object[] objArr = new object[] { bool_0 };
                vmethod_64().Invoke(new Login.GDelegate4(method_8), objArr);
                return;
            }
            vmethod_64().Enabled = bool_0;
        }

        public object method_9<T>(ref T[] gparam_0, int int_1)
        {
            Array.Copy(gparam_0, checked(int_1 + 1), gparam_0, int_1, checked(Information.UBound(gparam_0, 1) - int_1));
            gparam_0 = (T[])Utils.CopyArray((Array)gparam_0, new T[checked(checked(Information.UBound(gparam_0, 1) - 1) + 1)][]);
            return gparam_0;
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

        internal virtual ComboItem vmethod_0()
        {
            ComboItem comboItem;

            return comboItem_0;
        }

        internal virtual void vmethod_1(ComboItem comboItem_21)
        {
            comboItem_0 = comboItem_21;
        }

        internal virtual ComboItem vmethod_10()
        {
            ComboItem comboItem;

            return comboItem_3;
        }

        internal virtual void vmethod_11(ComboItem comboItem_21)
        {
            comboItem_3 = comboItem_21;
        }

        internal virtual ComboItem vmethod_12()
        {
            ComboItem comboItem;

            return comboItem_4;
        }

        internal virtual void vmethod_13(ComboItem comboItem_21)
        {
            comboItem_4 = comboItem_21;
        }

        internal virtual ComboItem vmethod_14()
        {
            ComboItem comboItem;

            return comboItem_5;
        }

        internal virtual void vmethod_15(ComboItem comboItem_21)
        {
            comboItem_5 = comboItem_21;
        }

        internal virtual ComboItem vmethod_16()
        {
            ComboItem comboItem;

            return comboItem_6;
        }

        internal virtual void vmethod_17(ComboItem comboItem_21)
        {
            comboItem_6 = comboItem_21;
        }

        internal virtual ComboItem vmethod_18()
        {
            ComboItem comboItem;

            return comboItem_7;
        }

        internal virtual void vmethod_19(ComboItem comboItem_21)
        {
            comboItem_7 = comboItem_21;
        }

        internal virtual ComboItem vmethod_2()
        {
            ComboItem comboItem;

            return comboItem_1;
        }

        internal virtual ComboItem vmethod_20()
        {
            ComboItem comboItem;

            return comboItem_8;
        }

        internal virtual void vmethod_21(ComboItem comboItem_21)
        {
            comboItem_8 = comboItem_21;
        }

        internal virtual ComboItem vmethod_22()
        {
            ComboItem comboItem;

            return comboItem_9;
        }

        internal virtual void vmethod_23(ComboItem comboItem_21)
        {
            comboItem_9 = comboItem_21;
        }

        internal virtual ComboItem vmethod_24()
        {
            ComboItem comboItem;

            return comboItem_10;
        }

        internal virtual void vmethod_25(ComboItem comboItem_21)
        {
            comboItem_10 = comboItem_21;
        }

        internal virtual ComboItem vmethod_26()
        {
            ComboItem comboItem;

            return comboItem_11;
        }

        internal virtual void vmethod_27(ComboItem comboItem_21)
        {
            comboItem_11 = comboItem_21;
        }

        internal virtual ComboItem vmethod_28()
        {
            ComboItem comboItem;

            return comboItem_12;
        }

        internal virtual void vmethod_29(ComboItem comboItem_21)
        {
            comboItem_12 = comboItem_21;
        }

        internal virtual void vmethod_3(ComboItem comboItem_21)
        {
            comboItem_1 = comboItem_21;
        }

        internal virtual ComboItem vmethod_30()
        {
            ComboItem comboItem;

            return comboItem_13;
        }

        internal virtual void vmethod_31(ComboItem comboItem_21)
        {
            comboItem_13 = comboItem_21;
        }

        internal virtual ComboItem vmethod_32()
        {
            ComboItem comboItem;

            return comboItem_14;
        }

        internal virtual void vmethod_33(ComboItem comboItem_21)
        {
            comboItem_14 = comboItem_21;
        }

        internal virtual ComboItem vmethod_34()
        {
            ComboItem comboItem;

            return comboItem_15;
        }

        internal virtual void vmethod_35(ComboItem comboItem_21)
        {
            comboItem_15 = comboItem_21;
        }

        internal virtual Timer vmethod_36()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual void vmethod_37(Timer timer_1)
        {
            EventHandler eventHandler = new EventHandler(method_13);
            if (timer_0 != null)
                timer_0.Tick -= eventHandler;
            timer_0 = timer_1;
            if (timer_0 != null)
                timer_0.Tick += eventHandler;
        }

        internal virtual WebBrowser vmethod_38()
        {
            WebBrowser webBrowser;

            return webBrowser_0;
        }

        internal virtual void vmethod_39(WebBrowser webBrowser_1)
        {
            webBrowser_0 = webBrowser_1;
        }

        internal virtual ComboItem vmethod_4()
        {
            ComboItem comboItem;

            return comboItem_2;
        }

        internal virtual PanelEx vmethod_40()
        {
            PanelEx panelEx;

            return panelEx_0;
        }

        internal virtual void vmethod_41(PanelEx panelEx_1)
        {
            panelEx_0 = panelEx_1;
        }

        internal virtual CheckBoxX vmethod_42()
        {
            CheckBoxX checkBoxX;

            return checkBoxX_1;
        }

        internal virtual void vmethod_43(CheckBoxX checkBoxX_2)
        {
            checkBoxX_1 = checkBoxX_2;
        }

        internal virtual ComboBoxEx vmethod_44()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_0;
        }

        internal virtual void vmethod_45(ComboBoxEx comboBoxEx_1)
        {
            comboBoxEx_0 = comboBoxEx_1;
        }

        internal virtual ComboItem vmethod_46()
        {
            ComboItem comboItem;

            return comboItem_16;
        }

        internal virtual void vmethod_47(ComboItem comboItem_21)
        {
            comboItem_16 = comboItem_21;
        }

        internal virtual ComboItem vmethod_48()
        {
            ComboItem comboItem;

            return comboItem_17;
        }

        internal virtual void vmethod_49(ComboItem comboItem_21)
        {
            comboItem_17 = comboItem_21;
        }

        internal virtual void vmethod_5(ComboItem comboItem_21)
        {
            comboItem_2 = comboItem_21;
        }

        internal virtual ComboItem vmethod_50()
        {
            ComboItem comboItem;

            return comboItem_18;
        }

        internal virtual void vmethod_51(ComboItem comboItem_21)
        {
            comboItem_18 = comboItem_21;
        }

        internal virtual ComboItem vmethod_52()
        {
            ComboItem comboItem;

            return comboItem_19;
        }

        internal virtual void vmethod_53(ComboItem comboItem_21)
        {
            comboItem_19 = comboItem_21;
        }

        internal virtual TextBoxX vmethod_54()
        {
            TextBoxX textBoxX;

            return textBoxX_0;
        }

        internal virtual void vmethod_55(TextBoxX textBoxX_2)
        {
            textBoxX_0 = textBoxX_2;
        }

        internal virtual TextBoxX vmethod_56()
        {
            TextBoxX textBoxX;

            return textBoxX_1;
        }

        internal virtual void vmethod_57(TextBoxX textBoxX_2)
        {
            textBoxX_1 = textBoxX_2;
        }

        internal virtual LabelX vmethod_58()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual void vmethod_59(LabelX labelX_4)
        {
            labelX_0 = labelX_4;
        }

        internal virtual ProgressBarX vmethod_6()
        {
            ProgressBarX progressBarX;

            return progressBarX_0;
        }

        internal virtual LabelX vmethod_60()
        {
            LabelX labelX;

            return labelX_1;
        }

        internal virtual void vmethod_61(LabelX labelX_4)
        {
            labelX_1 = labelX_4;
        }

        internal virtual LabelX vmethod_62()
        {
            LabelX labelX;

            return labelX_2;
        }

        internal virtual void vmethod_63(LabelX labelX_4)
        {
            labelX_2 = labelX_4;
        }

        internal virtual ButtonX vmethod_64()
        {
            ButtonX buttonX;

            return buttonX_0;
        }

        internal virtual void vmethod_65(ButtonX buttonX_1)
        {
            EventHandler eventHandler = new EventHandler(method_14);
            if (buttonX_0 != null)
                buttonX_0.Click -= eventHandler;
            buttonX_0 = buttonX_1;
            if (buttonX_0 != null)
                buttonX_0.Click += eventHandler;
        }

        internal virtual LabelX vmethod_66()
        {
            LabelX labelX;

            return labelX_3;
        }

        internal virtual void vmethod_67(LabelX labelX_4)
        {
            labelX_3 = labelX_4;
        }

        internal virtual ComboItem vmethod_68()
        {
            ComboItem comboItem;

            return comboItem_20;
        }

        internal virtual void vmethod_69(ComboItem comboItem_21)
        {
            comboItem_20 = comboItem_21;
        }

        internal virtual void vmethod_7(ProgressBarX progressBarX_1)
        {
            progressBarX_0 = progressBarX_1;
        }

        internal virtual CheckBoxX vmethod_8()
        {
            CheckBoxX checkBoxX;

            return checkBoxX_0;
        }

        internal virtual void vmethod_9(CheckBoxX checkBoxX_2)
        {
            checkBoxX_0 = checkBoxX_2;
        }

    } // class Login

}

