namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD992561988664D6, NameHash = 0xFCEA9505)]
    public class GcPlayerEffectsComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float VehicleInOutDissolveDelay;
        [NMS(Index = 1)]
        /* 0x4 */ public float VehicleInOutEffectDelay;
        [NMS(Index = 0)]
        /* 0x8 */ public float VehicleInOutTime;
    }
}
