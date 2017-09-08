namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3C)]
    public class GcAudioNPCDoppler : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new string[0x5] { "None", "Pirate", "Police", "Trader", "Freighter" })]        // enum vals from old audio globals...
		public GcAudio3PointDopplerData[] Config;
    }
}