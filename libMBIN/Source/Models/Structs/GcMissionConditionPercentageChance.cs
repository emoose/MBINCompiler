namespace libMBIN.Models.Structs
{
    public class GcMissionConditionPercentageChance : NMSTemplate
    {
        public int Percent;
        public bool Seeded;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
