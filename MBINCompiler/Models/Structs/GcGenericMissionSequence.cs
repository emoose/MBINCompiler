using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcGenericMissionSequence : NMSTemplate     // size: 0x400
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string MissionID;
        /* 0x010 */ public int MissionClass;
        public string[] MissionClassValues()
        {
            return new[] { "Primary", "Secondary", "ChainedSecondary", "Guide" };
        }

        /* 0x014 */ public bool MissionIsCritical;
        [NMS(Size = 0x20)]
        /* 0x015 */ public string MissionObjective;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x035 */ public byte[] Padding35;

        /* 0x038 */ public GcNumberedTextList MissionTitles;                 // whatever this is it is a 0x20 string followed by the missionpagehint, maybe?
        /* 0x05C */ public GcNumberedTextList MissionSubtitles;
        /* 0x080 */ public GcNumberedTextList MissionDescriptions;
        /* 0x0A4 */ public GcNumberedTextList MissionProcDescriptionHeader;
        /* 0x0C8 */ public GcNumberedTextList MissionProcDescriptionA;
        /* 0x0EC */ public GcNumberedTextList MissionProcDescriptionB;
        /* 0x110 */ public GcNumberedTextList MissionProcDescriptionCs;

        /* 0x134 */ public TkTextureResource MissionIcon;
        /* 0x1B8 */ public TkTextureResource MissionIconSelected;
        /* 0x23C */ public TkTextureResource MissionIconNotSelected;

        /* 0x2C0 */ public int MissionPriority;
        /* 0x2C4 */ public GcMissionCategory MissionCategory;
        /* 0x2C8 */ public GcMissionPageHint MissionPageHint;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2CC */ public byte[] Padding2CC;
        [NMS(Size = 0x20)]
        /* 0x2D0 */ public string MissionPageLocID;

        /* 0x2F0 */ public GcDefaultMissionItemsTable DefaultItems;

        /* 0x330 */ public bool PrefixTitle;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x331 */ public byte[] Padding331;
        [NMS(Size = 0x10)]
        /* 0x338 */ public string NextMissionHint;
        /* 0x348 */ public int MessageComplete;
        public string[] MessageCompleteValues()
        {
            return new[] { "Default", "Always", "Never" };
        }
        /* 0x34C */ public int MessageStart;
        public string[] MessageStartValues()
        {
            return new[] { "Default", "Always", "Never" };
        }

        /* 0x350 */ public GcMissionBoardOptions MissionBoardOptions;

        /* 0x370 */ public int AutoStart;
        public string[] AutoStartValues()
        {
            return new[] { "None", "AllModes", "NotCreative", "Survival", "Creative", "OnSelected"};
        }
        /* 0x374 */ public bool RestartOnCompletion;
        /* 0x375 */ public bool CloseMissionGiver;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x376 */ public byte[] Padding376;

        /* 0x378 */ public List<GcAlienPuzzleEntry> Dialog;
        /* 0x388 */ public List<GcScanEventData> ScanEvents;
        /* 0x398 */ public List<GcGenericRewardTableEntry> Rewards;
        /* 0x3A8 */ public List<GcCostTableEntry> Costs;

        /* 0x3B8 */ public GcMissionConditionTest StartConditionTest;
        /* 0x3BC */ public GcMissionConditionTest CancelConditionTest;  // ?? maybe?
        /* 0x3C0 */ public bool StartIsCancel;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x3C1 */ public byte[] Padding3C1;

        /* 0x3C8 */ public List<NMSTemplate> StartingConditions;
        /* 0x3D8 */ public List<NMSTemplate> CancelingConditions;
        /* 0x3E8 */ public List<NMSTemplate> NotificationSequence;
        /* 0x3F8 */ public bool IsProceduralAllowed;

        [NMS(Size = 0x7, Ignore = true)]
        /* 0x3F9 */ public byte[] EndPadding;
    }
}
