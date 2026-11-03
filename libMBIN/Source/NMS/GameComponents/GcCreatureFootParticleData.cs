using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x546850F067DB7AD, NameHash = 0xCC34EA26)]
    public class GcCreatureFootParticleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureFootParticleSingleData> ParticleData;
    }
}
