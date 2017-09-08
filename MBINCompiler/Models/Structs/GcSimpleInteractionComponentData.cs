using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x118)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        // the custom interactions have been added to allow for exactly that. They are not handled differently by the game files and using them might cause interactions to be a bit... weird...
        public int SimpleInteractionType;
        /* 0x00 */ public string[] SimpleInteractionTypeValues()
        {
            return new[] { "Interact", "Treasure", "Beacon", "Scan", "Save", "CallShip", "CallVehicle", "Word", "Tech", "GenericReward", "Feed",
                "Teleport", "ClaimBase", "TeleportStartPoint", "TeleportEndPoint", "Portal", "Chest", "ResourceHarvester",
                "BaseCapsule", "Hologram", "NPCTerminalMessage", "VehicleBoot", "BiomeHarvester", "FreighterGalacticMap",
                "CUSTOMINTERACTION0", "CUSTOMINTERACTION1", "CUSTOMINTERACTION2", "CUSTOMINTERACTION3", "CUSTOMINTERACTION4"};
        }

        /* 0x04 */ public float InteractDistance;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;

        /* 0x18 */ public GcRarity Rarity;
        /* 0x1C */ public GcSizeIndicator SizeIndicator;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string TriggerAction;
        /* 0x30 */ public bool BroadcastTriggerAction;
        /* 0x34 */ public float Delay;

        /* 0x38 */ public bool InteractIsCrime;
        /* 0x3C */ public int InteractCrimeLevel;
        /* 0x40 */ public GcInteractionActivationCost ActivationCost;

        /* 0x78 */ public GcStatsEnum StatToTrack;        // 8 bytes. Not sure if this is right??
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x7C */ public byte[] Padding7C;

        [NMS(Size = 0x20)]
        /* 0x80 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0xA0 */ public string TerminalMessage;
        [NMS(Size = 0x20)]
        /* 0xC0 */ public string ScanType;
        [NMS(Size = 0x20)]
        /* 0xE0 */ public string ScanData;
        /* 0x100 */ public GcDiscoveryTypes ScanIcon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x104 */ public byte[] Padding104;
        /* 0x108 */ public List<GcBaseBuildingTriggerAction> BaseBuildingTriggerActions;
    }
}
