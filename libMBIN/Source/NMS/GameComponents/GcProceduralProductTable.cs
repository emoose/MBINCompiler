using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xA8C9EEB7A0BFEBA6)]
    public class GcProceduralProductTable : NMSTemplate
    {
        public List<GcProceduralProductData> Table;
    }
}
