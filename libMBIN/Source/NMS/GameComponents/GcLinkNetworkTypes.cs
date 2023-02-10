namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFFD0F5DAF7159A3F, NameHash = 0xA2D103E3C1ECFE30)]
    public class GcLinkNetworkTypes : NMSTemplate
    {
        // size: 0x6
        public enum LinkNetworkTypeEnum {
            Power,
            Resources,
            Fuel,
            Portals,
            PlantGrowth,
            ByteBeat,
        }
        /* 0x0 */ public LinkNetworkTypeEnum LinkNetworkType;
    }
}
