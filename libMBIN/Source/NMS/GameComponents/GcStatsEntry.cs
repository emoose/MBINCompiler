using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB353F457EF11C4EF, NameHash = 0x4309D65C13EEC689)]
    public class GcStatsEntry : NMSTemplate
    {
        /* 0x00 */ public GcStatsTypes Type;
        /* 0x10 */ public Colour Colour;
        /* 0x20 */ public float RangeMin;
        /* 0x24 */ public float RangeMax;
        /* 0x28 */ public bool LessIsBetter;
        /* 0x30 */ public NMSString0x10 BaseTechID;
    }
}
