namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x854874F9E8BB10B0, NameHash = 0x24D022A0BCD713A0)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Technology;
        /* 0x10 */ public int RepairedComponents;
    }
}
