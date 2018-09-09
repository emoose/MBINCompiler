namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x41BC3C0B86CEBAA0)]
    public class TkRotationComponentData : NMSTemplate
    {
        public float Speed;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        public Vector4f Axis;
    }
}
