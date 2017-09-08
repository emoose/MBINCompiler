namespace MBINCompiler.Models.Structs
{
    public class GcUniqueNPCSpawnData : NMSTemplate // 0x2C8 bytes
    {
        /* 0x000 */ public int NPCSpawnCondition;
        public string[] NPCSpawnConditionValues()
        {
            return new[] { "Always", "MiniStation" };
        }

        [NMS(Size = 4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;

        [NMS(Size = 0x10)]
        /* 0x008 */ public string ID;
        /* 0x018 */ public GcResourceElement ResourceElement;

        /* 0x2C0 */ public GcAlienRace Race;
        [NMS(Size = 4, Ignore = true)]
        /* 0x2C4 */ public byte[] EndPadding;

    }
}
