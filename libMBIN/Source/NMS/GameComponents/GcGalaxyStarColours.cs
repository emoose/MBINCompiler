using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE980B433FDF773FA, NameHash = 0xE4AFCD52DEB8A62F)]
    public class GcGalaxyStarColours : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x0 */ public Colour[] ColourByStarType;
    }
}
