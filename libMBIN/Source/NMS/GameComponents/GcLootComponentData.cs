namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F0E6D81FCD11E097)]
    public class GcLootComponentData : NMSTemplate
    {
        public Vector2f Timed;
        [NMS(Size = 0x10)]
        public string TimeOutEffect;
        public bool DeathPoint;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding19;
    }
}
