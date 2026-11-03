namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3E4CE2068D0CB71, NameHash = 0xF6CB173)]
    public class GcSwarmDroneClusterComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A FlockingParamsAlive;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A FlockingParamsDying;
        [NMS(Index = 4)]
        /* 0x40 */ public NMSString0x10 DestroyEffect;
        [NMS(Index = 3)]
        /* 0x50 */ public NMSString0x10 DyingEffect;
        [NMS(Index = 0)]
        /* 0x60 */ public NMSString0x100 DroneNodePrefix;
    }
}
