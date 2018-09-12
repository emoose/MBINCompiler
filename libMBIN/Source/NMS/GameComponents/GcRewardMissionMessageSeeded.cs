namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x309B4877A6240E3)]
    public class GcRewardMissionMessageSeeded : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string MessageID;
        public bool BroadcastInMultiplayer;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Endpadding;
    }
}
