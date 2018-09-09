namespace libMBIN.Models.Structs
{
	[NMS(Size = 0xA0, GUID = 0x57B4A038FBBAC4CE)]
    public class GcHeavyAirSetting : NMSTemplate
    {
        [NMS(Size = 5)]
        public GcHeavyAirSettingValues[] Settings;
    }
}
