using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x991D1695C40B30C, NameHash = 0x80EBCD8A)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyleData Active;
        [NMS(Index = 0)]
        /* 0x070 */ public TkNGuiGraphicStyleData Default;
        [NMS(Index = 1)]
        /* 0x0E0 */ public TkNGuiGraphicStyleData Highlight;
        [NMS(Index = 17)]
        /* 0x150 */ public Vector2f CustomMaxStart;
        [NMS(Index = 16)]
        /* 0x158 */ public Vector2f CustomMinStart;
        // size: 0x7
        public enum AnimateEnum : uint {
            None,
            WipeRightToLeft,
            WipeLeftToRight,
            SimpleWipe,
            SimpleWipeDown,
            CustomWipe,
            CustomWipeAlpha,
        }
        [NMS(Index = 11)]
        /* 0x160 */ public AnimateEnum Animate;
        [NMS(Index = 13)]
        /* 0x164 */ public float AnimSplit;
        [NMS(Index = 12)]
        /* 0x168 */ public float AnimTime;
        [NMS(Index = 10)]
        /* 0x16C */ public float GlobalFade;
        [NMS(Index = 9)]
        /* 0x170 */ public float HighlightScale;
        [NMS(Index = 8)]
        /* 0x174 */ public float HighlightTime;
        [NMS(Index = 14)]
        /* 0x178 */ public TkCurveType AnimCurve1;
        [NMS(Index = 15)]
        /* 0x179 */ public TkCurveType AnimCurve2;
        [NMS(Index = 4)]
        /* 0x17A */ public bool AutoAdjustToChildrenHeight;
        [NMS(Index = 5)]
        /* 0x17B */ public bool AutoAdjustToChildrenWidth;
        [NMS(Index = 7)]
        /* 0x17C */ public bool DistributeChildrenHeight;
        [NMS(Index = 6)]
        /* 0x17D */ public bool DistributeChildrenWidth;
        [NMS(Index = 3)]
        /* 0x17E */ public bool InheritStyleFromParentLayer;
    }
}
