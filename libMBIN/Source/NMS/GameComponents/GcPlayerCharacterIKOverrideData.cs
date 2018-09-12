using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x28A5F0DD7B123C68)]
    public class GcPlayerCharacterIKOverrideData : NMSTemplate
    {
        public bool Enabled;
        public float Strength;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding8;
        public Vector4f RotStrengths;
    }
}
