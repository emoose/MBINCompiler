using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC, GUID = 0x0000000000000000, NameHash = 0x772BC47975467C69)]
    public class GcSeasonalRingData : NMSTemplate
    {
        public float RingSize;
        public float RingOpacity;
        public float CoreOpacity;
    }
}
