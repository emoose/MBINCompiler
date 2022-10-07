using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x236A8FA0D9098F3F, NameHash = 0x1FE13AB26770D8C5)]
    public class GcScanEffectComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcScanEffectData> ScanEffects;
        /* 0x10 */ public NMSString0x40 NodeName;
    }
}
