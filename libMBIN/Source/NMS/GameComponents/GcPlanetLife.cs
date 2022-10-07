namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4AD9DD295880EED, NameHash = 0x1E27C6F2466B2426)]
    public class GcPlanetLife : NMSTemplate
    {
        // size: 0x4
        public enum LifeSettingEnum {
            Dead,
            Low,
            Mid,
            Full
        }
        /* 0x0 */ public LifeSettingEnum LifeSetting;
    }
}
