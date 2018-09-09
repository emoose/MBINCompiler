namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x81, GUID = 0x49DC5CF05FC78D13)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        public bool ScanCargo;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
