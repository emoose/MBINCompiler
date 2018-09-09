namespace libMBIN.Models.Structs
{
	[NMS(Size = 0xC4, GUID = 0x204DFFD03BAA3C1A)]
    public class GcDiscoveryOwner : NMSTemplate
    {

        [NMS(Size = 0x40)]
        public string LocalID;
        [NMS(Size = 0x40)]
        public string OnlineID;
        [NMS(Size = 0x40)]
        public string Username;
        public int TimeStamp;
    }
}
