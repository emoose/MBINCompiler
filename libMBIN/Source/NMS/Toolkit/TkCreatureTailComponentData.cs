using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8B800F0FCBA2ED89, NameHash = 0xB8C7E2CA)]
    public class TkCreatureTailComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkCreatureTailParams DefaultParams;
        [NMS(Index = 3)]
        /* 0x78 */ public List<TkCreatureTailParams> ParamVariations;
        [NMS(Index = 0)]
        /* 0x88 */ public GcPrimaryAxis LengthAxis;
        [NMS(Index = 1)]
        /* 0x8C */ public bool CanUseDefaultParams;
    }
}
