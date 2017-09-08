namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x4EAB0)]
    public class GcDefaultSaveData : NMSTemplate
    {
        /* 0x00000 */ public GcPlayerStateData State;
        /* 0x4EA30 */ public GcPlayerSpawnStateData Spawn;
    }
}
