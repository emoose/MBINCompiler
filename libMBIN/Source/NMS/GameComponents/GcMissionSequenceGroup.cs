using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x290, Alignment = 0x10, GUID = 0x34E587243C3D95EE, NameHash = 0x51B3554FFBEBED66)]
    public class GcMissionSequenceGroup : NMSTemplate
    {
        /* 0x000 */ public bool Silent;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x001 */ public byte[] Padding1;
        /* 0x004 */ public TkTextureResource Icon;
        /* 0x088 */ public GcMissionPageHint PageHint;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x08C */ public byte[] Padding8C;
        [NMS(Size = 0x20)]
        /* 0x090 */ public string PageDataLocID;
        [NMS(Size = 0x10)]
        /* 0x0B0 */ public string BuildMenuHint;
        [NMS(Size = 0x10)]
        /* 0x0C0 */ public string InventoryHint;
        [NMS(Size = 0x10)]
        /* 0x0D0 */ public string TargetMissionSurveyId;
        [NMS(Size = 0x80)]
        /* 0x0E0 */ public string DebugText;
        [NMS(Size = 0x20)]
        /* 0x160 */ public string ObjectiveID;
        [NMS(Size = 0x20)]
        /* 0x180 */ public string ObjectiveTipID;
        /* 0x1A0 */ public bool HasCategoryOverride;
        /* 0x1A4 */ public GcMissionCategory OverrideCategory;
        /* 0x1A8 */ public bool HasColourOverride;
        /* 0x1B0 */ public Colour ColourOverride;
        /* 0x1C0 */ public bool PrefixTitle;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1C1 */ public byte[] Padding1C1;
        [NMS(Size = 0x20)]
        /* 0x1C8 */ public string PrefixTitleText;
        /* 0x1E8 */ public bool BlockPinning;
        /* 0x1EC */ public GcMissionConditionTest ConditionTest;

		public enum RepeatLogicEnum { None, Loop, RestartOnConditionFail }
		/* 0x1F0 */ public RepeatLogicEnum RepeatLogic;
        public enum IconStyleEnum { Default, Large }
		/* 0x1F4 */ public IconStyleEnum IconStyle;
        /* 0x1F8 */ public TkInputEnum SpecialButtonIcon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1FC */ public byte[] Padding1FC;
        /* 0x200 */ public GcObjectiveTextFormatOptions ObjectiveFormatting;
        /* 0x248 */ public GcCustomNotifyTimerOptions CustomNotifyTimers;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x254 */ public byte[] Padding254;
        /* 0x258 */ public List<NMSTemplate> Conditions;
        /* 0x268 */ public List<NMSTemplate> Consequences;
        /* 0x278 */ public List<GcGenericMissionStage> Stages;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x288 */ public byte[] EndPadding;
    }
}
