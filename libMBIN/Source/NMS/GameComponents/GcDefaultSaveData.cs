using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x25CF0, GUID = 0xA7B446FEA81D5252)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x25C70 */ public GcPlayerSpawnStateData Spawn;
    }
}
