using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9867783D0630B771, NameHash = 0xEE0A249BBB7EC33)]
    public class GcCreatureFootParticleData : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureFootParticleSingleData> ParticleData;
    }
}
