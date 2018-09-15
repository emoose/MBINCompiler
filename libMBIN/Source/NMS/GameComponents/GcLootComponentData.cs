using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF0E6D81FCD11E097)]
    public class GcLootComponentData : NMSTemplate
    {
        public Vector2f Timed;
        [NMS(Size = 0x10)]
        public string TimeOutEffect;
        public bool DeathPoint;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding19;
    }
}
