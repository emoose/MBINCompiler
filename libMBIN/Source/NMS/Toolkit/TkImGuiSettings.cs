namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x70F15FEDCAE3687B, NameHash = 0x20F7F01AF38D19B2)]
    public class TkImGuiSettings : NMSTemplate
    {
        /* 0x000 */ public Colour BackgroundColour;
        /* 0x010 */ public Colour WindowTitleColour;
        /* 0x020 */ public Colour ActiveWindowTitleColour;
        /* 0x030 */ public Colour WindowBackgroundColour;
        /* 0x040 */ public Colour ActiveWindowBackgroundColour;
        /* 0x050 */ public Colour WindowHighlight;
        /* 0x060 */ public Colour TextColour;
        /* 0x070 */ public Colour ActiveTextColour;
        /* 0x080 */ public Colour TextShadowColour;
        /* 0x090 */ public Colour TextDisabledColour;
        /* 0x0A0 */ public Colour ButtonColour;
        /* 0x0B0 */ public Colour ButtonHighlightColour;
        /* 0x0C0 */ public Colour ButtonPressedColour;
        /* 0x0D0 */ public Colour EditBoxColour;
        /* 0x0E0 */ public Colour EditBoxActiveColour;
        /* 0x0F0 */ public Colour EditBoxSelectedColour;
        /* 0x100 */ public Colour TaskBarColour;
        /* 0x110 */ public Colour TaskBarShadow;
        /* 0x120 */ public Colour CloseButtonColour;
        /* 0x130 */ public Colour CloseButtonHighlightColour;
        /* 0x140 */ public Colour CloseButtonClickColour;
        /* 0x150 */ public Colour MinimiseButtonColour;
        /* 0x160 */ public Colour MinimiseButtonHighlightColour;
        /* 0x170 */ public Colour MinimiseButtonClickColour;
        /* 0x180 */ public float ScrollSpeed;
        /* 0x184 */ public float AltPlacementDistanceScrollSpeed;
    }
}
