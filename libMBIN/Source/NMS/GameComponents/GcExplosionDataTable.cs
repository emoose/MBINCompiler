using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x52D18849DA636CA4)]
    public class GcExplosionDataTable : NMSTemplate
    {
        public List<GcExplosionData> Table;
    }
}
