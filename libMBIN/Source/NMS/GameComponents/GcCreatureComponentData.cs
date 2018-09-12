using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0CCC237984F4D9D40)]
    public class GcCreatureComponentData : NMSTemplate      // size: 0x18
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcPrimaryAxis Axis;
        public float Scaler;
    }
}
