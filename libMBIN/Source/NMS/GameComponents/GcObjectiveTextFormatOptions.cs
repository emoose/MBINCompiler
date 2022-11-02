namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBFDB0669BD9D8B68, NameHash = 0x2B3787F904F75390)]
    public class GcObjectiveTextFormatOptions : NMSTemplate
    {
        /* 0x00 */ public bool ObjectivesCanBeFormattedBySequences;
        /* 0x08 */ public NMSString0x20A FormattableObjective;
        /* 0x28 */ public NMSString0x20A FormattableObjectiveTip;
    }
}
