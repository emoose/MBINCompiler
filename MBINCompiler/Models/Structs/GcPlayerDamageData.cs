using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerDamageData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x20)]
        public string DeathMessage;
        public TkTextureResource HitIcon;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingB4;
        [NMS(Size = 0x20)]
        public string HitMessage;
        [NMS(Size = 0x20)]
        public string CriticalHitMessage;
        public float Damage;
        public float PushForce;
        public float CameraTurn;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding104;
        [NMS(Size = 0x10)]
        public string CameraShakeShield;
        [NMS(Size = 0x10)]
        public string CameraShakeNoShield;
    }
}
