using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE24E8152EA40C07, NameHash = 0x22F18769)]
    public class GcPetBattlerEffectPathOverride : NMSTemplate
    {
        [NMS(Index = 0, MxmlName = "Particle Id")]
        /* 0x00 */ public NMSString0x10 ParticleId;
        [NMS(Index = 1)]
        /* 0x10 */ public GcPetBattlerProjectilePath Path;
    }
}
