namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC3DBD4403921B16, NameHash = 0x2D0ED597896EB5AF)]
    public class GcNGuiActionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LayerID;
        /* 0x10 */ public NMSString0x80 Data;
        // size: 0x4
        public enum ActionEnum {
            Click,
            Hover,
            ArrowLeft,
            ArrowRight
        }
        /* 0x90 */ public ActionEnum Action;
    }
}
