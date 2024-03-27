namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB6F35E6A5707415, NameHash = 0xC652A220FFABA4FE)]
    public class GcProjectileImpactType : NMSTemplate
    {
        // size: 0x12
        public enum ImpactEnum : uint {
            Default,
            Terrain,
            Substance,
            Rock,
            Asteroid,
            Shield,
            Creature,
            Robot,
            Freighter,
            Cargo,
            Ship,
            Plant,
            NeedsTech,
            Player,
            OtherPlayer,
            SentinelShield,
            SpaceshipShield,
            FreighterShield,
        }
        /* 0x0 */ public ImpactEnum Impact;
    }
}
