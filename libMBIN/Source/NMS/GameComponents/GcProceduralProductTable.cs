using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x41D2B747BA8E5D04)]
    public class GcProceduralProductTable : NMSTemplate
    {
        public List<GcProceduralProductData> Table;
    }
}
