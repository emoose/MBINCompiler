using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x633E28D024120F97, NameHash = 0xF13C1835)]
    public class GcCustomisationBobbleHead : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource BobbleHead;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 LinkedTechId;
    }
}
