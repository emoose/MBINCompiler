using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2446AAD26CD3DE8, NameHash = 0xEE0A249BBB7EC33)]
    public class GcCreatureFootParticleData : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureFootParticleSingleData> ParticleData;
    }
}
