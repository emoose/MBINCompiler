namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1F730CC940B60A8, NameHash = 0xD6D9F16C)]
    public class GcFrigateFlybyType : NMSTemplate
    {
        // size: 0x6
        public enum FrigateFlybyTypeEnum : uint {
            SingleShip,
            AmbientGroup,
            ScriptedGroup,
            DeepSpace,
            DeepSpaceCommon,
            GhostShip,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FrigateFlybyTypeEnum FrigateFlybyType;
    }
}
