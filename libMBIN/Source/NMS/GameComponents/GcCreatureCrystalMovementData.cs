using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x147DDDD1F7BE314B, NameHash = 0x46EB806ED8904120)]
    public class GcCreatureCrystalMovementData : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureCrystalMovementDataParams> Params;
    }
}
