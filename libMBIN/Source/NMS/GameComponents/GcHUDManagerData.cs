using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8EAD6D192EF966, NameHash = 0x756972574B9CCB08)]
    public class GcHUDManagerData : NMSTemplate
    {
        /* 0x000 */ public GcTextPreset TitleFont;
        /* 0x070 */ public GcTextPreset SubtitleFont;
        /* 0x0E0 */ public GcTextPreset SubtitleFontSmall;
        /* 0x150 */ public float OSDCoreSize;
        /* 0x154 */ public float OSDFullSize;
        /* 0x158 */ public float OSDCoreAlpha;
        /* 0x15C */ public float OSDBaseTextY;
        /* 0x160 */ public float OSDBaseBandY;
        /* 0x164 */ public float OSDBorderY;
        /* 0x168 */ public float OSDUnderlineWidth;
        /* 0x16C */ public float PopUpCoreSize;
        /* 0x170 */ public float PopUpFullSize;
        /* 0x174 */ public float PopUpCoreAlpha;
        /* 0x178 */ public float PopUpY;
        /* 0x17C */ public float PopUpYMidLock;
        /* 0x180 */ public float OSDFadeSpeed;
        /* 0x184 */ public float OSDEdgeMergeAlpha;
        /* 0x188 */ public float OSDTextAppearRate;
        /* 0x18C */ public float OSDTextFadeRate;
        /* 0x190 */ public float OSDTextWaitOnAlpha;
        /* 0x194 */ public float PopUpFadeRate;
        /* 0x198 */ public float PopUpBGFadeInRate;
        /* 0x19C */ public float PopUpBGFadeOutRate;
        /* 0x1A0 */ public float PopUpBGTriggerFG;
        /* 0x1A4 */ public float PromptLine1Y;
        /* 0x1A8 */ public float PromptLine2Y;
        /* 0x1AC */ public int ModelRenderTextureSize;
        /* 0x1B0 */ public int ModelRenderDisplaySize;
        /* 0x1B4 */ public int ModelRenderDisplayBorder;
        /* 0x1B8 */ public float ModelRenderDisplayOffset;
        /* 0x1BC */ public float ModelRenderDisplayMove;
        /* 0x1C0 */ public TkCurveType ModelRenderDisplayAlphaCurve;
        /* 0x1C4 */ public TkCurveType ModelRenderDisplayMoveCurve;
    }
}
