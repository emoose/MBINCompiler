using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4D99FFC8B020A397)]
    public class TkShearWindOctaveData : NMSTemplate
    {
        public float MinStrength;
        public float MaxStrength;
        public float StrengthVariationFreq;
        public float WaveSize;
        public float WaveFrequency;
    }
}
