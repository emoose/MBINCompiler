using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F2AD3267AF1504F, NameHash = 0xB0AEFBA1BDCC6569)]
    public class GcByteBeatIcons : NMSTemplate
    {
        [NMS(Size = 0x12, EnumType = typeof(GcByteBeatToken.ByteBeatTokenEnum))]
        /* 0x000 */ public TkTextureResource[] Icons;
        /* 0x948 */ public TkTextureResource SawTooth;
        /* 0x9CC */ public TkTextureResource Sine;
        /* 0xA50 */ public TkTextureResource Square;
        /* 0xAD4 */ public TkTextureResource Triangle;
    }
}
