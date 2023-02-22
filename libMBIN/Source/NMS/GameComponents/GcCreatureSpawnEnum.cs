namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4D3D498FA5EAF4B, NameHash = 0xF1142B73FBEC2939)]
    public class GcCreatureSpawnEnum : NMSTemplate
    {
        // size: 0x1A
        public enum IncrementorEnum {
            None,
            Resource,
            ResourceAway,
            HeavyAir,
            Drone,
            Deer,
            DeerScan,
            DeerWords,
            DeerWordsAway,
            Diplo,
            DiploScan,
            DiploWords,
            DiploWordsAway,
            Flyby,
            Beast,
            Wingmen,
            Scouts,
            Fleet,
            Attackers,
            AttackersFromBehind,
            Flee,
            RemoveFleet,
            Fighters,
            PostFighters,
            Escape,
            Warp,
        }
        /* 0x0 */ public IncrementorEnum Incrementor;
    }
}
