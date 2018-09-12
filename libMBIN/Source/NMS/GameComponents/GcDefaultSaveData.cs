namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x24AD0, GUID = 0x9A06B824D8B40F5C)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x24A50 */ public GcPlayerSpawnStateData Spawn;
    }
}
