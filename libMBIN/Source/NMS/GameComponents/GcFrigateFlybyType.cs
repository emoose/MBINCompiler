namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x856B3AA61DD2C36D, NameHash = 0x20BC4D823F8443DB)]
    public class GcFrigateFlybyType : NMSTemplate
    {
        // size: 0x5
        public enum FrigateFlybyTypeEnum {
            SingleShip,
            AmbientGroup,
            ScriptedGroup,
            DeepSpace,
            DeepSpaceCommon
        }
        /* 0x0 */ public FrigateFlybyTypeEnum FrigateFlybyType;
    }
}
