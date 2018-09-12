namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x20, GUID = 0x8BFCD316778640C0)]
    public class GcMissionConditionStatChange : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Stat;
        [NMS(Size = 0x10)]
        public string StatGroup;
    }
}
