using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0x387E3703B4CDF8A3, NameHash = 0xF9FB8E431EB1179F)]
    public class GcExplosionDataTable : NMSTemplate
    {
        public NMSString0x80 Name;
        public List<GcExplosionData> Table;
    }
}
