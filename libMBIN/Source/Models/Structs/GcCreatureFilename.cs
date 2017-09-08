namespace libMBIN.Models.Structs
{
    public class GcCreatureFilename : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x80)]
        public string Filename;
    }
}
