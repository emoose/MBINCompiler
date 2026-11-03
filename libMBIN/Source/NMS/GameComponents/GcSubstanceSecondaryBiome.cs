using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAFDD8C49CEF5BE0, NameHash = 0xA368BE81)]
    public class GcSubstanceSecondaryBiome : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0 */ public GcSubstanceSecondary[] SecondarySubstanceByBiome;
    }
}
