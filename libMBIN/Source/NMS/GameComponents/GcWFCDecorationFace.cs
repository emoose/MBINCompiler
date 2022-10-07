namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DAFA2199AEC786B, NameHash = 0x7BCF7FA8AF0C694F)]
    public class GcWFCDecorationFace : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 RequiredFace;
        // size: 0x3
        public enum CanWalkEnum {
            None,
            RequireCanWalk,
            RequireCanNotWalk
        }
        /* 0x80 */ public CanWalkEnum CanWalk;
    }
}
