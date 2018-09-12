using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x421E242C08182A98)]
    public class GcCreatureDataTable : NMSTemplate
    {
        public List<GcCreatureData> Table;
    }
}
