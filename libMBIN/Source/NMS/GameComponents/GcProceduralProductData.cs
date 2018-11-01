using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4C0, GUID = 0x34ABCEA46F162515)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcProductData Product;
        [NMS(Size = 0x3)]
        /* 0x3E0 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x488 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4BC */ public byte[] EndPadding;
    }
}
