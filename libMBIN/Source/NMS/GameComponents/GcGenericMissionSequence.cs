using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE48645231A9A0B97, NameHash = 0xFAE86B2801335B6D)]
    public class GcGenericMissionSequence : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 MissionID;
        // size: 0x9
        public enum MissionClassEnum : uint {
            Primary,
            Secondary,
            ChainedSecondary,
            Guide,
            Wiki,
            Seasonal,
            Milestone,
            Atlas,
            BlackHole,
        }
        /* 0x010 */ public MissionClassEnum MissionClass;
        /* 0x014 */ public bool MissionIsCritical;
        /* 0x015 */ public NMSString0x20 MissionObjective;
        /* 0x038 */ public GcNumberedTextList MissionTitles;
        /* 0x05C */ public GcNumberedTextList MissionSubtitles;
        /* 0x080 */ public GcNumberedTextList MissionDescriptions;
        /* 0x0A8 */ public GcSeasonalLogOverrides SeasonalLogTextOverrides;
        /* 0x118 */ public NMSString0x20 MissionDescSwitchOverride;
        /* 0x138 */ public GcNumberedTextList MissionProcDescriptionHeader;
        /* 0x15C */ public GcNumberedTextList MissionProcDescriptionA;
        /* 0x180 */ public GcNumberedTextList MissionProcDescriptionB;
        /* 0x1A4 */ public GcNumberedTextList MissionProcDescriptionC;
        /* 0x1C8 */ public bool UseScanEventDetailsInLogInfo;
        /* 0x1CC */ public TkTextureResource MissionIcon;
        /* 0x250 */ public TkTextureResource MissionIconSelected;
        /* 0x2D4 */ public TkTextureResource MissionIconNotSelected;
        /* 0x358 */ public int MissionPriority;
        /* 0x35C */ public GcMissionCategory MissionCategory;
        /* 0x360 */ public GcMissionPageHint MissionPageHint;
        /* 0x368 */ public NMSString0x20A MissionPageLocID;
        /* 0x388 */ public NMSString0x10 MissionBuildMenuHint;
        /* 0x398 */ public bool MissionHasColourOverride;
        /* 0x3A0 */ public Colour MissionColourOverride;
        /* 0x3B0 */ public int BeginCheckFrequency;
        /* 0x3B8 */ public GcDefaultMissionItemsTable DefaultItems;
        /* 0x408 */ public bool PrefixTitle;
        /* 0x410 */ public NMSString0x10 NextMissionHint;
        // size: 0x3
        public enum MessageCompleteEnum : uint {
            Default,
            Always,
            Never,
        }
        /* 0x420 */ public MessageCompleteEnum MessageComplete;
        // size: 0x3
        public enum MessageStartEnum : uint {
            Default,
            Always,
            Never,
        }
        /* 0x424 */ public MessageStartEnum MessageStart;
        /* 0x428 */ public GcMissionBoardOptions MissionBoardOptions;
        // size: 0x4
        public enum AutoStartEnum : uint {
            None,
            AllModes,
            Seasonal,
            OnSelected,
        }
        /* 0x4A8 */ public AutoStartEnum AutoStart;
        /* 0x4AC */ public bool RestartOnCompletion;
        /* 0x4AD */ public bool CancelSetsComplete;
        /* 0x4B0 */ public GcAlienPuzzleTable Dialog;
        /* 0x4C0 */ public List<GcScanEventData> ScanEvents;
        /* 0x4D0 */ public List<GcGenericRewardTableEntry> Rewards;
        /* 0x4E0 */ public List<GcCostTableEntry> Costs;
        /* 0x4F0 */ public GcTradeData TradingDataOverride;
        /* 0x5C0 */ public GcMissionConditionTest StartConditionTest;
        /* 0x5C4 */ public GcMissionConditionTest CancelConditionTest;
        /* 0x5C8 */ public bool StartIsCancel;
        /* 0x5D0 */ public List<NMSTemplate> StartingConditions;
        /* 0x5E0 */ public List<NMSTemplate> CancelingConditions;
        /* 0x5F0 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        /* 0x600 */ public List<GcGenericMissionStage> Stages;
        /* 0x610 */ public bool ForcesPageHint;
        /* 0x611 */ public bool ForcesBuildMenuHint;
        /* 0x612 */ public bool IsProceduralAllowed;
        /* 0x613 */ public bool IsRecurring;
        /* 0x614 */ public bool IsLegacy;
        /* 0x615 */ public bool BlocksPinning;
        /* 0x616 */ public bool CanRenounce;
        /* 0x618 */ public NMSString0x10 UseCommunityMissionForLog;
        /* 0x628 */ public bool TakeCommunityMissionIDFromSeasonData;
        /* 0x629 */ public bool TelemetryUpload;
        /* 0x62A */ public bool UseSeasonTitleOverride;
    }
}
