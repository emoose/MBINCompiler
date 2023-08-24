using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC39A7C51A6287BE, NameHash = 0x6E90E2A796E798F4)]
    public class GcHeavyAirSetting : NMSTemplate
    {
        [NMS(Size = 0x5)]
        /* 0x0 */ public GcHeavyAirSettingValues[] Settings;
    }
}
