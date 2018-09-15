using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xE39536D6A25C5F9)]
    public class TkAnimPoseCorrelationData : NMSTemplate // 0x28 bytes
    {
        [NMS(Size = 0x10)]
        public string ItemA;
        [NMS(Size = 0x10)]
        public string ItemB;
        public float Correlation;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding24;
    }
}
