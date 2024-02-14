using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A12D8E1FDD5925E, NameHash = 0x40154165764DAC5)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        /* 0x0 */ public List<GcPlayerDamageData> DamageTable;
    }
}
