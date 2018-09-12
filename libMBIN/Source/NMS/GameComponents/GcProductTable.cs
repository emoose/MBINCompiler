using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F4D31B6A5263697)]
    public class GcProductTable : NMSTemplate
    {
        public List<GcProductData> Table;
    }
}
