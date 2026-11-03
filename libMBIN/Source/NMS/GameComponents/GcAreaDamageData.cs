namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x193D92C5B64E5BB4, NameHash = 0x65EC65D4)]
    public class GcAreaDamageData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 PlayerDamageId;
        [NMS(Index = 4)]
        /* 0x20 */ public float Damage;
        [NMS(Index = 2)]
        /* 0x24 */ public float DelayPerMetre;
        [NMS(Index = 8)]
        /* 0x28 */ public float PhysicsPushForce;
        [NMS(Index = 1)]
        /* 0x2C */ public float Radius;
        [NMS(Index = 7)]
        /* 0x30 */ public bool DamageCreatures;
        [NMS(Index = 6)]
        /* 0x31 */ public bool DamagePlayers;
        [NMS(Index = 5)]
        /* 0x32 */ public bool InstantKill;
    }
}
