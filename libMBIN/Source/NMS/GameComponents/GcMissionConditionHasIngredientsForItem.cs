using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAD7D437BD0066A8, NameHash = 0x84BBBF70C34631CA)]
    public class GcMissionConditionHasIngredientsForItem : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> TargetItems;
        /* 0x10 */ public NMSString0x20A TakeTargetItemsFromScanEvent;
        /* 0x30 */ public GcMaintenanceElementGroups ScanEventTargetGroup;
        /* 0x34 */ public int ExpectedTargetItemsFromScanEvent;
        /* 0x38 */ public bool TakeTargetFromSeasonData;
        /* 0x39 */ public bool FormatTextOneReqAtATime;
        /* 0x3C */ public int HorribleJustFormatTargetAmount;
        /* 0x40 */ public bool Repair;
        /* 0x41 */ public bool NeverReturnTrueOnlyUseForFormatting;
    }
}
