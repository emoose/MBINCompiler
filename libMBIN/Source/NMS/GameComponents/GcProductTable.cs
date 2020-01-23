using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA213AD6C8F4750F5, NameHash = 0x7A62ED648FC514F7)]
    public class GcProductTable : NMSTemplate
    {
        public List<GcProductData> Table;
    }
}
