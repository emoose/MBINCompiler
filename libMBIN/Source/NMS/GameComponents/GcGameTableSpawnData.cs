using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB09A2AEA4FAF2C16, NameHash = 0x10947519)]
    public class GcGameTableSpawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 3)]
        /* 0x20 */ public List<GcGameTableNPCSpawnData> NPCSpawns;
        [NMS(Index = 2)]
        /* 0x30 */ public GcFilename SceneFilename;
        [NMS(Index = 1)]
        /* 0x40 */ public bool AllowedInAbandonedSystems;
    }
}
