namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDEF4947456EBD497, NameHash = 0xAE0F03D4)]
    public class GcMissionConditionAllSystemPlanetsDiscovered : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int DisplayNumberOffset;
        [NMS(Index = 1)]
        /* 0x4 */ public bool OnlyMoons;
    }
}
