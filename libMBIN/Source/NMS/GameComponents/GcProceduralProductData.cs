using System.Collections.Generic;

/// <summary>
/// This struct doesn't seem to be in the exe!!!?
/// It has been constructed by looking at the mbin and piecing it together with other structs...
/// HG what you doing?!
/// </summary>
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4C0, GUID = 0x7F0C648A65F82876)]
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
