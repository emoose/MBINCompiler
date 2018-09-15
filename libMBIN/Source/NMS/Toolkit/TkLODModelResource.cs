using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x8C, GUID = 0xB8D561F082A01C10)]
    public class TkLODModelResource : NMSTemplate
    {
        /* 0x00 */ public TkModelResource LODModel;
        /* 0x84 */ public float CrossFadeTime;
        /* 0x88 */ public float CrossFadeOverlap;
    }
}
