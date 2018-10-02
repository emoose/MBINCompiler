using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x25CB00, GUID = 0xB8D8EA4076A7433A)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x25C30 */ public GcPlayerSpawnStateData Spawn;
    }
}
