using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28C0AACFCC45B57C, NameHash = 0x3C7F32FAD34D5752)]
    public class GcOutpostLSystemPair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Locator;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x20 */ public NMSString0x80[] LSystems;
    }
}
