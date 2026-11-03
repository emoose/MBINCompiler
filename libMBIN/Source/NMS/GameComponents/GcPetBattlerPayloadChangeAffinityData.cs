using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDBE73CA540BDBD01, NameHash = 0xA5AD0897)]
    public class GcPetBattlerPayloadChangeAffinityData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPetBattlerPayloadAffinity Affinity;
    }
}
