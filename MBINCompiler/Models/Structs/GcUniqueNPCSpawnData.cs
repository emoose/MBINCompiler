namespace MBINCompiler.Models.Structs
{
    public class GcUniqueNPCSpawnData : NMSTemplate // 0x20 bytes
    {
        public int NPCSpawnCondition;
        public string[] NPCSpawnConditionValues()
        {
            return new[] { "Always", "MiniStation" };
        }

        [NMS(Size = 0x10)]
        public string ID;
        public GcResourceElement ResourceElement;
        public GcAlienRace Race;
    }
}
