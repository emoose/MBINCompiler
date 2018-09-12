using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x10, GUID = 0x0F446EEAE3BC7CE8B)]
    public class GcScanEffectComponentData : NMSTemplate
    {
        public List<GcScanEffectData> ScanEffects;
    }
}
