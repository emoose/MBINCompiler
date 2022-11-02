namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F69C78FCFCD713C, NameHash = 0x1B95D5FDE04FECD9)]
    public class GcMissionConditionRefinerActive : NMSTemplate
    {
        /* 0x00 */ public bool HasFuel;
        /* 0x08 */ public NMSString0x20A ActiveRecipe;
        /* 0x28 */ public int AmountToMake;
    }
}
