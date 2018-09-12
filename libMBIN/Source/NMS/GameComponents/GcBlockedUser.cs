namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0DE740CFF10FD49AC)]
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
