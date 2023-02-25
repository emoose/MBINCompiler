using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5D439E96EBCE89D, NameHash = 0xFAE86B2801335B6D)]
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
        /* 0x388 */ public bool PrefixTitle;
        /* 0x390 */ public NMSString0x10 NextMissionHint;
        // size: 0x3
        public enum MessageCompleteEnum : uint {
            Default,
            Always,
            Never,
        }
        /* 0x3A0 */ public MessageCompleteEnum MessageComplete;
        // size: 0x3
        public enum MessageStartEnum : uint {
            Default,
            Always,
            Never,
        }
        /* 0x3A4 */ public MessageStartEnum MessageStart;
        /* 0x3A8 */ public GcMissionBoardOptions MissionBoardOptions;
        // size: 0x4
        public enum AutoStartEnum : uint {
            None,
            AllModes,
            Seasonal,
            OnSelected,
        }
        /* 0x428 */ public AutoStartEnum AutoStart;
        /* 0x42C */ public bool RestartOnCompletion;
        /* 0x42D */ public bool CancelSetsComplete;
        /* 0x430 */ public GcAlienPuzzleTable Dialog;
        /* 0x440 */ public List<GcScanEventData> ScanEvents;
        /* 0x450 */ public List<GcGenericRewardTableEntry> Rewards;
        /* 0x460 */ public List<GcCostTableEntry> Costs;
        /* 0x470 */ public GcTradeData TradingDataOverride;
        /* 0x540 */ public GcMissionConditionTest StartConditionTest;
        /* 0x544 */ public GcMissionConditionTest CancelConditionTest;
        /* 0x548 */ public bool StartIsCancel;
        /* 0x550 */ public List<NMSTemplate> StartingConditions;
        /* 0x560 */ public List<NMSTemplate> CancelingConditions;
        /* 0x570 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        /* 0x580 */ public List<GcGenericMissionStage> Stages;
        /* 0x590 */ public bool ForcesPageHint;
        /* 0x591 */ public bool ForcesBuildMenuHint;
        /* 0x592 */ public bool IsProceduralAllowed;
        /* 0x593 */ public bool IsRecurring;
        /* 0x594 */ public bool IsLegacy;
        /* 0x595 */ public bool BlocksPinning;
        /* 0x596 */ public bool CanRenounce;
        /* 0x598 */ public NMSString0x10 UseCommunityMissionForLog;
        /* 0x5A8 */ public bool TelemetryUpload;
        /* 0x5A9 */ public bool UseSeasonTitleOverride;
    }
}
