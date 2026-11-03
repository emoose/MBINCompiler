using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89A0A9D949E7C71D, NameHash = 0xD25823AF)]
    public class GcDamageMultiplierLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcDamageMultiplier> Multipliers;
        [NMS(Index = 1)]
        /* 0x20 */ public float Default;
    }
}
