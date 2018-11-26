using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xABC096FCF4596D62)]
    public class GcCreatureCrystalMovementData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureCrystalBiomeMovementData> BiomeParams;
    }
}
