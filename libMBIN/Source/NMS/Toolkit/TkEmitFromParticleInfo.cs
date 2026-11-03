namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x55657CC2FF723B9, NameHash = 0xE9067ED0)]
    public class TkEmitFromParticleInfo : NMSTemplate
    {
        // size: 0x2
        public enum EmissionRateTypeEnum : uint {
            PerParticle,
            Distance,
        }
        [NMS(Index = 1)]
        /* 0x0 */ public EmissionRateTypeEnum EmissionRateType;
        [NMS(Index = 0)]
        /* 0x4 */ public int OtherEmitterIndex;
    }
}
