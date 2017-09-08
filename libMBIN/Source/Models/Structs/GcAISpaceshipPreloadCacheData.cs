namespace libMBIN.Models.Structs
{
    public class GcAISpaceshipPreloadCacheData : NMSTemplate        // size: 0x20
    {
        /* 0x00 */ public GcRealityCommonFactions Faction;
        /* 0x04 */ public GcAISpaceshipRoles ShipRole;
        /* 0x08 */ public GcSpaceshipClasses ShipClass;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;

        public GcSeed Seed;
    }
}
