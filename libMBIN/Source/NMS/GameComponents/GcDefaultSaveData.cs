using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x24F90, GUID = 0x0CFCE39FDC123B572)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x24F10 */ public GcPlayerSpawnStateData Spawn;
    }
}
