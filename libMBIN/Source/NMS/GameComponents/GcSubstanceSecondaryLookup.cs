using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6D1A7B47F42D3C7, NameHash = 0x5AF4540465F27753)]
    public class GcSubstanceSecondaryLookup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PrimaryID;
        /* 0x10 */ public List<GcSubstanceSecondary> SecondaryChances;
    }
}
