using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x808115B826EC568E, NameHash = 0x9346E363)]
    public class GcRewardShipMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcShipMessage ShipMessage;
    }
}
