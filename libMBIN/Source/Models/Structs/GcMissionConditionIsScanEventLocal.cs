namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x20, Alignment = 0x8, GUID = 0x8BF18ADD8648960A)]
    public class GcMissionConditionIsScanEventLocal : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
    }
}
