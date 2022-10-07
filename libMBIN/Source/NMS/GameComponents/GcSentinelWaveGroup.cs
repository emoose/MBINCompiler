using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D48F6A5C0F95A1A, NameHash = 0xE866662BD040EDFB)]
    public class GcSentinelWaveGroup : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Waves;
        /* 0x10 */ public List<NMSString0x10> ExtremeWaves;
    }
}
