namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47C94EB32E85A057, NameHash = 0xA2D103E3C1ECFE30)]
    public class GcLinkNetworkTypes : NMSTemplate
    {
        // size: 0x6
        public enum LinkNetworkTypeEnum {
            Power,
            Resources,
            Fuel,
            Portals,
            PlantGrowth,
            ByteBeat
        }
        /* 0x0 */ public LinkNetworkTypeEnum LinkNetworkType;
    }
}
