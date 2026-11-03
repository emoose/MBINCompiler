using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCE9DA703DE2DFDD3, NameHash = 0x4B906CC8)]
    public class TkWaterConditionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<TkWaveInputData> Waves;
        [NMS(Index = 1)]
        /* 0x10 */ public TkFoamProperties FoamProperties;
        [NMS(Index = 2)]
        /* 0x30 */ public float DetailNormalsStrength;
        [NMS(Index = 3)]
        /* 0x34 */ public float WaveRTPCStrength;
    }
}
