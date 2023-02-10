namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31172347D3FA423E, NameHash = 0x801DCAAD4B4FAC26)]
    public class GcBaseAutoPowerSetting : NMSTemplate
    {
        // size: 0x3
        public enum BaseAutoPowerSettingEnum {
            UseDefault,
            ForceDisabled,
            ForceEnabled,
        }
        /* 0x0 */ public BaseAutoPowerSettingEnum BaseAutoPowerSetting;
    }
}
