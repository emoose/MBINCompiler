namespace MBINCompiler.Models.Structs
{
    public class GcCreatureFootParticleSingleData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string EffectName;

        public float Scale;
        public float MinCreatureSize;
        public float MaxCreatureSize;
        public int MoveSpeed;
        public string[] MoveSpeedValues()
        {
            return new[] { "Always", "Walk", "Run" };
        }
    }
}
