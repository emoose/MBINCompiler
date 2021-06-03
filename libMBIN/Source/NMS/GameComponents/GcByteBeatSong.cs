using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x260, Alignment = 0x8, GUID = 0x7C7F71709B8330B7, NameHash = 0xDC95ACD037A3B77)]
    public class GcByteBeatSong : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 RequiredSpecialId;
        /* 0x20 */ public NMSString0x20 Name;
        /* 0x40 */ public NMSString0x20A LocID;
        [NMS(Size = 0x8)]
        /* 0x60 */ public NMSString0x40[] Data;
    }
}
