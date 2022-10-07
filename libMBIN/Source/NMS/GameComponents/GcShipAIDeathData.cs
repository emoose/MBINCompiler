namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA72516623196493, NameHash = 0x52329167EAE2541C)]
    public class GcShipAIDeathData : NMSTemplate
    {
        /* 0x00 */ public float DroneDeathTime;
        /* 0x04 */ public float DroneDeathForce;
        /* 0x08 */ public float DroneDeathBoomTotalTime;
        /* 0x0C */ public float DroneDeathOffset;
        /* 0x10 */ public int DroneNumDeathBooms;
        /* 0x14 */ public float DroneDeathTimeout;
        /* 0x18 */ public float BrakeForce;
    }
}
