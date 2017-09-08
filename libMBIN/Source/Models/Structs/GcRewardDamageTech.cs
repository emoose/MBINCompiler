namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcRewardDamageTech : NMSTemplate
    {
        public GcTechnologyCategory Category;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Paddding4;
        [NMS(Size = 0x10)]
        public string TechToDamage_optional;
        public bool ShowDamageMessage;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
