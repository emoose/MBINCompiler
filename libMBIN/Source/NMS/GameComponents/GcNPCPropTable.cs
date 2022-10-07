using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x322882AEDADDDB0D, NameHash = 0x22BD6A8E5AD4C4CB)]
    public class GcNPCPropTable : NMSTemplate
    {
        // size: 0xD
        public enum PropsEnum {
            None,
            IPad,
            HoloBlob,
            HoloFrigate,
            HoloShip,
            HoloMultitool,
            HoloSolarSystem,
            Container,
            Box,
            Cup,
            DontCare,
            RandomHologram,
            HoloDrone
        }
        [NMS(Size = 0xD, EnumType = typeof(PropsEnum))]
        /* 0x0 */ public GcNPCPropInfo[] Props;
    }
}
