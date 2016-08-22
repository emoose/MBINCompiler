using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureMoveAnimData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Anim;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string AnimLeft;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string AnimRight;

        public float AnimSpeed;
        public float MinSpeedScale;
        public float MaxSpeedScale;
        public float MaxPredatorSpeedScale;
    }
}
