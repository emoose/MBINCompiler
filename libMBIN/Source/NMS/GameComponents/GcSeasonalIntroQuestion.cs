using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A979E8E9C419402, NameHash = 0x1200027E)]
    public class GcSeasonalIntroQuestion : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Question;
        [NMS(Index = 3)]
        /* 0x20 */ public List<GcSeasonalIntroAnswer> Answers;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x40 */ public NMSString0x10 NextQuestionID;
    }
}
