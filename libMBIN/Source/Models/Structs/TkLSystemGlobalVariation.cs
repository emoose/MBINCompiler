namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x381C116EDA8419EA)]
    public class TkLSystemGlobalVariation : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public int Variations;
    }
}
