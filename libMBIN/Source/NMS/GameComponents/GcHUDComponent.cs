namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C7856897DF694E5, NameHash = 0x9658E308A74D3E3C)]
    public class GcHUDComponent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public int PosX;
        /* 0x14 */ public int PosY;
        /* 0x18 */ public int Width;
        /* 0x1C */ public int Height;
        // size: 0x5
        public enum AlignEnum {
            Center,
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }
        /* 0x20 */ public AlignEnum Align;
    }
}
