using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureVocalData : NMSTemplate
    {
        public float ScaleBias;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding4;

        public GcCreatureVocalSoundData IdleVocal;
        public GcCreatureVocalSoundData FleeVocal;
        public GcCreatureVocalSoundData DeathVocal;
        public GcCreatureVocalSoundData AttackVocal;
    }
}
