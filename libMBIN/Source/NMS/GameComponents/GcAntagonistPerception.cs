namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BCCD4CF815D841F, NameHash = 0x44D6DFC8A512D8CB)]
    public class GcAntagonistPerception : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float Range;
        /* 0x14 */ public float XFOV;
        /* 0x18 */ public float YFOV;
        // size: 0x2
        public enum ViewShapeEnum : uint {
            Pyramid,
            Cone,
        }
        /* 0x1C */ public ViewShapeEnum ViewShape;
        /* 0x20 */ public bool Raycast;
        /* 0x21 */ public NMSString0x20 SenseLocator;
    }
}
