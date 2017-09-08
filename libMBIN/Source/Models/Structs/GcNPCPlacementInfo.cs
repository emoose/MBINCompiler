namespace libMBIN.Models.Structs
{
    public class GcNPCPlacementInfo : NMSTemplate       // size: 0xA0
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string PlacementRuleId;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string SpawnUnderNodeName;
        [NMS(Size = 0x20)]
        /* 0x30 */ public string PlacementNodeName;
        /* 0x50 */ public bool MustPlace;
        /* 0x54 */ public float SpawnChance;
        /* 0x58 */ public float FractionOfNodesActive;
        /* 0x5C */ public int MaxNodesActivated;
        [NMS(Size = 0x10)]
        /* 0x60 */ public string SpawnSpecific;
        /* 0x70 */ public GcAlienRace Race;
        /* 0x74 */ public GcInteractionType InteractionOverride;
        
        [NMS(Size = 0x20)]
        /* 0x78 */ public string ForceInteraction;
        /* 0x98 */ public bool DisableInteraction;
        /* 0x99 */ public bool UseFreighterNPC;
        /* 0x9A */ public bool PlaceAtLeastOne;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x9B */ public byte[] Endpadding;
        
    }
}
