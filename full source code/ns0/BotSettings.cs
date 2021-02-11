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
using DevComponents.DotNetBar.Rendering;
using DevComponents.Editors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0
{

    [DesignerGenerated]
    public sealed class BotSettings : MetroForm
    {

        public enum GEnum1
        {
            const_0 = 0,
            const_1 = 2035711
        }

        public Bot bot_0;
        [AccessedThroughProperty("saveButton")]
        private ButtonX buttonX_0;
        [AccessedThroughProperty("cancelSettingsButton")]
        private ButtonX buttonX_1;
        [AccessedThroughProperty("btnDeleteLocation")]
        private ButtonX buttonX_2;
        [AccessedThroughProperty("btnSaveLocation")]
        private ButtonX buttonX_3;
        [AccessedThroughProperty("btnRemoveGrindLocation")]
        private ButtonX buttonX_4;
        [AccessedThroughProperty("ButtonX1")]
        private ButtonX buttonX_5;
        [AccessedThroughProperty("btntownWaitSave")]
        private ButtonX buttonX_6;
        [AccessedThroughProperty("btntownWaitRemove")]
        private ButtonX buttonX_7;
        [AccessedThroughProperty("btnRemoveRechargeLocation")]
        private ButtonX buttonX_8;
        [AccessedThroughProperty("btnSaveRechargeLocation")]
        private ButtonX buttonX_9;
        [AccessedThroughProperty("clmLocation")]
        private ColumnHeader columnHeader_0;
        [AccessedThroughProperty("ColumnHeader3")]
        private ColumnHeader columnHeader_1;
        [AccessedThroughProperty("ColumnHeader1")]
        private ColumnHeader columnHeader_2;
        [AccessedThroughProperty("cmbGrindLocationMinutes")]
        private ComboBoxEx comboBoxEx_0;
        [AccessedThroughProperty("cmbGrindLocationHours")]
        private ComboBoxEx comboBoxEx_1;
        [AccessedThroughProperty("cmbManaPercent")]
        private ComboBoxEx comboBoxEx_10;
        [AccessedThroughProperty("cmbHealPercent")]
        private ComboBoxEx comboBoxEx_11;
        [AccessedThroughProperty("cmbLifePotion")]
        private ComboBoxEx comboBoxEx_12;
        [AccessedThroughProperty("cmbManaPotion")]
        private ComboBoxEx comboBoxEx_13;
        [AccessedThroughProperty("cmbLocations")]
        private ComboBoxEx comboBoxEx_14;
        [AccessedThroughProperty("cmbBattleSpeed")]
        private ComboBoxEx comboBoxEx_15;
        [AccessedThroughProperty("cmbZoom")]
        private ComboBoxEx comboBoxEx_16;
        [AccessedThroughProperty("cmbAutoBattleCount")]
        private ComboBoxEx comboBoxEx_17;
        [AccessedThroughProperty("cmbTownWaitMinutes")]
        private ComboBoxEx comboBoxEx_2;
        [AccessedThroughProperty("cmbTownWaitHours")]
        private ComboBoxEx comboBoxEx_3;
        [AccessedThroughProperty("cmbTownMinutes")]
        private ComboBoxEx comboBoxEx_4;
        [AccessedThroughProperty("cmbTownHours")]
        private ComboBoxEx comboBoxEx_5;
        [AccessedThroughProperty("cmbrechargeStart")]
        private ComboBoxEx comboBoxEx_6;
        [AccessedThroughProperty("cmbrechargeStop")]
        private ComboBoxEx comboBoxEx_7;
        [AccessedThroughProperty("cmbHealingPotion")]
        private ComboBoxEx comboBoxEx_8;
        [AccessedThroughProperty("cmbDeadCount")]
        private ComboBoxEx comboBoxEx_9;
        [AccessedThroughProperty("ComboItem27")]
        private ComboItem comboItem_0;
        [AccessedThroughProperty("ComboItem26")]
        private ComboItem comboItem_1;
        [AccessedThroughProperty("ComboItem110")]
        private ComboItem comboItem_10;
        [AccessedThroughProperty("ComboItem187")]
        private ComboItem comboItem_100;
        [AccessedThroughProperty("ComboItem18")]
        private ComboItem comboItem_101;
        [AccessedThroughProperty("ComboItem19")]
        private ComboItem comboItem_102;
        [AccessedThroughProperty("ComboItem20")]
        private ComboItem comboItem_103;
        [AccessedThroughProperty("ComboItem21")]
        private ComboItem comboItem_104;
        [AccessedThroughProperty("ComboItem22")]
        private ComboItem comboItem_105;
        [AccessedThroughProperty("ComboItem28")]
        private ComboItem comboItem_106;
        [AccessedThroughProperty("ComboItem29")]
        private ComboItem comboItem_107;
        [AccessedThroughProperty("ComboItem30")]
        private ComboItem comboItem_108;
        [AccessedThroughProperty("ComboItem31")]
        private ComboItem comboItem_109;
        [AccessedThroughProperty("ComboItem111")]
        private ComboItem comboItem_11;
        [AccessedThroughProperty("ComboItem32")]
        private ComboItem comboItem_110;
        [AccessedThroughProperty("ComboItem33")]
        private ComboItem comboItem_111;
        [AccessedThroughProperty("ComboItem34")]
        private ComboItem comboItem_112;
        [AccessedThroughProperty("ComboItem17")]
        private ComboItem comboItem_113;
        [AccessedThroughProperty("ComboItem35")]
        private ComboItem comboItem_114;
        [AccessedThroughProperty("ComboItem36")]
        private ComboItem comboItem_115;
        [AccessedThroughProperty("ComboItem192")]
        private ComboItem comboItem_116;
        [AccessedThroughProperty("ComboItem77")]
        private ComboItem comboItem_117;
        [AccessedThroughProperty("ComboItem78")]
        private ComboItem comboItem_118;
        [AccessedThroughProperty("ComboItem79")]
        private ComboItem comboItem_119;
        [AccessedThroughProperty("ComboItem112")]
        private ComboItem comboItem_12;
        [AccessedThroughProperty("ComboItem80")]
        private ComboItem comboItem_120;
        [AccessedThroughProperty("ComboItem81")]
        private ComboItem comboItem_121;
        [AccessedThroughProperty("ComboItem82")]
        private ComboItem comboItem_122;
        [AccessedThroughProperty("ComboItem83")]
        private ComboItem comboItem_123;
        [AccessedThroughProperty("ComboItem84")]
        private ComboItem comboItem_124;
        [AccessedThroughProperty("ComboItem68")]
        private ComboItem comboItem_125;
        [AccessedThroughProperty("ComboItem69")]
        private ComboItem comboItem_126;
        [AccessedThroughProperty("ComboItem70")]
        private ComboItem comboItem_127;
        [AccessedThroughProperty("ComboItem71")]
        private ComboItem comboItem_128;
        [AccessedThroughProperty("ComboItem72")]
        private ComboItem comboItem_129;
        [AccessedThroughProperty("ComboItem113")]
        private ComboItem comboItem_13;
        [AccessedThroughProperty("ComboItem73")]
        private ComboItem comboItem_130;
        [AccessedThroughProperty("ComboItem74")]
        private ComboItem comboItem_131;
        [AccessedThroughProperty("ComboItem75")]
        private ComboItem comboItem_132;
        [AccessedThroughProperty("ComboItem76")]
        private ComboItem comboItem_133;
        [AccessedThroughProperty("ComboItem59")]
        private ComboItem comboItem_134;
        [AccessedThroughProperty("ComboItem60")]
        private ComboItem comboItem_135;
        [AccessedThroughProperty("ComboItem61")]
        private ComboItem comboItem_136;
        [AccessedThroughProperty("ComboItem62")]
        private ComboItem comboItem_137;
        [AccessedThroughProperty("ComboItem63")]
        private ComboItem comboItem_138;
        [AccessedThroughProperty("ComboItem64")]
        private ComboItem comboItem_139;
        [AccessedThroughProperty("ComboItem114")]
        private ComboItem comboItem_14;
        [AccessedThroughProperty("ComboItem65")]
        private ComboItem comboItem_140;
        [AccessedThroughProperty("ComboItem66")]
        private ComboItem comboItem_141;
        [AccessedThroughProperty("ComboItem67")]
        private ComboItem comboItem_142;
        [AccessedThroughProperty("ComboItem52")]
        private ComboItem comboItem_143;
        [AccessedThroughProperty("ComboItem53")]
        private ComboItem comboItem_144;
        [AccessedThroughProperty("ComboItem54")]
        private ComboItem comboItem_145;
        [AccessedThroughProperty("ComboItem55")]
        private ComboItem comboItem_146;
        [AccessedThroughProperty("ComboItem56")]
        private ComboItem comboItem_147;
        [AccessedThroughProperty("ComboItem57")]
        private ComboItem comboItem_148;
        [AccessedThroughProperty("ComboItem58")]
        private ComboItem comboItem_149;
        [AccessedThroughProperty("ComboItem115")]
        private ComboItem comboItem_15;
        [AccessedThroughProperty("ComboItem190")]
        private ComboItem comboItem_150;
        [AccessedThroughProperty("ComboItem37")]
        private ComboItem comboItem_151;
        [AccessedThroughProperty("ComboItem38")]
        private ComboItem comboItem_152;
        [AccessedThroughProperty("ComboItem39")]
        private ComboItem comboItem_153;
        [AccessedThroughProperty("ComboItem40")]
        private ComboItem comboItem_154;
        [AccessedThroughProperty("ComboItem41")]
        private ComboItem comboItem_155;
        [AccessedThroughProperty("ComboItem42")]
        private ComboItem comboItem_156;
        [AccessedThroughProperty("ComboItem43")]
        private ComboItem comboItem_157;
        [AccessedThroughProperty("ComboItem44")]
        private ComboItem comboItem_158;
        [AccessedThroughProperty("ComboItem45")]
        private ComboItem comboItem_159;
        [AccessedThroughProperty("ComboItem116")]
        private ComboItem comboItem_16;
        [AccessedThroughProperty("ComboItem46")]
        private ComboItem comboItem_160;
        [AccessedThroughProperty("ComboItem47")]
        private ComboItem comboItem_161;
        [AccessedThroughProperty("ComboItem48")]
        private ComboItem comboItem_162;
        [AccessedThroughProperty("ComboItem49")]
        private ComboItem comboItem_163;
        [AccessedThroughProperty("ComboItem50")]
        private ComboItem comboItem_164;
        [AccessedThroughProperty("ComboItem51")]
        private ComboItem comboItem_165;
        [AccessedThroughProperty("ComboItem191")]
        private ComboItem comboItem_166;
        [AccessedThroughProperty("ComboItem1")]
        private ComboItem comboItem_167;
        [AccessedThroughProperty("ComboItem2")]
        private ComboItem comboItem_168;
        [AccessedThroughProperty("ComboItem3")]
        private ComboItem comboItem_169;
        [AccessedThroughProperty("ComboItem92")]
        private ComboItem comboItem_17;
        [AccessedThroughProperty("ComboItem4")]
        private ComboItem comboItem_170;
        [AccessedThroughProperty("ComboItem5")]
        private ComboItem comboItem_171;
        [AccessedThroughProperty("ComboItem6")]
        private ComboItem comboItem_172;
        [AccessedThroughProperty("ComboItem189")]
        private ComboItem comboItem_173;
        [AccessedThroughProperty("ComboItem188")]
        private ComboItem comboItem_174;
        [AccessedThroughProperty("ComboItem85")]
        private ComboItem comboItem_175;
        [AccessedThroughProperty("ComboItem86")]
        private ComboItem comboItem_176;
        [AccessedThroughProperty("ComboItem87")]
        private ComboItem comboItem_177;
        [AccessedThroughProperty("ComboItem88")]
        private ComboItem comboItem_178;
        [AccessedThroughProperty("ComboItem89")]
        private ComboItem comboItem_179;
        [AccessedThroughProperty("ComboItem93")]
        private ComboItem comboItem_18;
        [AccessedThroughProperty("ComboItem90")]
        private ComboItem comboItem_180;
        [AccessedThroughProperty("ComboItem91")]
        private ComboItem comboItem_181;
        [AccessedThroughProperty("ComboItem7")]
        private ComboItem comboItem_182;
        [AccessedThroughProperty("ComboItem8")]
        private ComboItem comboItem_183;
        [AccessedThroughProperty("ComboItem9")]
        private ComboItem comboItem_184;
        [AccessedThroughProperty("ComboItem10")]
        private ComboItem comboItem_185;
        [AccessedThroughProperty("ComboItem11")]
        private ComboItem comboItem_186;
        [AccessedThroughProperty("ComboItem12")]
        private ComboItem comboItem_187;
        [AccessedThroughProperty("ComboItem13")]
        private ComboItem comboItem_188;
        [AccessedThroughProperty("ComboItem14")]
        private ComboItem comboItem_189;
        [AccessedThroughProperty("ComboItem94")]
        private ComboItem comboItem_19;
        [AccessedThroughProperty("ComboItem15")]
        private ComboItem comboItem_190;
        [AccessedThroughProperty("ComboItem16")]
        private ComboItem comboItem_191;
        [AccessedThroughProperty("ComboItem25")]
        private ComboItem comboItem_2;
        [AccessedThroughProperty("ComboItem95")]
        private ComboItem comboItem_20;
        [AccessedThroughProperty("ComboItem96")]
        private ComboItem comboItem_21;
        [AccessedThroughProperty("ComboItem97")]
        private ComboItem comboItem_22;
        [AccessedThroughProperty("ComboItem98")]
        private ComboItem comboItem_23;
        [AccessedThroughProperty("ComboItem99")]
        private ComboItem comboItem_24;
        [AccessedThroughProperty("ComboItem100")]
        private ComboItem comboItem_25;
        [AccessedThroughProperty("ComboItem101")]
        private ComboItem comboItem_26;
        [AccessedThroughProperty("ComboItem102")]
        private ComboItem comboItem_27;
        [AccessedThroughProperty("ComboItem103")]
        private ComboItem comboItem_28;
        [AccessedThroughProperty("ComboItem104")]
        private ComboItem comboItem_29;
        [AccessedThroughProperty("ComboItem24")]
        private ComboItem comboItem_3;
        [AccessedThroughProperty("ComboItem142")]
        private ComboItem comboItem_30;
        [AccessedThroughProperty("ComboItem143")]
        private ComboItem comboItem_31;
        [AccessedThroughProperty("ComboItem144")]
        private ComboItem comboItem_32;
        [AccessedThroughProperty("ComboItem145")]
        private ComboItem comboItem_33;
        [AccessedThroughProperty("ComboItem146")]
        private ComboItem comboItem_34;
        [AccessedThroughProperty("ComboItem147")]
        private ComboItem comboItem_35;
        [AccessedThroughProperty("ComboItem148")]
        private ComboItem comboItem_36;
        [AccessedThroughProperty("ComboItem149")]
        private ComboItem comboItem_37;
        [AccessedThroughProperty("ComboItem150")]
        private ComboItem comboItem_38;
        [AccessedThroughProperty("ComboItem151")]
        private ComboItem comboItem_39;
        [AccessedThroughProperty("ComboItem23")]
        private ComboItem comboItem_4;
        [AccessedThroughProperty("ComboItem152")]
        private ComboItem comboItem_40;
        [AccessedThroughProperty("ComboItem153")]
        private ComboItem comboItem_41;
        [AccessedThroughProperty("ComboItem154")]
        private ComboItem comboItem_42;
        [AccessedThroughProperty("ComboItem155")]
        private ComboItem comboItem_43;
        [AccessedThroughProperty("ComboItem156")]
        private ComboItem comboItem_44;
        [AccessedThroughProperty("ComboItem157")]
        private ComboItem comboItem_45;
        [AccessedThroughProperty("ComboItem158")]
        private ComboItem comboItem_46;
        [AccessedThroughProperty("ComboItem159")]
        private ComboItem comboItem_47;
        [AccessedThroughProperty("ComboItem160")]
        private ComboItem comboItem_48;
        [AccessedThroughProperty("ComboItem161")]
        private ComboItem comboItem_49;
        [AccessedThroughProperty("ComboItem105")]
        private ComboItem comboItem_5;
        [AccessedThroughProperty("ComboItem162")]
        private ComboItem comboItem_50;
        [AccessedThroughProperty("ComboItem163")]
        private ComboItem comboItem_51;
        [AccessedThroughProperty("ComboItem164")]
        private ComboItem comboItem_52;
        [AccessedThroughProperty("ComboItem165")]
        private ComboItem comboItem_53;
        [AccessedThroughProperty("ComboItem166")]
        private ComboItem comboItem_54;
        [AccessedThroughProperty("ComboItem117")]
        private ComboItem comboItem_55;
        [AccessedThroughProperty("ComboItem118")]
        private ComboItem comboItem_56;
        [AccessedThroughProperty("ComboItem119")]
        private ComboItem comboItem_57;
        [AccessedThroughProperty("ComboItem120")]
        private ComboItem comboItem_58;
        [AccessedThroughProperty("ComboItem121")]
        private ComboItem comboItem_59;
        [AccessedThroughProperty("ComboItem106")]
        private ComboItem comboItem_6;
        [AccessedThroughProperty("ComboItem122")]
        private ComboItem comboItem_60;
        [AccessedThroughProperty("ComboItem123")]
        private ComboItem comboItem_61;
        [AccessedThroughProperty("ComboItem124")]
        private ComboItem comboItem_62;
        [AccessedThroughProperty("ComboItem125")]
        private ComboItem comboItem_63;
        [AccessedThroughProperty("ComboItem126")]
        private ComboItem comboItem_64;
        [AccessedThroughProperty("ComboItem127")]
        private ComboItem comboItem_65;
        [AccessedThroughProperty("ComboItem128")]
        private ComboItem comboItem_66;
        [AccessedThroughProperty("ComboItem129")]
        private ComboItem comboItem_67;
        [AccessedThroughProperty("ComboItem130")]
        private ComboItem comboItem_68;
        [AccessedThroughProperty("ComboItem131")]
        private ComboItem comboItem_69;
        [AccessedThroughProperty("ComboItem107")]
        private ComboItem comboItem_7;
        [AccessedThroughProperty("ComboItem132")]
        private ComboItem comboItem_70;
        [AccessedThroughProperty("ComboItem133")]
        private ComboItem comboItem_71;
        [AccessedThroughProperty("ComboItem134")]
        private ComboItem comboItem_72;
        [AccessedThroughProperty("ComboItem135")]
        private ComboItem comboItem_73;
        [AccessedThroughProperty("ComboItem136")]
        private ComboItem comboItem_74;
        [AccessedThroughProperty("ComboItem137")]
        private ComboItem comboItem_75;
        [AccessedThroughProperty("ComboItem138")]
        private ComboItem comboItem_76;
        [AccessedThroughProperty("ComboItem139")]
        private ComboItem comboItem_77;
        [AccessedThroughProperty("ComboItem140")]
        private ComboItem comboItem_78;
        [AccessedThroughProperty("ComboItem141")]
        private ComboItem comboItem_79;
        [AccessedThroughProperty("ComboItem108")]
        private ComboItem comboItem_8;
        [AccessedThroughProperty("ComboItem167")]
        private ComboItem comboItem_80;
        [AccessedThroughProperty("ComboItem168")]
        private ComboItem comboItem_81;
        [AccessedThroughProperty("ComboItem169")]
        private ComboItem comboItem_82;
        [AccessedThroughProperty("ComboItem170")]
        private ComboItem comboItem_83;
        [AccessedThroughProperty("ComboItem171")]
        private ComboItem comboItem_84;
        [AccessedThroughProperty("ComboItem172")]
        private ComboItem comboItem_85;
        [AccessedThroughProperty("ComboItem173")]
        private ComboItem comboItem_86;
        [AccessedThroughProperty("ComboItem174")]
        private ComboItem comboItem_87;
        [AccessedThroughProperty("ComboItem175")]
        private ComboItem comboItem_88;
        [AccessedThroughProperty("ComboItem176")]
        private ComboItem comboItem_89;
        [AccessedThroughProperty("ComboItem109")]
        private ComboItem comboItem_9;
        [AccessedThroughProperty("ComboItem177")]
        private ComboItem comboItem_90;
        [AccessedThroughProperty("ComboItem178")]
        private ComboItem comboItem_91;
        [AccessedThroughProperty("ComboItem179")]
        private ComboItem comboItem_92;
        [AccessedThroughProperty("ComboItem180")]
        private ComboItem comboItem_93;
        [AccessedThroughProperty("ComboItem181")]
        private ComboItem comboItem_94;
        [AccessedThroughProperty("ComboItem182")]
        private ComboItem comboItem_95;
        [AccessedThroughProperty("ComboItem183")]
        private ComboItem comboItem_96;
        [AccessedThroughProperty("ComboItem184")]
        private ComboItem comboItem_97;
        [AccessedThroughProperty("ComboItem185")]
        private ComboItem comboItem_98;
        [AccessedThroughProperty("ComboItem186")]
        private ComboItem comboItem_99;
        private GClass14 gclass14_0;
        private GClass22 gclass22_0;
        private IContainer icontainer_0;
        [AccessedThroughProperty("LabelX28")]
        private LabelX labelX_0;
        [AccessedThroughProperty("LabelX27")]
        private LabelX labelX_1;
        [AccessedThroughProperty("LabelX31")]
        private LabelX labelX_10;
        [AccessedThroughProperty("LabelX32")]
        private LabelX labelX_11;
        [AccessedThroughProperty("LabelX47")]
        private LabelX labelX_12;
        [AccessedThroughProperty("LabelX46")]
        private LabelX labelX_13;
        [AccessedThroughProperty("LabelX48")]
        private LabelX labelX_14;
        [AccessedThroughProperty("LabelX1")]
        private LabelX labelX_15;
        [AccessedThroughProperty("LabelX8")]
        private LabelX labelX_16;
        [AccessedThroughProperty("LabelX9")]
        private LabelX labelX_17;
        [AccessedThroughProperty("LabelX6")]
        private LabelX labelX_18;
        [AccessedThroughProperty("LabelX5")]
        private LabelX labelX_19;
        [AccessedThroughProperty("LabelX26")]
        private LabelX labelX_2;
        [AccessedThroughProperty("LabelX2")]
        private LabelX labelX_20;
        [AccessedThroughProperty("LabelX3")]
        private LabelX labelX_21;
        [AccessedThroughProperty("LabelX4")]
        private LabelX labelX_22;
        [AccessedThroughProperty("LabelX12")]
        private LabelX labelX_23;
        [AccessedThroughProperty("LabelX13")]
        private LabelX labelX_24;
        [AccessedThroughProperty("LabelX21")]
        private LabelX labelX_25;
        [AccessedThroughProperty("LabelX11")]
        private LabelX labelX_26;
        [AccessedThroughProperty("LabelX10")]
        private LabelX labelX_27;
        [AccessedThroughProperty("LabelX7")]
        private LabelX labelX_28;
        [AccessedThroughProperty("labelAfterdeathY")]
        private LabelX labelX_29;
        [AccessedThroughProperty("LabelX25")]
        private LabelX labelX_3;
        [AccessedThroughProperty("labelAfterdeathX")]
        private LabelX labelX_30;
        [AccessedThroughProperty("labelAfterdeathLocation")]
        private LabelX labelX_31;
        [AccessedThroughProperty("LabelX16")]
        private LabelX labelX_32;
        [AccessedThroughProperty("LabelX15")]
        private LabelX labelX_33;
        [AccessedThroughProperty("LabelX14")]
        private LabelX labelX_34;
        [AccessedThroughProperty("LabelX55")]
        private LabelX labelX_35;
        [AccessedThroughProperty("LabelX54")]
        private LabelX labelX_36;
        [AccessedThroughProperty("LabelX40")]
        private LabelX labelX_37;
        [AccessedThroughProperty("LabelX50")]
        private LabelX labelX_38;
        [AccessedThroughProperty("LabelX53")]
        private LabelX labelX_39;
        [AccessedThroughProperty("LabelX39")]
        private LabelX labelX_4;
        [AccessedThroughProperty("LabelX41")]
        private LabelX labelX_40;
        [AccessedThroughProperty("LabelX56")]
        private LabelX labelX_41;
        [AccessedThroughProperty("LabelX52")]
        private LabelX labelX_42;
        [AccessedThroughProperty("LabelX42")]
        private LabelX labelX_43;
        [AccessedThroughProperty("LabelX51")]
        private LabelX labelX_44;
        [AccessedThroughProperty("LabelX20")]
        private LabelX labelX_45;
        [AccessedThroughProperty("LabelX19")]
        private LabelX labelX_46;
        [AccessedThroughProperty("LabelX18")]
        private LabelX labelX_47;
        [AccessedThroughProperty("LabelX17")]
        private LabelX labelX_48;
        [AccessedThroughProperty("LabelX49")]
        private LabelX labelX_49;
        [AccessedThroughProperty("LabelX37")]
        private LabelX labelX_5;
        [AccessedThroughProperty("LabelX61")]
        private LabelX labelX_50;
        [AccessedThroughProperty("lblGrindY")]
        private LabelX labelX_51;
        [AccessedThroughProperty("lblGrindX")]
        private LabelX labelX_52;
        [AccessedThroughProperty("lblGrindLocation")]
        private LabelX labelX_53;
        [AccessedThroughProperty("LabelX22")]
        private LabelX labelX_54;
        [AccessedThroughProperty("LabelX23")]
        private LabelX labelX_55;
        [AccessedThroughProperty("LabelX24")]
        private LabelX labelX_56;
        [AccessedThroughProperty("LabelX57")]
        private LabelX labelX_57;
        [AccessedThroughProperty("lblTownWaitY")]
        private LabelX labelX_58;
        [AccessedThroughProperty("lblTownWaitX")]
        private LabelX labelX_59;
        [AccessedThroughProperty("LabelX38")]
        private LabelX labelX_6;
        [AccessedThroughProperty("lblTownWaitLocation")]
        private LabelX labelX_60;
        [AccessedThroughProperty("LabelX33")]
        private LabelX labelX_61;
        [AccessedThroughProperty("LabelX34")]
        private LabelX labelX_62;
        [AccessedThroughProperty("LabelX35")]
        private LabelX labelX_63;
        [AccessedThroughProperty("LabelX65")]
        private LabelX labelX_64;
        [AccessedThroughProperty("LabelX58")]
        private LabelX labelX_65;
        [AccessedThroughProperty("LabelX59")]
        private LabelX labelX_66;
        [AccessedThroughProperty("rechargeLocationY")]
        private LabelX labelX_67;
        [AccessedThroughProperty("rechargeLocationX")]
        private LabelX labelX_68;
        [AccessedThroughProperty("rechargeLocationName")]
        private LabelX labelX_69;
        [AccessedThroughProperty("LabelX36")]
        private LabelX labelX_7;
        [AccessedThroughProperty("LabelX43")]
        private LabelX labelX_70;
        [AccessedThroughProperty("LabelX44")]
        private LabelX labelX_71;
        [AccessedThroughProperty("LabelX45")]
        private LabelX labelX_72;
        [AccessedThroughProperty("LabelX67")]
        private LabelX labelX_73;
        [AccessedThroughProperty("LabelX29")]
        private LabelX labelX_8;
        [AccessedThroughProperty("LabelX30")]
        private LabelX labelX_9;
        [AccessedThroughProperty("lstGrindLocations")]
        private ListViewEx listViewEx_0;
        [AccessedThroughProperty("lstTownWaitLocations")]
        private ListViewEx listViewEx_1;
        [AccessedThroughProperty("lstrechargeLocations")]
        private ListViewEx listViewEx_2;
        public long long_0;
        [AccessedThroughProperty("PanelEx1")]
        private PanelEx panelEx_0;
        [AccessedThroughProperty("PanelEx2")]
        private PanelEx panelEx_1;
        [AccessedThroughProperty("PanelEx11")]
        private PanelEx panelEx_10;
        [AccessedThroughProperty("PanelEx12")]
        private PanelEx panelEx_11;
        [AccessedThroughProperty("PanelEx13")]
        private PanelEx panelEx_12;
        [AccessedThroughProperty("PanelEx14")]
        private PanelEx panelEx_13;
        [AccessedThroughProperty("PanelEx15")]
        private PanelEx panelEx_14;
        [AccessedThroughProperty("PanelEx16")]
        private PanelEx panelEx_15;
        [AccessedThroughProperty("PanelEx18")]
        private PanelEx panelEx_16;
        [AccessedThroughProperty("PanelEx17")]
        private PanelEx panelEx_17;
        [AccessedThroughProperty("PanelEx5")]
        private PanelEx panelEx_2;
        [AccessedThroughProperty("PanelEx4")]
        private PanelEx panelEx_3;
        [AccessedThroughProperty("PanelEx3")]
        private PanelEx panelEx_4;
        [AccessedThroughProperty("PanelEx10")]
        private PanelEx panelEx_5;
        [AccessedThroughProperty("PanelEx9")]
        private PanelEx panelEx_6;
        [AccessedThroughProperty("PanelEx8")]
        private PanelEx panelEx_7;
        [AccessedThroughProperty("PanelEx7")]
        private PanelEx panelEx_8;
        [AccessedThroughProperty("PanelEx6")]
        private PanelEx panelEx_9;
        public Process process_0;
        public SlidePanel slidePanel_0;
        public string string_0;
        private string string_1;
        private string string_2;
        private string string_3;
        private string string_4;
        [AccessedThroughProperty("SuperTabControl1")]
        private SuperTabControl superTabControl_0;
        [AccessedThroughProperty("SuperTabControl2")]
        private SuperTabControl superTabControl_1;
        [AccessedThroughProperty("SuperTabControlPanel1")]
        private SuperTabControlPanel superTabControlPanel_0;
        [AccessedThroughProperty("SuperTabControlPanel5")]
        private SuperTabControlPanel superTabControlPanel_1;
        [AccessedThroughProperty("SuperTabControlPanel4")]
        private SuperTabControlPanel superTabControlPanel_2;
        [AccessedThroughProperty("SuperTabControlPanel2")]
        private SuperTabControlPanel superTabControlPanel_3;
        [AccessedThroughProperty("SuperTabControlPanel3")]
        private SuperTabControlPanel superTabControlPanel_4;
        [AccessedThroughProperty("SuperTabControlPanel6")]
        private SuperTabControlPanel superTabControlPanel_5;
        [AccessedThroughProperty("SuperTabControlPanel7")]
        private SuperTabControlPanel superTabControlPanel_6;
        [AccessedThroughProperty("SuperTabControlPanel8")]
        private SuperTabControlPanel superTabControlPanel_7;
        [AccessedThroughProperty("SuperTabItem1")]
        private SuperTabItem superTabItem_0;
        [AccessedThroughProperty("SuperTabItem5")]
        private SuperTabItem superTabItem_1;
        [AccessedThroughProperty("SuperTabItem4")]
        private SuperTabItem superTabItem_2;
        [AccessedThroughProperty("SuperTabItem2")]
        private SuperTabItem superTabItem_3;
        [AccessedThroughProperty("SuperTabItem3")]
        private SuperTabItem superTabItem_4;
        [AccessedThroughProperty("tabGrindLocations")]
        private SuperTabItem superTabItem_5;
        [AccessedThroughProperty("SuperTabItem7")]
        private SuperTabItem superTabItem_6;
        [AccessedThroughProperty("SuperTabItem6")]
        private SuperTabItem superTabItem_7;
        [AccessedThroughProperty("SwitchButton1")]
        private SwitchButton switchButton_0;
        [AccessedThroughProperty("swtGrindLocationEnabled")]
        private SwitchButton switchButton_1;
        [AccessedThroughProperty("swtLifePotionEnabled")]
        private SwitchButton switchButton_10;
        [AccessedThroughProperty("swtManaPotionEnabled")]
        private SwitchButton switchButton_11;
        [AccessedThroughProperty("swtAfterDeathOption")]
        private SwitchButton switchButton_12;
        [AccessedThroughProperty("swtSpeedEnable")]
        private SwitchButton switchButton_13;
        [AccessedThroughProperty("swtTurnOption")]
        private SwitchButton switchButton_14;
        [AccessedThroughProperty("swtCloseMobInfo")]
        private SwitchButton switchButton_15;
        [AccessedThroughProperty("swtAllInfo")]
        private SwitchButton switchButton_16;
        [AccessedThroughProperty("swtTradeWindows")]
        private SwitchButton switchButton_17;
        [AccessedThroughProperty("swtWhisperWindows")]
        private SwitchButton switchButton_18;
        [AccessedThroughProperty("swtGrindLocationVariable")]
        private SwitchButton switchButton_2;
        [AccessedThroughProperty("swtGrindLocationAction")]
        private SwitchButton switchButton_3;
        [AccessedThroughProperty("swtTownWaitEnable")]
        private SwitchButton switchButton_4;
        [AccessedThroughProperty("swtTownWaitVariable")]
        private SwitchButton switchButton_5;
        [AccessedThroughProperty("swtTownWaitAction")]
        private SwitchButton switchButton_6;
        [AccessedThroughProperty("rechargeEnable")]
        private SwitchButton switchButton_7;
        [AccessedThroughProperty("swtrechargeAction")]
        private SwitchButton switchButton_8;
        [AccessedThroughProperty("swtHealPotionEnabled")]
        private SwitchButton switchButton_9;
        [AccessedThroughProperty("txtGrindLocationBattles")]
        private TextBoxX textBoxX_0;
        [AccessedThroughProperty("txtTownBattles")]
        private TextBoxX textBoxX_1;
        [AccessedThroughProperty("memVariables")]
        private Timer timer_0;

        public BotSettings()
        {
            Load += new EventHandler(BotSettings_Load);
            gclass22_0 = new GClass22();
            InitializeComponent();
        }

        private void BotSettings_Load(object sender, EventArgs e)
        {
            Color color;
            List<GClass1.GClass2>.Enumerator enumerator;

            vmethod_314().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_448().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_424().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_354().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_550().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_542().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_518().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_498().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_488().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_576().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_612().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_632().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_642().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_660().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_678().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_698().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_688().Style.BorderColor.Color = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_680().Border.BorderLeftColor = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_680().Border.BorderRightColor = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_690().Border.BorderLeftColor = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_690().Border.BorderRightColor = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_638().Border.BorderLeftColor = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            vmethod_638().Border.BorderRightColor = Class1.Class2_0.method_7().vmethod_18().ManagerColorTint;
            try
            {
                List<GClass1.GClass2> list = GClass1.list_0.FindAll(new Predicate<GClass1.GClass2>(method_17));
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
                method_3();
            }
            catch (Exception e2)
            {
                ProjectData.SetProjectError(e2);
                Interaction.MsgBox(e2.Message, MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Color color;

            icontainer_0 = new Container();
            SuperTabColorTable superTabColorTable1 = new SuperTabColorTable();
            SuperTabLinearGradientColorTable superTabLinearGradientColorTable1 = new SuperTabLinearGradientColorTable();
            SuperTabPanelColorTable superTabPanelColorTable1 = new SuperTabPanelColorTable();
            SuperTabPanelItemColorTable superTabPanelItemColorTable1 = new SuperTabPanelItemColorTable();
            SuperTabLinearGradientColorTable superTabLinearGradientColorTable2 = new SuperTabLinearGradientColorTable();
            SuperTabItemColorTable superTabItemColorTable1 = new SuperTabItemColorTable();
            SuperTabColorStates superTabColorStates1 = new SuperTabColorStates();
            SuperTabItemStateColorTable superTabItemStateColorTable1 = new SuperTabItemStateColorTable();
            SuperTabColorTable superTabColorTable2 = new SuperTabColorTable();
            SuperTabLinearGradientColorTable superTabLinearGradientColorTable3 = new SuperTabLinearGradientColorTable();
            SuperTabPanelColorTable superTabPanelColorTable2 = new SuperTabPanelColorTable();
            SuperTabPanelItemColorTable superTabPanelItemColorTable2 = new SuperTabPanelItemColorTable();
            SuperTabLinearGradientColorTable superTabLinearGradientColorTable4 = new SuperTabLinearGradientColorTable();
            SuperTabItemColorTable superTabItemColorTable2 = new SuperTabItemColorTable();
            SuperTabColorStates superTabColorStates2 = new SuperTabColorStates();
            SuperTabItemStateColorTable superTabItemStateColorTable2 = new SuperTabItemStateColorTable();
            SuperTabPanelColorTable superTabPanelColorTable3 = new SuperTabPanelColorTable();
            SuperTabPanelItemColorTable superTabPanelItemColorTable3 = new SuperTabPanelItemColorTable();
            SuperTabLinearGradientColorTable superTabLinearGradientColorTable5 = new SuperTabLinearGradientColorTable();
            SuperTabItemColorTable superTabItemColorTable3 = new SuperTabItemColorTable();
            SuperTabColorStates superTabColorStates3 = new SuperTabColorStates();
            SuperTabItemStateColorTable superTabItemStateColorTable3 = new SuperTabItemStateColorTable();
            SuperTabPanelColorTable superTabPanelColorTable4 = new SuperTabPanelColorTable();
            SuperTabPanelItemColorTable superTabPanelItemColorTable4 = new SuperTabPanelItemColorTable();
            SuperTabLinearGradientColorTable superTabLinearGradientColorTable6 = new SuperTabLinearGradientColorTable();
            SuperTabItemColorTable superTabItemColorTable4 = new SuperTabItemColorTable();
            SuperTabColorStates superTabColorStates4 = new SuperTabColorStates();
            SuperTabItemStateColorTable superTabItemStateColorTable4 = new SuperTabItemStateColorTable();
            SuperTabItemColorTable superTabItemColorTable5 = new SuperTabItemColorTable();
            SuperTabColorStates superTabColorStates5 = new SuperTabColorStates();
            SuperTabItemStateColorTable superTabItemStateColorTable5 = new SuperTabItemStateColorTable();
            SuperTabPanelColorTable superTabPanelColorTable5 = new SuperTabPanelColorTable();
            SuperTabPanelItemColorTable superTabPanelItemColorTable5 = new SuperTabPanelItemColorTable();
            SuperTabLinearGradientColorTable superTabLinearGradientColorTable7 = new SuperTabLinearGradientColorTable();
            SuperTabItemColorTable superTabItemColorTable6 = new SuperTabItemColorTable();
            SuperTabColorStates superTabColorStates6 = new SuperTabColorStates();
            SuperTabItemStateColorTable superTabItemStateColorTable6 = new SuperTabItemStateColorTable();
            SuperTabPanelColorTable superTabPanelColorTable6 = new SuperTabPanelColorTable();
            SuperTabPanelItemColorTable superTabPanelItemColorTable6 = new SuperTabPanelItemColorTable();
            SuperTabLinearGradientColorTable superTabLinearGradientColorTable8 = new SuperTabLinearGradientColorTable();
            SuperTabItemColorTable superTabItemColorTable7 = new SuperTabItemColorTable();
            SuperTabColorStates superTabColorStates7 = new SuperTabColorStates();
            SuperTabItemStateColorTable superTabItemStateColorTable7 = new SuperTabItemStateColorTable();
            SuperTabPanelColorTable superTabPanelColorTable7 = new SuperTabPanelColorTable();
            SuperTabPanelItemColorTable superTabPanelItemColorTable7 = new SuperTabPanelItemColorTable();
            SuperTabLinearGradientColorTable superTabLinearGradientColorTable9 = new SuperTabLinearGradientColorTable();
            SuperTabItemColorTable superTabItemColorTable8 = new SuperTabItemColorTable();
            SuperTabColorStates superTabColorStates8 = new SuperTabColorStates();
            SuperTabItemStateColorTable superTabItemStateColorTable8 = new SuperTabItemStateColorTable();
            vmethod_1(new SuperTabControl());
            vmethod_15(new SuperTabControlPanel());
            vmethod_613(new PanelEx());
            vmethod_615(new SwitchButton());
            vmethod_617(new LabelX());
            vmethod_619(new SwitchButton());
            vmethod_621(new SwitchButton());
            vmethod_623(new SwitchButton());
            vmethod_625(new LabelX());
            vmethod_627(new LabelX());
            vmethod_629(new LabelX());
            vmethod_631(new LabelX());
            vmethod_17(new SuperTabItem());
            vmethod_11(new SuperTabControlPanel());
            vmethod_39(new SuperTabControl());
            vmethod_253(new SuperTabControlPanel());
            vmethod_689(new PanelEx());
            vmethod_691(new ListViewEx());
            vmethod_693(new ColumnHeader());
            vmethod_695(new ButtonX());
            vmethod_697(new LabelX());
            vmethod_699(new PanelEx());
            vmethod_701(new LabelX());
            vmethod_703(new LabelX());
            vmethod_705(new LabelX());
            vmethod_707(new LabelX());
            vmethod_709(new LabelX());
            vmethod_711(new ButtonX());
            vmethod_713(new LabelX());
            vmethod_715(new LabelX());
            vmethod_287(new ComboBoxEx());
            vmethod_289(new ComboItem());
            vmethod_291(new ComboItem());
            vmethod_293(new ComboItem());
            vmethod_295(new ComboItem());
            vmethod_297(new ComboItem());
            vmethod_299(new ComboItem());
            vmethod_301(new ComboItem());
            vmethod_303(new ComboItem());
            vmethod_305(new ComboItem());
            vmethod_307(new ComboItem());
            vmethod_309(new LabelX());
            vmethod_257(new ComboBoxEx());
            vmethod_311(new ComboItem());
            vmethod_259(new ComboItem());
            vmethod_261(new ComboItem());
            vmethod_263(new ComboItem());
            vmethod_265(new ComboItem());
            vmethod_267(new ComboItem());
            vmethod_269(new ComboItem());
            vmethod_271(new ComboItem());
            vmethod_273(new ComboItem());
            vmethod_275(new ComboItem());
            vmethod_277(new ComboItem());
            vmethod_279(new LabelX());
            vmethod_281(new SwitchButton());
            vmethod_283(new LabelX());
            vmethod_285(new SwitchButton());
            vmethod_255(new SuperTabItem());
            vmethod_41(new SuperTabControlPanel());
            vmethod_643(new PanelEx());
            vmethod_645(new LabelX());
            vmethod_647(new LabelX());
            vmethod_649(new LabelX());
            vmethod_651(new LabelX());
            vmethod_653(new LabelX());
            vmethod_655(new ButtonX());
            vmethod_657(new LabelX());
            vmethod_659(new LabelX());
            vmethod_633(new PanelEx());
            vmethod_639(new ListViewEx());
            vmethod_641(new ColumnHeader());
            vmethod_635(new ButtonX());
            vmethod_637(new LabelX());
            vmethod_91(new TextBoxX());
            vmethod_51(new SwitchButton());
            vmethod_53(new LabelX());
            vmethod_55(new LabelX());
            vmethod_57(new LabelX());
            vmethod_59(new ComboBoxEx());
            vmethod_93(new ComboItem());
            vmethod_95(new ComboItem());
            vmethod_97(new ComboItem());
            vmethod_99(new ComboItem());
            vmethod_101(new ComboItem());
            vmethod_103(new ComboItem());
            vmethod_105(new ComboItem());
            vmethod_107(new ComboItem());
            vmethod_109(new ComboItem());
            vmethod_111(new ComboItem());
            vmethod_113(new ComboItem());
            vmethod_115(new ComboItem());
            vmethod_61(new ComboBoxEx());
            vmethod_117(new ComboItem());
            vmethod_119(new ComboItem());
            vmethod_121(new ComboItem());
            vmethod_123(new ComboItem());
            vmethod_125(new ComboItem());
            vmethod_127(new ComboItem());
            vmethod_129(new ComboItem());
            vmethod_131(new ComboItem());
            vmethod_133(new ComboItem());
            vmethod_135(new ComboItem());
            vmethod_137(new ComboItem());
            vmethod_139(new ComboItem());
            vmethod_141(new ComboItem());
            vmethod_63(new SwitchButton());
            vmethod_65(new LabelX());
            vmethod_67(new SwitchButton());
            vmethod_43(new SwitchButton());
            vmethod_45(new SuperTabItem());
            vmethod_47(new SuperTabControlPanel());
            vmethod_679(new PanelEx());
            vmethod_681(new ListViewEx());
            vmethod_683(new ColumnHeader());
            vmethod_687(new LabelX());
            vmethod_685(new ButtonX());
            vmethod_661(new PanelEx());
            vmethod_663(new LabelX());
            vmethod_665(new LabelX());
            vmethod_667(new LabelX());
            vmethod_669(new LabelX());
            vmethod_671(new LabelX());
            vmethod_673(new ButtonX());
            vmethod_675(new LabelX());
            vmethod_677(new LabelX());
            vmethod_143(new TextBoxX());
            vmethod_145(new ComboBoxEx());
            vmethod_147(new ComboItem());
            vmethod_149(new ComboItem());
            vmethod_151(new ComboItem());
            vmethod_153(new ComboItem());
            vmethod_155(new ComboItem());
            vmethod_157(new ComboItem());
            vmethod_159(new ComboItem());
            vmethod_161(new ComboItem());
            vmethod_163(new ComboItem());
            vmethod_165(new ComboItem());
            vmethod_167(new ComboItem());
            vmethod_169(new ComboItem());
            vmethod_171(new ComboBoxEx());
            vmethod_173(new ComboItem());
            vmethod_175(new ComboItem());
            vmethod_177(new ComboItem());
            vmethod_179(new ComboItem());
            vmethod_181(new ComboItem());
            vmethod_183(new ComboItem());
            vmethod_185(new ComboItem());
            vmethod_187(new ComboItem());
            vmethod_189(new ComboItem());
            vmethod_191(new ComboItem());
            vmethod_193(new ComboItem());
            vmethod_195(new ComboItem());
            vmethod_197(new ComboItem());
            vmethod_199(new ComboBoxEx());
            vmethod_201(new ComboItem());
            vmethod_203(new ComboItem());
            vmethod_205(new ComboItem());
            vmethod_207(new ComboItem());
            vmethod_209(new ComboItem());
            vmethod_211(new ComboItem());
            vmethod_213(new ComboItem());
            vmethod_215(new ComboItem());
            vmethod_217(new ComboItem());
            vmethod_219(new ComboItem());
            vmethod_221(new ComboItem());
            vmethod_223(new ComboItem());
            vmethod_225(new ComboBoxEx());
            vmethod_227(new ComboItem());
            vmethod_229(new ComboItem());
            vmethod_231(new ComboItem());
            vmethod_233(new ComboItem());
            vmethod_235(new ComboItem());
            vmethod_237(new ComboItem());
            vmethod_239(new ComboItem());
            vmethod_241(new ComboItem());
            vmethod_243(new ComboItem());
            vmethod_245(new ComboItem());
            vmethod_247(new ComboItem());
            vmethod_249(new ComboItem());
            vmethod_251(new ComboItem());
            vmethod_69(new LabelX());
            vmethod_71(new LabelX());
            vmethod_73(new LabelX());
            vmethod_75(new LabelX());
            vmethod_77(new SwitchButton());
            vmethod_79(new LabelX());
            vmethod_81(new LabelX());
            vmethod_83(new LabelX());
            vmethod_85(new SwitchButton());
            vmethod_87(new LabelX());
            vmethod_89(new SwitchButton());
            vmethod_49(new SuperTabItem());
            vmethod_13(new SuperTabItem());
            vmethod_23(new SuperTabControlPanel());
            vmethod_577(new PanelEx());
            vmethod_593(new LabelX());
            vmethod_579(new LabelX());
            vmethod_581(new LabelX());
            vmethod_583(new LabelX());
            vmethod_585(new LabelX());
            vmethod_587(new LabelX());
            vmethod_589(new ButtonX());
            vmethod_591(new LabelX());
            vmethod_489(new PanelEx());
            vmethod_595(new LabelX());
            vmethod_491(new ButtonX());
            vmethod_493(new LabelX());
            vmethod_495(new ComboBoxEx());
            vmethod_497(new SwitchButton());
            vmethod_25(new SuperTabItem());
            vmethod_19(new SuperTabControlPanel());
            vmethod_499(new PanelEx());
            vmethod_605(new LabelX());
            vmethod_501(new SwitchButton());
            vmethod_503(new ComboBoxEx());
            vmethod_505(new ComboItem());
            vmethod_507(new ComboItem());
            vmethod_509(new ComboItem());
            vmethod_511(new ComboItem());
            vmethod_513(new ComboItem());
            vmethod_515(new ComboItem());
            vmethod_517(new LabelX());
            vmethod_519(new PanelEx());
            vmethod_607(new LabelX());
            vmethod_521(new ComboBoxEx());
            vmethod_523(new ComboItem());
            vmethod_525(new ComboItem());
            vmethod_527(new ComboItem());
            vmethod_529(new ComboItem());
            vmethod_531(new ComboItem());
            vmethod_533(new ComboItem());
            vmethod_535(new ComboItem());
            vmethod_537(new ComboItem());
            vmethod_539(new ComboItem());
            vmethod_541(new LabelX());
            vmethod_543(new PanelEx());
            vmethod_609(new LabelX());
            vmethod_545(new SwitchButton());
            vmethod_547(new LabelX());
            vmethod_549(new LabelX());
            vmethod_551(new PanelEx());
            vmethod_611(new LabelX());
            vmethod_553(new ComboBoxEx());
            vmethod_555(new ComboItem());
            vmethod_557(new ComboItem());
            vmethod_559(new ComboItem());
            vmethod_561(new ComboItem());
            vmethod_563(new ComboItem());
            vmethod_565(new ComboItem());
            vmethod_567(new ComboItem());
            vmethod_569(new ComboItem());
            vmethod_571(new ComboItem());
            vmethod_573(new ComboItem());
            vmethod_575(new LabelX());
            vmethod_21(new SuperTabItem());
            vmethod_3(new SuperTabControlPanel());
            vmethod_355(new PanelEx());
            vmethod_597(new LabelX());
            vmethod_357(new LabelX());
            vmethod_359(new LabelX());
            vmethod_361(new ComboBoxEx());
            vmethod_363(new ComboItem());
            vmethod_365(new ComboItem());
            vmethod_367(new ComboItem());
            vmethod_369(new ComboItem());
            vmethod_371(new ComboItem());
            vmethod_373(new ComboItem());
            vmethod_375(new ComboItem());
            vmethod_377(new ComboItem());
            vmethod_379(new ComboBoxEx());
            vmethod_381(new ComboItem());
            vmethod_383(new ComboItem());
            vmethod_385(new ComboItem());
            vmethod_387(new ComboItem());
            vmethod_389(new ComboItem());
            vmethod_391(new ComboItem());
            vmethod_393(new ComboItem());
            vmethod_395(new ComboItem());
            vmethod_397(new ComboItem());
            vmethod_399(new ComboBoxEx());
            vmethod_401(new ComboItem());
            vmethod_403(new ComboItem());
            vmethod_405(new ComboItem());
            vmethod_407(new ComboItem());
            vmethod_409(new ComboItem());
            vmethod_411(new ComboItem());
            vmethod_413(new ComboItem());
            vmethod_415(new ComboItem());
            vmethod_417(new ComboItem());
            vmethod_419(new LabelX());
            vmethod_421(new LabelX());
            vmethod_423(new LabelX());
            vmethod_425(new PanelEx());
            vmethod_599(new LabelX());
            vmethod_427(new LabelX());
            vmethod_429(new SwitchButton());
            vmethod_431(new ComboBoxEx());
            vmethod_433(new ComboItem());
            vmethod_435(new ComboItem());
            vmethod_437(new ComboItem());
            vmethod_439(new ComboItem());
            vmethod_441(new ComboItem());
            vmethod_443(new ComboItem());
            vmethod_445(new ComboItem());
            vmethod_447(new ComboItem());
            vmethod_449(new PanelEx());
            vmethod_601(new LabelX());
            vmethod_451(new LabelX());
            vmethod_453(new SwitchButton());
            vmethod_455(new ComboBoxEx());
            vmethod_457(new ComboItem());
            vmethod_459(new ComboItem());
            vmethod_461(new ComboItem());
            vmethod_463(new ComboItem());
            vmethod_465(new ComboItem());
            vmethod_467(new ComboItem());
            vmethod_469(new ComboItem());
            vmethod_471(new ComboItem());
            vmethod_473(new ComboItem());
            vmethod_475(new ComboItem());
            vmethod_477(new ComboItem());
            vmethod_479(new ComboItem());
            vmethod_481(new ComboItem());
            vmethod_483(new ComboItem());
            vmethod_485(new ComboItem());
            vmethod_487(new ComboItem());
            vmethod_315(new PanelEx());
            vmethod_603(new LabelX());
            vmethod_317(new LabelX());
            vmethod_319(new SwitchButton());
            vmethod_321(new ComboBoxEx());
            vmethod_323(new ComboItem());
            vmethod_325(new ComboItem());
            vmethod_327(new ComboItem());
            vmethod_329(new ComboItem());
            vmethod_331(new ComboItem());
            vmethod_333(new ComboItem());
            vmethod_335(new ComboItem());
            vmethod_337(new ComboItem());
            vmethod_339(new ComboItem());
            vmethod_341(new ComboItem());
            vmethod_343(new ComboItem());
            vmethod_345(new ComboItem());
            vmethod_347(new ComboItem());
            vmethod_349(new ComboItem());
            vmethod_351(new ComboItem());
            vmethod_353(new ComboItem());
            vmethod_5(new SuperTabItem());
            vmethod_7(new PanelEx());
            vmethod_313(new ButtonX());
            vmethod_9(new ButtonX());
            vmethod_27(new Timer(icontainer_0));
            vmethod_29(new ComboItem());
            vmethod_31(new ComboItem());
            vmethod_33(new ComboItem());
            vmethod_35(new ComboItem());
            vmethod_37(new ComboItem());
            vmethod_0().BeginInit();
            vmethod_0().SuspendLayout();
            vmethod_14().SuspendLayout();
            vmethod_612().SuspendLayout();
            vmethod_10().SuspendLayout();
            vmethod_38().BeginInit();
            vmethod_38().SuspendLayout();
            vmethod_252().SuspendLayout();
            vmethod_688().SuspendLayout();
            vmethod_698().SuspendLayout();
            vmethod_40().SuspendLayout();
            vmethod_642().SuspendLayout();
            vmethod_632().SuspendLayout();
            vmethod_46().SuspendLayout();
            vmethod_678().SuspendLayout();
            vmethod_660().SuspendLayout();
            vmethod_22().SuspendLayout();
            vmethod_576().SuspendLayout();
            vmethod_488().SuspendLayout();
            vmethod_18().SuspendLayout();
            vmethod_498().SuspendLayout();
            vmethod_518().SuspendLayout();
            vmethod_542().SuspendLayout();
            vmethod_550().SuspendLayout();
            vmethod_2().SuspendLayout();
            vmethod_354().SuspendLayout();
            vmethod_424().SuspendLayout();
            vmethod_448().SuspendLayout();
            vmethod_314().SuspendLayout();
            vmethod_6().SuspendLayout();
            SuspendLayout();
            vmethod_0().BackColor = Color.Black;
            vmethod_0().ControlBox.CloseBox.Name = "";
            vmethod_0().ControlBox.MenuBox.Name = "";
            vmethod_0().ControlBox.MenuBox.PopupAnimation = ePopupAnimation.None;
            vmethod_0().ControlBox.MenuBox.Visible = false;
            vmethod_0().ControlBox.Name = "";
            BaseItem[] baseItemArr = new BaseItem[] {
                                                      vmethod_0().ControlBox.MenuBox, 
                                                      vmethod_0().ControlBox.CloseBox };
            vmethod_0().ControlBox.SubItems.AddRange(baseItemArr);
            vmethod_0().Controls.Add(vmethod_10());
            vmethod_0().Controls.Add(vmethod_18());
            vmethod_0().Controls.Add(vmethod_2());
            vmethod_0().Controls.Add(vmethod_14());
            vmethod_0().Controls.Add(vmethod_22());
            vmethod_0().Dock = DockStyle.Fill;
            vmethod_0().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_0().ForeColor = Color.White;
            Point point = new Point(0, 0);
            vmethod_0().Location = point;
            vmethod_0().Name = "SuperTabControl1";
            vmethod_0().ReorderTabsEnabled = true;
            vmethod_0().SelectedTabFont = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_0().SelectedTabIndex = 0;
            Size size = new Size(484, 343);
            vmethod_0().Size = size;
            vmethod_0().TabFont = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_0().TabIndex = 0;
            baseItemArr = new BaseItem[] {
                                           vmethod_4(), 
                                           vmethod_20(), 
                                           vmethod_24(), 
                                           vmethod_16(), 
                                           vmethod_12() };
            vmethod_0().Tabs.AddRange(baseItemArr);
            Color[] colorArr = new Color[1];
            colorArr[0] = Color.Black;
            superTabLinearGradientColorTable1.Colors = colorArr;
            superTabColorTable1.Background = superTabLinearGradientColorTable1;
            vmethod_0().TabStripColor = superTabColorTable1;
            vmethod_0().TabStyle = eSuperTabStyle.Office2010BackstageBlue;
            vmethod_0().Text = "AFTER DEATH";
            vmethod_14().CanvasColor = Color.Black;
            vmethod_14().ColorSchemeStyle = eDotNetBarStyle.Metro;
            vmethod_14().Controls.Add(vmethod_612());
            vmethod_14().Dock = DockStyle.Fill;
            point = new Point(0, 0);
            vmethod_14().Location = point;
            vmethod_14().Name = "SuperTabControlPanel4";
            colorArr = new Color[1];
            colorArr[0] = Color.Black;
            superTabLinearGradientColorTable2.Colors = colorArr;
            superTabPanelItemColorTable1.Background = superTabLinearGradientColorTable2;
            superTabPanelItemColorTable1.InnerBorder = Color.Black;
            superTabPanelItemColorTable1.OuterBorder = Color.Black;
            superTabPanelColorTable1.Default = superTabPanelItemColorTable1;
            vmethod_14().PanelColor = superTabPanelColorTable1;
            size = new Size(484, 343);
            vmethod_14().Size = size;
            vmethod_14().TabIndex = 0;
            vmethod_14().TabItem = vmethod_16();
            vmethod_612().CanvasColor = SystemColors.Control;
            vmethod_612().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_612().Controls.Add(vmethod_614());
            vmethod_612().Controls.Add(vmethod_616());
            vmethod_612().Controls.Add(vmethod_618());
            vmethod_612().Controls.Add(vmethod_620());
            vmethod_612().Controls.Add(vmethod_622());
            vmethod_612().Controls.Add(vmethod_624());
            vmethod_612().Controls.Add(vmethod_626());
            vmethod_612().Controls.Add(vmethod_628());
            vmethod_612().Controls.Add(vmethod_630());
            point = new Point(12, 20);
            vmethod_612().Location = point;
            vmethod_612().Name = "PanelEx12";
            size = new Size(267, 178);
            vmethod_612().Size = size;
            vmethod_612().Style.Alignment = StringAlignment.Center;
            vmethod_612().Style.BackColor1.Color = Color.Black;
            vmethod_612().Style.Border = eBorderType.SingleLine;
            vmethod_612().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_612().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_612().Style.GradientAngle = 90;
            vmethod_612().TabIndex = 42;
            vmethod_614().BackColor = Color.Black;
            vmethod_614().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_614().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_614().ForeColor = Color.White;
            point = new Point(11, 104);
            vmethod_614().Location = point;
            vmethod_614().Name = "swtCloseMobInfo";
            vmethod_614().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_614().OffTextColor = Color.White;
            size = new Size(62, 19);
            vmethod_614().Size = size;
            vmethod_614().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_614().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_614().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_614().SwitchWidth = 6;
            vmethod_614().TabIndex = 58;
            vmethod_616().AutoSize = true;
            vmethod_616().BackColor = Color.Black;
            vmethod_616().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_616().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_616().ForeColor = Color.White;
            point = new Point(79, 105);
            vmethod_616().Location = point;
            vmethod_616().Name = "LabelX20";
            size = new Size(121, 17);
            vmethod_616().Size = size;
            vmethod_616().TabIndex = 57;
            vmethod_616().Text = "CLOSE MONSTER INFO";
            vmethod_618().BackColor = Color.Black;
            vmethod_618().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_618().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_618().ForeColor = Color.White;
            point = new Point(11, 79);
            vmethod_618().Location = point;
            vmethod_618().Name = "swtAllInfo";
            vmethod_618().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_618().OffTextColor = Color.White;
            size = new Size(62, 19);
            vmethod_618().Size = size;
            vmethod_618().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_618().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_618().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_618().SwitchWidth = 6;
            vmethod_618().TabIndex = 56;
            vmethod_620().BackColor = Color.Black;
            vmethod_620().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_620().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_620().ForeColor = Color.White;
            point = new Point(11, 54);
            vmethod_620().Location = point;
            vmethod_620().Name = "swtTradeWindows";
            vmethod_620().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_620().OffTextColor = Color.White;
            size = new Size(62, 19);
            vmethod_620().Size = size;
            vmethod_620().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_620().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_620().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_620().SwitchWidth = 6;
            vmethod_620().TabIndex = 55;
            vmethod_622().BackColor = Color.Black;
            vmethod_622().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_622().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_622().ForeColor = Color.White;
            point = new Point(11, 29);
            vmethod_622().Location = point;
            vmethod_622().Name = "swtWhisperWindows";
            vmethod_622().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_622().OffTextColor = Color.White;
            size = new Size(62, 19);
            vmethod_622().Size = size;
            vmethod_622().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_622().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_622().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_622().SwitchWidth = 6;
            vmethod_622().TabIndex = 54;
            vmethod_624().AutoSize = true;
            vmethod_624().BackColor = Color.Black;
            vmethod_624().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_624().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_624().ForeColor = Color.White;
            point = new Point(79, 80);
            vmethod_624().Location = point;
            vmethod_624().Name = "LabelX19";
            size = new Size(94, 17);
            vmethod_624().Size = size;
            vmethod_624().TabIndex = 53;
            vmethod_624().Text = "ACCEPT ALL INFO";
            vmethod_626().AutoSize = true;
            vmethod_626().BackColor = Color.Black;
            vmethod_626().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_626().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_626().ForeColor = Color.White;
            point = new Point(79, 55);
            vmethod_626().Location = point;
            vmethod_626().Name = "LabelX18";
            size = new Size(134, 17);
            vmethod_626().Size = size;
            vmethod_626().TabIndex = 52;
            vmethod_626().Text = "CLOSE TRADE WINDOWS";
            vmethod_628().AutoSize = true;
            vmethod_628().BackColor = Color.Black;
            vmethod_628().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_628().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_628().ForeColor = Color.White;
            point = new Point(79, 30);
            vmethod_628().Location = point;
            vmethod_628().Name = "LabelX17";
            size = new Size(147, 17);
            vmethod_628().Size = size;
            vmethod_628().TabIndex = 51;
            vmethod_628().Text = "CLOSE WHISPER WINDOWS";
            BackgroundColorBlend[] backgroundColorBlendArr = new BackgroundColorBlend[] {
                                                                                          new BackgroundColorBlend(Color.FromArgb(255, 128, 0), 0.0F), 
                                                                                          new BackgroundColorBlend(Color.Black, 0.0F) };
            vmethod_630().BackgroundStyle.BackColorBlend.AddRange(backgroundColorBlendArr);
            vmethod_630().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_630().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_630().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_630().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_630().BackgroundStyle.MarginLeft = 1;
            vmethod_630().BackgroundStyle.MarginRight = 1;
            vmethod_630().BackgroundStyle.MarginTop = 1;
            vmethod_630().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_630().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Far;
            vmethod_630().Dock = DockStyle.Top;
            vmethod_630().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_630().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_630().Location = point;
            vmethod_630().Name = "LabelX49";
            vmethod_630().PaddingLeft = 10;
            size = new Size(267, 22);
            vmethod_630().Size = size;
            vmethod_630().TabIndex = 50;
            vmethod_630().Text = "WINDOW OPTIONS";
            vmethod_630().TextLineAlignment = StringAlignment.Near;
            vmethod_16().AttachedControl = vmethod_14();
            vmethod_16().GlobalItem = false;
            vmethod_16().Name = "SuperTabItem4";
            superTabItemStateColorTable1.SelectionMarker = Color.Black;
            superTabColorStates1.Selected = superTabItemStateColorTable1;
            superTabItemColorTable1.Default = superTabColorStates1;
            vmethod_16().TabColor = superTabItemColorTable1;
            vmethod_16().Text = "WINDOWS";
            vmethod_10().Controls.Add(vmethod_38());
            vmethod_10().Dock = DockStyle.Fill;
            point = new Point(0, 25);
            vmethod_10().Location = point;
            vmethod_10().Name = "SuperTabControlPanel5";
            size = new Size(484, 318);
            vmethod_10().Size = size;
            vmethod_10().TabIndex = 0;
            vmethod_10().TabItem = vmethod_12();
            vmethod_38().BackColor = Color.Transparent;
            vmethod_38().ControlBox.CloseBox.Name = "";
            vmethod_38().ControlBox.MenuBox.Name = "";
            vmethod_38().ControlBox.MenuBox.Visible = false;
            vmethod_38().ControlBox.Name = "";
            baseItemArr = new BaseItem[] {
                                           vmethod_38().ControlBox.MenuBox, 
                                           vmethod_38().ControlBox.CloseBox };
            vmethod_38().ControlBox.SubItems.AddRange(baseItemArr);
            vmethod_38().Controls.Add(vmethod_252());
            vmethod_38().Controls.Add(vmethod_40());
            vmethod_38().Controls.Add(vmethod_46());
            vmethod_38().Dock = DockStyle.Fill;
            vmethod_38().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_38().Location = point;
            vmethod_38().Name = "SuperTabControl2";
            vmethod_38().ReorderTabsEnabled = false;
            vmethod_38().SelectedTabFont = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            vmethod_38().SelectedTabIndex = 0;
            size = new Size(484, 318);
            vmethod_38().Size = size;
            vmethod_38().TabFont = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_38().TabIndex = 0;
            baseItemArr = new BaseItem[] {
                                           vmethod_44(), 
                                           vmethod_48(), 
                                           vmethod_254() };
            vmethod_38().Tabs.AddRange(baseItemArr);
            colorArr = new Color[1];
            colorArr[0] = Color.Black;
            superTabLinearGradientColorTable3.Colors = colorArr;
            superTabColorTable2.Background = superTabLinearGradientColorTable3;
            vmethod_38().TabStripColor = superTabColorTable2;
            vmethod_38().TabStyle = eSuperTabStyle.Office2010BackstageBlue;
            vmethod_38().TabVerticalSpacing = 5;
            vmethod_38().Text = "ACTIONTAB";
            vmethod_38().TextAlignment = eItemAlignment.Center;
            vmethod_252().ColorSchemeStyle = eDotNetBarStyle.Metro;
            vmethod_252().Controls.Add(vmethod_688());
            vmethod_252().Controls.Add(vmethod_698());
            vmethod_252().Controls.Add(vmethod_286());
            vmethod_252().Controls.Add(vmethod_308());
            vmethod_252().Controls.Add(vmethod_256());
            vmethod_252().Controls.Add(vmethod_278());
            vmethod_252().Controls.Add(vmethod_280());
            vmethod_252().Controls.Add(vmethod_282());
            vmethod_252().Controls.Add(vmethod_284());
            vmethod_252().Dock = DockStyle.Fill;
            point = new Point(0, 27);
            vmethod_252().Location = point;
            vmethod_252().Name = "SuperTabControlPanel8";
            colorArr = new Color[1];
            colorArr[0] = Color.Black;
            superTabLinearGradientColorTable4.Colors = colorArr;
            superTabPanelItemColorTable2.Background = superTabLinearGradientColorTable4;
            superTabPanelItemColorTable2.InnerBorder = Color.Black;
            superTabPanelItemColorTable2.OuterBorder = Color.Black;
            superTabPanelColorTable2.Default = superTabPanelItemColorTable2;
            vmethod_252().PanelColor = superTabPanelColorTable2;
            size = new Size(484, 291);
            vmethod_252().Size = size;
            vmethod_252().TabIndex = 0;
            vmethod_252().TabItem = vmethod_254();
            vmethod_688().CanvasColor = SystemColors.Control;
            vmethod_688().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_688().Controls.Add(vmethod_690());
            vmethod_688().Controls.Add(vmethod_694());
            vmethod_688().Controls.Add(vmethod_696());
            point = new Point(13, 13);
            vmethod_688().Location = point;
            vmethod_688().Name = "PanelEx18";
            size = new Size(232, 139);
            vmethod_688().Size = size;
            vmethod_688().Style.Alignment = StringAlignment.Center;
            vmethod_688().Style.BackColor1.Color = Color.Black;
            vmethod_688().Style.Border = eBorderType.SingleLine;
            vmethod_688().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_688().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_688().Style.GradientAngle = 90;
            vmethod_688().TabIndex = 94;
            vmethod_690().Activation = ItemActivation.OneClick;
            vmethod_690().BackColor = Color.Black;
            vmethod_690().Border.BorderBottom = eStyleBorderType.Solid;
            vmethod_690().Border.BorderBottomColor = Color.Transparent;
            vmethod_690().Border.BorderBottomWidth = 1;
            vmethod_690().Border.BorderColor = Color.FromArgb(255, 128, 0);
            vmethod_690().Border.BorderColorLight = Color.FromArgb(255, 128, 0);
            vmethod_690().Border.BorderColorLight2 = Color.FromArgb(255, 128, 0);
            vmethod_690().Border.BorderLeft = eStyleBorderType.Solid;
            vmethod_690().Border.BorderLeftColor = Color.FromArgb(255, 128, 0);
            vmethod_690().Border.BorderLeftWidth = 1;
            vmethod_690().Border.BorderRight = eStyleBorderType.Solid;
            vmethod_690().Border.BorderRightColor = Color.FromArgb(255, 128, 0);
            vmethod_690().Border.BorderRightWidth = 1;
            vmethod_690().Border.BorderTop = eStyleBorderType.Dash;
            vmethod_690().Border.BorderTopColor = Color.Transparent;
            vmethod_690().Border.Class = "ListViewBorder";
            vmethod_690().Border.CornerType = eCornerType.Square;
            vmethod_690().Border.CornerTypeBottomLeft = eCornerType.Square;
            vmethod_690().Border.CornerTypeBottomRight = eCornerType.Square;
            vmethod_690().Border.CornerTypeTopLeft = eCornerType.Square;
            vmethod_690().Border.CornerTypeTopRight = eCornerType.Square;
            vmethod_690().Border.PaddingLeft = 5;
            vmethod_690().Border.PaddingRight = 5;
            vmethod_690().ColumnHeaderFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColumnHeader[] columnHeaderArr = new ColumnHeader[] { vmethod_692() };
            vmethod_690().Columns.AddRange(columnHeaderArr);
            vmethod_690().Cursor = Cursors.Default;
            vmethod_690().Dock = DockStyle.Fill;
            vmethod_690().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_690().ForeColor = Color.White;
            vmethod_690().FullRowSelect = true;
            vmethod_690().HeaderStyle = ColumnHeaderStyle.Nonclickable;
            vmethod_690().HideSelection = false;
            point = new Point(0, 22);
            vmethod_690().Location = point;
            vmethod_690().Name = "lstrechargeLocations";
            size = new Size(232, 95);
            vmethod_690().Size = size;
            vmethod_690().TabIndex = 61;
            vmethod_690().UseCompatibleStateImageBehavior = false;
            vmethod_690().View = View.List;
            vmethod_692().Text = "LOCATIONS";
            vmethod_692().Width = 218;
            vmethod_694().AccessibleRole = AccessibleRole.PushButton;
            vmethod_694().ColorTable = eButtonColor.Blue;
            vmethod_694().Dock = DockStyle.Bottom;
            vmethod_694().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(0, 117);
            vmethod_694().Location = point;
            vmethod_694().Name = "btnRemoveRechargeLocation";
            vmethod_694().RightToLeft = RightToLeft.No;
            size = new Size(232, 22);
            vmethod_694().Size = size;
            vmethod_694().Style = eDotNetBarStyle.Metro;
            vmethod_694().SymbolSize = 11.0F;
            vmethod_694().TabIndex = 84;
            vmethod_694().Text = "REMOVE LOCATION";
            backgroundColorBlendArr = new BackgroundColorBlend[] {
                                                                   new BackgroundColorBlend(Color.FromArgb(255, 128, 0), 0.0F), 
                                                                   new BackgroundColorBlend(Color.Black, 0.0F) };
            vmethod_696().BackgroundStyle.BackColorBlend.AddRange(backgroundColorBlendArr);
            vmethod_696().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_696().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_696().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_696().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_696().BackgroundStyle.MarginLeft = 1;
            vmethod_696().BackgroundStyle.MarginRight = 1;
            vmethod_696().BackgroundStyle.MarginTop = 1;
            vmethod_696().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_696().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Far;
            vmethod_696().Dock = DockStyle.Top;
            vmethod_696().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_696().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_696().Location = point;
            vmethod_696().Name = "LabelX59";
            vmethod_696().PaddingLeft = 10;
            size = new Size(232, 22);
            vmethod_696().Size = size;
            vmethod_696().TabIndex = 62;
            vmethod_696().Text = "RECHARGE LOCATIONS";
            vmethod_696().TextLineAlignment = StringAlignment.Near;
            vmethod_698().CanvasColor = SystemColors.Control;
            vmethod_698().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_698().Controls.Add(vmethod_700());
            vmethod_698().Controls.Add(vmethod_702());
            vmethod_698().Controls.Add(vmethod_704());
            vmethod_698().Controls.Add(vmethod_706());
            vmethod_698().Controls.Add(vmethod_708());
            vmethod_698().Controls.Add(vmethod_710());
            vmethod_698().Controls.Add(vmethod_712());
            vmethod_698().Controls.Add(vmethod_714());
            point = new Point(251, 13);
            vmethod_698().Location = point;
            vmethod_698().Name = "PanelEx17";
            size = new Size(221, 139);
            vmethod_698().Size = size;
            vmethod_698().Style.Alignment = StringAlignment.Center;
            vmethod_698().Style.BackColor1.Color = Color.Black;
            vmethod_698().Style.Border = eBorderType.SingleLine;
            vmethod_698().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_698().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_698().Style.GradientAngle = 90;
            vmethod_698().TabIndex = 93;
            vmethod_700().AutoSize = true;
            vmethod_700().BackColor = Color.Black;
            vmethod_700().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_700().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_700().ForeColor = Color.White;
            point = new Point(74, 57);
            vmethod_700().Location = point;
            vmethod_700().Name = "rechargeLocationY";
            size = new Size(33, 17);
            vmethod_700().Size = size;
            vmethod_700().TabIndex = 57;
            vmethod_700().Text = "NONE";
            vmethod_702().AutoSize = true;
            vmethod_702().BackColor = Color.Black;
            vmethod_702().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_702().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_702().ForeColor = Color.White;
            point = new Point(74, 41);
            vmethod_702().Location = point;
            vmethod_702().Name = "rechargeLocationX";
            size = new Size(33, 17);
            vmethod_702().Size = size;
            vmethod_702().TabIndex = 56;
            vmethod_702().Text = "NONE";
            vmethod_704().AutoSize = true;
            vmethod_704().BackColor = Color.Black;
            vmethod_704().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_704().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_704().ForeColor = Color.White;
            point = new Point(74, 25);
            vmethod_704().Location = point;
            vmethod_704().Name = "rechargeLocationName";
            size = new Size(33, 17);
            vmethod_704().Size = size;
            vmethod_704().TabIndex = 55;
            vmethod_704().Text = "NONE";
            vmethod_706().AutoSize = true;
            vmethod_706().BackColor = Color.Black;
            vmethod_706().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_706().ForeColor = Color.White;
            point = new Point(61, 57);
            vmethod_706().Location = point;
            vmethod_706().Name = "LabelX43";
            size = new Size(12, 17);
            vmethod_706().Size = size;
            vmethod_706().TabIndex = 54;
            vmethod_706().Text = "Y:";
            vmethod_708().AutoSize = true;
            vmethod_708().BackColor = Color.Black;
            vmethod_708().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_708().ForeColor = Color.White;
            point = new Point(60, 41);
            vmethod_708().Location = point;
            vmethod_708().Name = "LabelX44";
            size = new Size(13, 17);
            vmethod_708().Size = size;
            vmethod_708().TabIndex = 53;
            vmethod_708().Text = "X:";
            vmethod_710().AccessibleRole = AccessibleRole.PushButton;
            vmethod_710().ColorTable = eButtonColor.Blue;
            vmethod_710().Dock = DockStyle.Bottom;
            vmethod_710().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(0, 117);
            vmethod_710().Location = point;
            vmethod_710().Name = "btnSaveRechargeLocation";
            vmethod_710().RightToLeft = RightToLeft.No;
            size = new Size(221, 22);
            vmethod_710().Size = size;
            vmethod_710().Style = eDotNetBarStyle.Metro;
            vmethod_710().TabIndex = 52;
            vmethod_710().Text = "SAVE LOCATION";
            vmethod_712().AutoSize = true;
            vmethod_712().BackColor = Color.Black;
            vmethod_712().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_712().ForeColor = Color.White;
            point = new Point(12, 25);
            vmethod_712().Location = point;
            vmethod_712().Name = "LabelX45";
            size = new Size(61, 17);
            vmethod_712().Size = size;
            vmethod_712().TabIndex = 51;
            vmethod_712().Text = "LOCATION:";
            vmethod_714().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_714().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_714().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_714().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_714().BackgroundStyle.MarginLeft = 1;
            vmethod_714().BackgroundStyle.MarginRight = 1;
            vmethod_714().BackgroundStyle.MarginTop = 1;
            vmethod_714().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_714().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_714().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_714().BackgroundStyle.TextShadowOffset = point;
            vmethod_714().Dock = DockStyle.Top;
            vmethod_714().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_714().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_714().Location = point;
            vmethod_714().Name = "LabelX67";
            vmethod_714().PaddingLeft = 10;
            size = new Size(221, 19);
            vmethod_714().Size = size;
            vmethod_714().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_714().TabIndex = 43;
            vmethod_714().Text = "CURRENT LOCATION";
            vmethod_714().TextLineAlignment = StringAlignment.Near;
            vmethod_286().DisplayMember = "Text";
            vmethod_286().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_286().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_286().FlatStyle = FlatStyle.Popup;
            vmethod_286().ForeColor = Color.White;
            vmethod_286().FormattingEnabled = true;
            vmethod_286().ItemHeight = 16;
            object[] objArr = new object[] {
                                             vmethod_288(), 
                                             vmethod_290(), 
                                             vmethod_292(), 
                                             vmethod_294(), 
                                             vmethod_296(), 
                                             vmethod_298(), 
                                             vmethod_300(), 
                                             vmethod_302(), 
                                             vmethod_304(), 
                                             vmethod_306() };
            vmethod_286().Items.AddRange(objArr);
            point = new Point(218, 214);
            vmethod_286().Location = point;
            vmethod_286().Name = "cmbrechargeStop";
            size = new Size(82, 22);
            vmethod_286().Size = size;
            vmethod_286().Style = eDotNetBarStyle.Metro;
            vmethod_286().TabIndex = 92;
            vmethod_288().Text = "5";
            vmethod_290().Text = "10";
            vmethod_292().Text = "15";
            vmethod_294().Text = "20";
            vmethod_296().Text = "25";
            vmethod_298().Text = "30";
            vmethod_300().Text = "35";
            vmethod_302().Text = "40";
            vmethod_304().Text = "45";
            vmethod_306().Text = "50";
            vmethod_308().AutoSize = true;
            vmethod_308().BackColor = Color.Transparent;
            vmethod_308().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_308().ForeColor = Color.White;
            point = new Point(12, 216);
            vmethod_308().Location = point;
            vmethod_308().Name = "LabelX48";
            size = new Size(202, 17);
            vmethod_308().Size = size;
            vmethod_308().Style = eDotNetBarStyle.Metro;
            vmethod_308().TabIndex = 91;
            vmethod_308().Text = "RECHARGE AUTOBATTLES TO          >=";
            vmethod_256().DisplayMember = "Text";
            vmethod_256().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_256().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_256().FlatStyle = FlatStyle.Popup;
            vmethod_256().ForeColor = Color.White;
            vmethod_256().FormattingEnabled = true;
            vmethod_256().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_310(), 
                                    vmethod_258(), 
                                    vmethod_260(), 
                                    vmethod_262(), 
                                    vmethod_264(), 
                                    vmethod_266(), 
                                    vmethod_268(), 
                                    vmethod_270(), 
                                    vmethod_272(), 
                                    vmethod_274(), 
                                    vmethod_276() };
            vmethod_256().Items.AddRange(objArr);
            point = new Point(218, 186);
            vmethod_256().Location = point;
            vmethod_256().Name = "cmbrechargeStart";
            size = new Size(82, 22);
            vmethod_256().Size = size;
            vmethod_256().Style = eDotNetBarStyle.Metro;
            vmethod_256().TabIndex = 90;
            vmethod_310().Text = "0";
            vmethod_258().Text = "5";
            vmethod_260().Text = "10";
            vmethod_262().Text = "15";
            vmethod_264().Text = "20";
            vmethod_266().Text = "25";
            vmethod_268().Text = "30";
            vmethod_270().Text = "35";
            vmethod_272().Text = "40";
            vmethod_274().Text = "45";
            vmethod_276().Text = "50";
            vmethod_278().AutoSize = true;
            vmethod_278().BackColor = Color.Transparent;
            vmethod_278().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_278().ForeColor = Color.White;
            point = new Point(12, 188);
            vmethod_278().Location = point;
            vmethod_278().Name = "LabelX47";
            size = new Size(200, 17);
            vmethod_278().Size = size;
            vmethod_278().Style = eDotNetBarStyle.Metro;
            vmethod_278().TabIndex = 89;
            vmethod_278().Text = "RECHARGE AUTOBATTLES WHEN   <=";
            vmethod_280().BackColor = Color.Black;
            vmethod_280().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_280().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_280().ForeColor = Color.White;
            point = new Point(382, 261);
            vmethod_280().Location = point;
            vmethod_280().Name = "rechargeEnable";
            vmethod_280().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_280().OffText = "DISABLED";
            vmethod_280().OffTextColor = Color.White;
            vmethod_280().OnText = "ENABLED";
            size = new Size(90, 17);
            vmethod_280().Size = size;
            vmethod_280().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_280().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_280().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_280().SwitchWidth = 6;
            vmethod_280().TabIndex = 88;
            vmethod_282().AutoSize = true;
            vmethod_282().BackColor = Color.Transparent;
            vmethod_282().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_282().ForeColor = Color.White;
            point = new Point(110, 160);
            vmethod_282().Location = point;
            vmethod_282().Name = "LabelX46";
            size = new Size(229, 17);
            vmethod_282().Size = size;
            vmethod_282().Style = eDotNetBarStyle.Metro;
            vmethod_282().TabIndex = 87;
            vmethod_282().Text = "TO LOCATION TO RECHARGE AUTO BATTLE";
            vmethod_284().BackColor = Color.Black;
            vmethod_284().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_284().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_284().ForeColor = Color.White;
            point = new Point(12, 160);
            vmethod_284().Location = point;
            vmethod_284().Name = "swtrechargeAction";
            vmethod_284().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_284().OffText = "AUTOMOVE";
            vmethod_284().OffTextColor = Color.White;
            vmethod_284().OnText = "TELEPORT";
            size = new Size(94, 17);
            vmethod_284().Size = size;
            vmethod_284().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_284().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_284().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_284().SwitchWidth = 6;
            vmethod_284().TabIndex = 86;
            vmethod_284().Value = true;
            vmethod_284().ValueObject = "Y";
            vmethod_254().AttachedControl = vmethod_252();
            vmethod_254().GlobalItem = false;
            vmethod_254().Name = "SuperTabItem6";
            superTabItemStateColorTable2.SelectionMarker = Color.Black;
            superTabColorStates2.Selected = superTabItemStateColorTable2;
            superTabItemColorTable2.Default = superTabColorStates2;
            vmethod_254().TabColor = superTabItemColorTable2;
            vmethod_254().Text = "RECHARGE AUTO BATTLE";
            vmethod_40().ColorSchemeStyle = eDotNetBarStyle.Metro;
            vmethod_40().Controls.Add(vmethod_642());
            vmethod_40().Controls.Add(vmethod_632());
            vmethod_40().Controls.Add(vmethod_90());
            vmethod_40().Controls.Add(vmethod_50());
            vmethod_40().Controls.Add(vmethod_52());
            vmethod_40().Controls.Add(vmethod_54());
            vmethod_40().Controls.Add(vmethod_56());
            vmethod_40().Controls.Add(vmethod_58());
            vmethod_40().Controls.Add(vmethod_60());
            vmethod_40().Controls.Add(vmethod_62());
            vmethod_40().Controls.Add(vmethod_64());
            vmethod_40().Controls.Add(vmethod_66());
            vmethod_40().Controls.Add(vmethod_42());
            vmethod_40().Dock = DockStyle.Fill;
            point = new Point(0, 27);
            vmethod_40().Location = point;
            vmethod_40().Name = "SuperTabControlPanel6";
            colorArr = new Color[1];
            colorArr[0] = Color.Black;
            superTabLinearGradientColorTable5.Colors = colorArr;
            superTabPanelItemColorTable3.Background = superTabLinearGradientColorTable5;
            superTabPanelItemColorTable3.InnerBorder = Color.Black;
            superTabPanelItemColorTable3.OuterBorder = Color.Black;
            superTabPanelColorTable3.Default = superTabPanelItemColorTable3;
            vmethod_40().PanelColor = superTabPanelColorTable3;
            size = new Size(484, 291);
            vmethod_40().Size = size;
            vmethod_40().TabIndex = 1;
            vmethod_40().TabItem = vmethod_44();
            vmethod_642().CanvasColor = SystemColors.Control;
            vmethod_642().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_642().Controls.Add(vmethod_644());
            vmethod_642().Controls.Add(vmethod_646());
            vmethod_642().Controls.Add(vmethod_648());
            vmethod_642().Controls.Add(vmethod_650());
            vmethod_642().Controls.Add(vmethod_652());
            vmethod_642().Controls.Add(vmethod_654());
            vmethod_642().Controls.Add(vmethod_656());
            vmethod_642().Controls.Add(vmethod_658());
            point = new Point(251, 13);
            vmethod_642().Location = point;
            vmethod_642().Name = "PanelEx14";
            size = new Size(222, 139);
            vmethod_642().Size = size;
            vmethod_642().Style.Alignment = StringAlignment.Center;
            vmethod_642().Style.BackColor1.Color = Color.Black;
            vmethod_642().Style.Border = eBorderType.SingleLine;
            vmethod_642().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_642().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_642().Style.GradientAngle = 90;
            vmethod_642().TabIndex = 60;
            vmethod_644().AutoSize = true;
            vmethod_644().BackColor = Color.Black;
            vmethod_644().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_644().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_644().ForeColor = Color.White;
            point = new Point(74, 57);
            vmethod_644().Location = point;
            vmethod_644().Name = "lblGrindY";
            size = new Size(33, 17);
            vmethod_644().Size = size;
            vmethod_644().TabIndex = 60;
            vmethod_644().Text = "NONE";
            vmethod_646().AutoSize = true;
            vmethod_646().BackColor = Color.Black;
            vmethod_646().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_646().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_646().ForeColor = Color.White;
            point = new Point(74, 41);
            vmethod_646().Location = point;
            vmethod_646().Name = "lblGrindX";
            size = new Size(33, 17);
            vmethod_646().Size = size;
            vmethod_646().TabIndex = 59;
            vmethod_646().Text = "NONE";
            vmethod_648().AutoSize = true;
            vmethod_648().BackColor = Color.Black;
            vmethod_648().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_648().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_648().ForeColor = Color.White;
            point = new Point(74, 25);
            vmethod_648().Location = point;
            vmethod_648().Name = "lblGrindLocation";
            size = new Size(33, 17);
            vmethod_648().Size = size;
            vmethod_648().TabIndex = 58;
            vmethod_648().Text = "NONE";
            vmethod_650().AutoSize = true;
            vmethod_650().BackColor = Color.Black;
            vmethod_650().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_650().ForeColor = Color.White;
            point = new Point(61, 57);
            vmethod_650().Location = point;
            vmethod_650().Name = "LabelX22";
            size = new Size(12, 17);
            vmethod_650().Size = size;
            vmethod_650().TabIndex = 57;
            vmethod_650().Text = "Y:";
            vmethod_652().AutoSize = true;
            vmethod_652().BackColor = Color.Black;
            vmethod_652().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_652().ForeColor = Color.White;
            point = new Point(60, 41);
            vmethod_652().Location = point;
            vmethod_652().Name = "LabelX23";
            size = new Size(13, 17);
            vmethod_652().Size = size;
            vmethod_652().TabIndex = 56;
            vmethod_652().Text = "X:";
            vmethod_654().AccessibleRole = AccessibleRole.PushButton;
            vmethod_654().ColorTable = eButtonColor.Orange;
            vmethod_654().Dock = DockStyle.Bottom;
            vmethod_654().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(0, 119);
            vmethod_654().Location = point;
            vmethod_654().Name = "ButtonX1";
            vmethod_654().RightToLeft = RightToLeft.No;
            size = new Size(222, 20);
            vmethod_654().Size = size;
            vmethod_654().Style = eDotNetBarStyle.Metro;
            vmethod_654().TabIndex = 55;
            vmethod_654().Text = "SAVE LOCATION";
            vmethod_656().AutoSize = true;
            vmethod_656().BackColor = Color.Black;
            vmethod_656().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_656().ForeColor = Color.White;
            point = new Point(12, 25);
            vmethod_656().Location = point;
            vmethod_656().Name = "LabelX24";
            size = new Size(61, 17);
            vmethod_656().Size = size;
            vmethod_656().TabIndex = 54;
            vmethod_656().Text = "LOCATION:";
            vmethod_658().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_658().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_658().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_658().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_658().BackgroundStyle.MarginLeft = 1;
            vmethod_658().BackgroundStyle.MarginRight = 1;
            vmethod_658().BackgroundStyle.MarginTop = 1;
            vmethod_658().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_658().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_658().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_658().BackgroundStyle.TextShadowOffset = point;
            vmethod_658().Dock = DockStyle.Top;
            vmethod_658().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_658().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_658().Location = point;
            vmethod_658().Name = "LabelX57";
            vmethod_658().PaddingLeft = 10;
            size = new Size(222, 19);
            vmethod_658().Size = size;
            vmethod_658().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_658().TabIndex = 43;
            vmethod_658().Text = "CURRENT LOCATION";
            vmethod_658().TextLineAlignment = StringAlignment.Near;
            vmethod_632().CanvasColor = SystemColors.Control;
            vmethod_632().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_632().Controls.Add(vmethod_638());
            vmethod_632().Controls.Add(vmethod_634());
            vmethod_632().Controls.Add(vmethod_636());
            point = new Point(13, 13);
            vmethod_632().Location = point;
            vmethod_632().Name = "PanelEx13";
            size = new Size(232, 139);
            vmethod_632().Size = size;
            vmethod_632().Style.Alignment = StringAlignment.Center;
            vmethod_632().Style.BackColor1.Color = Color.Black;
            vmethod_632().Style.Border = eBorderType.SingleLine;
            vmethod_632().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_632().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_632().Style.GradientAngle = 90;
            vmethod_632().TabIndex = 59;
            vmethod_638().Activation = ItemActivation.OneClick;
            vmethod_638().BackColor = Color.Black;
            vmethod_638().Border.BorderBottom = eStyleBorderType.Solid;
            vmethod_638().Border.BorderBottomColor = Color.Transparent;
            vmethod_638().Border.BorderBottomWidth = 1;
            vmethod_638().Border.BorderColor = Color.FromArgb(255, 128, 0);
            vmethod_638().Border.BorderColorLight = Color.FromArgb(255, 128, 0);
            vmethod_638().Border.BorderColorLight2 = Color.FromArgb(255, 128, 0);
            vmethod_638().Border.BorderLeft = eStyleBorderType.Solid;
            vmethod_638().Border.BorderLeftColor = Color.FromArgb(255, 128, 0);
            vmethod_638().Border.BorderLeftWidth = 1;
            vmethod_638().Border.BorderRight = eStyleBorderType.Solid;
            vmethod_638().Border.BorderRightColor = Color.FromArgb(255, 128, 0);
            vmethod_638().Border.BorderRightWidth = 1;
            vmethod_638().Border.BorderTop = eStyleBorderType.Dash;
            vmethod_638().Border.BorderTopColor = Color.Transparent;
            vmethod_638().Border.Class = "ListViewBorder";
            vmethod_638().Border.CornerType = eCornerType.Square;
            vmethod_638().Border.CornerTypeBottomLeft = eCornerType.Square;
            vmethod_638().Border.CornerTypeBottomRight = eCornerType.Square;
            vmethod_638().Border.CornerTypeTopLeft = eCornerType.Square;
            vmethod_638().Border.CornerTypeTopRight = eCornerType.Square;
            vmethod_638().Border.PaddingLeft = 5;
            vmethod_638().Border.PaddingRight = 5;
            vmethod_638().ColumnHeaderFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            columnHeaderArr = new ColumnHeader[] { vmethod_640() };
            vmethod_638().Columns.AddRange(columnHeaderArr);
            vmethod_638().Dock = DockStyle.Fill;
            vmethod_638().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_638().ForeColor = Color.White;
            vmethod_638().FullRowSelect = true;
            vmethod_638().HeaderStyle = ColumnHeaderStyle.Nonclickable;
            vmethod_638().HideSelection = false;
            point = new Point(0, 22);
            vmethod_638().Location = point;
            vmethod_638().Name = "lstGrindLocations";
            size = new Size(232, 95);
            vmethod_638().Size = size;
            vmethod_638().TabIndex = 53;
            vmethod_638().UseCompatibleStateImageBehavior = false;
            vmethod_638().View = View.List;
            vmethod_640().Text = "LOCATIONS";
            vmethod_640().Width = 218;
            vmethod_634().AccessibleRole = AccessibleRole.PushButton;
            vmethod_634().ColorTable = eButtonColor.Orange;
            vmethod_634().Dock = DockStyle.Bottom;
            vmethod_634().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(0, 117);
            vmethod_634().Location = point;
            vmethod_634().Name = "btnRemoveGrindLocation";
            vmethod_634().RightToLeft = RightToLeft.No;
            size = new Size(232, 22);
            vmethod_634().Size = size;
            vmethod_634().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_634().SymbolSize = 8.0F;
            vmethod_634().TabIndex = 51;
            vmethod_634().Text = "REMOVE LOCATION";
            backgroundColorBlendArr = new BackgroundColorBlend[] {
                                                                   new BackgroundColorBlend(Color.FromArgb(255, 128, 0), 0.0F), 
                                                                   new BackgroundColorBlend(Color.Black, 0.0F) };
            vmethod_636().BackgroundStyle.BackColorBlend.AddRange(backgroundColorBlendArr);
            vmethod_636().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_636().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_636().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_636().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_636().BackgroundStyle.MarginLeft = 1;
            vmethod_636().BackgroundStyle.MarginRight = 1;
            vmethod_636().BackgroundStyle.MarginTop = 1;
            vmethod_636().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_636().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Far;
            vmethod_636().Dock = DockStyle.Top;
            vmethod_636().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_636().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_636().Location = point;
            vmethod_636().Name = "LabelX61";
            vmethod_636().PaddingLeft = 10;
            size = new Size(232, 22);
            vmethod_636().Size = size;
            vmethod_636().TabIndex = 50;
            vmethod_636().Text = "GRIND LOCATIONS";
            vmethod_636().TextLineAlignment = StringAlignment.Near;
            vmethod_90().BackColor = Color.Black;
            vmethod_90().Border.Class = "TextBoxBorder";
            vmethod_90().Border.CornerType = eCornerType.Square;
            vmethod_90().ForeColor = Color.White;
            point = new Point(348, 189);
            vmethod_90().Location = point;
            vmethod_90().Name = "txtGrindLocationBattles";
            size = new Size(125, 22);
            vmethod_90().Size = size;
            vmethod_90().TabIndex = 58;
            vmethod_50().BackColor = Color.Black;
            vmethod_50().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_50().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_50().ForeColor = Color.White;
            point = new Point(383, 259);
            vmethod_50().Location = point;
            vmethod_50().Name = "swtGrindLocationEnabled";
            vmethod_50().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_50().OffText = "DISABLED";
            vmethod_50().OffTextColor = Color.White;
            vmethod_50().OnText = "ENABLED";
            size = new Size(90, 17);
            vmethod_50().Size = size;
            vmethod_50().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_50().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_50().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_50().SwitchWidth = 6;
            vmethod_50().TabIndex = 57;
            vmethod_52().AutoSize = true;
            vmethod_52().BackColor = Color.Transparent;
            vmethod_52().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_52().ForeColor = Color.White;
            point = new Point(296, 191);
            vmethod_52().Location = point;
            vmethod_52().Name = "LabelX28";
            size = new Size(48, 17);
            vmethod_52().Size = size;
            vmethod_52().Style = eDotNetBarStyle.Metro;
            vmethod_52().TabIndex = 56;
            vmethod_52().Text = "BATTLES";
            vmethod_54().AutoSize = true;
            vmethod_54().BackColor = Color.Transparent;
            vmethod_54().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_54().ForeColor = Color.White;
            point = new Point(15, 221);
            vmethod_54().Location = point;
            vmethod_54().Name = "LabelX27";
            size = new Size(52, 17);
            vmethod_54().Size = size;
            vmethod_54().Style = eDotNetBarStyle.Metro;
            vmethod_54().TabIndex = 54;
            vmethod_54().Text = "MINUTES";
            vmethod_56().AutoSize = true;
            vmethod_56().BackColor = Color.Transparent;
            vmethod_56().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_56().ForeColor = Color.White;
            point = new Point(26, 191);
            vmethod_56().Location = point;
            vmethod_56().Name = "LabelX26";
            size = new Size(41, 17);
            vmethod_56().Size = size;
            vmethod_56().Style = eDotNetBarStyle.Metro;
            vmethod_56().TabIndex = 53;
            vmethod_56().Text = "HOURS";
            vmethod_58().DisplayMember = "Text";
            vmethod_58().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_58().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_58().ForeColor = Color.White;
            vmethod_58().FormattingEnabled = true;
            vmethod_58().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_92(), 
                                    vmethod_94(), 
                                    vmethod_96(), 
                                    vmethod_98(), 
                                    vmethod_100(), 
                                    vmethod_102(), 
                                    vmethod_104(), 
                                    vmethod_106(), 
                                    vmethod_108(), 
                                    vmethod_110(), 
                                    vmethod_112(), 
                                    vmethod_114() };
            vmethod_58().Items.AddRange(objArr);
            point = new Point(68, 218);
            vmethod_58().Location = point;
            vmethod_58().Name = "cmbGrindLocationMinutes";
            size = new Size(120, 22);
            vmethod_58().Size = size;
            vmethod_58().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_58().TabIndex = 52;
            vmethod_92().Text = "0";
            vmethod_94().Text = "5";
            vmethod_96().Text = "10";
            vmethod_98().Text = "15";
            vmethod_100().Text = "20";
            vmethod_102().Text = "25";
            vmethod_104().Text = "30";
            vmethod_106().Text = "35";
            vmethod_108().Text = "40";
            vmethod_110().Text = "45";
            vmethod_112().Text = "50";
            vmethod_114().Text = "55";
            vmethod_60().DisplayMember = "Text";
            vmethod_60().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_60().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_60().ForeColor = Color.White;
            vmethod_60().FormattingEnabled = true;
            vmethod_60().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_116(), 
                                    vmethod_118(), 
                                    vmethod_120(), 
                                    vmethod_122(), 
                                    vmethod_124(), 
                                    vmethod_126(), 
                                    vmethod_128(), 
                                    vmethod_130(), 
                                    vmethod_132(), 
                                    vmethod_134(), 
                                    vmethod_136(), 
                                    vmethod_138(), 
                                    vmethod_140() };
            vmethod_60().Items.AddRange(objArr);
            point = new Point(68, 189);
            vmethod_60().Location = point;
            vmethod_60().Name = "cmbGrindLocationHours";
            size = new Size(120, 22);
            vmethod_60().Size = size;
            vmethod_60().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_60().TabIndex = 51;
            vmethod_116().Text = "0";
            vmethod_118().Text = "1";
            vmethod_120().Text = "2";
            vmethod_122().Text = "3";
            vmethod_124().Text = "4";
            vmethod_126().Text = "5";
            vmethod_128().Text = "6";
            vmethod_130().Text = "7";
            vmethod_132().Text = "8";
            vmethod_134().Text = "9";
            vmethod_136().Text = "10";
            vmethod_138().Text = "11";
            vmethod_140().Text = "12";
            vmethod_62().BackColor = Color.Black;
            vmethod_62().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_62().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_62().ForeColor = Color.White;
            point = new Point(261, 160);
            vmethod_62().Location = point;
            vmethod_62().Name = "swtGrindLocationVariable";
            vmethod_62().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_62().OffText = "TIME";
            vmethod_62().OffTextColor = Color.White;
            vmethod_62().OnText = "BATTLES";
            size = new Size(94, 17);
            vmethod_62().Size = size;
            vmethod_62().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_62().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_62().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_62().SwitchWidth = 6;
            vmethod_62().TabIndex = 49;
            vmethod_64().AutoSize = true;
            vmethod_64().BackColor = Color.Transparent;
            vmethod_64().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_64().ForeColor = Color.White;
            point = new Point(113, 160);
            vmethod_64().Location = point;
            vmethod_64().Name = "LabelX25";
            size = new Size(140, 17);
            vmethod_64().Size = size;
            vmethod_64().Style = eDotNetBarStyle.Metro;
            vmethod_64().TabIndex = 48;
            vmethod_64().Text = "TO NEW LOCATION AFTER";
            vmethod_66().BackColor = Color.Black;
            vmethod_66().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_66().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_66().ForeColor = Color.White;
            point = new Point(12, 160);
            vmethod_66().Location = point;
            vmethod_66().Name = "swtGrindLocationAction";
            vmethod_66().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_66().OffText = "AUTOMOVE";
            vmethod_66().OffTextColor = Color.White;
            vmethod_66().OnText = "TELEPORT";
            size = new Size(94, 17);
            vmethod_66().Size = size;
            vmethod_66().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_66().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_66().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_66().SwitchWidth = 6;
            vmethod_66().TabIndex = 47;
            vmethod_66().Value = true;
            vmethod_66().ValueObject = "Y";
            vmethod_42().BackColor = Color.Black;
            vmethod_42().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_42().ForeColor = Color.White;
            point = new Point(264, 293);
            vmethod_42().Location = point;
            vmethod_42().Name = "SwitchButton1";
            vmethod_42().OffText = "DISABLE";
            vmethod_42().OnText = "ENABLE";
            size = new Size(87, 15);
            vmethod_42().Size = size;
            vmethod_42().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_42().SwitchWidth = 6;
            vmethod_42().TabIndex = 45;
            vmethod_42().Value = true;
            vmethod_42().ValueObject = "Y";
            vmethod_44().AttachedControl = vmethod_40();
            vmethod_44().GlobalItem = false;
            vmethod_44().Name = "tabGrindLocations";
            superTabItemStateColorTable3.SelectionMarker = Color.Black;
            superTabColorStates3.Selected = superTabItemStateColorTable3;
            superTabItemColorTable3.Default = superTabColorStates3;
            vmethod_44().TabColor = superTabItemColorTable3;
            vmethod_44().Text = "GRIND LOCATION";
            vmethod_46().ColorSchemeStyle = eDotNetBarStyle.Metro;
            vmethod_46().Controls.Add(vmethod_678());
            vmethod_46().Controls.Add(vmethod_660());
            vmethod_46().Controls.Add(vmethod_142());
            vmethod_46().Controls.Add(vmethod_144());
            vmethod_46().Controls.Add(vmethod_170());
            vmethod_46().Controls.Add(vmethod_198());
            vmethod_46().Controls.Add(vmethod_224());
            vmethod_46().Controls.Add(vmethod_68());
            vmethod_46().Controls.Add(vmethod_70());
            vmethod_46().Controls.Add(vmethod_72());
            vmethod_46().Controls.Add(vmethod_74());
            vmethod_46().Controls.Add(vmethod_76());
            vmethod_46().Controls.Add(vmethod_78());
            vmethod_46().Controls.Add(vmethod_80());
            vmethod_46().Controls.Add(vmethod_82());
            vmethod_46().Controls.Add(vmethod_84());
            vmethod_46().Controls.Add(vmethod_86());
            vmethod_46().Controls.Add(vmethod_88());
            vmethod_46().Dock = DockStyle.Fill;
            point = new Point(0, 0);
            vmethod_46().Location = point;
            vmethod_46().Name = "SuperTabControlPanel7";
            colorArr = new Color[1];
            colorArr[0] = Color.Black;
            superTabLinearGradientColorTable6.Colors = colorArr;
            superTabPanelItemColorTable4.Background = superTabLinearGradientColorTable6;
            superTabPanelItemColorTable4.InnerBorder = Color.Black;
            superTabPanelItemColorTable4.OuterBorder = Color.Black;
            superTabPanelColorTable4.Default = superTabPanelItemColorTable4;
            vmethod_46().PanelColor = superTabPanelColorTable4;
            size = new Size(484, 318);
            vmethod_46().Size = size;
            vmethod_46().TabIndex = 0;
            vmethod_46().TabItem = vmethod_48();
            vmethod_678().CanvasColor = SystemColors.Control;
            vmethod_678().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_678().Controls.Add(vmethod_680());
            vmethod_678().Controls.Add(vmethod_686());
            vmethod_678().Controls.Add(vmethod_684());
            point = new Point(13, 13);
            vmethod_678().Location = point;
            vmethod_678().Name = "PanelEx16";
            size = new Size(232, 139);
            vmethod_678().Size = size;
            vmethod_678().Style.Alignment = StringAlignment.Center;
            vmethod_678().Style.BackColor1.Color = Color.Black;
            vmethod_678().Style.Border = eBorderType.SingleLine;
            vmethod_678().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_678().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_678().Style.GradientAngle = 90;
            vmethod_678().TabIndex = 84;
            vmethod_680().Activation = ItemActivation.OneClick;
            vmethod_680().BackColor = Color.Black;
            vmethod_680().Border.BorderBottom = eStyleBorderType.Solid;
            vmethod_680().Border.BorderBottomColor = Color.Transparent;
            vmethod_680().Border.BorderBottomWidth = 1;
            vmethod_680().Border.BorderColor = Color.FromArgb(255, 128, 0);
            vmethod_680().Border.BorderColorLight = Color.FromArgb(255, 128, 0);
            vmethod_680().Border.BorderColorLight2 = Color.FromArgb(255, 128, 0);
            vmethod_680().Border.BorderLeft = eStyleBorderType.Solid;
            vmethod_680().Border.BorderLeftColor = Color.FromArgb(255, 128, 0);
            vmethod_680().Border.BorderLeftWidth = 1;
            vmethod_680().Border.BorderRight = eStyleBorderType.Solid;
            vmethod_680().Border.BorderRightColor = Color.FromArgb(255, 128, 0);
            vmethod_680().Border.BorderRightWidth = 1;
            vmethod_680().Border.BorderTop = eStyleBorderType.Dash;
            vmethod_680().Border.BorderTopColor = Color.Transparent;
            vmethod_680().Border.Class = "ListViewBorder";
            vmethod_680().Border.CornerType = eCornerType.Square;
            vmethod_680().Border.CornerTypeBottomLeft = eCornerType.Square;
            vmethod_680().Border.CornerTypeBottomRight = eCornerType.Square;
            vmethod_680().Border.CornerTypeTopLeft = eCornerType.Square;
            vmethod_680().Border.CornerTypeTopRight = eCornerType.Square;
            vmethod_680().Border.PaddingLeft = 5;
            vmethod_680().Border.PaddingRight = 5;
            vmethod_680().ColumnHeaderFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            columnHeaderArr = new ColumnHeader[] { vmethod_682() };
            vmethod_680().Columns.AddRange(columnHeaderArr);
            vmethod_680().Cursor = Cursors.Default;
            vmethod_680().Dock = DockStyle.Fill;
            vmethod_680().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_680().ForeColor = Color.White;
            vmethod_680().FullRowSelect = true;
            vmethod_680().HeaderStyle = ColumnHeaderStyle.Nonclickable;
            vmethod_680().HideSelection = false;
            point = new Point(0, 22);
            vmethod_680().Location = point;
            vmethod_680().Name = "lstTownWaitLocations";
            size = new Size(232, 95);
            vmethod_680().Size = size;
            vmethod_680().TabIndex = 61;
            vmethod_680().UseCompatibleStateImageBehavior = false;
            vmethod_680().View = View.List;
            vmethod_682().Text = "LOCATIONS";
            vmethod_682().Width = 218;
            backgroundColorBlendArr = new BackgroundColorBlend[] {
                                                                   new BackgroundColorBlend(Color.FromArgb(255, 128, 0), 0.0F), 
                                                                   new BackgroundColorBlend(Color.Black, 0.0F) };
            vmethod_686().BackgroundStyle.BackColorBlend.AddRange(backgroundColorBlendArr);
            vmethod_686().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_686().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_686().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_686().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_686().BackgroundStyle.MarginLeft = 1;
            vmethod_686().BackgroundStyle.MarginRight = 1;
            vmethod_686().BackgroundStyle.MarginTop = 1;
            vmethod_686().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_686().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Far;
            vmethod_686().Dock = DockStyle.Top;
            vmethod_686().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_686().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_686().Location = point;
            vmethod_686().Name = "LabelX58";
            vmethod_686().PaddingLeft = 10;
            size = new Size(232, 22);
            vmethod_686().Size = size;
            vmethod_686().TabIndex = 62;
            vmethod_686().Text = "TOWN LOCATIONS";
            vmethod_686().TextLineAlignment = StringAlignment.Near;
            vmethod_684().AccessibleRole = AccessibleRole.PushButton;
            vmethod_684().ColorTable = eButtonColor.Blue;
            vmethod_684().Dock = DockStyle.Bottom;
            vmethod_684().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(0, 117);
            vmethod_684().Location = point;
            vmethod_684().Name = "btntownWaitRemove";
            vmethod_684().RightToLeft = RightToLeft.No;
            size = new Size(232, 22);
            vmethod_684().Size = size;
            vmethod_684().Style = eDotNetBarStyle.Metro;
            vmethod_684().TabIndex = 60;
            vmethod_684().Text = "REMOVE LOCATION";
            vmethod_660().CanvasColor = SystemColors.Control;
            vmethod_660().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_660().Controls.Add(vmethod_662());
            vmethod_660().Controls.Add(vmethod_664());
            vmethod_660().Controls.Add(vmethod_666());
            vmethod_660().Controls.Add(vmethod_668());
            vmethod_660().Controls.Add(vmethod_670());
            vmethod_660().Controls.Add(vmethod_672());
            vmethod_660().Controls.Add(vmethod_674());
            vmethod_660().Controls.Add(vmethod_676());
            point = new Point(251, 13);
            vmethod_660().Location = point;
            vmethod_660().Name = "PanelEx15";
            size = new Size(221, 139);
            vmethod_660().Size = size;
            vmethod_660().Style.Alignment = StringAlignment.Center;
            vmethod_660().Style.BackColor1.Color = Color.Black;
            vmethod_660().Style.Border = eBorderType.SingleLine;
            vmethod_660().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_660().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_660().Style.GradientAngle = 90;
            vmethod_660().TabIndex = 83;
            vmethod_662().AutoSize = true;
            vmethod_662().BackColor = Color.Black;
            vmethod_662().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_662().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_662().ForeColor = Color.White;
            point = new Point(74, 57);
            vmethod_662().Location = point;
            vmethod_662().Name = "lblTownWaitY";
            size = new Size(33, 17);
            vmethod_662().Size = size;
            vmethod_662().TabIndex = 57;
            vmethod_662().Text = "NONE";
            vmethod_664().AutoSize = true;
            vmethod_664().BackColor = Color.Black;
            vmethod_664().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_664().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_664().ForeColor = Color.White;
            point = new Point(74, 41);
            vmethod_664().Location = point;
            vmethod_664().Name = "lblTownWaitX";
            size = new Size(33, 17);
            vmethod_664().Size = size;
            vmethod_664().TabIndex = 56;
            vmethod_664().Text = "NONE";
            vmethod_666().AutoSize = true;
            vmethod_666().BackColor = Color.Black;
            vmethod_666().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_666().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_666().ForeColor = Color.White;
            point = new Point(74, 25);
            vmethod_666().Location = point;
            vmethod_666().Name = "lblTownWaitLocation";
            size = new Size(33, 17);
            vmethod_666().Size = size;
            vmethod_666().TabIndex = 55;
            vmethod_666().Text = "NONE";
            vmethod_668().AutoSize = true;
            vmethod_668().BackColor = Color.Black;
            vmethod_668().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_668().ForeColor = Color.White;
            point = new Point(61, 57);
            vmethod_668().Location = point;
            vmethod_668().Name = "LabelX33";
            size = new Size(12, 17);
            vmethod_668().Size = size;
            vmethod_668().TabIndex = 54;
            vmethod_668().Text = "Y:";
            vmethod_670().AutoSize = true;
            vmethod_670().BackColor = Color.Black;
            vmethod_670().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_670().ForeColor = Color.White;
            point = new Point(60, 41);
            vmethod_670().Location = point;
            vmethod_670().Name = "LabelX34";
            size = new Size(13, 17);
            vmethod_670().Size = size;
            vmethod_670().TabIndex = 53;
            vmethod_670().Text = "X:";
            vmethod_672().AccessibleRole = AccessibleRole.PushButton;
            vmethod_672().ColorTable = eButtonColor.Blue;
            vmethod_672().Dock = DockStyle.Bottom;
            vmethod_672().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(0, 117);
            vmethod_672().Location = point;
            vmethod_672().Name = "btntownWaitSave";
            vmethod_672().RightToLeft = RightToLeft.No;
            size = new Size(221, 22);
            vmethod_672().Size = size;
            vmethod_672().Style = eDotNetBarStyle.Metro;
            vmethod_672().TabIndex = 52;
            vmethod_672().Text = "SAVE LOCATION";
            vmethod_674().AutoSize = true;
            vmethod_674().BackColor = Color.Black;
            vmethod_674().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_674().ForeColor = Color.White;
            point = new Point(12, 25);
            vmethod_674().Location = point;
            vmethod_674().Name = "LabelX35";
            size = new Size(61, 17);
            vmethod_674().Size = size;
            vmethod_674().TabIndex = 51;
            vmethod_674().Text = "LOCATION:";
            vmethod_676().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_676().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_676().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_676().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_676().BackgroundStyle.MarginLeft = 1;
            vmethod_676().BackgroundStyle.MarginRight = 1;
            vmethod_676().BackgroundStyle.MarginTop = 1;
            vmethod_676().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_676().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_676().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_676().BackgroundStyle.TextShadowOffset = point;
            vmethod_676().Dock = DockStyle.Top;
            vmethod_676().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_676().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_676().Location = point;
            vmethod_676().Name = "LabelX65";
            vmethod_676().PaddingLeft = 10;
            size = new Size(221, 19);
            vmethod_676().Size = size;
            vmethod_676().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_676().TabIndex = 43;
            vmethod_676().Text = "CURRENT LOCATION";
            vmethod_676().TextLineAlignment = StringAlignment.Near;
            vmethod_142().BackColor = Color.Black;
            vmethod_142().Border.Class = "TextBoxBorder";
            vmethod_142().Border.CornerType = eCornerType.Square;
            vmethod_142().ForeColor = Color.White;
            point = new Point(68, 254);
            vmethod_142().Location = point;
            vmethod_142().Name = "txtTownBattles";
            size = new Size(120, 22);
            vmethod_142().Size = size;
            vmethod_142().TabIndex = 81;
            vmethod_144().DisplayMember = "Text";
            vmethod_144().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_144().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_144().ForeColor = Color.White;
            vmethod_144().FormattingEnabled = true;
            vmethod_144().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_146(), 
                                    vmethod_148(), 
                                    vmethod_150(), 
                                    vmethod_152(), 
                                    vmethod_154(), 
                                    vmethod_156(), 
                                    vmethod_158(), 
                                    vmethod_160(), 
                                    vmethod_162(), 
                                    vmethod_164(), 
                                    vmethod_166(), 
                                    vmethod_168() };
            vmethod_144().Items.AddRange(objArr);
            point = new Point(352, 218);
            vmethod_144().Location = point;
            vmethod_144().Name = "cmbTownWaitMinutes";
            size = new Size(120, 22);
            vmethod_144().Size = size;
            vmethod_144().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_144().TabIndex = 80;
            vmethod_146().Text = "0";
            vmethod_148().Text = "5";
            vmethod_150().Text = "10";
            vmethod_152().Text = "15";
            vmethod_154().Text = "20";
            vmethod_156().Text = "25";
            vmethod_158().Text = "30";
            vmethod_160().Text = "35";
            vmethod_162().Text = "40";
            vmethod_164().Text = "45";
            vmethod_166().Text = "50";
            vmethod_168().Text = "55";
            vmethod_170().DisplayMember = "Text";
            vmethod_170().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_170().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_170().ForeColor = Color.White;
            vmethod_170().FormattingEnabled = true;
            vmethod_170().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_172(), 
                                    vmethod_174(), 
                                    vmethod_176(), 
                                    vmethod_178(), 
                                    vmethod_180(), 
                                    vmethod_182(), 
                                    vmethod_184(), 
                                    vmethod_186(), 
                                    vmethod_188(), 
                                    vmethod_190(), 
                                    vmethod_192(), 
                                    vmethod_194(), 
                                    vmethod_196() };
            vmethod_170().Items.AddRange(objArr);
            point = new Point(352, 189);
            vmethod_170().Location = point;
            vmethod_170().Name = "cmbTownWaitHours";
            size = new Size(120, 22);
            vmethod_170().Size = size;
            vmethod_170().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_170().TabIndex = 79;
            vmethod_172().Text = "0";
            vmethod_174().Text = "1";
            vmethod_176().Text = "2";
            vmethod_178().Text = "3";
            vmethod_180().Text = "4";
            vmethod_182().Text = "5";
            vmethod_184().Text = "6";
            vmethod_186().Text = "7";
            vmethod_188().Text = "8";
            vmethod_190().Text = "9";
            vmethod_192().Text = "10";
            vmethod_194().Text = "11";
            vmethod_196().Text = "12";
            vmethod_198().DisplayMember = "Text";
            vmethod_198().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_198().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_198().ForeColor = Color.White;
            vmethod_198().FormattingEnabled = true;
            vmethod_198().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_200(), 
                                    vmethod_202(), 
                                    vmethod_204(), 
                                    vmethod_206(), 
                                    vmethod_208(), 
                                    vmethod_210(), 
                                    vmethod_212(), 
                                    vmethod_214(), 
                                    vmethod_216(), 
                                    vmethod_218(), 
                                    vmethod_220(), 
                                    vmethod_222() };
            vmethod_198().Items.AddRange(objArr);
            point = new Point(68, 218);
            vmethod_198().Location = point;
            vmethod_198().Name = "cmbTownMinutes";
            size = new Size(120, 22);
            vmethod_198().Size = size;
            vmethod_198().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_198().TabIndex = 78;
            vmethod_200().Text = "0";
            vmethod_202().Text = "5";
            vmethod_204().Text = "10";
            vmethod_206().Text = "15";
            vmethod_208().Text = "20";
            vmethod_210().Text = "25";
            vmethod_212().Text = "30";
            vmethod_214().Text = "35";
            vmethod_216().Text = "40";
            vmethod_218().Text = "45";
            vmethod_220().Text = "50";
            vmethod_222().Text = "55";
            vmethod_224().DisplayMember = "Text";
            vmethod_224().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_224().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_224().ForeColor = Color.White;
            vmethod_224().FormattingEnabled = true;
            vmethod_224().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_226(), 
                                    vmethod_228(), 
                                    vmethod_230(), 
                                    vmethod_232(), 
                                    vmethod_234(), 
                                    vmethod_236(), 
                                    vmethod_238(), 
                                    vmethod_240(), 
                                    vmethod_242(), 
                                    vmethod_244(), 
                                    vmethod_246(), 
                                    vmethod_248(), 
                                    vmethod_250() };
            vmethod_224().Items.AddRange(objArr);
            point = new Point(68, 189);
            vmethod_224().Location = point;
            vmethod_224().Name = "cmbTownHours";
            size = new Size(120, 22);
            vmethod_224().Size = size;
            vmethod_224().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_224().TabIndex = 77;
            vmethod_226().Text = "0";
            vmethod_228().Text = "1";
            vmethod_230().Text = "2";
            vmethod_232().Text = "3";
            vmethod_234().Text = "4";
            vmethod_236().Text = "5";
            vmethod_238().Text = "6";
            vmethod_240().Text = "7";
            vmethod_242().Text = "8";
            vmethod_244().Text = "9";
            vmethod_246().Text = "10";
            vmethod_248().Text = "11";
            vmethod_250().Text = "12";
            vmethod_68().AutoSize = true;
            vmethod_68().BackColor = Color.Transparent;
            vmethod_68().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_68().ForeColor = Color.White;
            point = new Point(376, 173);
            vmethod_68().Location = point;
            vmethod_68().Name = "LabelX39";
            size = new Size(98, 17);
            vmethod_68().Size = size;
            vmethod_68().Style = eDotNetBarStyle.Metro;
            vmethod_68().TabIndex = 76;
            vmethod_68().Text = "TOWN WAIT TIME";
            vmethod_70().AutoSize = true;
            vmethod_70().BackColor = Color.Transparent;
            vmethod_70().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_70().ForeColor = Color.White;
            point = new Point(298, 221);
            vmethod_70().Location = point;
            vmethod_70().Name = "LabelX37";
            size = new Size(52, 17);
            vmethod_70().Size = size;
            vmethod_70().Style = eDotNetBarStyle.Metro;
            vmethod_70().TabIndex = 75;
            vmethod_70().Text = "MINUTES";
            vmethod_72().AutoSize = true;
            vmethod_72().BackColor = Color.Transparent;
            vmethod_72().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_72().ForeColor = Color.White;
            point = new Point(310, 191);
            vmethod_72().Location = point;
            vmethod_72().Name = "LabelX38";
            size = new Size(41, 17);
            vmethod_72().Size = size;
            vmethod_72().Style = eDotNetBarStyle.Metro;
            vmethod_72().TabIndex = 74;
            vmethod_72().Text = "HOURS";
            vmethod_74().AutoSize = true;
            vmethod_74().BackColor = Color.Transparent;
            vmethod_74().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_74().ForeColor = Color.White;
            point = new Point(112, 239);
            vmethod_74().Location = point;
            vmethod_74().Name = "LabelX36";
            size = new Size(27, 17);
            vmethod_74().Size = size;
            vmethod_74().Style = eDotNetBarStyle.Metro;
            vmethod_74().TabIndex = 71;
            vmethod_74().Text = "-OR-";
            vmethod_76().BackColor = Color.Black;
            vmethod_76().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_76().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_76().ForeColor = Color.White;
            point = new Point(382, 259);
            vmethod_76().Location = point;
            vmethod_76().Name = "swtTownWaitEnable";
            vmethod_76().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_76().OffText = "DISABLED";
            vmethod_76().OffTextColor = Color.White;
            vmethod_76().OnText = "ENABLED";
            size = new Size(90, 17);
            vmethod_76().Size = size;
            vmethod_76().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_76().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_76().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_76().SwitchWidth = 6;
            vmethod_76().TabIndex = 70;
            vmethod_78().AutoSize = true;
            vmethod_78().BackColor = Color.Transparent;
            vmethod_78().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_78().ForeColor = Color.White;
            point = new Point(19, 256);
            vmethod_78().Location = point;
            vmethod_78().Name = "LabelX29";
            size = new Size(48, 17);
            vmethod_78().Size = size;
            vmethod_78().Style = eDotNetBarStyle.Metro;
            vmethod_78().TabIndex = 69;
            vmethod_78().Text = "BATTLES";
            vmethod_80().AutoSize = true;
            vmethod_80().BackColor = Color.Transparent;
            vmethod_80().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_80().ForeColor = Color.White;
            point = new Point(15, 221);
            vmethod_80().Location = point;
            vmethod_80().Name = "LabelX30";
            size = new Size(52, 17);
            vmethod_80().Size = size;
            vmethod_80().Style = eDotNetBarStyle.Metro;
            vmethod_80().TabIndex = 67;
            vmethod_80().Text = "MINUTES";
            vmethod_82().AutoSize = true;
            vmethod_82().BackColor = Color.Transparent;
            vmethod_82().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_82().ForeColor = Color.White;
            point = new Point(26, 191);
            vmethod_82().Location = point;
            vmethod_82().Name = "LabelX31";
            size = new Size(41, 17);
            vmethod_82().Size = size;
            vmethod_82().Style = eDotNetBarStyle.Metro;
            vmethod_82().TabIndex = 66;
            vmethod_82().Text = "HOURS";
            vmethod_84().BackColor = Color.Black;
            vmethod_84().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_84().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_84().ForeColor = Color.White;
            point = new Point(210, 160);
            vmethod_84().Location = point;
            vmethod_84().Name = "swtTownWaitVariable";
            vmethod_84().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_84().OffText = "TIME";
            vmethod_84().OffTextColor = Color.White;
            vmethod_84().OnText = "BATTLES";
            size = new Size(94, 17);
            vmethod_84().Size = size;
            vmethod_84().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_84().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_84().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_84().SwitchWidth = 6;
            vmethod_84().TabIndex = 63;
            vmethod_86().AutoSize = true;
            vmethod_86().BackColor = Color.Transparent;
            vmethod_86().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_86().ForeColor = Color.White;
            point = new Point(113, 160);
            vmethod_86().Location = point;
            vmethod_86().Name = "LabelX32";
            size = new Size(91, 17);
            vmethod_86().Size = size;
            vmethod_86().Style = eDotNetBarStyle.Metro;
            vmethod_86().TabIndex = 62;
            vmethod_86().Text = "TO TOWN AFTER";
            vmethod_88().BackColor = Color.Black;
            vmethod_88().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_88().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_88().ForeColor = Color.White;
            point = new Point(12, 160);
            vmethod_88().Location = point;
            vmethod_88().Name = "swtTownWaitAction";
            vmethod_88().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_88().OffText = "AUTOMOVE";
            vmethod_88().OffTextColor = Color.White;
            vmethod_88().OnText = "TELEPORT";
            size = new Size(94, 17);
            vmethod_88().Size = size;
            vmethod_88().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_88().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_88().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_88().SwitchWidth = 6;
            vmethod_88().TabIndex = 61;
            vmethod_88().Value = true;
            vmethod_88().ValueObject = "Y";
            vmethod_48().AttachedControl = vmethod_46();
            vmethod_48().GlobalItem = false;
            vmethod_48().Name = "SuperTabItem7";
            superTabItemStateColorTable4.SelectionMarker = Color.Black;
            superTabColorStates4.Selected = superTabItemStateColorTable4;
            superTabItemColorTable4.Default = superTabColorStates4;
            vmethod_48().TabColor = superTabItemColorTable4;
            vmethod_48().Text = "TOWN WAIT";
            vmethod_12().AttachedControl = vmethod_10();
            vmethod_12().GlobalItem = false;
            vmethod_12().Name = "SuperTabItem5";
            superTabItemStateColorTable5.SelectionMarker = Color.Black;
            superTabColorStates5.Selected = superTabItemStateColorTable5;
            superTabItemColorTable5.Default = superTabColorStates5;
            vmethod_12().TabColor = superTabItemColorTable5;
            vmethod_12().Text = "ACTIONS";
            vmethod_22().CanvasColor = Color.Black;
            vmethod_22().ColorSchemeStyle = eDotNetBarStyle.Metro;
            vmethod_22().Controls.Add(vmethod_576());
            vmethod_22().Controls.Add(vmethod_488());
            vmethod_22().Dock = DockStyle.Fill;
            point = new Point(0, 0);
            vmethod_22().Location = point;
            vmethod_22().Name = "SuperTabControlPanel3";
            colorArr = new Color[1];
            colorArr[0] = Color.Black;
            superTabLinearGradientColorTable7.Colors = colorArr;
            superTabPanelItemColorTable5.Background = superTabLinearGradientColorTable7;
            superTabPanelItemColorTable5.InnerBorder = Color.Black;
            superTabPanelItemColorTable5.OuterBorder = Color.Black;
            superTabPanelColorTable5.Default = superTabPanelItemColorTable5;
            vmethod_22().PanelColor = superTabPanelColorTable5;
            size = new Size(484, 343);
            vmethod_22().Size = size;
            vmethod_22().TabIndex = 0;
            vmethod_22().TabItem = vmethod_24();
            vmethod_576().CanvasColor = SystemColors.Control;
            vmethod_576().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_576().Controls.Add(vmethod_592());
            vmethod_576().Controls.Add(vmethod_578());
            vmethod_576().Controls.Add(vmethod_580());
            vmethod_576().Controls.Add(vmethod_582());
            vmethod_576().Controls.Add(vmethod_584());
            vmethod_576().Controls.Add(vmethod_586());
            vmethod_576().Controls.Add(vmethod_588());
            vmethod_576().Controls.Add(vmethod_590());
            point = new Point(12, 140);
            vmethod_576().Location = point;
            vmethod_576().Name = "PanelEx11";
            size = new Size(460, 112);
            vmethod_576().Size = size;
            vmethod_576().Style.Alignment = StringAlignment.Center;
            vmethod_576().Style.BackColor1.Color = Color.Black;
            vmethod_576().Style.Border = eBorderType.SingleLine;
            vmethod_576().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_576().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_576().Style.GradientAngle = 90;
            vmethod_576().TabIndex = 41;
            backgroundColorBlendArr = new BackgroundColorBlend[] {
                                                                   new BackgroundColorBlend(Color.FromArgb(255, 128, 0), 0.0F), 
                                                                   new BackgroundColorBlend(Color.Black, 0.0F) };
            vmethod_592().BackgroundStyle.BackColorBlend.AddRange(backgroundColorBlendArr);
            vmethod_592().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_592().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_592().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_592().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_592().BackgroundStyle.MarginLeft = 1;
            vmethod_592().BackgroundStyle.MarginRight = 1;
            vmethod_592().BackgroundStyle.MarginTop = 1;
            vmethod_592().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_592().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Far;
            vmethod_592().Dock = DockStyle.Top;
            vmethod_592().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_592().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_592().Location = point;
            vmethod_592().Name = "LabelX55";
            vmethod_592().PaddingLeft = 10;
            size = new Size(460, 22);
            vmethod_592().Size = size;
            vmethod_592().TabIndex = 50;
            vmethod_592().Text = "SAVE LOCATION";
            vmethod_592().TextLineAlignment = StringAlignment.Near;
            vmethod_578().AutoSize = true;
            vmethod_578().BackColor = Color.Black;
            vmethod_578().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_578().ForeColor = Color.White;
            point = new Point(78, 56);
            vmethod_578().Location = point;
            vmethod_578().Name = "labelAfterdeathY";
            size = new Size(0, 0);
            vmethod_578().Size = size;
            vmethod_578().TabIndex = 49;
            vmethod_580().AutoSize = true;
            vmethod_580().BackColor = Color.Black;
            vmethod_580().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_580().ForeColor = Color.White;
            point = new Point(78, 40);
            vmethod_580().Location = point;
            vmethod_580().Name = "labelAfterdeathX";
            size = new Size(0, 0);
            vmethod_580().Size = size;
            vmethod_580().TabIndex = 48;
            vmethod_582().AutoSize = true;
            vmethod_582().BackColor = Color.Black;
            vmethod_582().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_582().ForeColor = Color.White;
            point = new Point(78, 24);
            vmethod_582().Location = point;
            vmethod_582().Name = "labelAfterdeathLocation";
            size = new Size(0, 0);
            vmethod_582().Size = size;
            vmethod_582().TabIndex = 47;
            vmethod_584().AutoSize = true;
            vmethod_584().BackColor = Color.Black;
            vmethod_584().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_584().ForeColor = Color.White;
            point = new Point(60, 56);
            vmethod_584().Location = point;
            vmethod_584().Name = "LabelX16";
            size = new Size(12, 17);
            vmethod_584().Size = size;
            vmethod_584().TabIndex = 46;
            vmethod_584().Text = "Y:";
            vmethod_586().AutoSize = true;
            vmethod_586().BackColor = Color.Black;
            vmethod_586().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_586().ForeColor = Color.White;
            point = new Point(59, 40);
            vmethod_586().Location = point;
            vmethod_586().Name = "LabelX15";
            size = new Size(13, 17);
            vmethod_586().Size = size;
            vmethod_586().TabIndex = 45;
            vmethod_586().Text = "X:";
            vmethod_588().AccessibleRole = AccessibleRole.PushButton;
            vmethod_588().BackColor = Color.FromArgb(255, 128, 0);
            vmethod_588().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_588().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(333, 78);
            vmethod_588().Location = point;
            vmethod_588().Name = "btnSaveLocation";
            vmethod_588().RightToLeft = RightToLeft.No;
            size = new Size(114, 22);
            vmethod_588().Size = size;
            vmethod_588().Style = eDotNetBarStyle.Metro;
            vmethod_588().TabIndex = 44;
            vmethod_588().Text = "SAVE LOCATION";
            vmethod_590().AutoSize = true;
            vmethod_590().BackColor = Color.Black;
            vmethod_590().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_590().ForeColor = Color.White;
            point = new Point(11, 24);
            vmethod_590().Location = point;
            vmethod_590().Name = "LabelX14";
            size = new Size(61, 17);
            vmethod_590().Size = size;
            vmethod_590().TabIndex = 43;
            vmethod_590().Text = "LOCATION:";
            vmethod_488().CanvasColor = SystemColors.Control;
            vmethod_488().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_488().Controls.Add(vmethod_594());
            vmethod_488().Controls.Add(vmethod_490());
            vmethod_488().Controls.Add(vmethod_492());
            vmethod_488().Controls.Add(vmethod_494());
            vmethod_488().Controls.Add(vmethod_496());
            point = new Point(12, 20);
            vmethod_488().Location = point;
            vmethod_488().Name = "PanelEx10";
            size = new Size(460, 105);
            vmethod_488().Size = size;
            vmethod_488().Style.Alignment = StringAlignment.Center;
            vmethod_488().Style.BackColor1.Color = Color.Black;
            vmethod_488().Style.Border = eBorderType.SingleLine;
            vmethod_488().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_488().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_488().Style.GradientAngle = 90;
            vmethod_488().TabIndex = 40;
            vmethod_594().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_594().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_594().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_594().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_594().BackgroundStyle.MarginLeft = 1;
            vmethod_594().BackgroundStyle.MarginRight = 1;
            vmethod_594().BackgroundStyle.MarginTop = 1;
            vmethod_594().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_594().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_594().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_594().BackgroundStyle.TextShadowOffset = point;
            vmethod_594().Dock = DockStyle.Top;
            vmethod_594().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_594().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_594().Location = point;
            vmethod_594().Name = "LabelX54";
            vmethod_594().PaddingLeft = 10;
            size = new Size(460, 19);
            vmethod_594().Size = size;
            vmethod_594().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_594().TabIndex = 42;
            vmethod_594().Text = "AFTER DEATH LOCATION";
            vmethod_594().TextLineAlignment = StringAlignment.Near;
            vmethod_490().AccessibleRole = AccessibleRole.PushButton;
            vmethod_490().BackColor = Color.FromArgb(255, 128, 0);
            vmethod_490().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_490().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(333, 42);
            vmethod_490().Location = point;
            vmethod_490().Name = "btnDeleteLocation";
            vmethod_490().RightToLeft = RightToLeft.No;
            size = new Size(114, 22);
            vmethod_490().Size = size;
            vmethod_490().Style = eDotNetBarStyle.Metro;
            vmethod_490().TabIndex = 41;
            vmethod_490().Text = "DELETE LOCATION";
            vmethod_492().BackColor = Color.Black;
            vmethod_492().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_492().ForeColor = Color.White;
            point = new Point(11, 25);
            vmethod_492().Location = point;
            vmethod_492().Name = "LabelX12";
            size = new Size(81, 15);
            vmethod_492().Size = size;
            vmethod_492().TabIndex = 40;
            vmethod_492().Text = "LOCATION";
            vmethod_494().DisplayMember = "Text";
            vmethod_494().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_494().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_494().Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_494().ForeColor = Color.White;
            vmethod_494().FormattingEnabled = true;
            vmethod_494().ItemHeight = 16;
            point = new Point(11, 42);
            vmethod_494().Location = point;
            vmethod_494().Name = "cmbLocations";
            size = new Size(323, 22);
            vmethod_494().Size = size;
            vmethod_494().Style = eDotNetBarStyle.Metro;
            vmethod_494().TabIndex = 39;
            vmethod_496().BackColor = Color.Black;
            vmethod_496().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_496().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_496().ForeColor = Color.White;
            point = new Point(11, 65);
            vmethod_496().Location = point;
            vmethod_496().Name = "swtAfterDeathOption";
            vmethod_496().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_496().OffText = "AUTOMOVE";
            vmethod_496().OffTextColor = Color.White;
            vmethod_496().OnText = "TELEPORT";
            size = new Size(87, 19);
            vmethod_496().Size = size;
            vmethod_496().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_496().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_496().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_496().SwitchWidth = 6;
            vmethod_496().TabIndex = 38;
            vmethod_24().AttachedControl = vmethod_22();
            vmethod_24().GlobalItem = false;
            vmethod_24().Name = "SuperTabItem3";
            superTabItemStateColorTable6.SelectionMarker = Color.Black;
            superTabColorStates6.Selected = superTabItemStateColorTable6;
            superTabItemColorTable6.Default = superTabColorStates6;
            vmethod_24().TabColor = superTabItemColorTable6;
            vmethod_24().Text = "AFTER DEATH";
            vmethod_18().Controls.Add(vmethod_498());
            vmethod_18().Controls.Add(vmethod_518());
            vmethod_18().Controls.Add(vmethod_542());
            vmethod_18().Controls.Add(vmethod_550());
            vmethod_18().Dock = DockStyle.Fill;
            point = new Point(0, 25);
            vmethod_18().Location = point;
            vmethod_18().Name = "SuperTabControlPanel2";
            colorArr = new Color[1];
            colorArr[0] = Color.Black;
            superTabLinearGradientColorTable8.Colors = colorArr;
            superTabPanelItemColorTable6.Background = superTabLinearGradientColorTable8;
            superTabPanelItemColorTable6.InnerBorder = Color.Black;
            superTabPanelItemColorTable6.OuterBorder = Color.Black;
            superTabPanelColorTable6.Default = superTabPanelItemColorTable6;
            vmethod_18().PanelColor = superTabPanelColorTable6;
            size = new Size(484, 318);
            vmethod_18().Size = size;
            vmethod_18().TabIndex = 0;
            vmethod_18().TabItem = vmethod_20();
            vmethod_498().CanvasColor = SystemColors.Control;
            vmethod_498().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_498().Controls.Add(vmethod_604());
            vmethod_498().Controls.Add(vmethod_500());
            vmethod_498().Controls.Add(vmethod_502());
            vmethod_498().Controls.Add(vmethod_516());
            point = new Point(285, 20);
            vmethod_498().Location = point;
            vmethod_498().Name = "PanelEx9";
            size = new Size(187, 102);
            vmethod_498().Size = size;
            vmethod_498().Style.Alignment = StringAlignment.Center;
            vmethod_498().Style.BackColor1.Color = Color.Black;
            vmethod_498().Style.Border = eBorderType.SingleLine;
            vmethod_498().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_498().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_498().Style.GradientAngle = 90;
            vmethod_498().TabIndex = 42;
            vmethod_604().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_604().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_604().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_604().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_604().BackgroundStyle.MarginLeft = 1;
            vmethod_604().BackgroundStyle.MarginRight = 1;
            vmethod_604().BackgroundStyle.MarginTop = 1;
            vmethod_604().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_604().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_604().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_604().BackgroundStyle.TextShadowOffset = point;
            vmethod_604().Dock = DockStyle.Top;
            vmethod_604().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_604().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_604().Location = point;
            vmethod_604().Name = "LabelX56";
            vmethod_604().PaddingLeft = 10;
            size = new Size(187, 19);
            vmethod_604().Size = size;
            vmethod_604().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_604().TabIndex = 43;
            vmethod_604().Text = "SPEED OPTIONS";
            vmethod_604().TextLineAlignment = StringAlignment.Near;
            vmethod_500().BackColor = Color.Black;
            vmethod_500().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_500().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_500().ForeColor = Color.White;
            point = new Point(11, 66);
            vmethod_500().Location = point;
            vmethod_500().Name = "swtSpeedEnable";
            vmethod_500().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_500().OffText = "DISABLED";
            vmethod_500().OffTextColor = Color.White;
            vmethod_500().OnText = "ENABLED";
            size = new Size(72, 19);
            vmethod_500().Size = size;
            vmethod_500().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_500().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_500().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_500().SwitchWidth = 6;
            vmethod_500().TabIndex = 26;
            vmethod_502().DisplayMember = "Text";
            vmethod_502().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_502().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_502().ForeColor = Color.White;
            vmethod_502().FormattingEnabled = true;
            vmethod_502().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_504(), 
                                    vmethod_506(), 
                                    vmethod_508(), 
                                    vmethod_510(), 
                                    vmethod_512(), 
                                    vmethod_514() };
            vmethod_502().Items.AddRange(objArr);
            point = new Point(11, 44);
            vmethod_502().Location = point;
            vmethod_502().Name = "cmbBattleSpeed";
            size = new Size(163, 22);
            vmethod_502().Size = size;
            vmethod_502().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_502().TabIndex = 25;
            vmethod_504().Text = "150";
            vmethod_506().Text = "200";
            vmethod_508().Text = "250";
            vmethod_510().Text = "300";
            vmethod_512().Text = "350";
            vmethod_514().Text = "400";
            vmethod_516().AutoSize = true;
            vmethod_516().BackColor = Color.Transparent;
            vmethod_516().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_516().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_516().ForeColor = Color.White;
            point = new Point(11, 21);
            vmethod_516().Location = point;
            vmethod_516().Name = "LabelX13";
            size = new Size(99, 17);
            vmethod_516().Size = size;
            vmethod_516().TabIndex = 24;
            vmethod_516().Text = "SET BATTLE SPEED";
            vmethod_518().CanvasColor = SystemColors.Control;
            vmethod_518().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_518().Controls.Add(vmethod_606());
            vmethod_518().Controls.Add(vmethod_520());
            vmethod_518().Controls.Add(vmethod_540());
            point = new Point(285, 131);
            vmethod_518().Location = point;
            vmethod_518().Name = "PanelEx8";
            size = new Size(187, 89);
            vmethod_518().Size = size;
            vmethod_518().Style.Alignment = StringAlignment.Center;
            vmethod_518().Style.BackColor1.Color = Color.Black;
            vmethod_518().Style.Border = eBorderType.SingleLine;
            vmethod_518().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_518().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_518().Style.GradientAngle = 90;
            vmethod_518().TabIndex = 41;
            vmethod_606().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_606().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_606().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_606().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_606().BackgroundStyle.MarginLeft = 1;
            vmethod_606().BackgroundStyle.MarginRight = 1;
            vmethod_606().BackgroundStyle.MarginTop = 1;
            vmethod_606().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_606().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_606().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_606().BackgroundStyle.TextShadowOffset = point;
            vmethod_606().Dock = DockStyle.Top;
            vmethod_606().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_606().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_606().Location = point;
            vmethod_606().Name = "LabelX52";
            vmethod_606().PaddingLeft = 10;
            size = new Size(187, 19);
            vmethod_606().Size = size;
            vmethod_606().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_606().TabIndex = 43;
            vmethod_606().Text = "ZOOM OPTIONS";
            vmethod_606().TextLineAlignment = StringAlignment.Near;
            vmethod_520().DisplayMember = "Text";
            vmethod_520().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_520().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_520().ForeColor = Color.White;
            vmethod_520().FormattingEnabled = true;
            vmethod_520().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_522(), 
                                    vmethod_524(), 
                                    vmethod_526(), 
                                    vmethod_528(), 
                                    vmethod_530(), 
                                    vmethod_532(), 
                                    vmethod_534(), 
                                    vmethod_536(), 
                                    vmethod_538() };
            vmethod_520().Items.AddRange(objArr);
            point = new Point(10, 45);
            vmethod_520().Location = point;
            vmethod_520().Name = "cmbZoom";
            size = new Size(164, 22);
            vmethod_520().Size = size;
            vmethod_520().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_520().TabIndex = 22;
            vmethod_522().Text = "10";
            vmethod_524().Text = "15";
            vmethod_526().Text = "20";
            vmethod_528().Text = "25";
            vmethod_530().Text = "30";
            vmethod_532().Text = "35";
            vmethod_534().Text = "40";
            vmethod_536().Text = "45";
            vmethod_538().Text = "50";
            vmethod_540().AutoSize = true;
            vmethod_540().BackColor = Color.Transparent;
            vmethod_540().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_540().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_540().ForeColor = Color.White;
            point = new Point(10, 22);
            vmethod_540().Location = point;
            vmethod_540().Name = "LabelX21";
            size = new Size(58, 17);
            vmethod_540().Size = size;
            vmethod_540().TabIndex = 21;
            vmethod_540().Text = "SET ZOOM";
            vmethod_542().CanvasColor = SystemColors.Control;
            vmethod_542().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_542().Controls.Add(vmethod_608());
            vmethod_542().Controls.Add(vmethod_544());
            vmethod_542().Controls.Add(vmethod_546());
            vmethod_542().Controls.Add(vmethod_548());
            point = new Point(12, 110);
            vmethod_542().Location = point;
            vmethod_542().Name = "PanelEx7";
            size = new Size(256, 89);
            vmethod_542().Size = size;
            vmethod_542().Style.Alignment = StringAlignment.Center;
            vmethod_542().Style.BackColor1.Color = Color.Black;
            vmethod_542().Style.Border = eBorderType.SingleLine;
            vmethod_542().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_542().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_542().Style.GradientAngle = 90;
            vmethod_542().TabIndex = 40;
            vmethod_608().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_608().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_608().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_608().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_608().BackgroundStyle.MarginLeft = 1;
            vmethod_608().BackgroundStyle.MarginRight = 1;
            vmethod_608().BackgroundStyle.MarginTop = 1;
            vmethod_608().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_608().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_608().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_608().BackgroundStyle.TextShadowOffset = point;
            vmethod_608().Dock = DockStyle.Top;
            vmethod_608().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_608().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_608().Location = point;
            vmethod_608().Name = "LabelX42";
            vmethod_608().PaddingLeft = 10;
            size = new Size(256, 19);
            vmethod_608().Size = size;
            vmethod_608().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_608().TabIndex = 43;
            vmethod_608().Text = "TURN OPTIONS";
            vmethod_608().TextLineAlignment = StringAlignment.Near;
            vmethod_544().BackColor = Color.Black;
            vmethod_544().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_544().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_544().ForeColor = Color.White;
            point = new Point(59, 60);
            vmethod_544().Location = point;
            vmethod_544().Name = "swtTurnOption";
            vmethod_544().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_544().OffText = "WAIT MAIN";
            vmethod_544().OffTextColor = Color.White;
            vmethod_544().OnText = "GUARD MAIN";
            size = new Size(121, 19);
            vmethod_544().Size = size;
            vmethod_544().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_544().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_544().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_544().SwitchWidth = 6;
            vmethod_544().TabIndex = 24;
            vmethod_546().AutoSize = true;
            vmethod_546().BackColor = Color.Transparent;
            vmethod_546().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_546().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_546().ForeColor = Color.White;
            point = new Point(10, 37);
            vmethod_546().Location = point;
            vmethod_546().Name = "LabelX11";
            size = new Size(190, 17);
            vmethod_546().Size = size;
            vmethod_546().TabIndex = 23;
            vmethod_546().Text = "RANGED AND MAGIC MAIN'S WAIT";
            vmethod_548().AutoSize = true;
            vmethod_548().BackColor = Color.Transparent;
            vmethod_548().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_548().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_548().ForeColor = Color.White;
            point = new Point(10, 21);
            vmethod_548().Location = point;
            vmethod_548().Name = "LabelX10";
            size = new Size(121, 17);
            vmethod_548().Size = size;
            vmethod_548().TabIndex = 22;
            vmethod_548().Text = "MELEE MAIN'S GUARD";
            vmethod_550().CanvasColor = SystemColors.Control;
            vmethod_550().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_550().Controls.Add(vmethod_610());
            vmethod_550().Controls.Add(vmethod_552());
            vmethod_550().Controls.Add(vmethod_574());
            point = new Point(12, 20);
            vmethod_550().Location = point;
            vmethod_550().Name = "PanelEx6";
            size = new Size(256, 78);
            vmethod_550().Size = size;
            vmethod_550().Style.Alignment = StringAlignment.Center;
            vmethod_550().Style.BackColor1.Color = Color.Black;
            vmethod_550().Style.Border = eBorderType.SingleLine;
            vmethod_550().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_550().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_550().Style.GradientAngle = 90;
            vmethod_550().TabIndex = 39;
            vmethod_610().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_610().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_610().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_610().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_610().BackgroundStyle.MarginLeft = 1;
            vmethod_610().BackgroundStyle.MarginRight = 1;
            vmethod_610().BackgroundStyle.MarginTop = 1;
            vmethod_610().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_610().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_610().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_610().BackgroundStyle.TextShadowOffset = point;
            vmethod_610().Dock = DockStyle.Top;
            vmethod_610().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_610().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_610().Location = point;
            vmethod_610().Name = "LabelX51";
            vmethod_610().PaddingLeft = 10;
            size = new Size(256, 19);
            vmethod_610().Size = size;
            vmethod_610().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_610().TabIndex = 43;
            vmethod_610().Text = "AUTO-BATTLE";
            vmethod_610().TextLineAlignment = StringAlignment.Near;
            vmethod_552().DisplayMember = "Text";
            vmethod_552().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_552().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_552().FlatStyle = FlatStyle.Popup;
            vmethod_552().ForeColor = Color.White;
            vmethod_552().FormattingEnabled = true;
            vmethod_552().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_554(), 
                                    vmethod_556(), 
                                    vmethod_558(), 
                                    vmethod_560(), 
                                    vmethod_562(), 
                                    vmethod_564(), 
                                    vmethod_566(), 
                                    vmethod_568(), 
                                    vmethod_570(), 
                                    vmethod_572() };
            vmethod_552().Items.AddRange(objArr);
            point = new Point(10, 44);
            vmethod_552().Location = point;
            vmethod_552().Name = "cmbAutoBattleCount";
            size = new Size(107, 22);
            vmethod_552().Size = size;
            vmethod_552().Style = eDotNetBarStyle.Metro;
            vmethod_552().TabIndex = 21;
            vmethod_554().Text = "5";
            vmethod_556().Text = "10";
            vmethod_558().Text = "15";
            vmethod_560().Text = "20";
            vmethod_562().Text = "25";
            vmethod_564().Text = "30";
            vmethod_566().Text = "35";
            vmethod_568().Text = "40";
            vmethod_570().Text = "45";
            vmethod_572().Text = "50";
            vmethod_574().AutoSize = true;
            vmethod_574().BackColor = Color.Transparent;
            vmethod_574().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_574().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_574().ForeColor = Color.White;
            point = new Point(10, 21);
            vmethod_574().Location = point;
            vmethod_574().Name = "LabelX7";
            size = new Size(230, 17);
            vmethod_574().Size = size;
            vmethod_574().TabIndex = 20;
            vmethod_574().Text = "START AUTOBATTLE WHEN GREATER THEN";
            vmethod_20().AttachedControl = vmethod_18();
            vmethod_20().GlobalItem = false;
            vmethod_20().Name = "SuperTabItem2";
            superTabItemStateColorTable7.SelectionMarker = Color.Black;
            superTabColorStates7.Selected = superTabItemStateColorTable7;
            superTabItemColorTable7.Default = superTabColorStates7;
            vmethod_20().TabColor = superTabItemColorTable7;
            vmethod_20().Text = "BATTLE";
            vmethod_2().ColorSchemeStyle = eDotNetBarStyle.Metro;
            vmethod_2().Controls.Add(vmethod_354());
            vmethod_2().Controls.Add(vmethod_424());
            vmethod_2().Controls.Add(vmethod_448());
            vmethod_2().Controls.Add(vmethod_314());
            vmethod_2().Dock = DockStyle.Fill;
            point = new Point(0, 25);
            vmethod_2().Location = point;
            vmethod_2().Name = "SuperTabControlPanel1";
            colorArr = new Color[1];
            colorArr[0] = Color.Black;
            superTabLinearGradientColorTable9.Colors = colorArr;
            superTabPanelItemColorTable7.Background = superTabLinearGradientColorTable9;
            superTabPanelItemColorTable7.InnerBorder = Color.Black;
            superTabPanelItemColorTable7.OuterBorder = Color.Black;
            superTabPanelColorTable7.Default = superTabPanelItemColorTable7;
            vmethod_2().PanelColor = superTabPanelColorTable7;
            size = new Size(484, 318);
            vmethod_2().Size = size;
            vmethod_2().TabIndex = 1;
            vmethod_2().TabItem = vmethod_4();
            vmethod_354().CanvasColor = SystemColors.Control;
            vmethod_354().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_354().Controls.Add(vmethod_596());
            vmethod_354().Controls.Add(vmethod_356());
            vmethod_354().Controls.Add(vmethod_358());
            vmethod_354().Controls.Add(vmethod_360());
            vmethod_354().Controls.Add(vmethod_378());
            vmethod_354().Controls.Add(vmethod_398());
            vmethod_354().Controls.Add(vmethod_418());
            vmethod_354().Controls.Add(vmethod_420());
            vmethod_354().Controls.Add(vmethod_422());
            point = new Point(244, 20);
            vmethod_354().Location = point;
            vmethod_354().Name = "PanelEx5";
            size = new Size(228, 124);
            vmethod_354().Size = size;
            vmethod_354().Style.Alignment = StringAlignment.Center;
            vmethod_354().Style.BackColor1.Color = Color.Black;
            vmethod_354().Style.Border = eBorderType.SingleLine;
            vmethod_354().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_354().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_354().Style.GradientAngle = 90;
            vmethod_354().TabIndex = 41;
            vmethod_596().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_596().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_596().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_596().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_596().BackgroundStyle.MarginLeft = 1;
            vmethod_596().BackgroundStyle.MarginRight = 1;
            vmethod_596().BackgroundStyle.MarginTop = 1;
            vmethod_596().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_596().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_596().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_596().BackgroundStyle.TextShadowOffset = point;
            vmethod_596().Dock = DockStyle.Top;
            vmethod_596().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_596().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_596().Location = point;
            vmethod_596().Name = "LabelX40";
            vmethod_596().PaddingLeft = 10;
            size = new Size(228, 19);
            vmethod_596().Size = size;
            vmethod_596().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_596().TabIndex = 43;
            vmethod_596().Text = "USE POTION WHEN";
            vmethod_596().TextLineAlignment = StringAlignment.Near;
            vmethod_356().AutoSize = true;
            vmethod_356().BackColor = Color.Transparent;
            vmethod_356().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_356().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_356().ForeColor = Color.White;
            point = new Point(187, 59);
            vmethod_356().Location = point;
            vmethod_356().Name = "LabelX8";
            size = new Size(12, 17);
            vmethod_356().Size = size;
            vmethod_356().TabIndex = 29;
            vmethod_356().Text = "%";
            vmethod_358().AutoSize = true;
            vmethod_358().BackColor = Color.Transparent;
            vmethod_358().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_358().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_358().ForeColor = Color.White;
            point = new Point(187, 30);
            vmethod_358().Location = point;
            vmethod_358().Name = "LabelX9";
            size = new Size(12, 17);
            vmethod_358().Size = size;
            vmethod_358().TabIndex = 28;
            vmethod_358().Text = "%";
            vmethod_360().DisplayMember = "Text";
            vmethod_360().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_360().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_360().ForeColor = Color.White;
            vmethod_360().FormattingEnabled = true;
            vmethod_360().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_362(), 
                                    vmethod_364(), 
                                    vmethod_366(), 
                                    vmethod_368(), 
                                    vmethod_370(), 
                                    vmethod_372(), 
                                    vmethod_374(), 
                                    vmethod_376() };
            vmethod_360().Items.AddRange(objArr);
            point = new Point(89, 84);
            vmethod_360().Location = point;
            vmethod_360().Name = "cmbDeadCount";
            size = new Size(92, 22);
            vmethod_360().Size = size;
            vmethod_360().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_360().TabIndex = 27;
            vmethod_362().Text = "1";
            vmethod_364().Text = "2";
            vmethod_366().Text = "3";
            vmethod_368().Text = "4";
            vmethod_370().Text = "5";
            vmethod_372().Text = "6";
            vmethod_374().Text = "7";
            vmethod_376().Text = "8";
            vmethod_378().DisplayMember = "Text";
            vmethod_378().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_378().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_378().ForeColor = Color.White;
            vmethod_378().FormattingEnabled = true;
            vmethod_378().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_380(), 
                                    vmethod_382(), 
                                    vmethod_384(), 
                                    vmethod_386(), 
                                    vmethod_388(), 
                                    vmethod_390(), 
                                    vmethod_392(), 
                                    vmethod_394(), 
                                    vmethod_396() };
            vmethod_378().Items.AddRange(objArr);
            point = new Point(89, 56);
            vmethod_378().Location = point;
            vmethod_378().Name = "cmbManaPercent";
            size = new Size(92, 22);
            vmethod_378().Size = size;
            vmethod_378().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_378().TabIndex = 26;
            vmethod_380().Text = "10";
            vmethod_382().Text = "20";
            vmethod_384().Text = "30";
            vmethod_386().Text = "40";
            vmethod_388().Text = "50";
            vmethod_390().Text = "60";
            vmethod_392().Text = "70";
            vmethod_394().Text = "80";
            vmethod_396().Text = "90";
            vmethod_398().DisplayMember = "Text";
            vmethod_398().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_398().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_398().ForeColor = Color.White;
            vmethod_398().FormattingEnabled = true;
            vmethod_398().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_400(), 
                                    vmethod_402(), 
                                    vmethod_404(), 
                                    vmethod_406(), 
                                    vmethod_408(), 
                                    vmethod_410(), 
                                    vmethod_412(), 
                                    vmethod_414(), 
                                    vmethod_416() };
            vmethod_398().Items.AddRange(objArr);
            point = new Point(89, 28);
            vmethod_398().Location = point;
            vmethod_398().Name = "cmbHealPercent";
            size = new Size(92, 22);
            vmethod_398().Size = size;
            vmethod_398().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_398().TabIndex = 25;
            vmethod_400().Text = "10";
            vmethod_402().Text = "20";
            vmethod_404().Text = "30";
            vmethod_406().Text = "40";
            vmethod_408().Text = "50";
            vmethod_410().Text = "60";
            vmethod_412().Text = "70";
            vmethod_414().Text = "80";
            vmethod_416().Text = "90";
            vmethod_418().AutoSize = true;
            vmethod_418().BackColor = Color.Transparent;
            vmethod_418().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_418().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_418().ForeColor = Color.White;
            point = new Point(32, 87);
            vmethod_418().Location = point;
            vmethod_418().Name = "LabelX6";
            size = new Size(51, 17);
            vmethod_418().Size = size;
            vmethod_418().TabIndex = 24;
            vmethod_418().Text = "DEAD >=";
            vmethod_420().AutoSize = true;
            vmethod_420().BackColor = Color.Transparent;
            vmethod_420().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_420().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_420().ForeColor = Color.White;
            point = new Point(22, 59);
            vmethod_420().Location = point;
            vmethod_420().Name = "LabelX5";
            size = new Size(61, 17);
            vmethod_420().Size = size;
            vmethod_420().TabIndex = 23;
            vmethod_420().Text = "MANA IS <";
            vmethod_422().AutoSize = true;
            vmethod_422().BackColor = Color.Transparent;
            vmethod_422().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_422().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_422().ForeColor = Color.White;
            point = new Point(14, 30);
            vmethod_422().Location = point;
            vmethod_422().Name = "LabelX2";
            size = new Size(69, 17);
            vmethod_422().Size = size;
            vmethod_422().TabIndex = 22;
            vmethod_422().Text = "HEALTH IS <";
            vmethod_424().CanvasColor = SystemColors.Control;
            vmethod_424().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_424().Controls.Add(vmethod_598());
            vmethod_424().Controls.Add(vmethod_426());
            vmethod_424().Controls.Add(vmethod_428());
            vmethod_424().Controls.Add(vmethod_430());
            point = new Point(12, 213);
            vmethod_424().Location = point;
            vmethod_424().Name = "PanelEx4";
            size = new Size(221, 78);
            vmethod_424().Size = size;
            vmethod_424().Style.Alignment = StringAlignment.Center;
            vmethod_424().Style.BackColor1.Color = Color.Black;
            vmethod_424().Style.Border = eBorderType.SingleLine;
            vmethod_424().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_424().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_424().Style.GradientAngle = 90;
            vmethod_424().TabIndex = 40;
            vmethod_598().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_598().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_598().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_598().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_598().BackgroundStyle.MarginLeft = 1;
            vmethod_598().BackgroundStyle.MarginRight = 1;
            vmethod_598().BackgroundStyle.MarginTop = 1;
            vmethod_598().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_598().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_598().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_598().BackgroundStyle.TextShadowOffset = point;
            vmethod_598().Dock = DockStyle.Top;
            vmethod_598().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_598().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_598().Location = point;
            vmethod_598().Name = "LabelX50";
            vmethod_598().PaddingLeft = 10;
            size = new Size(221, 19);
            vmethod_598().Size = size;
            vmethod_598().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_598().TabIndex = 43;
            vmethod_598().Text = "REVIVAL";
            vmethod_598().TextLineAlignment = StringAlignment.Near;
            vmethod_426().BackColor = Color.Transparent;
            vmethod_426().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_426().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_426().ForeColor = Color.White;
            point = new Point(16, 26);
            vmethod_426().Location = point;
            vmethod_426().Name = "LabelX3";
            size = new Size(96, 14);
            vmethod_426().Size = size;
            vmethod_426().TabIndex = 16;
            vmethod_426().Text = "POTION TYPE";
            vmethod_428().BackColor = Color.Black;
            vmethod_428().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_428().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_428().ForeColor = Color.White;
            point = new Point(118, 25);
            vmethod_428().Location = point;
            vmethod_428().Name = "swtLifePotionEnabled";
            vmethod_428().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_428().OffText = "DISABLED";
            vmethod_428().OffTextColor = Color.White;
            vmethod_428().OnText = "ENABLED";
            size = new Size(78, 19);
            vmethod_428().Size = size;
            vmethod_428().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_428().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_428().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_428().SwitchWidth = 6;
            vmethod_428().TabIndex = 15;
            vmethod_430().DisplayMember = "Text";
            vmethod_430().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_430().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_430().ForeColor = Color.White;
            vmethod_430().FormattingEnabled = true;
            vmethod_430().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_432(), 
                                    vmethod_434(), 
                                    vmethod_436(), 
                                    vmethod_438(), 
                                    vmethod_440(), 
                                    vmethod_442(), 
                                    vmethod_444(), 
                                    vmethod_446() };
            vmethod_430().Items.AddRange(objArr);
            point = new Point(16, 44);
            vmethod_430().Location = point;
            vmethod_430().Name = "cmbLifePotion";
            size = new Size(180, 22);
            vmethod_430().Size = size;
            vmethod_430().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_430().TabIndex = 14;
            vmethod_432().Text = "Life Potion [I]";
            vmethod_434().Text = "Life Potion [II]";
            vmethod_436().Text = "Life Potion [III]";
            vmethod_438().Text = "Life Potion [IV]";
            vmethod_440().Text = "Life Potion [V]";
            vmethod_442().Text = "Life Potion [VI]";
            vmethod_444().Text = "Water of Life";
            vmethod_446().Text = "Water of Life (No Trade)";
            vmethod_448().CanvasColor = SystemColors.Control;
            vmethod_448().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_448().Controls.Add(vmethod_600());
            vmethod_448().Controls.Add(vmethod_450());
            vmethod_448().Controls.Add(vmethod_452());
            vmethod_448().Controls.Add(vmethod_454());
            point = new Point(12, 117);
            vmethod_448().Location = point;
            vmethod_448().Name = "PanelEx3";
            size = new Size(221, 78);
            vmethod_448().Size = size;
            vmethod_448().Style.Alignment = StringAlignment.Center;
            vmethod_448().Style.BackColor1.Color = Color.Black;
            vmethod_448().Style.Border = eBorderType.SingleLine;
            vmethod_448().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_448().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_448().Style.GradientAngle = 90;
            vmethod_448().TabIndex = 39;
            vmethod_600().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_600().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_600().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_600().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_600().BackgroundStyle.MarginLeft = 1;
            vmethod_600().BackgroundStyle.MarginRight = 1;
            vmethod_600().BackgroundStyle.MarginTop = 1;
            vmethod_600().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_600().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_600().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_600().BackgroundStyle.TextShadowOffset = point;
            vmethod_600().Dock = DockStyle.Top;
            vmethod_600().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_600().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_600().Location = point;
            vmethod_600().Name = "LabelX53";
            vmethod_600().PaddingLeft = 10;
            size = new Size(221, 19);
            vmethod_600().Size = size;
            vmethod_600().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_600().TabIndex = 43;
            vmethod_600().Text = "MANA";
            vmethod_600().TextLineAlignment = StringAlignment.Near;
            vmethod_450().BackColor = Color.Transparent;
            vmethod_450().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_450().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_450().ForeColor = Color.White;
            point = new Point(16, 27);
            vmethod_450().Location = point;
            vmethod_450().Name = "LabelX4";
            size = new Size(96, 14);
            vmethod_450().Size = size;
            vmethod_450().TabIndex = 16;
            vmethod_450().Text = "POTION TYPE";
            vmethod_452().BackColor = Color.Black;
            vmethod_452().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_452().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_452().ForeColor = Color.White;
            point = new Point(118, 26);
            vmethod_452().Location = point;
            vmethod_452().Name = "swtManaPotionEnabled";
            vmethod_452().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_452().OffText = "DISABLED";
            vmethod_452().OffTextColor = Color.White;
            vmethod_452().OnText = "ENABLED";
            size = new Size(78, 19);
            vmethod_452().Size = size;
            vmethod_452().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_452().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_452().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_452().SwitchWidth = 6;
            vmethod_452().TabIndex = 15;
            vmethod_454().DisplayMember = "Text";
            vmethod_454().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_454().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_454().ForeColor = Color.White;
            vmethod_454().FormattingEnabled = true;
            vmethod_454().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_456(), 
                                    vmethod_458(), 
                                    vmethod_460(), 
                                    vmethod_462(), 
                                    vmethod_464(), 
                                    vmethod_466(), 
                                    vmethod_468(), 
                                    vmethod_470(), 
                                    vmethod_472(), 
                                    vmethod_474(), 
                                    vmethod_476(), 
                                    vmethod_478(), 
                                    vmethod_480(), 
                                    vmethod_482(), 
                                    vmethod_484(), 
                                    vmethod_486() };
            vmethod_454().Items.AddRange(objArr);
            point = new Point(16, 45);
            vmethod_454().Location = point;
            vmethod_454().Name = "cmbManaPotion";
            size = new Size(180, 22);
            vmethod_454().Size = size;
            vmethod_454().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_454().TabIndex = 14;
            vmethod_456().Text = "Mana Potion [I]";
            vmethod_458().Text = "Mana Potion [II]";
            vmethod_460().Text = "Mana Potion [III]";
            vmethod_462().Text = "Mana Potion [IV]";
            vmethod_464().Text = "Mana Potion [V]";
            vmethod_466().Text = "Mana Potion [VI]";
            vmethod_468().Text = "Elixir [I]";
            vmethod_470().Text = "Elixir [II]";
            vmethod_472().Text = "Elixir [III]";
            vmethod_474().Text = "Elixir [IV]";
            vmethod_476().Text = "Elixir [V]";
            vmethod_478().Text = "Elixir [VI]";
            vmethod_480().Text = "Rooibos Tea";
            vmethod_482().Text = "Miracle Potion";
            vmethod_484().Text = "Water of Life";
            vmethod_486().Text = "Water of Life (No Trade)";
            vmethod_314().CanvasColor = SystemColors.Control;
            vmethod_314().ColorSchemeStyle = eDotNetBarStyle.StyleManagerControlled;
            vmethod_314().Controls.Add(vmethod_602());
            vmethod_314().Controls.Add(vmethod_316());
            vmethod_314().Controls.Add(vmethod_318());
            vmethod_314().Controls.Add(vmethod_320());
            point = new Point(12, 20);
            vmethod_314().Location = point;
            vmethod_314().Name = "PanelEx2";
            size = new Size(221, 78);
            vmethod_314().Size = size;
            vmethod_314().Style.Alignment = StringAlignment.Center;
            vmethod_314().Style.BackColor1.Color = Color.Black;
            vmethod_314().Style.Border = eBorderType.SingleLine;
            vmethod_314().Style.BorderColor.Color = Color.FromArgb(255, 128, 0);
            vmethod_314().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_314().Style.GradientAngle = 90;
            vmethod_314().TabIndex = 38;
            vmethod_602().BackgroundStyle.BackColorGradientAngle = 90;
            vmethod_602().BackgroundStyle.BorderBottomColor = Color.FromArgb(255, 128, 0);
            vmethod_602().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_602().BackgroundStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_602().BackgroundStyle.MarginLeft = 1;
            vmethod_602().BackgroundStyle.MarginRight = 1;
            vmethod_602().BackgroundStyle.MarginTop = 1;
            vmethod_602().BackgroundStyle.TextColor = Color.FromArgb(0, 0, 0);
            vmethod_602().BackgroundStyle.TextLineAlignment = eStyleTextAlignment.Near;
            vmethod_602().BackgroundStyle.TextShadowColor = Color.FromArgb(0, 0, 0);
            point = new Point(10, 10);
            vmethod_602().BackgroundStyle.TextShadowOffset = point;
            vmethod_602().Dock = DockStyle.Top;
            vmethod_602().Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vmethod_602().ForeColor = Color.White;
            point = new Point(0, 0);
            vmethod_602().Location = point;
            vmethod_602().Name = "LabelX41";
            vmethod_602().PaddingLeft = 10;
            size = new Size(221, 19);
            vmethod_602().Size = size;
            vmethod_602().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_602().TabIndex = 43;
            vmethod_602().Text = "HEALING";
            vmethod_602().TextLineAlignment = StringAlignment.Near;
            vmethod_316().BackColor = Color.Transparent;
            vmethod_316().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_316().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vmethod_316().ForeColor = Color.White;
            point = new Point(16, 27);
            vmethod_316().Location = point;
            vmethod_316().Name = "LabelX1";
            size = new Size(96, 14);
            vmethod_316().Size = size;
            vmethod_316().TabIndex = 16;
            vmethod_316().Text = "POTION TYPE";
            vmethod_318().BackColor = Color.Black;
            vmethod_318().BackgroundStyle.CornerType = eCornerType.Square;
            vmethod_318().BorderColor = Color.FromArgb(45, 45, 48);
            vmethod_318().ForeColor = Color.White;
            point = new Point(118, 26);
            vmethod_318().Location = point;
            vmethod_318().Name = "swtHealPotionEnabled";
            vmethod_318().OffBackColor = Color.FromArgb(45, 45, 48);
            vmethod_318().OffText = "DISABLED";
            vmethod_318().OffTextColor = Color.White;
            vmethod_318().OnText = "ENABLED";
            size = new Size(78, 19);
            vmethod_318().Size = size;
            vmethod_318().Style = eDotNetBarStyle.StyleManagerControlled;
            vmethod_318().SwitchBackColor = Color.FromArgb(45, 45, 48);
            vmethod_318().SwitchBorderColor = Color.FromArgb(45, 45, 48);
            vmethod_318().SwitchWidth = 6;
            vmethod_318().TabIndex = 15;
            vmethod_320().DisplayMember = "Text";
            vmethod_320().DrawMode = DrawMode.OwnerDrawFixed;
            vmethod_320().DropDownStyle = ComboBoxStyle.DropDownList;
            vmethod_320().ForeColor = Color.White;
            vmethod_320().FormattingEnabled = true;
            vmethod_320().ItemHeight = 16;
            objArr = new object[] {
                                    vmethod_322(), 
                                    vmethod_324(), 
                                    vmethod_326(), 
                                    vmethod_328(), 
                                    vmethod_330(), 
                                    vmethod_332(), 
                                    vmethod_334(), 
                                    vmethod_336(), 
                                    vmethod_338(), 
                                    vmethod_340(), 
                                    vmethod_342(), 
                                    vmethod_344(), 
                                    vmethod_346(), 
                                    vmethod_348(), 
                                    vmethod_350(), 
                                    vmethod_352() };
            vmethod_320().Items.AddRange(objArr);
            point = new Point(16, 45);
            vmethod_320().Location = point;
            vmethod_320().Name = "cmbHealingPotion";
            size = new Size(180, 22);
            vmethod_320().Size = size;
            vmethod_320().Style = eDotNetBarStyle.Metro;
            vmethod_320().TabIndex = 14;
            vmethod_322().Text = "Healing Potion [I]";
            vmethod_324().Text = "Healing Potion [II]";
            vmethod_326().Text = "Healing Potion [III]";
            vmethod_328().Text = "Healing Potion [IV]";
            vmethod_330().Text = "Healing Potion [V]";
            vmethod_332().Text = "Healing Potion [VI]";
            vmethod_334().Text = "Elixir [I]";
            vmethod_336().Text = "Elixir [II]";
            vmethod_338().Text = "Elixir [III]";
            vmethod_340().Text = "Elixir [IV]";
            vmethod_342().Text = "Elixir [V]";
            vmethod_344().Text = "Elixir [VI]";
            vmethod_346().Text = "Miracle Potion";
            vmethod_348().Text = "Plain BBQ";
            vmethod_350().Text = "Water of Life";
            vmethod_352().Text = "Water of Life (No Trade)";
            vmethod_4().AttachedControl = vmethod_2();
            vmethod_4().GlobalItem = false;
            vmethod_4().Name = "SuperTabItem1";
            superTabItemStateColorTable8.SelectionMarker = Color.Black;
            superTabColorStates8.Selected = superTabItemStateColorTable8;
            superTabItemColorTable8.Default = superTabColorStates8;
            vmethod_4().TabColor = superTabItemColorTable8;
            vmethod_4().Text = "HEALING";
            vmethod_6().CanvasColor = SystemColors.Control;
            vmethod_6().ColorSchemeStyle = eDotNetBarStyle.Metro;
            vmethod_6().Controls.Add(vmethod_312());
            vmethod_6().Controls.Add(vmethod_8());
            vmethod_6().Dock = DockStyle.Bottom;
            point = new Point(0, 343);
            vmethod_6().Location = point;
            vmethod_6().Name = "PanelEx1";
            size = new Size(484, 31);
            vmethod_6().Size = size;
            vmethod_6().Style.Alignment = StringAlignment.Center;
            vmethod_6().Style.BackColor1.Color = Color.Black;
            vmethod_6().Style.Border = eBorderType.SingleLine;
            vmethod_6().Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
            vmethod_6().Style.BorderWidth = 0;
            vmethod_6().Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
            vmethod_6().Style.GradientAngle = 90;
            vmethod_6().TabIndex = 1;
            vmethod_312().AccessibleRole = AccessibleRole.PushButton;
            vmethod_312().BackColor = Color.FromArgb(255, 128, 0);
            vmethod_312().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_312().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(382, 4);
            vmethod_312().Location = point;
            vmethod_312().Name = "cancelSettingsButton";
            vmethod_312().RightToLeft = RightToLeft.No;
            size = new Size(90, 22);
            vmethod_312().Size = size;
            vmethod_312().Style = eDotNetBarStyle.Metro;
            vmethod_312().TabIndex = 37;
            vmethod_312().Text = "CANCEL";
            vmethod_312().TextColor = Color.White;
            vmethod_8().AccessibleRole = AccessibleRole.PushButton;
            vmethod_8().BackColor = Color.FromArgb(255, 128, 0);
            vmethod_8().ColorTable = eButtonColor.OrangeWithBackground;
            vmethod_8().Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            point = new Point(286, 4);
            vmethod_8().Location = point;
            vmethod_8().Name = "saveButton";
            vmethod_8().RightToLeft = RightToLeft.No;
            size = new Size(90, 22);
            vmethod_8().Size = size;
            vmethod_8().Style = eDotNetBarStyle.Metro;
            vmethod_8().TabIndex = 36;
            vmethod_8().Text = "SAVE";
            vmethod_8().TextColor = Color.White;
            vmethod_26().Enabled = true;
            vmethod_28().Text = "40";
            vmethod_30().Text = "35";
            vmethod_32().Text = "30";
            vmethod_34().Text = "25";
            vmethod_36().Text = "20";
            SizeF sizeF = new SizeF(6.0F, 13.0F);
            AutoScaleDimensions = sizeF;
            AutoScaleMode = AutoScaleMode.Font;
            size = new Size(484, 374);
            ClientSize = size;
            Controls.Add(vmethod_0());
            Controls.Add(vmethod_6());
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BotSettings";
            Text = "BotSettings";
            vmethod_0().EndInit();
            vmethod_0().ResumeLayout(false);
            vmethod_14().ResumeLayout(false);
            vmethod_612().ResumeLayout(false);
            vmethod_612().PerformLayout();
            vmethod_10().ResumeLayout(false);
            vmethod_38().EndInit();
            vmethod_38().ResumeLayout(false);
            vmethod_252().ResumeLayout(false);
            vmethod_252().PerformLayout();
            vmethod_688().ResumeLayout(false);
            vmethod_698().ResumeLayout(false);
            vmethod_698().PerformLayout();
            vmethod_40().ResumeLayout(false);
            vmethod_40().PerformLayout();
            vmethod_642().ResumeLayout(false);
            vmethod_642().PerformLayout();
            vmethod_632().ResumeLayout(false);
            vmethod_46().ResumeLayout(false);
            vmethod_46().PerformLayout();
            vmethod_678().ResumeLayout(false);
            vmethod_660().ResumeLayout(false);
            vmethod_660().PerformLayout();
            vmethod_22().ResumeLayout(false);
            vmethod_576().ResumeLayout(false);
            vmethod_576().PerformLayout();
            vmethod_488().ResumeLayout(false);
            vmethod_18().ResumeLayout(false);
            vmethod_498().ResumeLayout(false);
            vmethod_498().PerformLayout();
            vmethod_518().ResumeLayout(false);
            vmethod_518().PerformLayout();
            vmethod_542().ResumeLayout(false);
            vmethod_542().PerformLayout();
            vmethod_550().ResumeLayout(false);
            vmethod_550().PerformLayout();
            vmethod_2().ResumeLayout(false);
            vmethod_354().ResumeLayout(false);
            vmethod_354().PerformLayout();
            vmethod_424().ResumeLayout(false);
            vmethod_448().ResumeLayout(false);
            vmethod_314().ResumeLayout(false);
            vmethod_6().ResumeLayout(false);
            ResumeLayout(false);
        }

        private void method_0(object sender, EventArgs e)
        {
            method_1();
        }

        private void method_1()
        {
            gclass14_0.int_1 = Enumerable.FirstOrDefault<GClass14.GClass20>(GClass14.smethod_0(), new Func<GClass14.GClass20,bool>(method_18)).method_0();
            gclass14_0.bool_1 = vmethod_318().Value;
            gclass14_0.int_2 = Enumerable.FirstOrDefault<GClass14.GClass20>(GClass14.smethod_0(), new Func<GClass14.GClass20,bool>(method_19)).method_0();
            gclass14_0.bool_2 = vmethod_452().Value;
            gclass14_0.int_0 = Enumerable.FirstOrDefault<GClass14.GClass20>(GClass14.smethod_0(), new Func<GClass14.GClass20,bool>(method_20)).method_0();
            gclass14_0.bool_0 = vmethod_428().Value;
            if (vmethod_494().SelectedItem != null)
            {
                gclass14_0.string_4 = vmethod_494().SelectedItem.ToString();
                gclass14_0.bool_3 = vmethod_496().Value;
                gclass14_0.int_7 = Conversions.ToInteger(vmethod_552().SelectedItem.ToString());
                gclass14_0.bool_4 = vmethod_544().Value;
                gclass14_0.int_8 = Conversions.ToInteger(vmethod_502().SelectedItem.ToString());
                gclass14_0.bool_5 = vmethod_500().Value;
                gclass14_0.int_9 = Conversions.ToInteger(vmethod_520().SelectedItem.ToString());
                gclass14_0.bool_6 = vmethod_622().Value;
                gclass14_0.bool_7 = vmethod_620().Value;
                gclass14_0.bool_8 = vmethod_618().Value;
                gclass14_0.bool_9 = vmethod_614().Value;
                if (vmethod_398().SelectedItem != null)
                {
                    gclass14_0.double_0 = (double)Conversions.ToInteger(vmethod_398().SelectedItem.ToString()) / 100.0;
                    if (vmethod_378().SelectedItem != null)
                    {
                        gclass14_0.double_1 = (double)Conversions.ToInteger(vmethod_378().SelectedItem.ToString()) / 100.0;
                        gclass14_0.int_3 = Conversions.ToInteger(vmethod_360().SelectedItem.ToString());
                        gclass14_0.bool_11 = vmethod_66().Value;
                        gclass14_0.bool_12 = vmethod_62().Value;
                        gclass14_0.int_10 = Conversions.ToInteger(vmethod_60().SelectedItem.ToString());
                        gclass14_0.int_11 = Conversions.ToInteger(vmethod_58().SelectedItem.ToString());
                        gclass14_0.int_12 = Conversions.ToInteger(vmethod_90().Text);
                        gclass14_0.bool_10 = vmethod_50().Value;
                        gclass14_0.bool_14 = vmethod_88().Value;
                        gclass14_0.bool_15 = vmethod_84().Value;
                        gclass14_0.int_13 = Conversions.ToInteger(vmethod_224().SelectedItem.ToString());
                        gclass14_0.int_14 = Conversions.ToInteger(vmethod_198().SelectedItem.ToString());
                        gclass14_0.int_17 = Conversions.ToInteger(vmethod_142().Text);
                        gclass14_0.int_15 = Conversions.ToInteger(vmethod_170().SelectedItem.ToString());
                        gclass14_0.int_16 = Conversions.ToInteger(vmethod_144().SelectedItem.ToString());
                        gclass14_0.bool_13 = vmethod_76().Value;
                        gclass14_0.bool_16 = vmethod_284().Value;
                        gclass14_0.bool_17 = vmethod_280().Value;
                        gclass14_0.int_18 = Conversions.ToInteger(vmethod_256().SelectedItem.ToString());
                        gclass14_0.int_19 = Conversions.ToInteger(vmethod_286().SelectedItem.ToString());
                        GClass14.GClass16 gclass16 = Enumerable.FirstOrDefault<GClass14.GClass16>(gclass14_0.list_1, new Func<GClass14.GClass16,bool>(method_21));
                        if (gclass16 != null)
                        {
                            gclass14_0.string_3 = gclass16.method_0();
                            gclass14_0.int_4 = checked((int)gclass16.method_2());
                            gclass14_0.int_5 = checked((int)gclass16.method_4());
                            gclass14_0.int_6 = Conversions.ToInteger(gclass16.method_6());
                        }
                        method_2();
                        slidePanel_0.IsOpen = false;
                        return;
                    }
                    Interaction.MsgBox("You need to select Mana Percentage", MsgBoxStyle.ApplicationModal, null);
                    return;
                }
                Interaction.MsgBox("You need to select Heal Percentage", MsgBoxStyle.ApplicationModal, null);
                return;
            }
            Interaction.MsgBox("You need to set a Favorite Location.", MsgBoxStyle.ApplicationModal, null);
        }

        private void method_10(object sender, EventArgs e)
        {
            if (vmethod_680().SelectedItems.Count > 0)
            {
                GClass14.GClass18 gclass18 = Enumerable.FirstOrDefault<GClass14.GClass18>(gclass14_0.list_3, new Func<GClass14.GClass18,bool>(method_28));
                gclass14_0.list_3.Remove(gclass18);
                GClass5.smethod_6(string_2, vmethod_680().FocusedItem.Text);
                vmethod_680().FocusedItem.Remove();
            }
        }

        private void method_11(object sender, EventArgs e)
        {
            string s = GClass5.smethod_2(string_3, vmethod_648().Text);
            GClass14.GClass17 gclass17_1 = Enumerable.FirstOrDefault<GClass14.GClass17>(gclass14_0.list_2, new Func<GClass14.GClass17,bool>(method_29));
            if ((gclass17_1 == null) && (Operators.CompareString(s, "", false) == 0))
            {
                GClass14.GClass17 gclass17_2 = new GClass14.GClass17();
                long l = gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_46), 2);
                gclass17_2.method_1(vmethod_648().Text);
                gclass17_2.method_3(l);
                gclass17_2.method_5(Conversions.ToLong(vmethod_646().Text));
                gclass17_2.method_7(vmethod_644().Text);
                gclass14_0.list_2.Add(gclass17_2);
                GClass5.smethod_4(string_3, vmethod_648().Text, "Id", Conversions.ToString(l));
                GClass5.smethod_4(string_3, vmethod_648().Text, "X", vmethod_646().Text);
                GClass5.smethod_4(string_3, vmethod_648().Text, "Y", vmethod_644().Text + "\r\n");
                vmethod_638().Items.Add(vmethod_666().Text);
            }
        }

        private void method_12(object sender, EventArgs e)
        {
            if (vmethod_638().SelectedItems.Count > 0)
            {
                GClass14.GClass17 gclass17 = Enumerable.FirstOrDefault<GClass14.GClass17>(gclass14_0.list_2, new Func<GClass14.GClass17,bool>(method_30));
                gclass14_0.list_2.Remove(gclass17);
                GClass5.smethod_6(string_3, vmethod_638().FocusedItem.Text);
                vmethod_638().FocusedItem.Remove();
            }
        }

        private void method_13(object sender, EventArgs e)
        {
            string s = GClass5.smethod_2(string_4, vmethod_704().Text);
            GClass14.GClass15 gclass15_1 = Enumerable.FirstOrDefault<GClass14.GClass15>(gclass14_0.list_0, new Func<GClass14.GClass15,bool>(method_31));
            if ((gclass15_1 == null) && (Operators.CompareString(s, "", false) == 0))
            {
                GClass14.GClass15 gclass15_2 = new GClass14.GClass15();
                long l = gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_46), 2);
                gclass15_2.method_1(vmethod_704().Text);
                gclass15_2.method_3(l);
                gclass15_2.method_5(Conversions.ToLong(vmethod_646().Text));
                gclass15_2.method_7(vmethod_644().Text);
                gclass14_0.list_0.Add(gclass15_2);
                GClass5.smethod_4(string_4, vmethod_704().Text, "Id", Conversions.ToString(l));
                GClass5.smethod_4(string_4, vmethod_704().Text, "X", vmethod_646().Text);
                GClass5.smethod_4(string_4, vmethod_704().Text, "Y", vmethod_644().Text + "\r\n");
                vmethod_690().Items.Add(vmethod_704().Text);
            }
        }

        private void method_14(object sender, EventArgs e)
        {
            if (vmethod_690().SelectedItems.Count > 0)
            {
                GClass14.GClass15 gclass15 = Enumerable.FirstOrDefault<GClass14.GClass15>(gclass14_0.list_0, new Func<GClass14.GClass15,bool>(method_32));
                gclass14_0.list_0.Remove(gclass15);
                GClass5.smethod_6(string_4, vmethod_690().FocusedItem.Text);
                vmethod_690().FocusedItem.Remove();
            }
        }

        private void method_15(object sender, EventArgs e)
        {
            slidePanel_0.IsOpen = false;
        }

        private void method_16(object sender, EventArgs e)
        {
        }

        [CompilerGenerated]
        private bool method_17(GClass1.GClass2 gclass2_0)
        {
            return Operators.CompareString(gclass2_0.method_6(), string_0, false) == 0;
        }

        [CompilerGenerated]
        private bool method_18(GClass14.GClass20 gclass20_0)
        {
            return Operators.CompareString(gclass20_0.method_2(), vmethod_320().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_19(GClass14.GClass20 gclass20_0)
        {
            return Operators.CompareString(gclass20_0.method_2(), vmethod_454().SelectedItem.ToString(), false) == 0;
        }

        private void method_2()
        {
            string s = Application.StartupPath + "\\" + string_0 + "\\settings.ini";
            GClass5.smethod_4(s, "Healing Options", "UseLifePotion", Conversions.ToString(gclass14_0.bool_0));
            GClass5.smethod_4(s, "Healing Options", "UseManaPotion", Conversions.ToString(gclass14_0.bool_2));
            GClass5.smethod_4(s, "Healing Options", "UseHealingPotion", Conversions.ToString(gclass14_0.bool_1));
            GClass5.smethod_4(s, "Healing Options", "SelectedLifePotion", Conversions.ToString(gclass14_0.int_0));
            GClass5.smethod_4(s, "Healing Options", "SelectedManaPotion", Conversions.ToString(gclass14_0.int_2));
            GClass5.smethod_4(s, "Healing Options", "SelectedHealPotion", Conversions.ToString(gclass14_0.int_1));
            GClass5.smethod_4(s, "Healing Options", "HealPercentage", Conversions.ToString(gclass14_0.double_0));
            GClass5.smethod_4(s, "Healing Options", "ManaPercentage", Conversions.ToString(gclass14_0.double_1));
            GClass5.smethod_4(s, "Healing Options", "ReviveNumber", Conversions.ToString(gclass14_0.int_3));
            GClass5.smethod_4(s, "AutoBattle", "EnableAB", Conversions.ToString(gclass14_0.int_7));
            GClass5.smethod_4(s, "AutoBattle", "Main", Conversions.ToString(gclass14_0.bool_4));
            GClass5.smethod_4(s, "SpeedHack", "Enabled", Conversions.ToString(gclass14_0.bool_5));
            GClass5.smethod_4(s, "SpeedHack", "SetSpeed", Conversions.ToString(gclass14_0.int_8));
            GClass5.smethod_4(s, "Favorites", "Teleport", Conversions.ToString(gclass14_0.bool_3));
            GClass5.smethod_4(s, "Favorites", "Location", gclass14_0.string_4);
            GClass5.smethod_4(s, "Zoom Options", "Zoom Value", Conversions.ToString(gclass14_0.int_9));
            GClass5.smethod_4(s, "Window Options", "Close Whisper", Conversions.ToString(gclass14_0.bool_6));
            GClass5.smethod_4(s, "Window Options", "Close Trade", Conversions.ToString(gclass14_0.bool_7));
            GClass5.smethod_4(s, "Window Options", "Accept Information", Conversions.ToString(gclass14_0.bool_8));
            GClass5.smethod_4(s, "Window Options", "Close Monster Information", Conversions.ToString(gclass14_0.bool_9));
            GClass5.smethod_4(s, "Action Location", "Enabled", Conversions.ToString(gclass14_0.bool_10));
            GClass5.smethod_4(s, "Action Location", "Action", Conversions.ToString(gclass14_0.bool_11));
            GClass5.smethod_4(s, "Action Location", "Variable", Conversions.ToString(gclass14_0.bool_12));
            GClass5.smethod_4(s, "Action Location", "Hours", Conversions.ToString(gclass14_0.int_10));
            GClass5.smethod_4(s, "Action Location", "Minutes", Conversions.ToString(gclass14_0.int_11));
            GClass5.smethod_4(s, "Action Location", "Battles", Conversions.ToString(gclass14_0.int_12));
            GClass5.smethod_4(s, "Action Town", "Enabled", Conversions.ToString(gclass14_0.bool_13));
            GClass5.smethod_4(s, "Action Town", "Action", Conversions.ToString(gclass14_0.bool_14));
            GClass5.smethod_4(s, "Action Town", "Variable", Conversions.ToString(gclass14_0.bool_15));
            GClass5.smethod_4(s, "Action Town", "Hours", Conversions.ToString(gclass14_0.int_13));
            GClass5.smethod_4(s, "Action Town", "Minutes", Conversions.ToString(gclass14_0.int_14));
            GClass5.smethod_4(s, "Action Town", "waitHours", Conversions.ToString(gclass14_0.int_15));
            GClass5.smethod_4(s, "Action Town", "waitMinutes", Conversions.ToString(gclass14_0.int_16));
            GClass5.smethod_4(s, "Action Town", "Battles", Conversions.ToString(gclass14_0.int_17));
            GClass5.smethod_4(s, "Recharge", "Action", Conversions.ToString(gclass14_0.bool_16));
            GClass5.smethod_4(s, "Recharge", "Start", Conversions.ToString(gclass14_0.int_18));
            GClass5.smethod_4(s, "Recharge", "Stop", Conversions.ToString(gclass14_0.int_19));
            GClass5.smethod_4(s, "Recharge", "Enable", Conversions.ToString(gclass14_0.bool_17));
        }

        [CompilerGenerated]
        private bool method_20(GClass14.GClass20 gclass20_0)
        {
            return Operators.CompareString(gclass20_0.method_2(), vmethod_430().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_21(GClass14.GClass16 gclass16_0)
        {
            return Operators.CompareString(gclass16_0.method_0(), vmethod_494().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_22(GClass14.GClass20 gclass20_0)
        {
            return gclass20_0.method_0() == gclass14_0.int_1;
        }

        [CompilerGenerated]
        private bool method_23(GClass14.GClass20 gclass20_0)
        {
            return gclass20_0.method_0() == gclass14_0.int_2;
        }

        [CompilerGenerated]
        private bool method_24(GClass14.GClass20 gclass20_0)
        {
            return gclass20_0.method_0() == gclass14_0.int_0;
        }

        [CompilerGenerated]
        private bool method_25(GClass14.GClass16 gclass16_0)
        {
            return Operators.CompareString(gclass16_0.method_0(), vmethod_582().Text, false) == 0;
        }

        [CompilerGenerated]
        private bool method_26(GClass14.GClass16 gclass16_0)
        {
            return Operators.CompareString(gclass16_0.method_0(), vmethod_494().SelectedItem.ToString(), false) == 0;
        }

        [CompilerGenerated]
        private bool method_27(GClass14.GClass18 gclass18_0)
        {
            return Operators.CompareString(gclass18_0.method_0(), vmethod_666().Text, false) == 0;
        }

        [CompilerGenerated]
        private bool method_28(GClass14.GClass18 gclass18_0)
        {
            return Operators.CompareString(gclass18_0.method_0(), vmethod_680().FocusedItem.Text, false) == 0;
        }

        [CompilerGenerated]
        private bool method_29(GClass14.GClass17 gclass17_0)
        {
            return Operators.CompareString(gclass17_0.method_0(), vmethod_648().Text, false) == 0;
        }

        private void method_3()
        {
            List<GClass14.GClass17>.Enumerator enumerator;
            List<GClass14.GClass18>.Enumerator enumerator1;
            List<GClass14.GClass15>.Enumerator enumerator2;
            List<GClass14.GClass16>.Enumerator enumerator3;

            string_1 = Application.StartupPath + "\\" + string_0 + "\\favorites.ini";
            string_2 = Application.StartupPath + "\\" + string_0 + "\\actionTowns.ini";
            string_3 = Application.StartupPath + "\\" + string_0 + "\\actionLocation.ini";
            string_4 = Application.StartupPath + "\\" + string_0 + "\\rechargeLocation.ini";
            List<GClass14.GClass16> list = gclass14_0.list_1;
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Login));
            if (list.get_Count() != 0)
            {
                try
                {
                    enumerator3 = list.GetEnumerator();
                    while (enumerator3.MoveNext())
                    {
                        GClass14.GClass16 gclass16 = enumerator3.get_Current();
                        ComboItem comboItem = new ComboItem();
                        comboItem.Text = gclass16.method_0();
                        componentResourceManager.ApplyResources(comboItem, gclass16.method_0());
                        vmethod_494().Items.Add(comboItem);
                    }
                }
                finally
                {
                    enumerator3.Dispose();
                }
            }
            if (gclass14_0.list_2.get_Count() != 0)
            {
                try
                {
                    enumerator = gclass14_0.list_2.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        GClass14.GClass17 gclass17 = enumerator.get_Current();
                        vmethod_638().Items.Add(gclass17.method_0());
                    }
                }
                finally
                {
                    enumerator.Dispose();
                }
            }
            if (gclass14_0.list_3.get_Count() != 0)
            {
                try
                {
                    enumerator1 = gclass14_0.list_3.GetEnumerator();
                    while (enumerator1.MoveNext())
                    {
                        GClass14.GClass18 gclass18 = enumerator1.get_Current();
                        vmethod_680().Items.Add(gclass18.method_0());
                    }
                }
                finally
                {
                    enumerator1.Dispose();
                }
            }
            if (gclass14_0.list_0.get_Count() != 0)
            {
                try
                {
                    enumerator2 = gclass14_0.list_0.GetEnumerator();
                    while (enumerator2.MoveNext())
                    {
                        GClass14.GClass15 gclass15 = enumerator2.get_Current();
                        vmethod_690().Items.Add(gclass15.method_0());
                    }
                }
                finally
                {
                    enumerator2.Dispose();
                }
            }
            vmethod_320().Text = Enumerable.FirstOrDefault<GClass14.GClass20>(GClass14.smethod_0(), new Func<GClass14.GClass20,bool>(method_22)).method_2();
            vmethod_318().Value = gclass14_0.bool_1;
            vmethod_454().Text = Enumerable.FirstOrDefault<GClass14.GClass20>(GClass14.smethod_0(), new Func<GClass14.GClass20,bool>(method_23)).method_2();
            vmethod_452().Value = gclass14_0.bool_2;
            vmethod_430().Text = Enumerable.FirstOrDefault<GClass14.GClass20>(GClass14.smethod_0(), new Func<GClass14.GClass20,bool>(method_24)).method_2();
            vmethod_428().Value = gclass14_0.bool_0;
            vmethod_494().Text = gclass14_0.string_4;
            vmethod_496().Value = gclass14_0.bool_3;
            vmethod_552().Text = Conversions.ToString(gclass14_0.int_7);
            vmethod_544().Value = gclass14_0.bool_4;
            vmethod_502().Text = Conversions.ToString(gclass14_0.int_8);
            vmethod_500().Value = gclass14_0.bool_5;
            vmethod_520().Text = Conversions.ToString(gclass14_0.int_9);
            vmethod_622().Value = gclass14_0.bool_6;
            vmethod_620().Value = gclass14_0.bool_7;
            vmethod_618().Value = gclass14_0.bool_8;
            vmethod_614().Value = gclass14_0.bool_9;
            vmethod_398().Text = Conversions.ToString(gclass14_0.double_0 * 100.0);
            vmethod_378().Text = Conversions.ToString(gclass14_0.double_1 * 100.0);
            vmethod_360().Text = Conversions.ToString(gclass14_0.int_3);
            vmethod_66().Value = gclass14_0.bool_11;
            vmethod_62().Value = gclass14_0.bool_12;
            vmethod_60().Text = Conversions.ToString(gclass14_0.int_10);
            vmethod_58().Text = Conversions.ToString(gclass14_0.int_11);
            vmethod_90().Text = Conversions.ToString(gclass14_0.int_12);
            vmethod_50().Value = gclass14_0.bool_10;
            vmethod_88().Value = gclass14_0.bool_14;
            vmethod_84().Value = gclass14_0.bool_15;
            vmethod_224().Text = Conversions.ToString(gclass14_0.int_13);
            vmethod_198().Text = Conversions.ToString(gclass14_0.int_14);
            vmethod_142().Text = Conversions.ToString(gclass14_0.int_17);
            vmethod_170().Text = Conversions.ToString(gclass14_0.int_15);
            vmethod_144().Text = Conversions.ToString(gclass14_0.int_16);
            vmethod_76().Value = gclass14_0.bool_13;
            vmethod_284().Value = gclass14_0.bool_16;
            vmethod_280().Value = gclass14_0.bool_17;
            vmethod_256().Text = Conversions.ToString(gclass14_0.int_18);
            vmethod_286().Text = Conversions.ToString(gclass14_0.int_19);
        }

        [CompilerGenerated]
        private bool method_30(GClass14.GClass17 gclass17_0)
        {
            return Operators.CompareString(gclass17_0.method_0(), vmethod_638().FocusedItem.Text, false) == 0;
        }

        [CompilerGenerated]
        private bool method_31(GClass14.GClass15 gclass15_0)
        {
            return Operators.CompareString(gclass15_0.method_0(), vmethod_704().Text, false) == 0;
        }

        [CompilerGenerated]
        private bool method_32(GClass14.GClass15 gclass15_0)
        {
            return Operators.CompareString(gclass15_0.method_0(), vmethod_690().FocusedItem.Text, false) == 0;
        }

        private void method_4(object sender, EventArgs e)
        {
            vmethod_582().Text = gclass22_0.method_5(checked((int)bot_0.gclass26_0.long_30), 100);
            vmethod_580().Text = Conversions.ToString(gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_21), 2));
            vmethod_578().Text = Conversions.ToString(gclass22_0.method_3(checked((int)checked(bot_0.gclass26_0.long_21 + 2L)), 2));
            vmethod_666().Text = vmethod_582().Text;
            vmethod_664().Text = vmethod_580().Text;
            vmethod_662().Text = vmethod_578().Text;
            vmethod_648().Text = vmethod_582().Text;
            vmethod_646().Text = vmethod_580().Text;
            vmethod_644().Text = vmethod_578().Text;
            vmethod_704().Text = vmethod_582().Text;
            vmethod_702().Text = vmethod_580().Text;
            vmethod_700().Text = vmethod_578().Text;
        }

        private void method_5(object sender, EventArgs e)
        {
            List<GClass14.GClass16>.Enumerator enumerator;

            string s = GClass5.smethod_2(string_1, vmethod_582().Text);
            GClass14.GClass16 gclass16_1 = Enumerable.FirstOrDefault<GClass14.GClass16>(gclass14_0.list_1, new Func<GClass14.GClass16,bool>(method_25));
            if (gclass16_1 == null)
            {
                if (Operators.CompareString(s, "", false) != 0)
                    return;
                GClass14.GClass16 gclass16_2 = new GClass14.GClass16();
                long l = gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_46), 2);
                gclass16_2.method_1(vmethod_582().Text);
                gclass16_2.method_3(l);
                gclass16_2.method_5(Conversions.ToLong(vmethod_580().Text));
                gclass16_2.method_7(vmethod_578().Text);
                gclass14_0.list_1.Add(gclass16_2);
                GClass5.smethod_4(string_1, vmethod_582().Text, "Id", Conversions.ToString(l));
                GClass5.smethod_4(string_1, vmethod_582().Text, "X", vmethod_580().Text);
                GClass5.smethod_4(string_1, vmethod_582().Text, "Y", vmethod_578().Text + "\r\n");
                List<GClass14.GClass16> list = gclass14_0.list_1;
                try
                {
                    enumerator = list.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        GClass14.GClass16 gclass16_3 = enumerator.get_Current();
                        int i = vmethod_494().FindString(gclass16_3.method_0());
                        if (i == -1)
                        {
                            vmethod_494().Items.Add(gclass16_3.method_0());
                            vmethod_494().SelectedIndex = vmethod_494().FindString(gclass16_3.method_0());
                        }
                    }
                    return;
                }
                finally
                {
                    enumerator.Dispose();
                }
            }
            ErrorForm errorForm = new ErrorForm();
            errorForm.vmethod_2().Text = "You already have this location added to your list.";
            errorForm.Show();
        }

        private void method_6(object sender, EventArgs e)
        {
            GClass14.GClass16 gclass16 = Enumerable.FirstOrDefault<GClass14.GClass16>(gclass14_0.list_1, new Func<GClass14.GClass16,bool>(method_26));
            if (gclass16 != null)
            {
                gclass14_0.list_1.Remove(gclass16);
                GClass5.smethod_6(string_1, vmethod_494().SelectedItem.ToString());
                vmethod_494().Items.Remove(RuntimeHelpers.GetObjectValue(vmethod_494().SelectedItem));
                if (vmethod_494().Items.Count > 0)
                    vmethod_494().SelectedIndex = 0;
            }
        }

        private void method_7(object sender, EventArgs e)
        {
            if ((vmethod_50().Value & vmethod_76().Value))
                vmethod_76().Value = false;
        }

        private void method_8(object sender, EventArgs e)
        {
            if ((vmethod_50().Value & vmethod_76().Value))
                vmethod_50().Value = false;
        }

        private void method_9(object sender, EventArgs e)
        {
            string s = GClass5.smethod_2(string_2, vmethod_666().Text);
            GClass14.GClass18 gclass18_1 = Enumerable.FirstOrDefault<GClass14.GClass18>(gclass14_0.list_3, new Func<GClass14.GClass18,bool>(method_27));
            if ((gclass18_1 == null) && (Operators.CompareString(s, "", false) == 0))
            {
                GClass14.GClass18 gclass18_2 = new GClass14.GClass18();
                long l = gclass22_0.method_3(checked((int)bot_0.gclass26_0.long_46), 2);
                gclass18_2.method_1(vmethod_666().Text);
                gclass18_2.method_3(l);
                gclass18_2.method_5(Conversions.ToLong(vmethod_664().Text));
                gclass18_2.method_7(vmethod_662().Text);
                gclass14_0.list_3.Add(gclass18_2);
                GClass5.smethod_4(string_2, vmethod_666().Text, "Id", Conversions.ToString(l));
                GClass5.smethod_4(string_2, vmethod_666().Text, "X", vmethod_664().Text);
                GClass5.smethod_4(string_2, vmethod_666().Text, "Y", vmethod_662().Text + "\r\n");
                vmethod_680().Items.Add(vmethod_666().Text);
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

        internal virtual SuperTabControl vmethod_0()
        {
            SuperTabControl superTabControl;

            return superTabControl_0;
        }

        internal virtual void vmethod_1(SuperTabControl superTabControl_2)
        {
            superTabControl_0 = superTabControl_2;
        }

        internal virtual SuperTabControlPanel vmethod_10()
        {
            SuperTabControlPanel superTabControlPanel;

            return superTabControlPanel_1;
        }

        internal virtual ComboItem vmethod_100()
        {
            ComboItem comboItem;

            return comboItem_9;
        }

        internal virtual void vmethod_101(ComboItem comboItem_192)
        {
            comboItem_9 = comboItem_192;
        }

        internal virtual ComboItem vmethod_102()
        {
            ComboItem comboItem;

            return comboItem_10;
        }

        internal virtual void vmethod_103(ComboItem comboItem_192)
        {
            comboItem_10 = comboItem_192;
        }

        internal virtual ComboItem vmethod_104()
        {
            ComboItem comboItem;

            return comboItem_11;
        }

        internal virtual void vmethod_105(ComboItem comboItem_192)
        {
            comboItem_11 = comboItem_192;
        }

        internal virtual ComboItem vmethod_106()
        {
            ComboItem comboItem;

            return comboItem_12;
        }

        internal virtual void vmethod_107(ComboItem comboItem_192)
        {
            comboItem_12 = comboItem_192;
        }

        internal virtual ComboItem vmethod_108()
        {
            ComboItem comboItem;

            return comboItem_13;
        }

        internal virtual void vmethod_109(ComboItem comboItem_192)
        {
            comboItem_13 = comboItem_192;
        }

        internal virtual void vmethod_11(SuperTabControlPanel superTabControlPanel_8)
        {
            superTabControlPanel_1 = superTabControlPanel_8;
        }

        internal virtual ComboItem vmethod_110()
        {
            ComboItem comboItem;

            return comboItem_14;
        }

        internal virtual void vmethod_111(ComboItem comboItem_192)
        {
            comboItem_14 = comboItem_192;
        }

        internal virtual ComboItem vmethod_112()
        {
            ComboItem comboItem;

            return comboItem_15;
        }

        internal virtual void vmethod_113(ComboItem comboItem_192)
        {
            comboItem_15 = comboItem_192;
        }

        internal virtual ComboItem vmethod_114()
        {
            ComboItem comboItem;

            return comboItem_16;
        }

        internal virtual void vmethod_115(ComboItem comboItem_192)
        {
            comboItem_16 = comboItem_192;
        }

        internal virtual ComboItem vmethod_116()
        {
            ComboItem comboItem;

            return comboItem_17;
        }

        internal virtual void vmethod_117(ComboItem comboItem_192)
        {
            comboItem_17 = comboItem_192;
        }

        internal virtual ComboItem vmethod_118()
        {
            ComboItem comboItem;

            return comboItem_18;
        }

        internal virtual void vmethod_119(ComboItem comboItem_192)
        {
            comboItem_18 = comboItem_192;
        }

        internal virtual SuperTabItem vmethod_12()
        {
            SuperTabItem superTabItem;

            return superTabItem_1;
        }

        internal virtual ComboItem vmethod_120()
        {
            ComboItem comboItem;

            return comboItem_19;
        }

        internal virtual void vmethod_121(ComboItem comboItem_192)
        {
            comboItem_19 = comboItem_192;
        }

        internal virtual ComboItem vmethod_122()
        {
            ComboItem comboItem;

            return comboItem_20;
        }

        internal virtual void vmethod_123(ComboItem comboItem_192)
        {
            comboItem_20 = comboItem_192;
        }

        internal virtual ComboItem vmethod_124()
        {
            ComboItem comboItem;

            return comboItem_21;
        }

        internal virtual void vmethod_125(ComboItem comboItem_192)
        {
            comboItem_21 = comboItem_192;
        }

        internal virtual ComboItem vmethod_126()
        {
            ComboItem comboItem;

            return comboItem_22;
        }

        internal virtual void vmethod_127(ComboItem comboItem_192)
        {
            comboItem_22 = comboItem_192;
        }

        internal virtual ComboItem vmethod_128()
        {
            ComboItem comboItem;

            return comboItem_23;
        }

        internal virtual void vmethod_129(ComboItem comboItem_192)
        {
            comboItem_23 = comboItem_192;
        }

        internal virtual void vmethod_13(SuperTabItem superTabItem_8)
        {
            superTabItem_1 = superTabItem_8;
        }

        internal virtual ComboItem vmethod_130()
        {
            ComboItem comboItem;

            return comboItem_24;
        }

        internal virtual void vmethod_131(ComboItem comboItem_192)
        {
            comboItem_24 = comboItem_192;
        }

        internal virtual ComboItem vmethod_132()
        {
            ComboItem comboItem;

            return comboItem_25;
        }

        internal virtual void vmethod_133(ComboItem comboItem_192)
        {
            comboItem_25 = comboItem_192;
        }

        internal virtual ComboItem vmethod_134()
        {
            ComboItem comboItem;

            return comboItem_26;
        }

        internal virtual void vmethod_135(ComboItem comboItem_192)
        {
            comboItem_26 = comboItem_192;
        }

        internal virtual ComboItem vmethod_136()
        {
            ComboItem comboItem;

            return comboItem_27;
        }

        internal virtual void vmethod_137(ComboItem comboItem_192)
        {
            comboItem_27 = comboItem_192;
        }

        internal virtual ComboItem vmethod_138()
        {
            ComboItem comboItem;

            return comboItem_28;
        }

        internal virtual void vmethod_139(ComboItem comboItem_192)
        {
            comboItem_28 = comboItem_192;
        }

        internal virtual SuperTabControlPanel vmethod_14()
        {
            SuperTabControlPanel superTabControlPanel;

            return superTabControlPanel_2;
        }

        internal virtual ComboItem vmethod_140()
        {
            ComboItem comboItem;

            return comboItem_29;
        }

        internal virtual void vmethod_141(ComboItem comboItem_192)
        {
            comboItem_29 = comboItem_192;
        }

        internal virtual TextBoxX vmethod_142()
        {
            TextBoxX textBoxX;

            return textBoxX_1;
        }

        internal virtual void vmethod_143(TextBoxX textBoxX_2)
        {
            textBoxX_1 = textBoxX_2;
        }

        internal virtual ComboBoxEx vmethod_144()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_2;
        }

        internal virtual void vmethod_145(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_2 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_146()
        {
            ComboItem comboItem;

            return comboItem_30;
        }

        internal virtual void vmethod_147(ComboItem comboItem_192)
        {
            comboItem_30 = comboItem_192;
        }

        internal virtual ComboItem vmethod_148()
        {
            ComboItem comboItem;

            return comboItem_31;
        }

        internal virtual void vmethod_149(ComboItem comboItem_192)
        {
            comboItem_31 = comboItem_192;
        }

        internal virtual void vmethod_15(SuperTabControlPanel superTabControlPanel_8)
        {
            superTabControlPanel_2 = superTabControlPanel_8;
        }

        internal virtual ComboItem vmethod_150()
        {
            ComboItem comboItem;

            return comboItem_32;
        }

        internal virtual void vmethod_151(ComboItem comboItem_192)
        {
            comboItem_32 = comboItem_192;
        }

        internal virtual ComboItem vmethod_152()
        {
            ComboItem comboItem;

            return comboItem_33;
        }

        internal virtual void vmethod_153(ComboItem comboItem_192)
        {
            comboItem_33 = comboItem_192;
        }

        internal virtual ComboItem vmethod_154()
        {
            ComboItem comboItem;

            return comboItem_34;
        }

        internal virtual void vmethod_155(ComboItem comboItem_192)
        {
            comboItem_34 = comboItem_192;
        }

        internal virtual ComboItem vmethod_156()
        {
            ComboItem comboItem;

            return comboItem_35;
        }

        internal virtual void vmethod_157(ComboItem comboItem_192)
        {
            comboItem_35 = comboItem_192;
        }

        internal virtual ComboItem vmethod_158()
        {
            ComboItem comboItem;

            return comboItem_36;
        }

        internal virtual void vmethod_159(ComboItem comboItem_192)
        {
            comboItem_36 = comboItem_192;
        }

        internal virtual SuperTabItem vmethod_16()
        {
            SuperTabItem superTabItem;

            return superTabItem_2;
        }

        internal virtual ComboItem vmethod_160()
        {
            ComboItem comboItem;

            return comboItem_37;
        }

        internal virtual void vmethod_161(ComboItem comboItem_192)
        {
            comboItem_37 = comboItem_192;
        }

        internal virtual ComboItem vmethod_162()
        {
            ComboItem comboItem;

            return comboItem_38;
        }

        internal virtual void vmethod_163(ComboItem comboItem_192)
        {
            comboItem_38 = comboItem_192;
        }

        internal virtual ComboItem vmethod_164()
        {
            ComboItem comboItem;

            return comboItem_39;
        }

        internal virtual void vmethod_165(ComboItem comboItem_192)
        {
            comboItem_39 = comboItem_192;
        }

        internal virtual ComboItem vmethod_166()
        {
            ComboItem comboItem;

            return comboItem_40;
        }

        internal virtual void vmethod_167(ComboItem comboItem_192)
        {
            comboItem_40 = comboItem_192;
        }

        internal virtual ComboItem vmethod_168()
        {
            ComboItem comboItem;

            return comboItem_41;
        }

        internal virtual void vmethod_169(ComboItem comboItem_192)
        {
            comboItem_41 = comboItem_192;
        }

        internal virtual void vmethod_17(SuperTabItem superTabItem_8)
        {
            superTabItem_2 = superTabItem_8;
        }

        internal virtual ComboBoxEx vmethod_170()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_3;
        }

        internal virtual void vmethod_171(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_3 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_172()
        {
            ComboItem comboItem;

            return comboItem_42;
        }

        internal virtual void vmethod_173(ComboItem comboItem_192)
        {
            comboItem_42 = comboItem_192;
        }

        internal virtual ComboItem vmethod_174()
        {
            ComboItem comboItem;

            return comboItem_43;
        }

        internal virtual void vmethod_175(ComboItem comboItem_192)
        {
            comboItem_43 = comboItem_192;
        }

        internal virtual ComboItem vmethod_176()
        {
            ComboItem comboItem;

            return comboItem_44;
        }

        internal virtual void vmethod_177(ComboItem comboItem_192)
        {
            comboItem_44 = comboItem_192;
        }

        internal virtual ComboItem vmethod_178()
        {
            ComboItem comboItem;

            return comboItem_45;
        }

        internal virtual void vmethod_179(ComboItem comboItem_192)
        {
            comboItem_45 = comboItem_192;
        }

        internal virtual SuperTabControlPanel vmethod_18()
        {
            SuperTabControlPanel superTabControlPanel;

            return superTabControlPanel_3;
        }

        internal virtual ComboItem vmethod_180()
        {
            ComboItem comboItem;

            return comboItem_46;
        }

        internal virtual void vmethod_181(ComboItem comboItem_192)
        {
            comboItem_46 = comboItem_192;
        }

        internal virtual ComboItem vmethod_182()
        {
            ComboItem comboItem;

            return comboItem_47;
        }

        internal virtual void vmethod_183(ComboItem comboItem_192)
        {
            comboItem_47 = comboItem_192;
        }

        internal virtual ComboItem vmethod_184()
        {
            ComboItem comboItem;

            return comboItem_48;
        }

        internal virtual void vmethod_185(ComboItem comboItem_192)
        {
            comboItem_48 = comboItem_192;
        }

        internal virtual ComboItem vmethod_186()
        {
            ComboItem comboItem;

            return comboItem_49;
        }

        internal virtual void vmethod_187(ComboItem comboItem_192)
        {
            comboItem_49 = comboItem_192;
        }

        internal virtual ComboItem vmethod_188()
        {
            ComboItem comboItem;

            return comboItem_50;
        }

        internal virtual void vmethod_189(ComboItem comboItem_192)
        {
            comboItem_50 = comboItem_192;
        }

        internal virtual void vmethod_19(SuperTabControlPanel superTabControlPanel_8)
        {
            superTabControlPanel_3 = superTabControlPanel_8;
        }

        internal virtual ComboItem vmethod_190()
        {
            ComboItem comboItem;

            return comboItem_51;
        }

        internal virtual void vmethod_191(ComboItem comboItem_192)
        {
            comboItem_51 = comboItem_192;
        }

        internal virtual ComboItem vmethod_192()
        {
            ComboItem comboItem;

            return comboItem_52;
        }

        internal virtual void vmethod_193(ComboItem comboItem_192)
        {
            comboItem_52 = comboItem_192;
        }

        internal virtual ComboItem vmethod_194()
        {
            ComboItem comboItem;

            return comboItem_53;
        }

        internal virtual void vmethod_195(ComboItem comboItem_192)
        {
            comboItem_53 = comboItem_192;
        }

        internal virtual ComboItem vmethod_196()
        {
            ComboItem comboItem;

            return comboItem_54;
        }

        internal virtual void vmethod_197(ComboItem comboItem_192)
        {
            comboItem_54 = comboItem_192;
        }

        internal virtual ComboBoxEx vmethod_198()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_4;
        }

        internal virtual void vmethod_199(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_4 = comboBoxEx_18;
        }

        internal virtual SuperTabControlPanel vmethod_2()
        {
            SuperTabControlPanel superTabControlPanel;

            return superTabControlPanel_0;
        }

        internal virtual SuperTabItem vmethod_20()
        {
            SuperTabItem superTabItem;

            return superTabItem_3;
        }

        internal virtual ComboItem vmethod_200()
        {
            ComboItem comboItem;

            return comboItem_55;
        }

        internal virtual void vmethod_201(ComboItem comboItem_192)
        {
            comboItem_55 = comboItem_192;
        }

        internal virtual ComboItem vmethod_202()
        {
            ComboItem comboItem;

            return comboItem_56;
        }

        internal virtual void vmethod_203(ComboItem comboItem_192)
        {
            comboItem_56 = comboItem_192;
        }

        internal virtual ComboItem vmethod_204()
        {
            ComboItem comboItem;

            return comboItem_57;
        }

        internal virtual void vmethod_205(ComboItem comboItem_192)
        {
            comboItem_57 = comboItem_192;
        }

        internal virtual ComboItem vmethod_206()
        {
            ComboItem comboItem;

            return comboItem_58;
        }

        internal virtual void vmethod_207(ComboItem comboItem_192)
        {
            comboItem_58 = comboItem_192;
        }

        internal virtual ComboItem vmethod_208()
        {
            ComboItem comboItem;

            return comboItem_59;
        }

        internal virtual void vmethod_209(ComboItem comboItem_192)
        {
            comboItem_59 = comboItem_192;
        }

        internal virtual void vmethod_21(SuperTabItem superTabItem_8)
        {
            superTabItem_3 = superTabItem_8;
        }

        internal virtual ComboItem vmethod_210()
        {
            ComboItem comboItem;

            return comboItem_60;
        }

        internal virtual void vmethod_211(ComboItem comboItem_192)
        {
            comboItem_60 = comboItem_192;
        }

        internal virtual ComboItem vmethod_212()
        {
            ComboItem comboItem;

            return comboItem_61;
        }

        internal virtual void vmethod_213(ComboItem comboItem_192)
        {
            comboItem_61 = comboItem_192;
        }

        internal virtual ComboItem vmethod_214()
        {
            ComboItem comboItem;

            return comboItem_62;
        }

        internal virtual void vmethod_215(ComboItem comboItem_192)
        {
            comboItem_62 = comboItem_192;
        }

        internal virtual ComboItem vmethod_216()
        {
            ComboItem comboItem;

            return comboItem_63;
        }

        internal virtual void vmethod_217(ComboItem comboItem_192)
        {
            comboItem_63 = comboItem_192;
        }

        internal virtual ComboItem vmethod_218()
        {
            ComboItem comboItem;

            return comboItem_64;
        }

        internal virtual void vmethod_219(ComboItem comboItem_192)
        {
            comboItem_64 = comboItem_192;
        }

        internal virtual SuperTabControlPanel vmethod_22()
        {
            SuperTabControlPanel superTabControlPanel;

            return superTabControlPanel_4;
        }

        internal virtual ComboItem vmethod_220()
        {
            ComboItem comboItem;

            return comboItem_65;
        }

        internal virtual void vmethod_221(ComboItem comboItem_192)
        {
            comboItem_65 = comboItem_192;
        }

        internal virtual ComboItem vmethod_222()
        {
            ComboItem comboItem;

            return comboItem_66;
        }

        internal virtual void vmethod_223(ComboItem comboItem_192)
        {
            comboItem_66 = comboItem_192;
        }

        internal virtual ComboBoxEx vmethod_224()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_5;
        }

        internal virtual void vmethod_225(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_5 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_226()
        {
            ComboItem comboItem;

            return comboItem_67;
        }

        internal virtual void vmethod_227(ComboItem comboItem_192)
        {
            comboItem_67 = comboItem_192;
        }

        internal virtual ComboItem vmethod_228()
        {
            ComboItem comboItem;

            return comboItem_68;
        }

        internal virtual void vmethod_229(ComboItem comboItem_192)
        {
            comboItem_68 = comboItem_192;
        }

        internal virtual void vmethod_23(SuperTabControlPanel superTabControlPanel_8)
        {
            superTabControlPanel_4 = superTabControlPanel_8;
        }

        internal virtual ComboItem vmethod_230()
        {
            ComboItem comboItem;

            return comboItem_69;
        }

        internal virtual void vmethod_231(ComboItem comboItem_192)
        {
            comboItem_69 = comboItem_192;
        }

        internal virtual ComboItem vmethod_232()
        {
            ComboItem comboItem;

            return comboItem_70;
        }

        internal virtual void vmethod_233(ComboItem comboItem_192)
        {
            comboItem_70 = comboItem_192;
        }

        internal virtual ComboItem vmethod_234()
        {
            ComboItem comboItem;

            return comboItem_71;
        }

        internal virtual void vmethod_235(ComboItem comboItem_192)
        {
            comboItem_71 = comboItem_192;
        }

        internal virtual ComboItem vmethod_236()
        {
            ComboItem comboItem;

            return comboItem_72;
        }

        internal virtual void vmethod_237(ComboItem comboItem_192)
        {
            comboItem_72 = comboItem_192;
        }

        internal virtual ComboItem vmethod_238()
        {
            ComboItem comboItem;

            return comboItem_73;
        }

        internal virtual void vmethod_239(ComboItem comboItem_192)
        {
            comboItem_73 = comboItem_192;
        }

        internal virtual SuperTabItem vmethod_24()
        {
            SuperTabItem superTabItem;

            return superTabItem_4;
        }

        internal virtual ComboItem vmethod_240()
        {
            ComboItem comboItem;

            return comboItem_74;
        }

        internal virtual void vmethod_241(ComboItem comboItem_192)
        {
            comboItem_74 = comboItem_192;
        }

        internal virtual ComboItem vmethod_242()
        {
            ComboItem comboItem;

            return comboItem_75;
        }

        internal virtual void vmethod_243(ComboItem comboItem_192)
        {
            comboItem_75 = comboItem_192;
        }

        internal virtual ComboItem vmethod_244()
        {
            ComboItem comboItem;

            return comboItem_76;
        }

        internal virtual void vmethod_245(ComboItem comboItem_192)
        {
            comboItem_76 = comboItem_192;
        }

        internal virtual ComboItem vmethod_246()
        {
            ComboItem comboItem;

            return comboItem_77;
        }

        internal virtual void vmethod_247(ComboItem comboItem_192)
        {
            comboItem_77 = comboItem_192;
        }

        internal virtual ComboItem vmethod_248()
        {
            ComboItem comboItem;

            return comboItem_78;
        }

        internal virtual void vmethod_249(ComboItem comboItem_192)
        {
            comboItem_78 = comboItem_192;
        }

        internal virtual void vmethod_25(SuperTabItem superTabItem_8)
        {
            superTabItem_4 = superTabItem_8;
        }

        internal virtual ComboItem vmethod_250()
        {
            ComboItem comboItem;

            return comboItem_79;
        }

        internal virtual void vmethod_251(ComboItem comboItem_192)
        {
            comboItem_79 = comboItem_192;
        }

        internal virtual SuperTabControlPanel vmethod_252()
        {
            SuperTabControlPanel superTabControlPanel;

            return superTabControlPanel_7;
        }

        internal virtual void vmethod_253(SuperTabControlPanel superTabControlPanel_8)
        {
            superTabControlPanel_7 = superTabControlPanel_8;
        }

        internal virtual SuperTabItem vmethod_254()
        {
            SuperTabItem superTabItem;

            return superTabItem_7;
        }

        internal virtual void vmethod_255(SuperTabItem superTabItem_8)
        {
            superTabItem_7 = superTabItem_8;
        }

        internal virtual ComboBoxEx vmethod_256()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_6;
        }

        internal virtual void vmethod_257(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_6 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_258()
        {
            ComboItem comboItem;

            return comboItem_80;
        }

        internal virtual void vmethod_259(ComboItem comboItem_192)
        {
            comboItem_80 = comboItem_192;
        }

        internal virtual Timer vmethod_26()
        {
            Timer timer;

            return timer_0;
        }

        internal virtual ComboItem vmethod_260()
        {
            ComboItem comboItem;

            return comboItem_81;
        }

        internal virtual void vmethod_261(ComboItem comboItem_192)
        {
            comboItem_81 = comboItem_192;
        }

        internal virtual ComboItem vmethod_262()
        {
            ComboItem comboItem;

            return comboItem_82;
        }

        internal virtual void vmethod_263(ComboItem comboItem_192)
        {
            comboItem_82 = comboItem_192;
        }

        internal virtual ComboItem vmethod_264()
        {
            ComboItem comboItem;

            return comboItem_83;
        }

        internal virtual void vmethod_265(ComboItem comboItem_192)
        {
            comboItem_83 = comboItem_192;
        }

        internal virtual ComboItem vmethod_266()
        {
            ComboItem comboItem;

            return comboItem_84;
        }

        internal virtual void vmethod_267(ComboItem comboItem_192)
        {
            comboItem_84 = comboItem_192;
        }

        internal virtual ComboItem vmethod_268()
        {
            ComboItem comboItem;

            return comboItem_85;
        }

        internal virtual void vmethod_269(ComboItem comboItem_192)
        {
            comboItem_85 = comboItem_192;
        }

        internal virtual void vmethod_27(Timer timer_1)
        {
            EventHandler eventHandler = new EventHandler(method_4);
            if (timer_0 != null)
                timer_0.Tick -= eventHandler;
            timer_0 = timer_1;
            if (timer_0 != null)
                timer_0.Tick += eventHandler;
        }

        internal virtual ComboItem vmethod_270()
        {
            ComboItem comboItem;

            return comboItem_86;
        }

        internal virtual void vmethod_271(ComboItem comboItem_192)
        {
            comboItem_86 = comboItem_192;
        }

        internal virtual ComboItem vmethod_272()
        {
            ComboItem comboItem;

            return comboItem_87;
        }

        internal virtual void vmethod_273(ComboItem comboItem_192)
        {
            comboItem_87 = comboItem_192;
        }

        internal virtual ComboItem vmethod_274()
        {
            ComboItem comboItem;

            return comboItem_88;
        }

        internal virtual void vmethod_275(ComboItem comboItem_192)
        {
            comboItem_88 = comboItem_192;
        }

        internal virtual ComboItem vmethod_276()
        {
            ComboItem comboItem;

            return comboItem_89;
        }

        internal virtual void vmethod_277(ComboItem comboItem_192)
        {
            comboItem_89 = comboItem_192;
        }

        internal virtual LabelX vmethod_278()
        {
            LabelX labelX;

            return labelX_12;
        }

        internal virtual void vmethod_279(LabelX labelX_74)
        {
            labelX_12 = labelX_74;
        }

        internal virtual ComboItem vmethod_28()
        {
            ComboItem comboItem;

            return comboItem_0;
        }

        internal virtual SwitchButton vmethod_280()
        {
            SwitchButton switchButton;

            return switchButton_7;
        }

        internal virtual void vmethod_281(SwitchButton switchButton_19)
        {
            switchButton_7 = switchButton_19;
        }

        internal virtual LabelX vmethod_282()
        {
            LabelX labelX;

            return labelX_13;
        }

        internal virtual void vmethod_283(LabelX labelX_74)
        {
            labelX_13 = labelX_74;
        }

        internal virtual SwitchButton vmethod_284()
        {
            SwitchButton switchButton;

            return switchButton_8;
        }

        internal virtual void vmethod_285(SwitchButton switchButton_19)
        {
            switchButton_8 = switchButton_19;
        }

        internal virtual ComboBoxEx vmethod_286()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_7;
        }

        internal virtual void vmethod_287(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_7 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_288()
        {
            ComboItem comboItem;

            return comboItem_90;
        }

        internal virtual void vmethod_289(ComboItem comboItem_192)
        {
            comboItem_90 = comboItem_192;
        }

        internal virtual void vmethod_29(ComboItem comboItem_192)
        {
            comboItem_0 = comboItem_192;
        }

        internal virtual ComboItem vmethod_290()
        {
            ComboItem comboItem;

            return comboItem_91;
        }

        internal virtual void vmethod_291(ComboItem comboItem_192)
        {
            comboItem_91 = comboItem_192;
        }

        internal virtual ComboItem vmethod_292()
        {
            ComboItem comboItem;

            return comboItem_92;
        }

        internal virtual void vmethod_293(ComboItem comboItem_192)
        {
            comboItem_92 = comboItem_192;
        }

        internal virtual ComboItem vmethod_294()
        {
            ComboItem comboItem;

            return comboItem_93;
        }

        internal virtual void vmethod_295(ComboItem comboItem_192)
        {
            comboItem_93 = comboItem_192;
        }

        internal virtual ComboItem vmethod_296()
        {
            ComboItem comboItem;

            return comboItem_94;
        }

        internal virtual void vmethod_297(ComboItem comboItem_192)
        {
            comboItem_94 = comboItem_192;
        }

        internal virtual ComboItem vmethod_298()
        {
            ComboItem comboItem;

            return comboItem_95;
        }

        internal virtual void vmethod_299(ComboItem comboItem_192)
        {
            comboItem_95 = comboItem_192;
        }

        internal virtual void vmethod_3(SuperTabControlPanel superTabControlPanel_8)
        {
            superTabControlPanel_0 = superTabControlPanel_8;
        }

        internal virtual ComboItem vmethod_30()
        {
            ComboItem comboItem;

            return comboItem_1;
        }

        internal virtual ComboItem vmethod_300()
        {
            ComboItem comboItem;

            return comboItem_96;
        }

        internal virtual void vmethod_301(ComboItem comboItem_192)
        {
            comboItem_96 = comboItem_192;
        }

        internal virtual ComboItem vmethod_302()
        {
            ComboItem comboItem;

            return comboItem_97;
        }

        internal virtual void vmethod_303(ComboItem comboItem_192)
        {
            comboItem_97 = comboItem_192;
        }

        internal virtual ComboItem vmethod_304()
        {
            ComboItem comboItem;

            return comboItem_98;
        }

        internal virtual void vmethod_305(ComboItem comboItem_192)
        {
            comboItem_98 = comboItem_192;
        }

        internal virtual ComboItem vmethod_306()
        {
            ComboItem comboItem;

            return comboItem_99;
        }

        internal virtual void vmethod_307(ComboItem comboItem_192)
        {
            comboItem_99 = comboItem_192;
        }

        internal virtual LabelX vmethod_308()
        {
            LabelX labelX;

            return labelX_14;
        }

        internal virtual void vmethod_309(LabelX labelX_74)
        {
            labelX_14 = labelX_74;
        }

        internal virtual void vmethod_31(ComboItem comboItem_192)
        {
            comboItem_1 = comboItem_192;
        }

        internal virtual ComboItem vmethod_310()
        {
            ComboItem comboItem;

            return comboItem_100;
        }

        internal virtual void vmethod_311(ComboItem comboItem_192)
        {
            comboItem_100 = comboItem_192;
        }

        internal virtual ButtonX vmethod_312()
        {
            ButtonX buttonX;

            return buttonX_1;
        }

        internal virtual void vmethod_313(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_15);
            if (buttonX_1 != null)
                buttonX_1.Click -= eventHandler;
            buttonX_1 = buttonX_10;
            if (buttonX_1 != null)
                buttonX_1.Click += eventHandler;
        }

        internal virtual PanelEx vmethod_314()
        {
            PanelEx panelEx;

            return panelEx_1;
        }

        internal virtual void vmethod_315(PanelEx panelEx_18)
        {
            panelEx_1 = panelEx_18;
        }

        internal virtual LabelX vmethod_316()
        {
            LabelX labelX;

            return labelX_15;
        }

        internal virtual void vmethod_317(LabelX labelX_74)
        {
            labelX_15 = labelX_74;
        }

        internal virtual SwitchButton vmethod_318()
        {
            SwitchButton switchButton;

            return switchButton_9;
        }

        internal virtual void vmethod_319(SwitchButton switchButton_19)
        {
            switchButton_9 = switchButton_19;
        }

        internal virtual ComboItem vmethod_32()
        {
            ComboItem comboItem;

            return comboItem_2;
        }

        internal virtual ComboBoxEx vmethod_320()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_8;
        }

        internal virtual void vmethod_321(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_8 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_322()
        {
            ComboItem comboItem;

            return comboItem_101;
        }

        internal virtual void vmethod_323(ComboItem comboItem_192)
        {
            comboItem_101 = comboItem_192;
        }

        internal virtual ComboItem vmethod_324()
        {
            ComboItem comboItem;

            return comboItem_102;
        }

        internal virtual void vmethod_325(ComboItem comboItem_192)
        {
            comboItem_102 = comboItem_192;
        }

        internal virtual ComboItem vmethod_326()
        {
            ComboItem comboItem;

            return comboItem_103;
        }

        internal virtual void vmethod_327(ComboItem comboItem_192)
        {
            comboItem_103 = comboItem_192;
        }

        internal virtual ComboItem vmethod_328()
        {
            ComboItem comboItem;

            return comboItem_104;
        }

        internal virtual void vmethod_329(ComboItem comboItem_192)
        {
            comboItem_104 = comboItem_192;
        }

        internal virtual void vmethod_33(ComboItem comboItem_192)
        {
            comboItem_2 = comboItem_192;
        }

        internal virtual ComboItem vmethod_330()
        {
            ComboItem comboItem;

            return comboItem_105;
        }

        internal virtual void vmethod_331(ComboItem comboItem_192)
        {
            comboItem_105 = comboItem_192;
        }

        internal virtual ComboItem vmethod_332()
        {
            ComboItem comboItem;

            return comboItem_106;
        }

        internal virtual void vmethod_333(ComboItem comboItem_192)
        {
            comboItem_106 = comboItem_192;
        }

        internal virtual ComboItem vmethod_334()
        {
            ComboItem comboItem;

            return comboItem_107;
        }

        internal virtual void vmethod_335(ComboItem comboItem_192)
        {
            comboItem_107 = comboItem_192;
        }

        internal virtual ComboItem vmethod_336()
        {
            ComboItem comboItem;

            return comboItem_108;
        }

        internal virtual void vmethod_337(ComboItem comboItem_192)
        {
            comboItem_108 = comboItem_192;
        }

        internal virtual ComboItem vmethod_338()
        {
            ComboItem comboItem;

            return comboItem_109;
        }

        internal virtual void vmethod_339(ComboItem comboItem_192)
        {
            comboItem_109 = comboItem_192;
        }

        internal virtual ComboItem vmethod_34()
        {
            ComboItem comboItem;

            return comboItem_3;
        }

        internal virtual ComboItem vmethod_340()
        {
            ComboItem comboItem;

            return comboItem_110;
        }

        internal virtual void vmethod_341(ComboItem comboItem_192)
        {
            comboItem_110 = comboItem_192;
        }

        internal virtual ComboItem vmethod_342()
        {
            ComboItem comboItem;

            return comboItem_111;
        }

        internal virtual void vmethod_343(ComboItem comboItem_192)
        {
            comboItem_111 = comboItem_192;
        }

        internal virtual ComboItem vmethod_344()
        {
            ComboItem comboItem;

            return comboItem_112;
        }

        internal virtual void vmethod_345(ComboItem comboItem_192)
        {
            comboItem_112 = comboItem_192;
        }

        internal virtual ComboItem vmethod_346()
        {
            ComboItem comboItem;

            return comboItem_113;
        }

        internal virtual void vmethod_347(ComboItem comboItem_192)
        {
            comboItem_113 = comboItem_192;
        }

        internal virtual ComboItem vmethod_348()
        {
            ComboItem comboItem;

            return comboItem_114;
        }

        internal virtual void vmethod_349(ComboItem comboItem_192)
        {
            comboItem_114 = comboItem_192;
        }

        internal virtual void vmethod_35(ComboItem comboItem_192)
        {
            comboItem_3 = comboItem_192;
        }

        internal virtual ComboItem vmethod_350()
        {
            ComboItem comboItem;

            return comboItem_115;
        }

        internal virtual void vmethod_351(ComboItem comboItem_192)
        {
            comboItem_115 = comboItem_192;
        }

        internal virtual ComboItem vmethod_352()
        {
            ComboItem comboItem;

            return comboItem_116;
        }

        internal virtual void vmethod_353(ComboItem comboItem_192)
        {
            comboItem_116 = comboItem_192;
        }

        internal virtual PanelEx vmethod_354()
        {
            PanelEx panelEx;

            return panelEx_2;
        }

        internal virtual void vmethod_355(PanelEx panelEx_18)
        {
            panelEx_2 = panelEx_18;
        }

        internal virtual LabelX vmethod_356()
        {
            LabelX labelX;

            return labelX_16;
        }

        internal virtual void vmethod_357(LabelX labelX_74)
        {
            labelX_16 = labelX_74;
        }

        internal virtual LabelX vmethod_358()
        {
            LabelX labelX;

            return labelX_17;
        }

        internal virtual void vmethod_359(LabelX labelX_74)
        {
            labelX_17 = labelX_74;
        }

        internal virtual ComboItem vmethod_36()
        {
            ComboItem comboItem;

            return comboItem_4;
        }

        internal virtual ComboBoxEx vmethod_360()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_9;
        }

        internal virtual void vmethod_361(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_9 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_362()
        {
            ComboItem comboItem;

            return comboItem_117;
        }

        internal virtual void vmethod_363(ComboItem comboItem_192)
        {
            comboItem_117 = comboItem_192;
        }

        internal virtual ComboItem vmethod_364()
        {
            ComboItem comboItem;

            return comboItem_118;
        }

        internal virtual void vmethod_365(ComboItem comboItem_192)
        {
            comboItem_118 = comboItem_192;
        }

        internal virtual ComboItem vmethod_366()
        {
            ComboItem comboItem;

            return comboItem_119;
        }

        internal virtual void vmethod_367(ComboItem comboItem_192)
        {
            comboItem_119 = comboItem_192;
        }

        internal virtual ComboItem vmethod_368()
        {
            ComboItem comboItem;

            return comboItem_120;
        }

        internal virtual void vmethod_369(ComboItem comboItem_192)
        {
            comboItem_120 = comboItem_192;
        }

        internal virtual void vmethod_37(ComboItem comboItem_192)
        {
            comboItem_4 = comboItem_192;
        }

        internal virtual ComboItem vmethod_370()
        {
            ComboItem comboItem;

            return comboItem_121;
        }

        internal virtual void vmethod_371(ComboItem comboItem_192)
        {
            comboItem_121 = comboItem_192;
        }

        internal virtual ComboItem vmethod_372()
        {
            ComboItem comboItem;

            return comboItem_122;
        }

        internal virtual void vmethod_373(ComboItem comboItem_192)
        {
            comboItem_122 = comboItem_192;
        }

        internal virtual ComboItem vmethod_374()
        {
            ComboItem comboItem;

            return comboItem_123;
        }

        internal virtual void vmethod_375(ComboItem comboItem_192)
        {
            comboItem_123 = comboItem_192;
        }

        internal virtual ComboItem vmethod_376()
        {
            ComboItem comboItem;

            return comboItem_124;
        }

        internal virtual void vmethod_377(ComboItem comboItem_192)
        {
            comboItem_124 = comboItem_192;
        }

        internal virtual ComboBoxEx vmethod_378()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_10;
        }

        internal virtual void vmethod_379(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_10 = comboBoxEx_18;
        }

        internal virtual SuperTabControl vmethod_38()
        {
            SuperTabControl superTabControl;

            return superTabControl_1;
        }

        internal virtual ComboItem vmethod_380()
        {
            ComboItem comboItem;

            return comboItem_125;
        }

        internal virtual void vmethod_381(ComboItem comboItem_192)
        {
            comboItem_125 = comboItem_192;
        }

        internal virtual ComboItem vmethod_382()
        {
            ComboItem comboItem;

            return comboItem_126;
        }

        internal virtual void vmethod_383(ComboItem comboItem_192)
        {
            comboItem_126 = comboItem_192;
        }

        internal virtual ComboItem vmethod_384()
        {
            ComboItem comboItem;

            return comboItem_127;
        }

        internal virtual void vmethod_385(ComboItem comboItem_192)
        {
            comboItem_127 = comboItem_192;
        }

        internal virtual ComboItem vmethod_386()
        {
            ComboItem comboItem;

            return comboItem_128;
        }

        internal virtual void vmethod_387(ComboItem comboItem_192)
        {
            comboItem_128 = comboItem_192;
        }

        internal virtual ComboItem vmethod_388()
        {
            ComboItem comboItem;

            return comboItem_129;
        }

        internal virtual void vmethod_389(ComboItem comboItem_192)
        {
            comboItem_129 = comboItem_192;
        }

        internal virtual void vmethod_39(SuperTabControl superTabControl_2)
        {
            superTabControl_1 = superTabControl_2;
        }

        internal virtual ComboItem vmethod_390()
        {
            ComboItem comboItem;

            return comboItem_130;
        }

        internal virtual void vmethod_391(ComboItem comboItem_192)
        {
            comboItem_130 = comboItem_192;
        }

        internal virtual ComboItem vmethod_392()
        {
            ComboItem comboItem;

            return comboItem_131;
        }

        internal virtual void vmethod_393(ComboItem comboItem_192)
        {
            comboItem_131 = comboItem_192;
        }

        internal virtual ComboItem vmethod_394()
        {
            ComboItem comboItem;

            return comboItem_132;
        }

        internal virtual void vmethod_395(ComboItem comboItem_192)
        {
            comboItem_132 = comboItem_192;
        }

        internal virtual ComboItem vmethod_396()
        {
            ComboItem comboItem;

            return comboItem_133;
        }

        internal virtual void vmethod_397(ComboItem comboItem_192)
        {
            comboItem_133 = comboItem_192;
        }

        internal virtual ComboBoxEx vmethod_398()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_11;
        }

        internal virtual void vmethod_399(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_11 = comboBoxEx_18;
        }

        internal virtual SuperTabItem vmethod_4()
        {
            SuperTabItem superTabItem;

            return superTabItem_0;
        }

        internal virtual SuperTabControlPanel vmethod_40()
        {
            SuperTabControlPanel superTabControlPanel;

            return superTabControlPanel_5;
        }

        internal virtual ComboItem vmethod_400()
        {
            ComboItem comboItem;

            return comboItem_134;
        }

        internal virtual void vmethod_401(ComboItem comboItem_192)
        {
            comboItem_134 = comboItem_192;
        }

        internal virtual ComboItem vmethod_402()
        {
            ComboItem comboItem;

            return comboItem_135;
        }

        internal virtual void vmethod_403(ComboItem comboItem_192)
        {
            comboItem_135 = comboItem_192;
        }

        internal virtual ComboItem vmethod_404()
        {
            ComboItem comboItem;

            return comboItem_136;
        }

        internal virtual void vmethod_405(ComboItem comboItem_192)
        {
            comboItem_136 = comboItem_192;
        }

        internal virtual ComboItem vmethod_406()
        {
            ComboItem comboItem;

            return comboItem_137;
        }

        internal virtual void vmethod_407(ComboItem comboItem_192)
        {
            comboItem_137 = comboItem_192;
        }

        internal virtual ComboItem vmethod_408()
        {
            ComboItem comboItem;

            return comboItem_138;
        }

        internal virtual void vmethod_409(ComboItem comboItem_192)
        {
            comboItem_138 = comboItem_192;
        }

        internal virtual void vmethod_41(SuperTabControlPanel superTabControlPanel_8)
        {
            superTabControlPanel_5 = superTabControlPanel_8;
        }

        internal virtual ComboItem vmethod_410()
        {
            ComboItem comboItem;

            return comboItem_139;
        }

        internal virtual void vmethod_411(ComboItem comboItem_192)
        {
            comboItem_139 = comboItem_192;
        }

        internal virtual ComboItem vmethod_412()
        {
            ComboItem comboItem;

            return comboItem_140;
        }

        internal virtual void vmethod_413(ComboItem comboItem_192)
        {
            comboItem_140 = comboItem_192;
        }

        internal virtual ComboItem vmethod_414()
        {
            ComboItem comboItem;

            return comboItem_141;
        }

        internal virtual void vmethod_415(ComboItem comboItem_192)
        {
            comboItem_141 = comboItem_192;
        }

        internal virtual ComboItem vmethod_416()
        {
            ComboItem comboItem;

            return comboItem_142;
        }

        internal virtual void vmethod_417(ComboItem comboItem_192)
        {
            comboItem_142 = comboItem_192;
        }

        internal virtual LabelX vmethod_418()
        {
            LabelX labelX;

            return labelX_18;
        }

        internal virtual void vmethod_419(LabelX labelX_74)
        {
            labelX_18 = labelX_74;
        }

        internal virtual SwitchButton vmethod_42()
        {
            SwitchButton switchButton;

            return switchButton_0;
        }

        internal virtual LabelX vmethod_420()
        {
            LabelX labelX;

            return labelX_19;
        }

        internal virtual void vmethod_421(LabelX labelX_74)
        {
            labelX_19 = labelX_74;
        }

        internal virtual LabelX vmethod_422()
        {
            LabelX labelX;

            return labelX_20;
        }

        internal virtual void vmethod_423(LabelX labelX_74)
        {
            labelX_20 = labelX_74;
        }

        internal virtual PanelEx vmethod_424()
        {
            PanelEx panelEx;

            return panelEx_3;
        }

        internal virtual void vmethod_425(PanelEx panelEx_18)
        {
            panelEx_3 = panelEx_18;
        }

        internal virtual LabelX vmethod_426()
        {
            LabelX labelX;

            return labelX_21;
        }

        internal virtual void vmethod_427(LabelX labelX_74)
        {
            labelX_21 = labelX_74;
        }

        internal virtual SwitchButton vmethod_428()
        {
            SwitchButton switchButton;

            return switchButton_10;
        }

        internal virtual void vmethod_429(SwitchButton switchButton_19)
        {
            switchButton_10 = switchButton_19;
        }

        internal virtual void vmethod_43(SwitchButton switchButton_19)
        {
            switchButton_0 = switchButton_19;
        }

        internal virtual ComboBoxEx vmethod_430()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_12;
        }

        internal virtual void vmethod_431(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_12 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_432()
        {
            ComboItem comboItem;

            return comboItem_143;
        }

        internal virtual void vmethod_433(ComboItem comboItem_192)
        {
            comboItem_143 = comboItem_192;
        }

        internal virtual ComboItem vmethod_434()
        {
            ComboItem comboItem;

            return comboItem_144;
        }

        internal virtual void vmethod_435(ComboItem comboItem_192)
        {
            comboItem_144 = comboItem_192;
        }

        internal virtual ComboItem vmethod_436()
        {
            ComboItem comboItem;

            return comboItem_145;
        }

        internal virtual void vmethod_437(ComboItem comboItem_192)
        {
            comboItem_145 = comboItem_192;
        }

        internal virtual ComboItem vmethod_438()
        {
            ComboItem comboItem;

            return comboItem_146;
        }

        internal virtual void vmethod_439(ComboItem comboItem_192)
        {
            comboItem_146 = comboItem_192;
        }

        internal virtual SuperTabItem vmethod_44()
        {
            SuperTabItem superTabItem;

            return superTabItem_5;
        }

        internal virtual ComboItem vmethod_440()
        {
            ComboItem comboItem;

            return comboItem_147;
        }

        internal virtual void vmethod_441(ComboItem comboItem_192)
        {
            comboItem_147 = comboItem_192;
        }

        internal virtual ComboItem vmethod_442()
        {
            ComboItem comboItem;

            return comboItem_148;
        }

        internal virtual void vmethod_443(ComboItem comboItem_192)
        {
            comboItem_148 = comboItem_192;
        }

        internal virtual ComboItem vmethod_444()
        {
            ComboItem comboItem;

            return comboItem_149;
        }

        internal virtual void vmethod_445(ComboItem comboItem_192)
        {
            comboItem_149 = comboItem_192;
        }

        internal virtual ComboItem vmethod_446()
        {
            ComboItem comboItem;

            return comboItem_150;
        }

        internal virtual void vmethod_447(ComboItem comboItem_192)
        {
            comboItem_150 = comboItem_192;
        }

        internal virtual PanelEx vmethod_448()
        {
            PanelEx panelEx;

            return panelEx_4;
        }

        internal virtual void vmethod_449(PanelEx panelEx_18)
        {
            panelEx_4 = panelEx_18;
        }

        internal virtual void vmethod_45(SuperTabItem superTabItem_8)
        {
            superTabItem_5 = superTabItem_8;
        }

        internal virtual LabelX vmethod_450()
        {
            LabelX labelX;

            return labelX_22;
        }

        internal virtual void vmethod_451(LabelX labelX_74)
        {
            labelX_22 = labelX_74;
        }

        internal virtual SwitchButton vmethod_452()
        {
            SwitchButton switchButton;

            return switchButton_11;
        }

        internal virtual void vmethod_453(SwitchButton switchButton_19)
        {
            switchButton_11 = switchButton_19;
        }

        internal virtual ComboBoxEx vmethod_454()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_13;
        }

        internal virtual void vmethod_455(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_13 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_456()
        {
            ComboItem comboItem;

            return comboItem_151;
        }

        internal virtual void vmethod_457(ComboItem comboItem_192)
        {
            comboItem_151 = comboItem_192;
        }

        internal virtual ComboItem vmethod_458()
        {
            ComboItem comboItem;

            return comboItem_152;
        }

        internal virtual void vmethod_459(ComboItem comboItem_192)
        {
            comboItem_152 = comboItem_192;
        }

        internal virtual SuperTabControlPanel vmethod_46()
        {
            SuperTabControlPanel superTabControlPanel;

            return superTabControlPanel_6;
        }

        internal virtual ComboItem vmethod_460()
        {
            ComboItem comboItem;

            return comboItem_153;
        }

        internal virtual void vmethod_461(ComboItem comboItem_192)
        {
            comboItem_153 = comboItem_192;
        }

        internal virtual ComboItem vmethod_462()
        {
            ComboItem comboItem;

            return comboItem_154;
        }

        internal virtual void vmethod_463(ComboItem comboItem_192)
        {
            comboItem_154 = comboItem_192;
        }

        internal virtual ComboItem vmethod_464()
        {
            ComboItem comboItem;

            return comboItem_155;
        }

        internal virtual void vmethod_465(ComboItem comboItem_192)
        {
            comboItem_155 = comboItem_192;
        }

        internal virtual ComboItem vmethod_466()
        {
            ComboItem comboItem;

            return comboItem_156;
        }

        internal virtual void vmethod_467(ComboItem comboItem_192)
        {
            comboItem_156 = comboItem_192;
        }

        internal virtual ComboItem vmethod_468()
        {
            ComboItem comboItem;

            return comboItem_157;
        }

        internal virtual void vmethod_469(ComboItem comboItem_192)
        {
            comboItem_157 = comboItem_192;
        }

        internal virtual void vmethod_47(SuperTabControlPanel superTabControlPanel_8)
        {
            superTabControlPanel_6 = superTabControlPanel_8;
        }

        internal virtual ComboItem vmethod_470()
        {
            ComboItem comboItem;

            return comboItem_158;
        }

        internal virtual void vmethod_471(ComboItem comboItem_192)
        {
            comboItem_158 = comboItem_192;
        }

        internal virtual ComboItem vmethod_472()
        {
            ComboItem comboItem;

            return comboItem_159;
        }

        internal virtual void vmethod_473(ComboItem comboItem_192)
        {
            comboItem_159 = comboItem_192;
        }

        internal virtual ComboItem vmethod_474()
        {
            ComboItem comboItem;

            return comboItem_160;
        }

        internal virtual void vmethod_475(ComboItem comboItem_192)
        {
            comboItem_160 = comboItem_192;
        }

        internal virtual ComboItem vmethod_476()
        {
            ComboItem comboItem;

            return comboItem_161;
        }

        internal virtual void vmethod_477(ComboItem comboItem_192)
        {
            comboItem_161 = comboItem_192;
        }

        internal virtual ComboItem vmethod_478()
        {
            ComboItem comboItem;

            return comboItem_162;
        }

        internal virtual void vmethod_479(ComboItem comboItem_192)
        {
            comboItem_162 = comboItem_192;
        }

        internal virtual SuperTabItem vmethod_48()
        {
            SuperTabItem superTabItem;

            return superTabItem_6;
        }

        internal virtual ComboItem vmethod_480()
        {
            ComboItem comboItem;

            return comboItem_163;
        }

        internal virtual void vmethod_481(ComboItem comboItem_192)
        {
            comboItem_163 = comboItem_192;
        }

        internal virtual ComboItem vmethod_482()
        {
            ComboItem comboItem;

            return comboItem_164;
        }

        internal virtual void vmethod_483(ComboItem comboItem_192)
        {
            comboItem_164 = comboItem_192;
        }

        internal virtual ComboItem vmethod_484()
        {
            ComboItem comboItem;

            return comboItem_165;
        }

        internal virtual void vmethod_485(ComboItem comboItem_192)
        {
            comboItem_165 = comboItem_192;
        }

        internal virtual ComboItem vmethod_486()
        {
            ComboItem comboItem;

            return comboItem_166;
        }

        internal virtual void vmethod_487(ComboItem comboItem_192)
        {
            comboItem_166 = comboItem_192;
        }

        internal virtual PanelEx vmethod_488()
        {
            PanelEx panelEx;

            return panelEx_5;
        }

        internal virtual void vmethod_489(PanelEx panelEx_18)
        {
            panelEx_5 = panelEx_18;
        }

        internal virtual void vmethod_49(SuperTabItem superTabItem_8)
        {
            superTabItem_6 = superTabItem_8;
        }

        internal virtual ButtonX vmethod_490()
        {
            ButtonX buttonX;

            return buttonX_2;
        }

        internal virtual void vmethod_491(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_6);
            if (buttonX_2 != null)
                buttonX_2.Click -= eventHandler;
            buttonX_2 = buttonX_10;
            if (buttonX_2 != null)
                buttonX_2.Click += eventHandler;
        }

        internal virtual LabelX vmethod_492()
        {
            LabelX labelX;

            return labelX_23;
        }

        internal virtual void vmethod_493(LabelX labelX_74)
        {
            labelX_23 = labelX_74;
        }

        internal virtual ComboBoxEx vmethod_494()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_14;
        }

        internal virtual void vmethod_495(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_14 = comboBoxEx_18;
        }

        internal virtual SwitchButton vmethod_496()
        {
            SwitchButton switchButton;

            return switchButton_12;
        }

        internal virtual void vmethod_497(SwitchButton switchButton_19)
        {
            switchButton_12 = switchButton_19;
        }

        internal virtual PanelEx vmethod_498()
        {
            PanelEx panelEx;

            return panelEx_6;
        }

        internal virtual void vmethod_499(PanelEx panelEx_18)
        {
            panelEx_6 = panelEx_18;
        }

        internal virtual void vmethod_5(SuperTabItem superTabItem_8)
        {
            superTabItem_0 = superTabItem_8;
        }

        internal virtual SwitchButton vmethod_50()
        {
            SwitchButton switchButton;

            return switchButton_1;
        }

        internal virtual SwitchButton vmethod_500()
        {
            SwitchButton switchButton;

            return switchButton_13;
        }

        internal virtual void vmethod_501(SwitchButton switchButton_19)
        {
            switchButton_13 = switchButton_19;
        }

        internal virtual ComboBoxEx vmethod_502()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_15;
        }

        internal virtual void vmethod_503(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_15 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_504()
        {
            ComboItem comboItem;

            return comboItem_167;
        }

        internal virtual void vmethod_505(ComboItem comboItem_192)
        {
            comboItem_167 = comboItem_192;
        }

        internal virtual ComboItem vmethod_506()
        {
            ComboItem comboItem;

            return comboItem_168;
        }

        internal virtual void vmethod_507(ComboItem comboItem_192)
        {
            comboItem_168 = comboItem_192;
        }

        internal virtual ComboItem vmethod_508()
        {
            ComboItem comboItem;

            return comboItem_169;
        }

        internal virtual void vmethod_509(ComboItem comboItem_192)
        {
            comboItem_169 = comboItem_192;
        }

        internal virtual void vmethod_51(SwitchButton switchButton_19)
        {
            EventHandler eventHandler = new EventHandler(method_7);
            if (switchButton_1 != null)
                switchButton_1.ValueChanged -= eventHandler;
            switchButton_1 = switchButton_19;
            if (switchButton_1 != null)
                switchButton_1.ValueChanged += eventHandler;
        }

        internal virtual ComboItem vmethod_510()
        {
            ComboItem comboItem;

            return comboItem_170;
        }

        internal virtual void vmethod_511(ComboItem comboItem_192)
        {
            comboItem_170 = comboItem_192;
        }

        internal virtual ComboItem vmethod_512()
        {
            ComboItem comboItem;

            return comboItem_171;
        }

        internal virtual void vmethod_513(ComboItem comboItem_192)
        {
            comboItem_171 = comboItem_192;
        }

        internal virtual ComboItem vmethod_514()
        {
            ComboItem comboItem;

            return comboItem_172;
        }

        internal virtual void vmethod_515(ComboItem comboItem_192)
        {
            comboItem_172 = comboItem_192;
        }

        internal virtual LabelX vmethod_516()
        {
            LabelX labelX;

            return labelX_24;
        }

        internal virtual void vmethod_517(LabelX labelX_74)
        {
            labelX_24 = labelX_74;
        }

        internal virtual PanelEx vmethod_518()
        {
            PanelEx panelEx;

            return panelEx_7;
        }

        internal virtual void vmethod_519(PanelEx panelEx_18)
        {
            panelEx_7 = panelEx_18;
        }

        internal virtual LabelX vmethod_52()
        {
            LabelX labelX;

            return labelX_0;
        }

        internal virtual ComboBoxEx vmethod_520()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_16;
        }

        internal virtual void vmethod_521(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_16 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_522()
        {
            ComboItem comboItem;

            return comboItem_173;
        }

        internal virtual void vmethod_523(ComboItem comboItem_192)
        {
            comboItem_173 = comboItem_192;
        }

        internal virtual ComboItem vmethod_524()
        {
            ComboItem comboItem;

            return comboItem_174;
        }

        internal virtual void vmethod_525(ComboItem comboItem_192)
        {
            comboItem_174 = comboItem_192;
        }

        internal virtual ComboItem vmethod_526()
        {
            ComboItem comboItem;

            return comboItem_175;
        }

        internal virtual void vmethod_527(ComboItem comboItem_192)
        {
            comboItem_175 = comboItem_192;
        }

        internal virtual ComboItem vmethod_528()
        {
            ComboItem comboItem;

            return comboItem_176;
        }

        internal virtual void vmethod_529(ComboItem comboItem_192)
        {
            comboItem_176 = comboItem_192;
        }

        internal virtual void vmethod_53(LabelX labelX_74)
        {
            labelX_0 = labelX_74;
        }

        internal virtual ComboItem vmethod_530()
        {
            ComboItem comboItem;

            return comboItem_177;
        }

        internal virtual void vmethod_531(ComboItem comboItem_192)
        {
            comboItem_177 = comboItem_192;
        }

        internal virtual ComboItem vmethod_532()
        {
            ComboItem comboItem;

            return comboItem_178;
        }

        internal virtual void vmethod_533(ComboItem comboItem_192)
        {
            comboItem_178 = comboItem_192;
        }

        internal virtual ComboItem vmethod_534()
        {
            ComboItem comboItem;

            return comboItem_179;
        }

        internal virtual void vmethod_535(ComboItem comboItem_192)
        {
            comboItem_179 = comboItem_192;
        }

        internal virtual ComboItem vmethod_536()
        {
            ComboItem comboItem;

            return comboItem_180;
        }

        internal virtual void vmethod_537(ComboItem comboItem_192)
        {
            comboItem_180 = comboItem_192;
        }

        internal virtual ComboItem vmethod_538()
        {
            ComboItem comboItem;

            return comboItem_181;
        }

        internal virtual void vmethod_539(ComboItem comboItem_192)
        {
            comboItem_181 = comboItem_192;
        }

        internal virtual LabelX vmethod_54()
        {
            LabelX labelX;

            return labelX_1;
        }

        internal virtual LabelX vmethod_540()
        {
            LabelX labelX;

            return labelX_25;
        }

        internal virtual void vmethod_541(LabelX labelX_74)
        {
            labelX_25 = labelX_74;
        }

        internal virtual PanelEx vmethod_542()
        {
            PanelEx panelEx;

            return panelEx_8;
        }

        internal virtual void vmethod_543(PanelEx panelEx_18)
        {
            panelEx_8 = panelEx_18;
        }

        internal virtual SwitchButton vmethod_544()
        {
            SwitchButton switchButton;

            return switchButton_14;
        }

        internal virtual void vmethod_545(SwitchButton switchButton_19)
        {
            switchButton_14 = switchButton_19;
        }

        internal virtual LabelX vmethod_546()
        {
            LabelX labelX;

            return labelX_26;
        }

        internal virtual void vmethod_547(LabelX labelX_74)
        {
            labelX_26 = labelX_74;
        }

        internal virtual LabelX vmethod_548()
        {
            LabelX labelX;

            return labelX_27;
        }

        internal virtual void vmethod_549(LabelX labelX_74)
        {
            labelX_27 = labelX_74;
        }

        internal virtual void vmethod_55(LabelX labelX_74)
        {
            labelX_1 = labelX_74;
        }

        internal virtual PanelEx vmethod_550()
        {
            PanelEx panelEx;

            return panelEx_9;
        }

        internal virtual void vmethod_551(PanelEx panelEx_18)
        {
            panelEx_9 = panelEx_18;
        }

        internal virtual ComboBoxEx vmethod_552()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_17;
        }

        internal virtual void vmethod_553(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_17 = comboBoxEx_18;
        }

        internal virtual ComboItem vmethod_554()
        {
            ComboItem comboItem;

            return comboItem_182;
        }

        internal virtual void vmethod_555(ComboItem comboItem_192)
        {
            comboItem_182 = comboItem_192;
        }

        internal virtual ComboItem vmethod_556()
        {
            ComboItem comboItem;

            return comboItem_183;
        }

        internal virtual void vmethod_557(ComboItem comboItem_192)
        {
            comboItem_183 = comboItem_192;
        }

        internal virtual ComboItem vmethod_558()
        {
            ComboItem comboItem;

            return comboItem_184;
        }

        internal virtual void vmethod_559(ComboItem comboItem_192)
        {
            comboItem_184 = comboItem_192;
        }

        internal virtual LabelX vmethod_56()
        {
            LabelX labelX;

            return labelX_2;
        }

        internal virtual ComboItem vmethod_560()
        {
            ComboItem comboItem;

            return comboItem_185;
        }

        internal virtual void vmethod_561(ComboItem comboItem_192)
        {
            comboItem_185 = comboItem_192;
        }

        internal virtual ComboItem vmethod_562()
        {
            ComboItem comboItem;

            return comboItem_186;
        }

        internal virtual void vmethod_563(ComboItem comboItem_192)
        {
            comboItem_186 = comboItem_192;
        }

        internal virtual ComboItem vmethod_564()
        {
            ComboItem comboItem;

            return comboItem_187;
        }

        internal virtual void vmethod_565(ComboItem comboItem_192)
        {
            comboItem_187 = comboItem_192;
        }

        internal virtual ComboItem vmethod_566()
        {
            ComboItem comboItem;

            return comboItem_188;
        }

        internal virtual void vmethod_567(ComboItem comboItem_192)
        {
            comboItem_188 = comboItem_192;
        }

        internal virtual ComboItem vmethod_568()
        {
            ComboItem comboItem;

            return comboItem_189;
        }

        internal virtual void vmethod_569(ComboItem comboItem_192)
        {
            comboItem_189 = comboItem_192;
        }

        internal virtual void vmethod_57(LabelX labelX_74)
        {
            labelX_2 = labelX_74;
        }

        internal virtual ComboItem vmethod_570()
        {
            ComboItem comboItem;

            return comboItem_190;
        }

        internal virtual void vmethod_571(ComboItem comboItem_192)
        {
            comboItem_190 = comboItem_192;
        }

        internal virtual ComboItem vmethod_572()
        {
            ComboItem comboItem;

            return comboItem_191;
        }

        internal virtual void vmethod_573(ComboItem comboItem_192)
        {
            comboItem_191 = comboItem_192;
        }

        internal virtual LabelX vmethod_574()
        {
            LabelX labelX;

            return labelX_28;
        }

        internal virtual void vmethod_575(LabelX labelX_74)
        {
            labelX_28 = labelX_74;
        }

        internal virtual PanelEx vmethod_576()
        {
            PanelEx panelEx;

            return panelEx_10;
        }

        internal virtual void vmethod_577(PanelEx panelEx_18)
        {
            panelEx_10 = panelEx_18;
        }

        internal virtual LabelX vmethod_578()
        {
            LabelX labelX;

            return labelX_29;
        }

        internal virtual void vmethod_579(LabelX labelX_74)
        {
            labelX_29 = labelX_74;
        }

        internal virtual ComboBoxEx vmethod_58()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_0;
        }

        internal virtual LabelX vmethod_580()
        {
            LabelX labelX;

            return labelX_30;
        }

        internal virtual void vmethod_581(LabelX labelX_74)
        {
            labelX_30 = labelX_74;
        }

        internal virtual LabelX vmethod_582()
        {
            LabelX labelX;

            return labelX_31;
        }

        internal virtual void vmethod_583(LabelX labelX_74)
        {
            labelX_31 = labelX_74;
        }

        internal virtual LabelX vmethod_584()
        {
            LabelX labelX;

            return labelX_32;
        }

        internal virtual void vmethod_585(LabelX labelX_74)
        {
            labelX_32 = labelX_74;
        }

        internal virtual LabelX vmethod_586()
        {
            LabelX labelX;

            return labelX_33;
        }

        internal virtual void vmethod_587(LabelX labelX_74)
        {
            labelX_33 = labelX_74;
        }

        internal virtual ButtonX vmethod_588()
        {
            ButtonX buttonX;

            return buttonX_3;
        }

        internal virtual void vmethod_589(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_5);
            if (buttonX_3 != null)
                buttonX_3.Click -= eventHandler;
            buttonX_3 = buttonX_10;
            if (buttonX_3 != null)
                buttonX_3.Click += eventHandler;
        }

        internal virtual void vmethod_59(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_0 = comboBoxEx_18;
        }

        internal virtual LabelX vmethod_590()
        {
            LabelX labelX;

            return labelX_34;
        }

        internal virtual void vmethod_591(LabelX labelX_74)
        {
            labelX_34 = labelX_74;
        }

        internal virtual LabelX vmethod_592()
        {
            LabelX labelX;

            return labelX_35;
        }

        internal virtual void vmethod_593(LabelX labelX_74)
        {
            labelX_35 = labelX_74;
        }

        internal virtual LabelX vmethod_594()
        {
            LabelX labelX;

            return labelX_36;
        }

        internal virtual void vmethod_595(LabelX labelX_74)
        {
            labelX_36 = labelX_74;
        }

        internal virtual LabelX vmethod_596()
        {
            LabelX labelX;

            return labelX_37;
        }

        internal virtual void vmethod_597(LabelX labelX_74)
        {
            labelX_37 = labelX_74;
        }

        internal virtual LabelX vmethod_598()
        {
            LabelX labelX;

            return labelX_38;
        }

        internal virtual void vmethod_599(LabelX labelX_74)
        {
            labelX_38 = labelX_74;
        }

        internal virtual PanelEx vmethod_6()
        {
            PanelEx panelEx;

            return panelEx_0;
        }

        internal virtual ComboBoxEx vmethod_60()
        {
            ComboBoxEx comboBoxEx;

            return comboBoxEx_1;
        }

        internal virtual LabelX vmethod_600()
        {
            LabelX labelX;

            return labelX_39;
        }

        internal virtual void vmethod_601(LabelX labelX_74)
        {
            labelX_39 = labelX_74;
        }

        internal virtual LabelX vmethod_602()
        {
            LabelX labelX;

            return labelX_40;
        }

        internal virtual void vmethod_603(LabelX labelX_74)
        {
            labelX_40 = labelX_74;
        }

        internal virtual LabelX vmethod_604()
        {
            LabelX labelX;

            return labelX_41;
        }

        internal virtual void vmethod_605(LabelX labelX_74)
        {
            labelX_41 = labelX_74;
        }

        internal virtual LabelX vmethod_606()
        {
            LabelX labelX;

            return labelX_42;
        }

        internal virtual void vmethod_607(LabelX labelX_74)
        {
            labelX_42 = labelX_74;
        }

        internal virtual LabelX vmethod_608()
        {
            LabelX labelX;

            return labelX_43;
        }

        internal virtual void vmethod_609(LabelX labelX_74)
        {
            labelX_43 = labelX_74;
        }

        internal virtual void vmethod_61(ComboBoxEx comboBoxEx_18)
        {
            comboBoxEx_1 = comboBoxEx_18;
        }

        internal virtual LabelX vmethod_610()
        {
            LabelX labelX;

            return labelX_44;
        }

        internal virtual void vmethod_611(LabelX labelX_74)
        {
            labelX_44 = labelX_74;
        }

        internal virtual PanelEx vmethod_612()
        {
            PanelEx panelEx;

            return panelEx_11;
        }

        internal virtual void vmethod_613(PanelEx panelEx_18)
        {
            panelEx_11 = panelEx_18;
        }

        internal virtual SwitchButton vmethod_614()
        {
            SwitchButton switchButton;

            return switchButton_15;
        }

        internal virtual void vmethod_615(SwitchButton switchButton_19)
        {
            switchButton_15 = switchButton_19;
        }

        internal virtual LabelX vmethod_616()
        {
            LabelX labelX;

            return labelX_45;
        }

        internal virtual void vmethod_617(LabelX labelX_74)
        {
            labelX_45 = labelX_74;
        }

        internal virtual SwitchButton vmethod_618()
        {
            SwitchButton switchButton;

            return switchButton_16;
        }

        internal virtual void vmethod_619(SwitchButton switchButton_19)
        {
            switchButton_16 = switchButton_19;
        }

        internal virtual SwitchButton vmethod_62()
        {
            SwitchButton switchButton;

            return switchButton_2;
        }

        internal virtual SwitchButton vmethod_620()
        {
            SwitchButton switchButton;

            return switchButton_17;
        }

        internal virtual void vmethod_621(SwitchButton switchButton_19)
        {
            switchButton_17 = switchButton_19;
        }

        internal virtual SwitchButton vmethod_622()
        {
            SwitchButton switchButton;

            return switchButton_18;
        }

        internal virtual void vmethod_623(SwitchButton switchButton_19)
        {
            switchButton_18 = switchButton_19;
        }

        internal virtual LabelX vmethod_624()
        {
            LabelX labelX;

            return labelX_46;
        }

        internal virtual void vmethod_625(LabelX labelX_74)
        {
            labelX_46 = labelX_74;
        }

        internal virtual LabelX vmethod_626()
        {
            LabelX labelX;

            return labelX_47;
        }

        internal virtual void vmethod_627(LabelX labelX_74)
        {
            labelX_47 = labelX_74;
        }

        internal virtual LabelX vmethod_628()
        {
            LabelX labelX;

            return labelX_48;
        }

        internal virtual void vmethod_629(LabelX labelX_74)
        {
            labelX_48 = labelX_74;
        }

        internal virtual void vmethod_63(SwitchButton switchButton_19)
        {
            switchButton_2 = switchButton_19;
        }

        internal virtual LabelX vmethod_630()
        {
            LabelX labelX;

            return labelX_49;
        }

        internal virtual void vmethod_631(LabelX labelX_74)
        {
            labelX_49 = labelX_74;
        }

        internal virtual PanelEx vmethod_632()
        {
            PanelEx panelEx;

            return panelEx_12;
        }

        internal virtual void vmethod_633(PanelEx panelEx_18)
        {
            panelEx_12 = panelEx_18;
        }

        internal virtual ButtonX vmethod_634()
        {
            ButtonX buttonX;

            return buttonX_4;
        }

        internal virtual void vmethod_635(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_12);
            if (buttonX_4 != null)
                buttonX_4.Click -= eventHandler;
            buttonX_4 = buttonX_10;
            if (buttonX_4 != null)
                buttonX_4.Click += eventHandler;
        }

        internal virtual LabelX vmethod_636()
        {
            LabelX labelX;

            return labelX_50;
        }

        internal virtual void vmethod_637(LabelX labelX_74)
        {
            labelX_50 = labelX_74;
        }

        internal virtual ListViewEx vmethod_638()
        {
            ListViewEx listViewEx;

            return listViewEx_0;
        }

        internal virtual void vmethod_639(ListViewEx listViewEx_3)
        {
            listViewEx_0 = listViewEx_3;
        }

        internal virtual LabelX vmethod_64()
        {
            LabelX labelX;

            return labelX_3;
        }

        internal virtual ColumnHeader vmethod_640()
        {
            ColumnHeader columnHeader;

            return columnHeader_0;
        }

        internal virtual void vmethod_641(ColumnHeader columnHeader_3)
        {
            columnHeader_0 = columnHeader_3;
        }

        internal virtual PanelEx vmethod_642()
        {
            PanelEx panelEx;

            return panelEx_13;
        }

        internal virtual void vmethod_643(PanelEx panelEx_18)
        {
            panelEx_13 = panelEx_18;
        }

        internal virtual LabelX vmethod_644()
        {
            LabelX labelX;

            return labelX_51;
        }

        internal virtual void vmethod_645(LabelX labelX_74)
        {
            labelX_51 = labelX_74;
        }

        internal virtual LabelX vmethod_646()
        {
            LabelX labelX;

            return labelX_52;
        }

        internal virtual void vmethod_647(LabelX labelX_74)
        {
            labelX_52 = labelX_74;
        }

        internal virtual LabelX vmethod_648()
        {
            LabelX labelX;

            return labelX_53;
        }

        internal virtual void vmethod_649(LabelX labelX_74)
        {
            labelX_53 = labelX_74;
        }

        internal virtual void vmethod_65(LabelX labelX_74)
        {
            labelX_3 = labelX_74;
        }

        internal virtual LabelX vmethod_650()
        {
            LabelX labelX;

            return labelX_54;
        }

        internal virtual void vmethod_651(LabelX labelX_74)
        {
            labelX_54 = labelX_74;
        }

        internal virtual LabelX vmethod_652()
        {
            LabelX labelX;

            return labelX_55;
        }

        internal virtual void vmethod_653(LabelX labelX_74)
        {
            labelX_55 = labelX_74;
        }

        internal virtual ButtonX vmethod_654()
        {
            ButtonX buttonX;

            return buttonX_5;
        }

        internal virtual void vmethod_655(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_11);
            if (buttonX_5 != null)
                buttonX_5.Click -= eventHandler;
            buttonX_5 = buttonX_10;
            if (buttonX_5 != null)
                buttonX_5.Click += eventHandler;
        }

        internal virtual LabelX vmethod_656()
        {
            LabelX labelX;

            return labelX_56;
        }

        internal virtual void vmethod_657(LabelX labelX_74)
        {
            labelX_56 = labelX_74;
        }

        internal virtual LabelX vmethod_658()
        {
            LabelX labelX;

            return labelX_57;
        }

        internal virtual void vmethod_659(LabelX labelX_74)
        {
            labelX_57 = labelX_74;
        }

        internal virtual SwitchButton vmethod_66()
        {
            SwitchButton switchButton;

            return switchButton_3;
        }

        internal virtual PanelEx vmethod_660()
        {
            PanelEx panelEx;

            return panelEx_14;
        }

        internal virtual void vmethod_661(PanelEx panelEx_18)
        {
            panelEx_14 = panelEx_18;
        }

        internal virtual LabelX vmethod_662()
        {
            LabelX labelX;

            return labelX_58;
        }

        internal virtual void vmethod_663(LabelX labelX_74)
        {
            labelX_58 = labelX_74;
        }

        internal virtual LabelX vmethod_664()
        {
            LabelX labelX;

            return labelX_59;
        }

        internal virtual void vmethod_665(LabelX labelX_74)
        {
            labelX_59 = labelX_74;
        }

        internal virtual LabelX vmethod_666()
        {
            LabelX labelX;

            return labelX_60;
        }

        internal virtual void vmethod_667(LabelX labelX_74)
        {
            labelX_60 = labelX_74;
        }

        internal virtual LabelX vmethod_668()
        {
            LabelX labelX;

            return labelX_61;
        }

        internal virtual void vmethod_669(LabelX labelX_74)
        {
            labelX_61 = labelX_74;
        }

        internal virtual void vmethod_67(SwitchButton switchButton_19)
        {
            switchButton_3 = switchButton_19;
        }

        internal virtual LabelX vmethod_670()
        {
            LabelX labelX;

            return labelX_62;
        }

        internal virtual void vmethod_671(LabelX labelX_74)
        {
            labelX_62 = labelX_74;
        }

        internal virtual ButtonX vmethod_672()
        {
            ButtonX buttonX;

            return buttonX_6;
        }

        internal virtual void vmethod_673(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_9);
            if (buttonX_6 != null)
                buttonX_6.Click -= eventHandler;
            buttonX_6 = buttonX_10;
            if (buttonX_6 != null)
                buttonX_6.Click += eventHandler;
        }

        internal virtual LabelX vmethod_674()
        {
            LabelX labelX;

            return labelX_63;
        }

        internal virtual void vmethod_675(LabelX labelX_74)
        {
            labelX_63 = labelX_74;
        }

        internal virtual LabelX vmethod_676()
        {
            LabelX labelX;

            return labelX_64;
        }

        internal virtual void vmethod_677(LabelX labelX_74)
        {
            labelX_64 = labelX_74;
        }

        internal virtual PanelEx vmethod_678()
        {
            PanelEx panelEx;

            return panelEx_15;
        }

        internal virtual void vmethod_679(PanelEx panelEx_18)
        {
            panelEx_15 = panelEx_18;
        }

        internal virtual LabelX vmethod_68()
        {
            LabelX labelX;

            return labelX_4;
        }

        internal virtual ListViewEx vmethod_680()
        {
            ListViewEx listViewEx;

            return listViewEx_1;
        }

        internal virtual void vmethod_681(ListViewEx listViewEx_3)
        {
            listViewEx_1 = listViewEx_3;
        }

        internal virtual ColumnHeader vmethod_682()
        {
            ColumnHeader columnHeader;

            return columnHeader_1;
        }

        internal virtual void vmethod_683(ColumnHeader columnHeader_3)
        {
            columnHeader_1 = columnHeader_3;
        }

        internal virtual ButtonX vmethod_684()
        {
            ButtonX buttonX;

            return buttonX_7;
        }

        internal virtual void vmethod_685(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_10);
            if (buttonX_7 != null)
                buttonX_7.Click -= eventHandler;
            buttonX_7 = buttonX_10;
            if (buttonX_7 != null)
                buttonX_7.Click += eventHandler;
        }

        internal virtual LabelX vmethod_686()
        {
            LabelX labelX;

            return labelX_65;
        }

        internal virtual void vmethod_687(LabelX labelX_74)
        {
            labelX_65 = labelX_74;
        }

        internal virtual PanelEx vmethod_688()
        {
            PanelEx panelEx;

            return panelEx_16;
        }

        internal virtual void vmethod_689(PanelEx panelEx_18)
        {
            panelEx_16 = panelEx_18;
        }

        internal virtual void vmethod_69(LabelX labelX_74)
        {
            labelX_4 = labelX_74;
        }

        internal virtual ListViewEx vmethod_690()
        {
            ListViewEx listViewEx;

            return listViewEx_2;
        }

        internal virtual void vmethod_691(ListViewEx listViewEx_3)
        {
            listViewEx_2 = listViewEx_3;
        }

        internal virtual ColumnHeader vmethod_692()
        {
            ColumnHeader columnHeader;

            return columnHeader_2;
        }

        internal virtual void vmethod_693(ColumnHeader columnHeader_3)
        {
            columnHeader_2 = columnHeader_3;
        }

        internal virtual ButtonX vmethod_694()
        {
            ButtonX buttonX;

            return buttonX_8;
        }

        internal virtual void vmethod_695(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_14);
            if (buttonX_8 != null)
                buttonX_8.Click -= eventHandler;
            buttonX_8 = buttonX_10;
            if (buttonX_8 != null)
                buttonX_8.Click += eventHandler;
        }

        internal virtual LabelX vmethod_696()
        {
            LabelX labelX;

            return labelX_66;
        }

        internal virtual void vmethod_697(LabelX labelX_74)
        {
            labelX_66 = labelX_74;
        }

        internal virtual PanelEx vmethod_698()
        {
            PanelEx panelEx;

            return panelEx_17;
        }

        internal virtual void vmethod_699(PanelEx panelEx_18)
        {
            panelEx_17 = panelEx_18;
        }

        internal virtual void vmethod_7(PanelEx panelEx_18)
        {
            EventHandler eventHandler = new EventHandler(method_16);
            if (panelEx_0 != null)
                panelEx_0.Click -= eventHandler;
            panelEx_0 = panelEx_18;
            if (panelEx_0 != null)
                panelEx_0.Click += eventHandler;
        }

        internal virtual LabelX vmethod_70()
        {
            LabelX labelX;

            return labelX_5;
        }

        internal virtual LabelX vmethod_700()
        {
            LabelX labelX;

            return labelX_67;
        }

        internal virtual void vmethod_701(LabelX labelX_74)
        {
            labelX_67 = labelX_74;
        }

        internal virtual LabelX vmethod_702()
        {
            LabelX labelX;

            return labelX_68;
        }

        internal virtual void vmethod_703(LabelX labelX_74)
        {
            labelX_68 = labelX_74;
        }

        internal virtual LabelX vmethod_704()
        {
            LabelX labelX;

            return labelX_69;
        }

        internal virtual void vmethod_705(LabelX labelX_74)
        {
            labelX_69 = labelX_74;
        }

        internal virtual LabelX vmethod_706()
        {
            LabelX labelX;

            return labelX_70;
        }

        internal virtual void vmethod_707(LabelX labelX_74)
        {
            labelX_70 = labelX_74;
        }

        internal virtual LabelX vmethod_708()
        {
            LabelX labelX;

            return labelX_71;
        }

        internal virtual void vmethod_709(LabelX labelX_74)
        {
            labelX_71 = labelX_74;
        }

        internal virtual void vmethod_71(LabelX labelX_74)
        {
            labelX_5 = labelX_74;
        }

        internal virtual ButtonX vmethod_710()
        {
            ButtonX buttonX;

            return buttonX_9;
        }

        internal virtual void vmethod_711(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_13);
            if (buttonX_9 != null)
                buttonX_9.Click -= eventHandler;
            buttonX_9 = buttonX_10;
            if (buttonX_9 != null)
                buttonX_9.Click += eventHandler;
        }

        internal virtual LabelX vmethod_712()
        {
            LabelX labelX;

            return labelX_72;
        }

        internal virtual void vmethod_713(LabelX labelX_74)
        {
            labelX_72 = labelX_74;
        }

        internal virtual LabelX vmethod_714()
        {
            LabelX labelX;

            return labelX_73;
        }

        internal virtual void vmethod_715(LabelX labelX_74)
        {
            labelX_73 = labelX_74;
        }

        internal virtual LabelX vmethod_72()
        {
            LabelX labelX;

            return labelX_6;
        }

        internal virtual void vmethod_73(LabelX labelX_74)
        {
            labelX_6 = labelX_74;
        }

        internal virtual LabelX vmethod_74()
        {
            LabelX labelX;

            return labelX_7;
        }

        internal virtual void vmethod_75(LabelX labelX_74)
        {
            labelX_7 = labelX_74;
        }

        internal virtual SwitchButton vmethod_76()
        {
            SwitchButton switchButton;

            return switchButton_4;
        }

        internal virtual void vmethod_77(SwitchButton switchButton_19)
        {
            EventHandler eventHandler = new EventHandler(method_8);
            if (switchButton_4 != null)
                switchButton_4.ValueChanged -= eventHandler;
            switchButton_4 = switchButton_19;
            if (switchButton_4 != null)
                switchButton_4.ValueChanged += eventHandler;
        }

        internal virtual LabelX vmethod_78()
        {
            LabelX labelX;

            return labelX_8;
        }

        internal virtual void vmethod_79(LabelX labelX_74)
        {
            labelX_8 = labelX_74;
        }

        internal virtual ButtonX vmethod_8()
        {
            ButtonX buttonX;

            return buttonX_0;
        }

        internal virtual LabelX vmethod_80()
        {
            LabelX labelX;

            return labelX_9;
        }

        internal virtual void vmethod_81(LabelX labelX_74)
        {
            labelX_9 = labelX_74;
        }

        internal virtual LabelX vmethod_82()
        {
            LabelX labelX;

            return labelX_10;
        }

        internal virtual void vmethod_83(LabelX labelX_74)
        {
            labelX_10 = labelX_74;
        }

        internal virtual SwitchButton vmethod_84()
        {
            SwitchButton switchButton;

            return switchButton_5;
        }

        internal virtual void vmethod_85(SwitchButton switchButton_19)
        {
            switchButton_5 = switchButton_19;
        }

        internal virtual LabelX vmethod_86()
        {
            LabelX labelX;

            return labelX_11;
        }

        internal virtual void vmethod_87(LabelX labelX_74)
        {
            labelX_11 = labelX_74;
        }

        internal virtual SwitchButton vmethod_88()
        {
            SwitchButton switchButton;

            return switchButton_6;
        }

        internal virtual void vmethod_89(SwitchButton switchButton_19)
        {
            switchButton_6 = switchButton_19;
        }

        internal virtual void vmethod_9(ButtonX buttonX_10)
        {
            EventHandler eventHandler = new EventHandler(method_0);
            if (buttonX_0 != null)
                buttonX_0.Click -= eventHandler;
            buttonX_0 = buttonX_10;
            if (buttonX_0 != null)
                buttonX_0.Click += eventHandler;
        }

        internal virtual TextBoxX vmethod_90()
        {
            TextBoxX textBoxX;

            return textBoxX_0;
        }

        internal virtual void vmethod_91(TextBoxX textBoxX_2)
        {
            textBoxX_0 = textBoxX_2;
        }

        internal virtual ComboItem vmethod_92()
        {
            ComboItem comboItem;

            return comboItem_5;
        }

        internal virtual void vmethod_93(ComboItem comboItem_192)
        {
            comboItem_5 = comboItem_192;
        }

        internal virtual ComboItem vmethod_94()
        {
            ComboItem comboItem;

            return comboItem_6;
        }

        internal virtual void vmethod_95(ComboItem comboItem_192)
        {
            comboItem_6 = comboItem_192;
        }

        internal virtual ComboItem vmethod_96()
        {
            ComboItem comboItem;

            return comboItem_7;
        }

        internal virtual void vmethod_97(ComboItem comboItem_192)
        {
            comboItem_7 = comboItem_192;
        }

        internal virtual ComboItem vmethod_98()
        {
            ComboItem comboItem;

            return comboItem_8;
        }

        internal virtual void vmethod_99(ComboItem comboItem_192)
        {
            comboItem_8 = comboItem_192;
        }

    } // class BotSettings

}

