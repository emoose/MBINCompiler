namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF031B23F4E47519, NameHash = 0xD1F40E0F6517D194)]
    public class GcRectangularInitialShape : NMSTemplate
    {
        /* 0x00 */ public Vector3f TopLineStart;
        /* 0x10 */ public Vector3f TopLineEnd;
        /* 0x20 */ public Vector3f BottomLineStart;
        /* 0x30 */ public Vector3f BottomLineEnd;
    }
}
