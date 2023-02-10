namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED354ECE77C8A9C, NameHash = 0x1E27C6F2466B2426)]
    public class GcPlanetLife : NMSTemplate
    {
        // size: 0x4
        public enum LifeSettingEnum {
            Dead,
            Low,
            Mid,
            Full,
        }
        /* 0x0 */ public LifeSettingEnum LifeSetting;
    }
}
