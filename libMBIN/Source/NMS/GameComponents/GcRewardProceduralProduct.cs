using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x28, GUID = 0x249A565C45F7A70C, NameHash = 0x28EDE156F726CF4C)]
    public class GcRewardProceduralProduct : NMSTemplate
    {
        /* 0x00 */ public GcProceduralProductCategory Type;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x20)]
        /* 0x08 */ public string OSDMessage;
    }
}
