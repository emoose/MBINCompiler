namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0xC4)]
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
