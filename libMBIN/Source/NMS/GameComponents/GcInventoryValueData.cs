namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBFBA97AD59322690, NameHash = 0x9118F575B23083D9)]
    public class GcInventoryValueData : NMSTemplate
    {
        /* 0x00 */ public float BaseMinValue;
        /* 0x04 */ public float BaseMaxValue;
        /* 0x08 */ public float ExponentialValue;
        /* 0x0C */ public float BaseCostPerSlot;
        /* 0x10 */ public float SlotExponentialValue;
        /* 0x14 */ public float ValueToCost;
        /* 0x18 */ public float SlotsPerLevel;
    }
}
