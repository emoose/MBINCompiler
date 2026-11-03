namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A3E40468CA4EC5B, NameHash = 0xC91B3D31)]
    public class GcHologramType : NMSTemplate
    {
        // size: 0x4
        public enum HologramTypeEnum : uint {
            Mesh,
            PlayerCharacter,
            PlayerShip,
            PlayerMultiTool,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HologramTypeEnum HologramType;
    }
}
