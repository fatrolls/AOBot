using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    public sealed class GClass38
    {

        public sealed class GClass39
        {

            [CompilerGenerated]
            private List<GClass38.GClass41> list_0;
            [CompilerGenerated]
            private string string_0;

            public GClass39()
            {
                List<GClass38.GClass41> list = new List<GClass38.GClass41>();
                method_3(list);
            }

            public string method_0()
            {
                return string_0;
            }

            public void method_1(string string_1)
            {
                string_0 = string_1;
            }

            public List<GClass38.GClass41> method_2()
            {
                return list_0;
            }

            public void method_3(List<GClass38.GClass41> list_1)
            {
                list_0 = list_1;
            }

        } // class GClass39

        public sealed class GClass40
        {

            [CompilerGenerated]
            private int int_0;
            [CompilerGenerated]
            private int int_1;
            [CompilerGenerated]
            private int int_2;
            [CompilerGenerated]
            private string string_0;

            public GClass40()
            {
            }

            public string method_0()
            {
                return string_0;
            }

            public void method_1(string string_1)
            {
                string_0 = string_1;
            }

            public int method_2()
            {
                return int_0;
            }

            public void method_3(int int_3)
            {
                int_0 = int_3;
            }

            public int method_4()
            {
                return int_1;
            }

            public void method_5(int int_3)
            {
                int_1 = int_3;
            }

            public int method_6()
            {
                return int_2;
            }

            public void method_7(int int_3)
            {
                int_2 = int_3;
            }

        } // class GClass40

        public sealed class GClass41
        {

            [CompilerGenerated]
            private byte[] byte_0;
            [CompilerGenerated]
            private GClass38.GClass40 gclass40_0;
            [CompilerGenerated]
            private List<GClass38.GClass42> list_0;

            public GClass41()
            {
                List<GClass38.GClass42> list = new List<GClass38.GClass42>();
                method_5(list);
            }

            public byte[] method_0()
            {
                return byte_0;
            }

            public void method_1(byte[] byte_1)
            {
                byte_0 = byte_1;
            }

            public GClass38.GClass40 method_2()
            {
                return gclass40_0;
            }

            public void method_3(GClass38.GClass40 gclass40_1)
            {
                gclass40_0 = gclass40_1;
            }

            public List<GClass38.GClass42> method_4()
            {
                return list_0;
            }

            public void method_5(List<GClass38.GClass42> list_1)
            {
                list_0 = list_1;
            }

        } // class GClass41

        public sealed class GClass42
        {

            [CompilerGenerated]
            private int int_0;
            [CompilerGenerated]
            private int int_1;
            [CompilerGenerated]
            private int int_2;
            [CompilerGenerated]
            private int int_3;
            [CompilerGenerated]
            private int int_4;

            public GClass42()
            {
            }

            public int method_0()
            {
                return int_0;
            }

            public void method_1(int int_5)
            {
                int_0 = int_5;
            }

            public int method_2()
            {
                return int_1;
            }

            public void method_3(int int_5)
            {
                int_1 = int_5;
            }

            public int method_4()
            {
                return int_2;
            }

            public void method_5(int int_5)
            {
                int_2 = int_5;
            }

            public int method_6()
            {
                return int_3;
            }

            public void method_7(int int_5)
            {
                int_3 = int_5;
            }

            public int method_8()
            {
                return int_4;
            }

            public void method_9(int int_5)
            {
                int_4 = int_5;
            }

        } // class GClass42

        public GClass38()
        {
        }

        public static List<GClass38.GClass39> smethod_0(string string_0)
        {
            XmlNodeType xmlNodeType;

            GClass38.GClass39 gclass39 = new GClass38.GClass39();
            GClass38.GClass41 gclass41 = new GClass38.GClass41();
            GClass38.GClass42 gclass42 = new GClass38.GClass42();
            GClass38.GClass40 gclass40 = new GClass38.GClass40();
            List<GClass38.GClass39> list = new List<GClass38.GClass39>();
            XmlTextReader xmlTextReader = new XmlTextReader(Application.StartupPath + "/Quests/" + string_0 + ".xml");
            string s1 = "";
            string s2 = "";
            while (xmlTextReader.Read())
            {
                switch (xmlTextReader.NodeType)
                {
                    case XmlNodeType.Element:
                        s1 = xmlTextReader.Name;
                        string s3 = xmlTextReader.Name;
                        if (Operators.CompareString(s3, "QuestTable", false) == 0)
                        {
                            gclass39 = new GClass38.GClass39();
                            xmlTextReader.MoveToNextAttribute();
                            gclass39.method_1(xmlTextReader.Value);
                            goto label_1;
                        }
                        if (Operators.CompareString(s3, "Quest", false) == 0)
                        {
                            gclass41 = new GClass38.GClass41();
                            goto label_1;
                        }
                        if (Operators.CompareString(s3, "Condition", false) == 0)
                        {
                            s2 = "Condition";
                            gclass42 = new GClass38.GClass42();
                            goto label_1;
                        }
                        if (Operators.CompareString(s3, "QuestStart", false) != 0)
                            goto label_1;
                        s2 = "QuestStart";
                        gclass40 = new GClass38.GClass40();
                        break;

                    case XmlNodeType.Text:
                        string s4 = s1;
                        if (Operators.CompareString(s4, "QuestId", false) == 0)
                        {
                            gclass41.method_1(BitConverter.GetBytes(Conversions.ToInteger(xmlTextReader.Value)));
                            goto label_1;
                        }
                        if (Operators.CompareString(s4, "ConditionId", false) == 0)
                        {
                            gclass42.method_1(Conversions.ToInteger(xmlTextReader.Value));
                            goto label_1;
                        }
                        if (Operators.CompareString(s4, "ConditionType", false) == 0)
                        {
                            gclass42.method_3(Conversions.ToInteger(xmlTextReader.Value));
                            goto label_1;
                        }
                        if (Operators.CompareString(s4, "MapId", false) == 0)
                        {
                            string s5 = s2;
                            if (Operators.CompareString(s5, "Condition", false) == 0)
                            {
                                gclass42.method_5(Conversions.ToInteger(xmlTextReader.Value));
                                goto label_1;
                            }
                            if (Operators.CompareString(s5, "QuestStart", false) != 0)
                                goto label_1;
                            gclass40.method_3(Conversions.ToInteger(xmlTextReader.Value));
                            goto label_1;
                        }
                        if (Operators.CompareString(s4, "PositionX", false) == 0)
                        {
                            string s6 = s2;
                            if (Operators.CompareString(s6, "Condition", false) == 0)
                            {
                                gclass42.method_7(Conversions.ToInteger(xmlTextReader.Value));
                                goto label_1;
                            }
                            if (Operators.CompareString(s6, "QuestStart", false) != 0)
                                goto label_1;
                            gclass40.method_5(Conversions.ToInteger(xmlTextReader.Value));
                            goto label_1;
                        }
                        if (Operators.CompareString(s4, "PositionY", false) != 0)
                            goto label_1;
                        string s7 = s2;
                        if (Operators.CompareString(s7, "Condition", false) == 0)
                        {
                            gclass42.method_9(Conversions.ToInteger(xmlTextReader.Value));
                            goto label_1;
                        }
                        if (Operators.CompareString(s7, "QuestStart", false) != 0)
                            goto label_1;
                        gclass40.method_7(Conversions.ToInteger(xmlTextReader.Value));
                        break;

                    case XmlNodeType.EndElement:
                        string s8 = xmlTextReader.Name;
                        if (Operators.CompareString(s8, "QuestTable", false) == 0)
                        {
                            list.Add(gclass39);
                            goto label_1;
                        }
                        if (Operators.CompareString(s8, "Quest", false) == 0)
                        {
                            gclass39.method_2().Add(gclass41);
                            goto label_1;
                        }
                        if (Operators.CompareString(s8, "Condition", false) == 0)
                        {
                            gclass41.method_4().Add(gclass42);
                            goto label_1;
                        }
                        if (Operators.CompareString(s8, "QuestStart", false) != 0)
                            goto label_1;
                        gclass41.method_3(gclass40);
                        break;

                    case XmlNodeType.Attribute:
                    case XmlNodeType.CDATA:
                    case XmlNodeType.EntityReference:
                    case XmlNodeType.Entity:
                    case XmlNodeType.ProcessingInstruction:
                    case XmlNodeType.Comment:
                    case XmlNodeType.Document:
                    case XmlNodeType.DocumentType:
                    case XmlNodeType.DocumentFragment:
                    case XmlNodeType.Notation:
                    case XmlNodeType.Whitespace:
                    case XmlNodeType.SignificantWhitespace:
                    label_1:
                        Thread.Sleep(5);
                        break;
                }
            }
            return list;
        }

    } // class GClass38

}

