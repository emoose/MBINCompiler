using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C160C2ACF140D66A)]
    public class GcExplosionDataTable : NMSTemplate
    {
        public List<GcExplosionData> Table;
    }
}
