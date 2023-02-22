namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x892B407E9E1FA9E, NameHash = 0xBF11E8FC1185AE00)]
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
