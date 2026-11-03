using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81200E7E23975916, NameHash = 0x4820DB54)]
    public class GcBiomeCondition : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeType BiomeType;
    }
}
