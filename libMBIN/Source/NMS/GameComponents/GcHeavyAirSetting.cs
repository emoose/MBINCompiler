using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87D38F494FB0DD9B, NameHash = 0x6E90E2A796E798F4)]
    public class GcHeavyAirSetting : NMSTemplate
    {
        [NMS(Size = 0x5)]
        /* 0x0 */ public GcHeavyAirSettingValues[] Settings;
    }
}
