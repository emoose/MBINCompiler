using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD7194FE714CA2ED7, NameHash = 0x4628D51A)]
    public class GcPetBattlerPayloadDoTData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPetBattlerPayloadAffinity Affinity;
        [NMS(Index = 1)]
        /* 0x8 */ public bool ApplyOnTurnBegin;
        [NMS(Index = 2)]
        /* 0x9 */ public bool ApplyOnTurnEnd;
    }
}
