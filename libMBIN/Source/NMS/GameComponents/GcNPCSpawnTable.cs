using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x64AD3242B026EB72, NameHash = 0xEF1AB4FE11FCFA6D)]
    public class GcNPCSpawnTable : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x000 */ public NMSString0x80[] NPCModelNames;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x480 */ public float[] NPCRaceScale;
        /* 0x4A8 */ public List<GcUniqueNPCSpawnData> UniqueNPCs;
        /* 0x4B8 */ public List<GcNPCPlacementInfo> PlacementInfos;
    }
}
