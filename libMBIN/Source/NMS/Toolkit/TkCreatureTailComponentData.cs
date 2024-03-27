using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x38F8BA7B7D94CFC6, NameHash = 0x787641F134B1AFBD)]
    public class TkCreatureTailComponentData : NMSTemplate
    {
        /* 0x00 */ public GcPrimaryAxis LengthAxis;
        /* 0x04 */ public bool CanUseDefaultParams;
        /* 0x08 */ public TkCreatureTailParams DefaultParams;
        /* 0x78 */ public List<TkCreatureTailParams> ParamVariations;
    }
}
