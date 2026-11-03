using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF130CB9F2CC0AC3, NameHash = 0x79D7BFEB)]
    public class GcPetBattlerPayloadDealDamageData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPetBattlerPayloadAffinity Affinity;
    }
}
