namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA1D7E494DBD81D7, NameHash = 0x69F60839059BF3CD)]
    public class GcNPCPropType : NMSTemplate
    {
        // size: 0xD
        public enum NPCPropEnum {
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
