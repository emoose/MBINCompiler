namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD12B8EA6BDF5A800, NameHash = 0xF561A1A1)]
    public class GcPetBattlerHitStandard : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float MissChanceModifier;
        [NMS(Index = 1)]
        /* 0x4 */ public bool MissChanceAffectsPayloadScore;
    }
}
