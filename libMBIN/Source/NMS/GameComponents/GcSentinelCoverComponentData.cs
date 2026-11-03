using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5AB310C32C04B2E6, NameHash = 0x351CFA91)]
    public class GcSentinelCoverComponentData : NMSTemplate
    {
        [NMS(Index = 5, Size = 0x4, EnumType = typeof(GcSentinelCoverState.SentinelCoverStateEnum))]
        /* 0x00 */ public NMSString0x10[] CoverStateAnims;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x10 DestroyEffectId;
        [NMS(Index = 2)]
        /* 0x50 */ public NMSString0x10 SpawnEffectId;
        [NMS(Index = 1)]
        /* 0x60 */ public float HealthPercLostPerSecMax;
        [NMS(Index = 0)]
        /* 0x64 */ public float HealthPercLostPerSecMin;
        [NMS(Index = 4)]
        /* 0x68 */ public NMSString0x20 EffectLocator;
    }
}
