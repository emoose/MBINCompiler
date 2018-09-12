namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0FDD9F1E5F1524FF4)]
    public class GcExpeditionDurationValues : NMSTemplate
    {
        [NMS(Size = 0x5)]
        public int[] Duration;
    }
}
