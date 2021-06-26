using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xB298C5330E3BC5AB, NameHash = 0x7A62ED648FC514F7)]
    public class GcProductTable : NMSTemplate
    {
        public List<GcProductData> Table;
    }
}