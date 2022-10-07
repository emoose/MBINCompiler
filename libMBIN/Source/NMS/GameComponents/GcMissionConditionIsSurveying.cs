namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE837A1764D2B2315, NameHash = 0xD3E5CFFA024865D7)]
    public class GcMissionConditionIsSurveying : NMSTemplate
    {
        // size: 0x4
        public enum ForHotspotTypeEnum {
            Any,
            Power,
            Gas,
            Minerals
        }
        /* 0x0 */ public ForHotspotTypeEnum ForHotspotType;
        /* 0x4 */ public bool RequireAlreadyAnalysed;
    }
}
