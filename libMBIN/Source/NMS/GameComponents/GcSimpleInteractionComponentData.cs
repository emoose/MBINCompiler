using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x138, GUID = 0x373A2CB133B33962)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
		public enum SimpleInteractionTypeEnum { Interact, Treasure, Beacon, Scan, Save, CallShip, CallVehicle, Word, Tech, GenericReward, Feed, Ladder,
            ClaimBase, TeleportStartPoint, TeleportEndPoint, Portal, Chest, ResourceHarvester, BaseCapsule, Hologram, NPCTerminalMessage, VehicleBoot,
            BiomeHarvester, FreighterGalacticMap, FreighterChest }
		/* 0x00 */ public SimpleInteractionTypeEnum SimpleInteractionType;

        /* 0x04 */ public float InteractDistance;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;

        /* 0x18 */ public GcRarity Rarity;
        /* 0x1C */ public GcSizeIndicator Size;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string TriggerAction;
        /* 0x30 */ public bool BroadcastTriggerAction;
        /* 0x34 */ public float Delay;
        /* 0x38 */ public bool HideContents;
        /* 0x39 */ public bool InteractIsCrime;
        /* 0x3C */ public GcFiendCrime InteractFiendCrimeType;
        /* 0x40 */ public int InteractCrimeLevel;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x44 */ public byte[] Padding44;
        /* 0x48 */ public GcInteractionActivationCost ActivationCost;

        /* 0x80 */ public GcStatsEnum StatToTrack;
        /* 0x84 */ public bool StartsBuried;
        /* 0x85 */ public bool MustBeVisibleToInteract;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x86 */ public byte[] Padding86;

        [NMS(Size = 0x20)]
        /* 0x88 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0xA8 */ public string TerminalMessage;
        [NMS(Size = 0x20)]
        /* 0xC8 */ public string ScanType;
        [NMS(Size = 0x20)]
        /* 0xE8 */ public string ScanData;
        /* 0x108 */ public GcDiscoveryTypes ScanIcon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x10C */ public byte[] Padding10C;
        /* 0x110 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        /* 0x120 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x130 */ public bool UsePersonalPersistentBuffer;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x131 */ public byte[] EndPadding;
    }
}
