namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class GcPortalSaveData : NMSTemplate
    {
        public GcSeed PortalSeed;
        public ulong LastPortalUA;      // Universal Address
    }
}
