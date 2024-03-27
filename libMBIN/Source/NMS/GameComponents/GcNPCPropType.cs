namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x641CC042BFEEE1A9, NameHash = 0x69F60839059BF3CD)]
    public class GcNPCPropType : NMSTemplate
    {
        // size: 0xF
        public enum NPCPropEnum : uint {
            None,
            Default,
            DontCare,
            IPad,
            RandomHologram,
            HoloBlob,
            HoloFrigate,
            HoloShip,
            HoloMultitool,
            HoloSolarSystem,
            HoloDrone,
            Container,
            Box,
            Cup,
            Staff,
        }
        /* 0x0 */ public NPCPropEnum NPCProp;
    }
}
