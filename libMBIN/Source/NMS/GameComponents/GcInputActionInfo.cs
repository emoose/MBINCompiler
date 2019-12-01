using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x290, GUID = 0x800C6BACE678BE27, NameHash = 0x793BE7AABA010DFF)]
    public class GcInputActionInfo : NMSTemplate
    {
        /* 0x000 */ public bool Analogue;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x001 */ public byte[] Padding1;
        /* 0x004 */ public GcInputActions Pairing;
        [NMS(Size = 0x80)]
        /* 0x008 */ public string TextTag;
        [NMS(Size = 0x20)]
        /* 0x088 */ public string LocTag;
        [NMS(Size = 0x80)]
        /* 0x0A8 */ public string SolidIcon;
        [NMS(Size = 0x80)]
        /* 0x128 */ public string OverlayIcon;
        [NMS(Size = 0x80)]
        /* 0x1A8 */ public string SpecialIcon;
        [NMS(Size = 0x20)]
        /* 0x228 */ public string ExternalId;
        [NMS(Size = 0x20)]
        /* 0x248 */ public string ExternalLoc;
        [NMS(Size = 0x20)]
        /* 0x268 */ public string ExternalDigitalAliasId;
        public enum InputActionInfoFlagsEnum { None = 0x0, HideInControlsPage = 0x1, OnlyVR = 0x2, OnlyNonVR = 0x4 }
        /* 0x288 */ public InputActionInfoFlagsEnum InputActionInfoFlags;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x28C */ public byte[] EndPadding;
    }
}
