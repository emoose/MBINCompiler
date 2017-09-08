using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcNPCSpawnTable : NMSTemplate      // size: 0x3C0
    {
        [NMS(Size = 7, EnumValue = new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x000 */ public NMSString0x80[] NPCModelNames;
        [NMS(Size = 7, EnumValue = new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x380 */ public float[] NPCRaceScale;

        /* 0x3A0 */ public List<GcUniqueNPCSpawnData> UniqueNPCs;
        /* 0x3B0 */ public List<GcNPCPlacementInfo> PlacementInfos;
    }
}
