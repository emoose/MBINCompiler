using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkNGuiTextStyleData : NMSTemplate
    {
        public Colour Colour;
        public float FontHeight;
        public float FontSpacing;

        public bool IsIndented;
        public bool HasDropShadow;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x2 )]
        public byte[] Padding1;

        public float DropShadowOffset;
        public bool HasOutline;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x3 )]
        public byte[] Padding2;

        public float OutlineSize;
        public bool IsParagraph;
        public bool AllowScroll;
        public bool ForceUpperCase;
        public bool AutoAdjustHeight;
        public int FontIndex;
        public TkNGuiAlignment Align;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x8 )]
        public byte[] Padding3;
    }
}
