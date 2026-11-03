using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA11D6B0293B69B5F, NameHash = 0xD022A151)]
    public class GcGalaxyStarColours : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x0 */ public Colour[] ColourByStarType;
    }
}
