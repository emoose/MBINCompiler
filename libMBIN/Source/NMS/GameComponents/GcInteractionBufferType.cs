namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B7C38A7535EE3C7, NameHash = 0x56096224708D16B)]
    public class GcInteractionBufferType : NMSTemplate
    {
        // size: 0xB
        public enum InteractionBufferTypeEnum {
            Distress_Signal,
            Crate,
            Destructable,
            Terrain,
            Cost,
            Building,
            Creature,
            Maintenance,
            Personal,
            Personal_Maintenance,
            FireteamSync,
        }
        /* 0x0 */ public InteractionBufferTypeEnum InteractionBufferType;
    }
}
