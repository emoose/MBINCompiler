using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8B7E882F806EED1, NameHash = 0x9130A310)]
    public class GcPetBattlerMovePhase : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Animation;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSTemplate HitPolicy;
        [NMS(Index = 4)]
        /* 0x20 */ public List<GcPetBattlerMovePayloadItem> PayloadList;
        [NMS(Index = 2)]
        /* 0x30 */ public GcPetBattlerMoveEffect Effect;
        [NMS(Index = 0)]
        /* 0x34 */ public GcPetBattlerPayloadStrength Strength;
    }
}
