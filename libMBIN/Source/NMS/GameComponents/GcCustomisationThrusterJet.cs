using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7254BA90397895B3, NameHash = 0x9B9CCCEC)]
    public class GcCustomisationThrusterJet : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkModelResource JetMesh;
        [NMS(Index = 3)]
        /* 0x20 */ public TkModelResource Trail;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 Effect;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 LocatorPrefix;
    }
}
