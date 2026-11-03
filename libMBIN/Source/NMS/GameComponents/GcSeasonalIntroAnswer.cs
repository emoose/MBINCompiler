namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1672000B8F3BFA01, NameHash = 0x59CFD217)]
    public class GcSeasonalIntroAnswer : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Text;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 OverrideNextQuestionID;
    }
}
