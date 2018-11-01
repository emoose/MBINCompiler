using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3C0, GUID = 0xA0227D35EC592CE6)]
    public class GcNPCSpawnTable : NMSTemplate
    {
        [NMS(Size = 7, EnumValue = new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x000 */ public NMSString0x80[] NPCModelNames;
        [NMS(Size = 7, EnumValue = new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x380 */ public float[] NPCRaceScale;

        /* 0x3A0 */ public List<GcUniqueNPCSpawnData> UniqueNPCs;
        /* 0x3B0 */ public List<GcNPCPlacementInfo> PlacementInfos;
    }
}
