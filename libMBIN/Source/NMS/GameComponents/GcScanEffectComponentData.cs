using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xF446EEAE3BC7CE8B)]
    public class GcScanEffectComponentData : NMSTemplate
    {
        public List<GcScanEffectData> ScanEffects;
    }
}
