namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28521170BE62C2D7, NameHash = 0x801DCAAD4B4FAC26)]
    public class GcBaseAutoPowerSetting : NMSTemplate
    {
        // size: 0x3
        public enum BaseAutoPowerSettingEnum {
            UseDefault,
            ForceDisabled,
            ForceEnabled
        }
        /* 0x0 */ public BaseAutoPowerSettingEnum BaseAutoPowerSetting;
    }
}
