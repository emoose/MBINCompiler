namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A5117479225A1A, NameHash = 0x69F60839059BF3CD)]
    public class GcNPCPropType : NMSTemplate
    {
        // size: 0xD
        public enum NPCPropEnum : uint {
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
            HoloDrone,
        }
        /* 0x0 */ public NPCPropEnum NPCProp;
    }
}
