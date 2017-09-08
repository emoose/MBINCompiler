namespace libMBIN.Models.Structs
{
    public class GcCostBuildingParts : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Description;
        public GcBuildingCostPartCount RequiredParts;
    }
}
