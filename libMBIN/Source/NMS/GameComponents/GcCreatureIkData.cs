using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAAEA2EE500D3BD5, NameHash = 0x5997488E)]
    public class GcCreatureIkData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCreatureIkType Type;
        [NMS(Index = 1)]
        /* 0x4 */ public NMSString0x100 JointName;
    }
}
