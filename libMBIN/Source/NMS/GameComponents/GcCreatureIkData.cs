using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66B16F67CA82A027, NameHash = 0x3B356CAA76CA79F8)]
    public class GcCreatureIkData : NMSTemplate
    {
        /* 0x0 */ public GcCreatureIkType Type;
        /* 0x4 */ public NMSString0x100 JointName;
    }
}
