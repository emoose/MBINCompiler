using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x24413570DF127C76)]
    public class GcProductTable : NMSTemplate
    {
        public List<GcProductData> Table;
    }
}
