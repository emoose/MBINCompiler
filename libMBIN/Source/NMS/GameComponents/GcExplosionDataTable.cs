using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC11B6139AA2C986E)]
    public class GcExplosionDataTable : NMSTemplate
    {
        public List<GcExplosionData> Table;
    }
}
