using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C0, Alignment = 0x8, GUID = 0x27B5D767424493C9, NameHash = 0xEAE36C86E1479AF5)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        // 0x20 entries
		public enum SimpleInteractionTypeEnum {
            Interact, Treasure, Beacon, Scan, Save, CallShip, CallVehicle, Word, Tech, GenericReward,
            Feed, Ladder, ClaimBase, TeleportStartPoint, TeleportEndPoint, Portal, Chest, ResourceHarvester, BaseCapsule, Hologram,
            NPCTerminalMessage, VehicleBoot, BiomeHarvester, FreighterGalacticMap, FreighterChest, Collectable, Chair, BaseTreasureChest, SpawnObject, NoiseBox,
            AbandFreighterTeleporter, PetEgg, SubstancePickup
        }
		/* 0x00 */ public SimpleInteractionTypeEnum SimpleInteractionType;
        /* 0x04 */ public float InteractDistance;
        /* 0x08 */ public bool Use2dInteractDistance;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x09 */ public byte[] Padding9;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string Id;
        /* 0x20 */ public GcRarity Rarity;
        /* 0x24 */ public GcSizeIndicator Size;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string TriggerAction;
        [NMS(Size = 0x10)]
        /* 0x38 */ public string TriggerActionOnPrepare;
        [NMS(Size = 0x10)]
        /* 0x48 */ public string TriggerActionToggle;
        /* 0x58 */ public bool BroadcastTriggerAction;
        /* 0x5C */ public float Delay;
        /* 0x60 */ public bool HideContents;
        /* 0x61 */ public bool InteractIsCrime;
        /* 0x64 */ public GcFiendCrime InteractFiendCrimeType;
        /* 0x68 */ public int InteractCrimeLevel;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x6C */ public byte[] Padding6C;
        /* 0x70 */ public GcInteractionActivationCost ActivationCost;
        /* 0xA8 */ public GcStatsEnum StatToTrack;
        /* 0xAC */ public bool StartsBuried;
        /* 0xAD */ public bool MustBeVisibleToInteract;
        /* 0xAE */ public bool NeedsStorm;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0xAF */ public byte[] PaddingAF;
        [NMS(Size = 0x20)]
        /* 0xB0 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0xD0 */ public string VRInteractMessage;
        [NMS(Size = 0x20)]
        /* 0xF0 */ public string TerminalMessage;
        [NMS(Size = 0x20)]
        /* 0x110 */ public string ScanType;
        [NMS(Size = 0x20)]
        /* 0x130 */ public string ScanData;
        /* 0x150 */ public GcDiscoveryTypes ScanIcon;
        /* 0x154 */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x155 */ public byte[] Padding13D;
        [NMS(Size = 0x3)]
        /* 0x158 */ public NMSString0x10[] RarityLocators;
        /* 0x188 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        /* 0x198 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x1A8 */ public List<GcPersistencyMissionOverride> PersistencyBufferOverride;
        /* 0x1B8 */ public bool UsePersonalPersistentBuffer;
        /* 0x1B9 */ public bool ReseedOnRewardSuccess;
        /* 0x1BA */ public bool CanCollectInMech;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x1BB */ public byte[] EndPadding;
    }
}
