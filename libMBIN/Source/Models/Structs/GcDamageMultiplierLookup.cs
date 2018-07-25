namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x28)]
    public class GcDamageMultiplierLookup : NMSTemplate
    {

        [NMS(Size = 0x10)]
        public string Id;
        public float Default;
        [NMS(Size = 0x20)]
        public GcDamageMultiplier[] Multipliers;
    }
}