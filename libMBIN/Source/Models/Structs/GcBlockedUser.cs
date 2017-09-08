namespace libMBIN.Models.Structs
{
    public class GcBlockedUser : NMSTemplate        // size: 0xA0
    {
        [NMS(Size = 0x40)]
        public string UserId;
        [NMS(Size = 0x20)]
        public string Username;
        [NMS(Size = 0x20)]
        public string Platform;
    }
}
