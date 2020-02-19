using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB0, GUID = 0x129967321DE298AA, NameHash = 0xFFDCD21B79EE81DE)]
    public class GcScreenFilterData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string LocText;
        [NMS(Size = 0x80)]
        /* 0x20 */ public string Filename;
        /* 0xA0 */ public float FadeDistance;
        /* 0xA4 */ public bool SelectableInPhotoMode;
        /* 0xA8 */ public float HdrAreaAdjust;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xAC */ public byte[] EndPadding;
    }
}
