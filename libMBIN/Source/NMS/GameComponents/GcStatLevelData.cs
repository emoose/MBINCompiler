using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBAE251674841B75, NameHash = 0xECC1CDECFE5FC437)]
    public class GcStatLevelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A LevelName;
        /* 0x20 */ public NMSString0x20A LevelNameUpper;
        /* 0x40 */ public NMSString0x20A OSDLevelName;
        /* 0x60 */ public GcStatValueData Value;
        /* 0x70 */ public NMSString0x10 TrophyToUnlock;
    }
}
