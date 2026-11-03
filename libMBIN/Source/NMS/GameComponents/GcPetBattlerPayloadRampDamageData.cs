using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7981A198C018EC59, NameHash = 0x29D4D66F)]
    public class GcPetBattlerPayloadRampDamageData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPetBattlerPayloadAffinity Affinity;
        [NMS(Index = 1)]
        /* 0x8 */ public bool ApplyTheDamage;
        [NMS(Index = 2)]
        /* 0x9 */ public bool BuildTheCharge;
    }
}
