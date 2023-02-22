namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B865C4DF7135393, NameHash = 0xBF11E8FC1185AE00)]
    public class GcPlayerSurvivalBarType : NMSTemplate
    {
        // size: 0x3
        public enum SurvivalBarEnum {
            Health,
            Hazard,
            Energy,
        }
        /* 0x0 */ public SurvivalBarEnum SurvivalBar;
    }
}
