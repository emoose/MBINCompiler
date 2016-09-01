using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureHealthData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string HurtAnim;
        [NMS(Size = 0x10)]
        public string DeathAnim;
        [NMS(Size = 0x10)]
        public string DeathEffect;
        [NMS(Size = 0x10)]
        public string HurtAudio;
        [NMS(Size = 0x10)]
        public string DeathAudio;
    }
}
