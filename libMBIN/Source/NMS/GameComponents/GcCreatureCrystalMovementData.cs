using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x592C060689E4A018, NameHash = 0x46EB806ED8904120)]
    public class GcCreatureCrystalMovementData : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureCrystalMovementDataParams> Params;
    }
}
