using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        public TkNGuiGraphicStyleData Default;
        public TkNGuiGraphicStyleData Highlight;
        public TkNGuiGraphicStyleData Active;
        public float HighlightTime;
        public float HighlightScale;

        public int Animate;
        public string[] AnimateValues()
        { return new string[] { "None", "WipeRightToLeft", "SimpleWipe", "CustomWipe"}; }


        public float AnimTime;
        public float AnimSplit;
        public TkCurveType Curve1;
        public TkCurveType Curve2;

        public Vector2f CustomMinStart;
        public Vector2f CustomMaxStart;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x4 )]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding;
    }
}
