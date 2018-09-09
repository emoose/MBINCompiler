namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20, Alignment = 0x8)]
    public class GcMissionConditionIsScanEventLocal : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
    }
}
