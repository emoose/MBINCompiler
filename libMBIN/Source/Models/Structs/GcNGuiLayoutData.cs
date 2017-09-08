namespace libMBIN.Models.Structs
{
    public class GcNGuiLayoutData : NMSTemplate     // size: 0x2C
    {
        /* 0x00 */ public float PositionX;
        /* 0x04 */ public float PositionY;
        /* 0x08 */ public float Width; 
        /* 0x0C */ public bool WidthPercentage;

        /* 0x10 */ public float Height;
        /* 0x14 */ public bool HeightPercentage;
        /* 0x15 */ public bool ConstrainProportions;

        /* 0x18 */ public float ConstrainAspect;
        /* 0x1C */ public bool Anchor;
        /* 0x1D */ public bool AnchorPercent;
        /* 0x1E */ public bool SameLine;

        [NMS(Size = 1, Ignore = true)]
        /* 0x00 */ public byte[] Padding1F;

        /* 0x20 */ public TkNGuiAlignment Align;
        /* 0x28 */ public bool SlowCursorOnHover;

        [NMS(Size = 0x3, Ignore = true)]
        /* 0x00 */ public byte[] Padding29;
    }
}
