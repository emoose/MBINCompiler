using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2F859649BEC0FAE, NameHash = 0xA69F77FD)]
    public class GcDiscoveryRewardLookup : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public NMSString0x10[] BiomeSpecific;
        [NMS(Index = 0)]
        /* 0x110 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x120 */ public NMSString0x10 Secondary;
    }
}
