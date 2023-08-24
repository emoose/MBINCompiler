using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33DD87693095B1BD, NameHash = 0xFAE86B2801335B6D)]
    public class GcGenericMissionSequence : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 MissionID;
        // size: 0x7
        public enum MissionClassEnum : uint {
            Primary,
            Secondary,
            ChainedSecondary,
            Guide,
            Wiki,
            Seasonal,
            Milestone,
        }
        /* 0x010 */ public MissionClassEnum MissionClass;
        /* 0x014 */ public bool MissionIsCritical;
        /* 0x015 */ public NMSString0x20 MissionObjective;
        /* 0x038 */ public GcNumberedTextList MissionTitles;
        /* 0x05C */ public GcNumberedTextList MissionSubtitles;
        /* 0x080 */ public GcNumberedTextList MissionDescriptions;
        /* 0x0A4 */ public NMSString0x20 MissionDescSwitchOverride;
        /* 0x0C4 */ public GcNumberedTextList MissionProcDescriptionHeader;
        /* 0x0E8 */ public GcNumberedTextList MissionProcDescriptionA;
        /* 0x10C */ public GcNumberedTextList MissionProcDescriptionB;
        /* 0x130 */ public GcNumberedTextList MissionProcDescriptionC;
        /* 0x154 */ public bool UseScanEventDetailsInLogInfo;
        /* 0x158 */ public TkTextureResource MissionIcon;
        /* 0x1DC */ public TkTextureResource MissionIconSelected;
        /* 0x260 */ public TkTextureResource MissionIconNotSelected;
        /* 0x2E4 */ public int MissionPriority;
        /* 0x2E8 */ public GcMissionCategory MissionCategory;
        /* 0x2EC */ public GcMissionPageHint MissionPageHint;
        /* 0x2F0 */ public NMSString0x20A MissionPageLocID;
        /* 0x310 */ public NMSString0x10 MissionBuildMenuHint;
        /* 0x320 */ public bool MissionHasColourOverride;
        /* 0x330 */ public Colour MissionColourOverride;
        /* 0x340 */ public int BeginCheckFrequency;
        /* 0x348 */ public GcDefaultMissionItemsTable DefaultItems;
        /* 0x398 */ public bool PrefixTitle;
        /* 0x3A0 */ public NMSString0x10 NextMissionHint;
        // size: 0x3
        public enum MessageCompleteEnum : uint {
            Default,
            Always,
            Never,
        }
        /* 0x3B0 */ public MessageCompleteEnum MessageComplete;
        // size: 0x3
        public enum MessageStartEnum : uint {
            Default,
            Always,
            Never,
        }
        /* 0x3B4 */ public MessageStartEnum MessageStart;
        /* 0x3B8 */ public GcMissionBoardOptions MissionBoardOptions;
        // size: 0x4
        public enum AutoStartEnum : uint {
            None,
            AllModes,
            Seasonal,
            OnSelected,
        }
        /* 0x438 */ public AutoStartEnum AutoStart;
        /* 0x43C */ public bool RestartOnCompletion;
        /* 0x43D */ public bool CancelSetsComplete;
        /* 0x440 */ public GcAlienPuzzleTable Dialog;
        /* 0x450 */ public List<GcScanEventData> ScanEvents;
        /* 0x460 */ public List<GcGenericRewardTableEntry> Rewards;
        /* 0x470 */ public List<GcCostTableEntry> Costs;
        /* 0x480 */ public GcTradeData TradingDataOverride;
        /* 0x550 */ public GcMissionConditionTest StartConditionTest;
        /* 0x554 */ public GcMissionConditionTest CancelConditionTest;
        /* 0x558 */ public bool StartIsCancel;
        /* 0x560 */ public List<NMSTemplate> StartingConditions;
        /* 0x570 */ public List<NMSTemplate> CancelingConditions;
        /* 0x580 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        /* 0x590 */ public List<GcGenericMissionStage> Stages;
        /* 0x5A0 */ public bool ForcesPageHint;
        /* 0x5A1 */ public bool ForcesBuildMenuHint;
        /* 0x5A2 */ public bool IsProceduralAllowed;
        /* 0x5A3 */ public bool IsRecurring;
        /* 0x5A4 */ public bool IsLegacy;
        /* 0x5A5 */ public bool BlocksPinning;
        /* 0x5A6 */ public bool CanRenounce;
        /* 0x5A8 */ public NMSString0x10 UseCommunityMissionForLog;
        /* 0x5B8 */ public bool TelemetryUpload;
        /* 0x5B9 */ public bool UseSeasonTitleOverride;
    }
}
