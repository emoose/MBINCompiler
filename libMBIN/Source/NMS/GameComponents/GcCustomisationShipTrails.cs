using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D84AD5552145841, NameHash = 0x67C3C3C4)]
    public class GcCustomisationShipTrails : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource Trails;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 LinkedTechID;
    }
}
