using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x145858E7D95F4962)]
    public class GcExplosionDataTable : NMSTemplate
    {
        public List<GcExplosionData> Table;
    }
}
