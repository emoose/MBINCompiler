namespace libMBIN.Models.Structs
{
    public class GcSubstanceAmount : NMSTemplate // 0x20 bytes
    {
        public int AmountMin;
        public int AmountMax;
        [NMS(Size = 0x10)]
        public string Specific;

        public GcRealitySubstanceCategory SubstanceCategory;
        public GcRarity Rarity;
    }
}
