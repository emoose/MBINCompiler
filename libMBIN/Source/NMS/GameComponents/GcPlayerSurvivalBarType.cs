namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A3AC396F3228AEB, NameHash = 0x4E1E4B3F)]
    public class GcPlayerSurvivalBarType : NMSTemplate
    {
        // size: 0x3
        public enum SurvivalBarEnum : uint {
            Health,
            Hazard,
            Energy,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SurvivalBarEnum SurvivalBar;
    }
}
