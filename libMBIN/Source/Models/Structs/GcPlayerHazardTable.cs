namespace libMBIN.Models.Structs
{
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Size = 6)]
        public GcPlayerHazardData[] Table;
    }
}
