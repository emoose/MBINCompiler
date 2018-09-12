namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0C377F0E807316984)]
    public class GcInventoryBaseStatEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string BaseStatID;
        public float Value;
    }
}
