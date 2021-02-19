using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xFF71B6F7256E9F22, NameHash = 0x7A62ED648FC514F7)]
    public class GcProductTable : NMSTemplate
    {
        public List<GcProductData> Table;
    }
}