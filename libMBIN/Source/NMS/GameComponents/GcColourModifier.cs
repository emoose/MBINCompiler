using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x114B7C2B8D22F51)]
    public class GcColourModifier : NMSTemplate
    {
        public bool ForceColour;
        [NMS(Size = 0xF, Ignore = true)]
        public byte[] Padding1;
        public Colour ForceColourTo;
        public float OffsetSaturation;
        public float OffsetValue;
        public float MultiplySaturation;
        public float MultiplyValue;
    }
}
