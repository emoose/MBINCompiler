using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x24AD0, GUID = 0x0CFCE39FDC123B572, Broken = true)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x24A50 */ public GcPlayerSpawnStateData Spawn;
    }
}
