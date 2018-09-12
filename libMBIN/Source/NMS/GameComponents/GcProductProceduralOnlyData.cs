namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x38, GUID = 0x53EF9B4977C9F6C4)]
    public class GcProductProceduralOnlyData : NMSTemplate
    {
        public int DropWeight;
        public int BasevalueMin;
        public int BaseValueMax;
        public int AgeMin;
        public int AgeMax;
        public GcNumberedTextList Descriptions;
    }
}
