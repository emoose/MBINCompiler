namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x803EA1F22C387F8E, NameHash = 0x24D022A0BCD713A0)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Technology;
        /* 0x10 */ public int RepairedComponents;
    }
}
