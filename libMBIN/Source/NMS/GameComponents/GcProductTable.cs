using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0F4D31B6A5263697)]
    public class GcProductTable : NMSTemplate
    {
        public List<GcProductData> Table;
    }
}
