namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF01A423BCFD84D13, NameHash = 0x4F580907)]
    public class GcCutSceneTriggerActionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Action;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 GroupFilter;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 IdFilter;
        [NMS(Index = 3)]
        /* 0x30 */ public NMSString0x10 Parameter;
    }
}
