namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79A76EAFBFCDDB6B, NameHash = 0x2D0ED597896EB5AF)]
    public class GcNGuiActionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LayerID;
        /* 0x10 */ public NMSString0x80 Data;
        // size: 0x4
        public enum ActionEnum : uint {
            Click,
            Hover,
            ArrowLeft,
            ArrowRight,
        }
        /* 0x90 */ public ActionEnum Action;
    }
}
