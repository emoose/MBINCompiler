using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xD103E4E5D1F47380)]
    public class GcPhotoFauna : NMSTemplate
    {
        public short AmountMin;
        public short AmountMax;
        public GcPhotoCreature CreatureArea;
    }
}
