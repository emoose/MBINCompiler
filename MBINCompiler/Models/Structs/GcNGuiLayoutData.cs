using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcNGuiLayoutData : NMSTemplate
    {
        public float PositionX;
        public float PositionY;
        public float Width; 
        public bool WidthPercentage;

        public float Height;
        public bool HeightPercentage;
        public bool ConstrainProportions;

        public float ConstrainAspect;
        public bool Anchor;
        public bool AnchorPercent;
        public bool SameLine;

        [NMS(Size = 1)]
        public byte[] Padding1F;

        public TkNGuiAlignment Align;
        public bool SlowCursorOnHover;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x7 )]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding4;
    }
}
