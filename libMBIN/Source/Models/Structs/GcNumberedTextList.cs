namespace libMBIN.Models.Structs
{
    public class GcNumberedTextList : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Format;
        public int Count;
    }
}
