namespace MBINCompiler.Models.Structs
{
    public class GcRewardScanEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Event;
        public int ScanEventTable;
        public string[] ScanEventTableValues()
        {
            return new[] { "Space", "Planet", "Missions", "Tutorial" };
        }
    }
}
