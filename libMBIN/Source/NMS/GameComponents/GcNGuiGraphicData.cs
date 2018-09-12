namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x280, Alignment = 0x10, GUID = 0x4FA1552617F32EFF)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        /* 0x050 */ public TkNGuiGraphicStyle Style;

        [NMS(Size = 0x80)]
        public string Image;
    }
}
