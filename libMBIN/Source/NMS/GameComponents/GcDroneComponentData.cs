using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0x70EF540613FC0A4D, NameHash = 0xE4A9F22B5EB5CBF8)]
    public class GcDroneComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public GcPrimaryAxis PrimaryAxis;
        /* 0x14 */ public float Scaler;
        /* 0x18 */ public GcCreatureHealthData Health;
    }
}
