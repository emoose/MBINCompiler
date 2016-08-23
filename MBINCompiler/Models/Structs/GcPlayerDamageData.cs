using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerDamageData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string DeathMessage;
        public TkTextureResource HitIcon;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [NMSAttribute(Ignore = true)]
        public byte[] PaddingB4;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string HitMessage;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string CriticalHitMessage;
        public float Damage;
        public float PushForce;
        public float CameraTurn;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding104;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string CameraShakeShield;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string CameraShakeNoShield;
    }
}
