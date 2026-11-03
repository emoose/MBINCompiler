using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB884C401BBC21F96, NameHash = 0x964497D2)]
    public class GcCreatureGenerationDomainEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFilename File;
        [NMS(Index = 0)]
        /* 0x10 */ public GcCreatureGenerationDensity DensityModifier;
    }
}
