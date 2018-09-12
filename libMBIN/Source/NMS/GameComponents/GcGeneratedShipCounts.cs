using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x3EAE70796B38879D)]
    public class GcGeneratedShipCounts : NMSTemplate
    {
        [NMS(Size = 0x6)]
        public int[] Counts;
    }
}