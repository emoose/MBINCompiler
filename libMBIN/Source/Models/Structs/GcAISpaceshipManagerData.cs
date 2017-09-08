namespace libMBIN.Models.Structs
{
    public class GcAISpaceshipManagerData : NMSTemplate     // size: 0x50
    {
        [NMS(Size = 5)]
        public GcAISpaceshipModelDataArray[] FactionMapping;
    }
}
