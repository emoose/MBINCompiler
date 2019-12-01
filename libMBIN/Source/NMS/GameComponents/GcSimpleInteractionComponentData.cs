using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x1B8, GUID = 0xA071AC732FC7F531, NameHash = 0xEAE36C86E1479AF5)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        // 0x1E entries
		public enum SimpleInteractionTypeEnum { Interact, Treasure, Beacon, Scan, Save, CallShip, CallVehicle, Word, Tech, GenericReward, Feed, Ladder, ClaimBase, TeleportStartPoint,
            TeleportEndPoint, Portal, Chest, ResourceHarvester, BaseCapsule, Hologram, NPCTerminalMessage, VehicleBoot, BiomeHarvester, FreighterGalacticMap, FreighterChest,
            Collectable, Chair, BaseTreasureChest, SpawnObject, NoiseBox }
		/* 0x00 */ public SimpleInteractionTypeEnum SimpleInteractionType;

        /* 0x04 */ public float InteractDistance;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;

        /* 0x18 */ public GcRarity Rarity;
        /* 0x1C */ public GcSizeIndicator Size;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string TriggerAction;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string TriggerActionOnPrepare;
        [NMS(Size = 0x10)]
        /* 0x40 */ public string TriggerActionToggle;
        /* 0x50 */ public bool BroadcastTriggerAction;
        /* 0x54 */ public float Delay;
        /* 0x58 */ public bool HideContents;
        /* 0x59 */ public bool InteractIsCrime;
        /* 0x5C */ public GcFiendCrime InteractFiendCrimeType;
        /* 0x60 */ public int InteractCrimeLevel;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x64 */ public byte[] Padding64;
        /* 0x68 */ public GcInteractionActivationCost ActivationCost;

        /* 0xA0 */ public GcStatsEnum StatToTrack;
        /* 0xA4 */ public bool StartsBuried;
        /* 0xA5 */ public bool MustBeVisibleToInteract;
        /* 0xA6 */ public bool NeedsStorm;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0xA7 */ public byte[] PaddingA7;

        [NMS(Size = 0x20)]
        /* 0xA8 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0xC8 */ public string VRInteractMessage;
        [NMS(Size = 0x20)]
        /* 0xE8 */ public string TerminalMessage;
        [NMS(Size = 0x20)]
        /* 0x108 */ public string ScanType;
        [NMS(Size = 0x20)]
        /* 0x128 */ public string ScanData;
        /* 0x148 */ public GcDiscoveryTypes ScanIcon;
        /* 0x14C */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x14D */ public byte[] Padding13D;
        [NMS(Size = 0x3)]
        /* 0x150 */ public NMSString0x10[] RarityLocators;
        /* 0x180 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        /* 0x190 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x1A0 */ public List<GcPersistencyMissionOverride> PersistencyBufferOverride;
        /* 0x1B0 */ public bool UsePersonalPersistentBuffer;
        /* 0x1B1 */ public bool ReseedOnRewardSuccess;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x1B2 */ public byte[] EndPadding;
    }
}
