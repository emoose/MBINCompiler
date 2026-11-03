namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD06E84CDA46797A6, NameHash = 0x7859819E)]
    public class GcMissionConditionCanMakeItem : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 TargetItem;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
    }
}
