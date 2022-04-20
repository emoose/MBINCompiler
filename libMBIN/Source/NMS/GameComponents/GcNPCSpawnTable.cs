using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x440, GUID = 0x5C0B33E825347A4D, NameHash = 0xEF1AB4FE11FCFA6D)]
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
