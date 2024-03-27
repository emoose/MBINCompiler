using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4EAD1F33EAED6BC9, NameHash = 0xE1F35851383555E2)]
    public class GcSentinelCoverComponentData : NMSTemplate
    {
        /* 0x00 */ public float HealthPercLostPerSecMin;
        /* 0x04 */ public float HealthPercLostPerSecMax;
        /* 0x08 */ public NMSString0x10 SpawnEffectId;
        /* 0x18 */ public NMSString0x10 DestroyEffectId;
        /* 0x28 */ public NMSString0x20 EffectLocator;
        [NMS(Size = 0x4, EnumType = typeof(GcSentinelCoverState.SentinelCoverStateEnum))]
        /* 0x48 */ public NMSString0x10[] CoverStateAnims;
    }
}
