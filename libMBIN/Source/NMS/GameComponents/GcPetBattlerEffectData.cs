namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E658C28E486BECD, NameHash = 0xF38DBF8E)]
    public class GcPetBattlerEffectData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x10 ImpactEffect;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 LaunchEffect;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 ProjectileEffect;
        [NMS(Index = 1)]
        /* 0x30 */ public float LaunchBuildupTime;
        [NMS(Index = 3)]
        /* 0x34 */ public float ProjectileFlightTime;
    }
}
