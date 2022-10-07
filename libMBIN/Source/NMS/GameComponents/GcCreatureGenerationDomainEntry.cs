using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1B4D7D91BC2E2B4, NameHash = 0x79E2609CF7F155CE)]
    public class GcCreatureGenerationDomainEntry : NMSTemplate
    {
        /* 0x0 */ public GcCreatureGenerationDensity DensityModifier;
        /* 0x4 */ public NMSString0x80 File;
    }
}
