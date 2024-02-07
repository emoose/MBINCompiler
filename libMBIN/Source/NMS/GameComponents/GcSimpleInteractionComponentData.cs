using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB584181F03B9E004, NameHash = 0xEAE36C86E1479AF5)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        // size: 0x24
        public enum SimpleInteractionTypeEnum : uint {
            Interact,
            Treasure,
            Beacon,
            Scan,
            Save,
            CallShip,
            CallVehicle,
            Word,
            Tech,
            GenericReward,
            Feed,
            Ladder,
            ClaimBase,
            TeleportStartPoint,
            TeleportEndPoint,
            Portal,
            Chest,
            ResourceHarvester,
            BaseCapsule,
            Hologram,
            NPCTerminalMessage,
            VehicleBoot,
            BiomeHarvester,
            FreighterGalacticMap,
            FreighterChest,
            Collectable,
            Chair,
            BaseTreasureChest,
            SpawnObject,
            NoiseBox,
            AbandFreighterTeleporter,
            PetEgg,
            SubstancePickup,
            FreighterTeleport,
            MiniPortalTrigger,
            SuperDoopaScanner,
        }
        /* 0x000 */ public SimpleInteractionTypeEnum SimpleInteractionType;
        /* 0x004 */ public float InteractDistance;
        /* 0x008 */ public bool Use2dInteractDistance;
        /* 0x010 */ public NMSString0x10 Id;
        /* 0x020 */ public GcRarity Rarity;
        /* 0x024 */ public GcSizeIndicator Size;
        /* 0x028 */ public NMSString0x10 TriggerAction;
        /* 0x038 */ public NMSString0x10 TriggerActionOnPrepare;
        /* 0x048 */ public NMSString0x10 TriggerActionToggle;
        /* 0x058 */ public bool BroadcastTriggerAction;
        /* 0x05C */ public float Delay;
        /* 0x060 */ public bool HideContents;
        /* 0x061 */ public bool InteractIsCrime;
        /* 0x064 */ public GcFiendCrime InteractFiendCrimeType;
        /* 0x068 */ public float InteractFiendCrimeChance;
        /* 0x06C */ public int InteractCrimeLevel;
        /* 0x070 */ public int IncreaseCorruptSentinelWanted;
        /* 0x074 */ public bool NotifyEncounter;
        /* 0x078 */ public GcInteractionActivationCost ActivationCost;
        /* 0x0E0 */ public GcStatsEnum StatToTrack;
        /* 0x0E4 */ public bool StartsBuried;
        /* 0x0E5 */ public bool MustBeVisibleToInteract;
        /* 0x0E6 */ public bool NeedsStorm;
        /* 0x0E8 */ public NMSString0x20A Name;
        /* 0x108 */ public NMSString0x20A VRInteractMessage;
        /* 0x128 */ public NMSString0x20A TerminalHeading;
        /* 0x148 */ public NMSString0x20A TerminalMessage;
        /* 0x168 */ public NMSString0x20A ScanType;
        /* 0x188 */ public NMSString0x20A ScanData;
        /* 0x1A8 */ public GcDiscoveryType ScanIcon;
        /* 0x1AC */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1B0 */ public NMSString0x10[] RarityLocators;
        /* 0x1E0 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        /* 0x1F0 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x200 */ public List<GcPersistencyMissionOverride> PersistencyBufferOverride;
        /* 0x210 */ public bool UsePersonalPersistentBuffer;
        /* 0x211 */ public bool ReseedOnRewardSuccess;
        /* 0x212 */ public bool CanCollectInMech;
    }
}
