namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE976A8B51A128BF, NameHash = 0x24D022A0BCD713A0)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Technology;
        /* 0x10 */ public int RepairedComponents;
        /* 0x18 */ public NMSString0x10 SpecificComponent;
    }
}
