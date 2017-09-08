namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x4EAC0)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x4EA40 */ public GcPlayerSpawnStateData Spawn;
    }
}
