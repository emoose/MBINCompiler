using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4214172204E22DCE, NameHash = 0x40154165764DAC5)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        /* 0x0 */ public List<GcPlayerDamageData> DamageTable;
    }
}
