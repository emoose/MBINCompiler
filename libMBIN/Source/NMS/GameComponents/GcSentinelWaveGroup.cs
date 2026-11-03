using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DAB2FDEE6796BD1, NameHash = 0xA4C0BC95)]
    public class GcSentinelWaveGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> ExtremeWaves;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x10> Waves;
    }
}
