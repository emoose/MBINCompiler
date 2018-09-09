using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9867783D0630B771)]
    public class GcCreatureFootParticleData : NMSTemplate
    {
        public List<GcCreatureFootParticleSingleData> ParticleData;
    }
}
