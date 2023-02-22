namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B2046067B91DF22, NameHash = 0xC652A220FFABA4FE)]
    public class GcProjectileImpactType : NMSTemplate
    {
        // size: 0x11
        public enum ImpactEnum {
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
        }
        /* 0x0 */ public ImpactEnum Impact;
    }
}
