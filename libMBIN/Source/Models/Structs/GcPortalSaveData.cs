namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x18, GUID = 0x0A9ECFDEF35F6EEDF)]
    public class GcPortalSaveData : NMSTemplate
    {
        public GcSeed PortalSeed;
        public ulong LastPortalUA;      // Universal Address
    }
}
