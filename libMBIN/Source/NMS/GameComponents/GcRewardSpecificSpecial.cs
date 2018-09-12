namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8429195766863F79)]
    public class GcRewardSpecificSpecial : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x20)]
        public string Message;
    }
}
