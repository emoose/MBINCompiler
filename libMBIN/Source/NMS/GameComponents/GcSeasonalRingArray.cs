using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x0000000000000000, NameHash = 0x4B1FC18F2123392C)]
    public class GcSeasonalRingArray : NMSTemplate
    {
        public List<GcSeasonalRingData> SeasonalRingData;
    }
}
