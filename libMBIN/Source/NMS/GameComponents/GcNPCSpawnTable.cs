using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A684E5416ADDA01, NameHash = 0xEF1AB4FE11FCFA6D)]
    public class GcNPCSpawnTable : NMSTemplate
    {
        // size: 0x8
        public enum NPCModelNamesEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(NPCModelNamesEnum))]
        /* 0x000 */ public NMSString0x80[] NPCModelNames;
        // size: 0x8
        public enum NPCRaceScaleEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(NPCRaceScaleEnum))]
        /* 0x400 */ public float[] NPCRaceScale;
        /* 0x420 */ public List<GcUniqueNPCSpawnData> UniqueNPCs;
        /* 0x430 */ public List<GcNPCPlacementInfo> PlacementInfos;
    }
}
