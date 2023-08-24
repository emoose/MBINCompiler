namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x62D59DFE20DC13BC, NameHash = 0x2B44FF66E5B6FEC1)]
    public class TkNGuiTreeViewTemplate : NMSTemplate
    {
        /* 0x00 */ public float ElementHeight;
        /* 0x04 */ public float LineWidth;
        /* 0x08 */ public float NestIndent;
        /* 0x0C */ public float IconPad;
        /* 0x10 */ public float IconMargin;
        /* 0x14 */ public float IconWidth;
        /* 0x18 */ public float VerticalSplitWidth;
        /* 0x1C */ public float VerticalSplitPad;
        /* 0x20 */ public bool FilteringHidesElements;
        /* 0x21 */ public bool AllowVerticalSplit;
        /* 0x30 */ public Colour LineColour;
        /* 0x40 */ public Colour TextColour;
        /* 0x50 */ public Colour InactiveTextColour;
        /* 0x60 */ public Colour FilteredTextColour;
        /* 0x70 */ public Colour HighlightColour;
    }
}
