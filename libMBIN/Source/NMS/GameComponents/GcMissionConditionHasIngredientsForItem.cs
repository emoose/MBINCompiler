using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81232ADEE7656512, NameHash = 0x84BBBF70C34631CA)]
    public class GcMissionConditionHasIngredientsForItem : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> TargetItems;
        /* 0x10 */ public bool TakeTargetFromSeasonData;
        /* 0x11 */ public bool FormatTextOneReqAtATime;
        /* 0x14 */ public int HorribleJustFormatTargetAmount;
        /* 0x18 */ public bool Repair;
        /* 0x19 */ public bool NeverReturnTrueOnlyUseForFormatting;
    }
}
