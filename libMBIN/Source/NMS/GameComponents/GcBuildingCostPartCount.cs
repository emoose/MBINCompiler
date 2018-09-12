namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F701652DA9F900D6)]
    public class GcBuildingCostPartCount : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Count;

        [NMS( Size = 0x04, Ignore = true )]
        public byte[] Padding14;
    }
}
