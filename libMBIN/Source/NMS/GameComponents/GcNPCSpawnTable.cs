using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE455A41C31AF49CE, NameHash = 0xEF1AB4FE11FCFA6D)]
    public class GcNPCSpawnTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x000 */ public NMSString0x80[] NPCModelNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x400 */ public float[] NPCRaceScale;
        /* 0x420 */ public List<GcUniqueNPCSpawnData> UniqueNPCs;
        /* 0x430 */ public List<GcNPCPlacementInfo> PlacementInfos;
    }
}
