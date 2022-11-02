using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9992C38CFA225CBC, NameHash = 0xF53E6F170BCA9237)]
    public class GcHeavyAirSettingValues : NMSTemplate
    {
        /* 0x00 */ public float Thickness;
        /* 0x04 */ public float Speed;
        /* 0x08 */ public float Alpha1;
        /* 0x0C */ public float Alpha2;
        /* 0x10 */ public TkPaletteTexture Colour1;
        /* 0x18 */ public TkPaletteTexture Colour2;
    }
}
