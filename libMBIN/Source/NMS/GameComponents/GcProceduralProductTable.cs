using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5B70, GUID = 0x1D20382C6544FD00, NameHash = 0x9A0073340429C464)]
    public class GcProceduralProductTable : NMSTemplate
    {
        [NMS(Size = 0xB, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        public GcProceduralProductData[] Table;
    }
}
