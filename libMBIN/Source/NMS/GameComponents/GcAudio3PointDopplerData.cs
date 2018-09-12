using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x12CAE7C5B1936243)]
    public class GcAudio3PointDopplerData : NMSTemplate
    {
        /* 0x0 */ public float Front;
		/* 0x4 */ public float Mid;
		/* 0x8 */ public float Rear;
    }
}
