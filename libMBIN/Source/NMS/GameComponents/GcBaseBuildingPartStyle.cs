namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA63C1943EC1792A2, NameHash = 0xCEBA5F1259779D68)]
    public class GcBaseBuildingPartStyle : NMSTemplate
    {
        // size: 0x7
        public enum StyleEnum {
            None,
            Wood,
            Metal,
            Concrete,
            Stone,
            Timber,
            Fibreglass,
        }
        /* 0x0 */ public StyleEnum Style;
    }
}
