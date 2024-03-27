using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEA5909A9D17C463, NameHash = 0x51B3554FFBEBED66)]
    public class GcMissionSequenceGroup : NMSTemplate
    {
        /* 0x000 */ public bool Silent;
        /* 0x004 */ public TkTextureResource Icon;
        /* 0x088 */ public GcMissionPageHint PageHint;
        /* 0x090 */ public NMSString0x20A PageDataLocID;
        /* 0x0B0 */ public NMSString0x10 BuildMenuHint;
        /* 0x0C0 */ public NMSString0x10 InventoryHint;
        /* 0x0D0 */ public NMSString0x10 TerrainTarget;
        /* 0x0E0 */ public NMSString0x80 DebugText;
        /* 0x160 */ public NMSString0x20A ObjectiveID;
        /* 0x180 */ public NMSString0x20A ObjectiveTipID;
        /* 0x1A0 */ public bool HasCategoryOverride;
        /* 0x1A4 */ public GcMissionCategory OverrideCategory;
        /* 0x1A8 */ public bool HasColourOverride;
        /* 0x1B0 */ public Colour ColourOverride;
        /* 0x1C0 */ public bool PrefixTitle;
        /* 0x1C8 */ public NMSString0x20A PrefixTitleText;
        /* 0x1E8 */ public bool BlockPinning;
        /* 0x1E9 */ public bool AutoPinRepairs;
        /* 0x1EA */ public bool BlockSpaceBattles;
        /* 0x1EC */ public GcMissionConditionTest ConditionTest;
        /* 0x1F0 */ public bool HideFromLogIfConditionsMet;
        /* 0x1F1 */ public bool DoConsequencesIfNeverActivated;
        // size: 0x3
        public enum RepeatLogicEnum : uint {
            None,
            Loop,
            RestartOnConditionFail,
        }
        /* 0x1F4 */ public RepeatLogicEnum RepeatLogic;
        // size: 0x4
        public enum IconStyleEnum : uint {
            Default,
            Large,
            Square,
            NoFrame,
        }
        /* 0x1F8 */ public IconStyleEnum IconStyle;
        // size: 0x3
        public enum GalMapPathOverrideEnum : uint {
            None,
            BlackHole,
            Atlas,
        }
        /* 0x1FC */ public GalMapPathOverrideEnum GalMapPathOverride;
        /* 0x200 */ public TkInputEnum SpecialButtonIcon;
        /* 0x208 */ public GcObjectiveTextFormatOptions ObjectiveFormatting;
        /* 0x250 */ public GcSeasonalObjectiveOverrides SeasonalObjectiveOverrides;
        /* 0x2A0 */ public GcTargetMissionSurveyOptions SurveyTarget;
        /* 0x4B8 */ public GcCustomNotifyTimerOptions CustomNotifyTimers;
        /* 0x4C8 */ public List<NMSTemplate> Conditions;
        /* 0x4D8 */ public List<NMSTemplate> Consequences;
        /* 0x4E8 */ public List<GcGenericMissionStage> Stages;
    }
}
