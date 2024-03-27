using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C57930CC9E6FEFB, NameHash = 0x74723646531009E2)]
    public class GcAISpaceshipPreloadCacheData : NMSTemplate
    {
        /* 0x00 */ public GcRealityCommonFactions Faction;
        /* 0x04 */ public GcAISpaceshipRoles ShipRole;
        /* 0x08 */ public GcSpaceshipClasses ShipClass;
        /* 0x0C */ public GcFrigateClass FrigateClass;
        /* 0x10 */ public GcSeed Seed;
        /* 0x20 */ public NMSString0x20A TextureDescriptorHint;
    }
}
