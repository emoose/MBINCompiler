using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x20, Alignment = 0x10, GUID = 0x41BC3C0B86CEBAA0, NameHash = 0xB808E542DB69E5FE)]
    public class TkRotationComponentData : NMSTemplate
    {
        /* 0x00 */ public float Speed;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x10 */ public Vector4f Axis;
    }
}
