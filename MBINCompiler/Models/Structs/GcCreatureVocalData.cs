using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureVocalData : NMSTemplate
    {
        public float ScaleBias;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;

        public GcCreatureVocalSoundData IdleVocal;
        public GcCreatureVocalSoundData FleeVocal;
        public GcCreatureVocalSoundData DeathVocal;
        public GcCreatureVocalSoundData AttackVocal;
    }
}
